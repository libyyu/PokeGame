#define LUA_LIB

#include "PCH.h"
#if FLIB_COMPILER_ANDROID
#include "FilePackage/File.h"
#include <jni.h>
#include <android/log.h>
#include <android/asset_manager.h>
#include <android/asset_manager_jni.h>
#define LOG_TAG "AssetFILEWrapper"
#define LOGV(...) __android_log_print(ANDROID_LOG_VERBOSE, LOG_TAG, __VA_ARGS__)
#define LOGD(...) __android_log_print(ANDROID_LOG_DEBUG , LOG_TAG, __VA_ARGS__)
#define LOGI(...) __android_log_print(ANDROID_LOG_INFO  , LOG_TAG, __VA_ARGS__)
#define LOGW(...) __android_log_print(ANDROID_LOG_WARN  , LOG_TAG, __VA_ARGS__)
#define LOGE(...) __android_log_print(ANDROID_LOG_ERROR  , LOG_TAG, __VA_ARGS__)

static AAssetManager* l_assetManager = nullptr;
class AssetFILEWrapper
{
public:
    static void setupAssetManager(AAssetManager* assetManager)
    {
        l_assetManager = assetManager;
    }
    static bool setupAssetManager(JNIEnv* env, jobject assetManager)
    {
        LOGI("setupAssetManager");
        AAssetManager* aAssetMgr = AAssetManager_fromJava(env, assetManager);
        if (aAssetMgr == NULL)
            return false;
        
        setupAssetManager(aAssetMgr);
        return true;
    }
    
    //open asset file in readonly mode
    static FILE* open(char const* fileName, bool read_only = true)
    {
        return openInner(l_assetManager, fileName, read_only);
    }

    static bool file_exists(char const* fileName)
    {
        AAsset* asset = openAAsset(l_assetManager, fileName);
        if (asset == NULL)
        {
            return false;
        }
        
        off_t fileStart, fileLength;
        int fd = AAsset_openFileDescriptor(asset, &fileStart, &fileLength);
        AAsset_close(asset);
        return fd >=0;
    }

    static AAsset* openAAsset(AAssetManager* assetManager, char const* fileName)
    {
        if (assetManager == NULL)
        {
            LOGW("assetManager is null, please setupAssetManager first.");
            return NULL;
        }
        
        AAsset* asset = AAssetManager_open(assetManager, fileName, AASSET_MODE_RANDOM);
        return asset;
    }
    
private:
    //open asset file in readonly mode
    static FILE* openInner(AAssetManager* assetManager, char const* fileName, bool read_only)
    {
        AAsset* asset = openAAsset(assetManager, fileName);
        if (asset == NULL)
        {
            LOGW("AAssetManager_open failed.");
            return NULL;
        }

        size_t fileLength1 = AAsset_getLength(asset);
        LOGD("before fd fileLength:%d",fileLength1);
        
        off_t fileStart, fileLength;
        int fd = AAsset_openFileDescriptor(asset, &fileStart, &fileLength);
        AAsset_close(asset);
        LOGD("fd:%d  start:%d  length:%d", fd, fileStart, fileLength);
        
        if (fd < 0)    //fail
        {
            LOGW("AAsset_openFileDescriptor failed with code %d.", fd);
            return NULL;
        }
        
        lseek(fd, fileStart, SEEK_SET);
        
        AssetFILEWrapper* cookie = new AssetFILEWrapper();
        cookie->m_wholeFd = fd;
        cookie->m_fileStart = fileStart;
        cookie->m_fileLen = fileLength;
        cookie->m_readonly = read_only;
        
        FILE* file = funopen(cookie, &AssetFILEWrapper::read, &AssetFILEWrapper::write, &AssetFILEWrapper::seek, &AssetFILEWrapper::close);
        if (file == NULL)
        {
            close(cookie);
            LOGW("AAsset funopen failed.");
            return NULL;
        }
        
        return file;
    }
 
    static int read(void *cookie, char *buffer, int buffer_size)
    {
        AssetFILEWrapper* self = (AssetFILEWrapper*)cookie;
        fpos_t curWholePos = self->tell();
        
        int leftLength = self->m_fileStart + self->m_fileLen - curWholePos;
        
        if (buffer_size > leftLength)
            buffer_size = leftLength;
        
        return ::read(self->m_wholeFd, buffer, buffer_size);
    }
    static int write(void *cookie, const char *buffer, int buffer_size)
    {
        AssetFILEWrapper* self = (AssetFILEWrapper*)cookie;
        if(self->m_readonly)
        {
            LOGE("Android.asset can't write, it's readonly.");
            return -1;
        }
        
        return ::write(self->m_wholeFd, buffer, buffer_size);
    }
    static fpos_t seek(void *cookie, fpos_t offset, int origin)
    {
        AssetFILEWrapper* self = (AssetFILEWrapper*)cookie;
        fpos_t curWholePos = self->tell();
        fpos_t newWholePos;
        if (origin == SEEK_SET)
            newWholePos = self->m_fileStart + offset;
        else if (origin == SEEK_CUR)
            newWholePos = curWholePos + offset;
        else if (origin == SEEK_END)
            newWholePos = self->m_fileStart + self->m_fileLen + offset;
        else
            return -1;
        
        if (newWholePos < self->m_fileStart || newWholePos > self->m_fileStart + self->m_fileLen)
            return -1;
        
        ::lseek(self->m_wholeFd, newWholePos, SEEK_SET);
        return newWholePos - self->m_fileStart;
    }
    static int close(void * cookie)
    {
        AssetFILEWrapper* self = (AssetFILEWrapper*)cookie;
        ::close(self->m_wholeFd);
        
        delete self;
        return 0;
    }
    
    fpos_t tell()
    {
        return lseek(m_wholeFd, 0, SEEK_CUR);
    }
private:
    int m_wholeFd;
    off_t m_fileStart;
    off_t m_fileLen;
    bool  m_readonly;
};


static JNIEnv* g_JniEnv = NULL;
JNIEnv* glb_GetJniEnv()
{
    return g_JniEnv;
}

void setupAssetFILEWrapper()
{
    LOGI("setupAssetFILEWrapper");
    JNIEnv* env = glb_GetJniEnv();
    jclass UnityPlayer = env->FindClass("com/unity3d/player/UnityPlayer");
    if (UnityPlayer == NULL)
    {
        LOGW("com/unity3d/player/UnityPlayer not found");
        return;
    }
    
    jfieldID currentActivityId = env->GetStaticFieldID(UnityPlayer, "currentActivity", "Landroid/app/Activity;");
    if (currentActivityId == NULL)
    {
        LOGW("currentActivity not found");
        return;
    }
    
    jobject activity = env->GetStaticObjectField(UnityPlayer, currentActivityId);
    if (activity == NULL)
    {
        LOGW("activity not found");
        return;
    }
    
    jclass Activity = env->FindClass("android/app/Activity");
    if (Activity == NULL)
    {
        LOGW("android/app/Activity not found");
        return;
    }
    
    jmethodID getAssetsId = env->GetMethodID(Activity, "getAssets", "()Landroid/content/res/AssetManager;");
    if (getAssetsId == NULL)
    {
        LOGW("getAssets not found");
        return;
    }
    
    jobject assets = env->CallObjectMethod(activity, getAssetsId);
    if (assets == NULL)
    {
        LOGW("assets not found");
        return;
    }
    //
    AssetFILEWrapper::setupAssetManager(env, assets);
}
///////////////////////////////////////////////////////////////////////////
////
JNIEXPORT jint JNICALL JNI_OnLoad(JavaVM* vm, void* reserved)
{
    LOGI("JNI_OnLoad.");
    jint result = -1;

    if (vm->GetEnv((void**) &g_JniEnv, JNI_VERSION_1_4) != JNI_OK)
    {
        LOGW("JNI_OnLoad Get JniEnv Failed. JNI_VERSION_1_4.");
        return -1;
    }
    assert(g_JniEnv != NULL);

    /* success -- return valid version number */
    result = JNI_VERSION_1_4;
    LOGI("JNI_OnLoad.setupAssetFILEWrapper");
    setupAssetFILEWrapper();

    return result;
}
///////////////////////////////////////////////////////////////////////////
////
namespace FengEngine
{
File* File::OpenFile(const char *szFileName, bool readonly)
{
    assert(szFileName && "szFileName is null");
    std::string strFile(szFileName);
    const char* assetsPrefix = "!/assets/";
    size_t pos = strFile.find(assetsPrefix);
    if (pos != std::string::npos)
    {
        //是 assets 路径，去掉开头
        std::string sAssetPath = strFile.substr(pos+strlen(assetsPrefix));  
        log_info("load android %s", sAssetPath.c_str());     
        /*FILE* fp = AssetFILEWrapper::open(sAssetPath.c_str(), readonly);
        if(!fp)
        {
            return nullptr;
        }*/
        AAsset* asset = AssetFILEWrapper::openAAsset(l_assetManager, sAssetPath.c_str());
        if(!asset)
        {
            return nullptr;
        }
        File* file = new File;
        file->m_pFileHandle = asset/*fp*/;
        file->m_IsAndroidAssets = true;
        return file;
    }
    else
    {
        FStd::FFile* fp = new FStd::FFile;
        if(0 != fp->Open(szFileName, readonly))
        {
            delete fp;
            return nullptr;
        }
        File* file = new File;
        file->m_pFileHandle = fp;
        file->m_IsAndroidAssets = false;
        return file;
    }
}

bool  File::FileExists(const char* szFileName)
{
    assert(szFileName && "szFileName is null");
    std::string strFile(szFileName);
    const char* assetsPrefix = "!/assets/";
    size_t pos = strFile.find(assetsPrefix);
    if (pos != std::string::npos)
    {
        //是 assets 路径，去掉开头
        std::string sAssetPath = strFile.substr(pos+strlen(assetsPrefix));       
        return AssetFILEWrapper::file_exists(sAssetPath.c_str());
    }
    else
    {
        return FStd::FFileExists(szFileName);
    }
}

}
#endif
