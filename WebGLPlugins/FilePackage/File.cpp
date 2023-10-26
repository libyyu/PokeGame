#include "../PCH.h"
#include "File.h"
#define FLIB_COMPILER_ANDROID 0
#if FLIB_COMPILER_ANDROID
#include <jni.h>
#include <android/log.h>
#include <android/asset_manager.h>
#include <android/asset_manager_jni.h>
#endif//PLATFORM_ANDROID

/////////////////////////////////////////////////////
//这个文件这么复杂，主要是AAsset_openFileDescriptor不生效导致的
namespace FengEngine
{
File::File() : m_pFileHandle(nullptr), m_IsAndroidAssets(false)
{
}
File::~File()
{
    close();
}

void File::close()
{
    if(m_pFileHandle)
    {
        if(!m_IsAndroidAssets)
        {
            //FStd::FFile* fp = static_cast<FStd::FFile*>(m_pFileHandle);
            //delete fp;
        }
        else
        {
            //FILE* fp = static_cast<FILE*>(m_pFileHandle);
            //fclose(fp);
#if FLIB_COMPILER_ANDROID
            AAsset *asset = static_cast<AAsset*>(m_pFileHandle);
            if(asset) AAsset_close(asset);
#endif   
        }
    }
    m_pFileHandle = nullptr;
}

size_t File::GetSize()
{
    if(!m_IsAndroidAssets)
    {
        //FStd::FFile* fp = static_cast<FStd::FFile*>(m_pFileHandle);
        return 0;//fp->GetSize();
    }
    else
    {
        // FILE* fp = static_cast<FILE*>(m_pFileHandle);
        // size_t offset = GetOffset();
        // size_t filelen = fseek(fp, 0L, SEEK_END);
        // log_info("offset:%d, filelen:%d", offset, filelen);
        // fseek(fp, offset, SEEK_SET);
        // return filelen-offset;
#if FLIB_COMPILER_ANDROID
        AAsset *asset = static_cast<AAsset*>(m_pFileHandle);
        return (size_t)AAsset_getLength(asset);
#else
        return 0;
#endif
    }
}
size_t File::GetOffset()
{
    if(!m_IsAndroidAssets)
    {
        //FStd::FFile* fp = static_cast<FStd::FFile*>(m_pFileHandle);
        return 0;//fp->GetOffset();
    }
    else
    {
        //FILE* fp = static_cast<FILE*>(m_pFileHandle);
        //return ftell(fp);
#if FLIB_COMPILER_ANDROID
        AAsset *asset = static_cast<AAsset*>(m_pFileHandle);
        return AAsset_getLength(asset) - AAsset_getRemainingLength(asset);
#else
        return 0;
#endif
    }
}
int File::Seek(int offset, unsigned int mode)
{
    if(!m_IsAndroidAssets)
    {
        //FStd::FFile* fp = static_cast<FStd::FFile*>(m_pFileHandle);
        return 0;//fp->Seek(offset, mode);
    }
    else
    {
        //FILE* fp = static_cast<FILE*>(m_pFileHandle);
        //return fseek(fp, offset, mode);
#if FLIB_COMPILER_ANDROID
        AAsset *asset = static_cast<AAsset*>(m_pFileHandle);
        return AAsset_seek(asset, offset, mode);
#else
        return 0;
#endif
    }
}
size_t File::Read(void* p_buffer, size_t n_bytes_2_read)
{
    assert(p_buffer);
    if(!m_IsAndroidAssets)
    {
        //FStd::FFile* fp = static_cast<FStd::FFile*>(m_pFileHandle);
        return 0;//fp->Read(p_buffer, n_bytes_2_read);
    }
    else
    {
        //FILE* fp = static_cast<FILE*>(m_pFileHandle);
        //return fread(p_buffer, n_bytes_2_read, 1, fp);
#if FLIB_COMPILER_ANDROID
        AAsset *asset = static_cast<AAsset*>(m_pFileHandle);
        return AAsset_read(asset, p_buffer, n_bytes_2_read);
#else
        return 0;
#endif
    }
}
size_t File::Write(const void* p_buffer, size_t n_bytes_2_write)
{
    assert(p_buffer);
    if(!m_IsAndroidAssets)
    {
        //FStd::FFile* fp = static_cast<FStd::FFile*>(m_pFileHandle);
        return 0;//fp->Write(p_buffer, n_bytes_2_write);
    }
    else
    {
        //FILE* fp = static_cast<FILE*>(m_pFileHandle);
        //return fwrite(p_buffer, n_bytes_2_write, 1, fp);
        return 0;
    }
}
size_t File::ReadAll(void* p_buffer)
{
    assert(p_buffer);
    if(!m_IsAndroidAssets)
    {
        //FStd::FFile* fp = static_cast<FStd::FFile*>(m_pFileHandle);
        return 0;//fp->ReadAll(p_buffer);
    }
    else
    {
        // FILE* fp = static_cast<FILE*>(m_pFileHandle);
        // size_t len = GetSize();
        // return fread(p_buffer, len, 1, fp);
#if FLIB_COMPILER_ANDROID
        size_t len = GetSize();
        return Read(p_buffer, len);
#else
        return 0;
#endif
    }
}

#if !FLIB_COMPILER_ANDROID
File* File::OpenFile(const char *szFileName, bool readonly)
{
    assert(szFileName && "szFileName is null");
    // FStd::FFile* fp = new FStd::FFile;
    // if(!fp) return nullptr;
    // if(0 != fp->Open(szFileName, readonly))
    // {
    //     delete fp;
    //     return nullptr;
    // }
    
    // File* file = new File;
    // file->m_pFileHandle = fp;
    // file->m_IsAndroidAssets = false;
    // return file;
    return nullptr;
}
bool  File::FileExists(const char* szFileName)
{
    assert(szFileName && "szFileName is null");
    return false;//FStd::FFileExists(szFileName);
}
#endif

}
