#include "../PCH.h"
#include "FileSystem.h"
#include "File.h"
namespace FengEngine
{
FileSystem::FileSystem()
{
    layers.clear();
}
FileSystem::~FileSystem()
{

}
FileSystem& FileSystem::Get()
{
    static FileSystem inst;
    return inst;
}
void FileSystem::AddLayer(const char* path)
{
    assert(path);
    for(auto& p : layers){
        if(p.compare(path) == 0){
            return;
        }
    }
    layers.push_back(path);
}
bool FileSystem::ReadFileBuffer(const char* szFile, char** ppbuffer, int* length)
{
    // for(auto& p : layers)
    // {
    //     std::string fPath = FStd::FJoinPath(p, szFile);
    //     //sep path
    //     FILE* pFile = NULL;
    //     if(FStd::FFileExists(fPath.c_str()) && (pFile = fopen(fPath.c_str(), "rb")))
    //     {
    //         fseek(pFile, 0, SEEK_END);
    //         long fileLen = ftell(pFile);
    //         fseek(pFile, 0, SEEK_SET);
    //         char* pData = new char[fileLen];
    //         if(!pData)
    //         {
    //             fclose(pFile);
    //             log_warning("Not enough memory when read %s!", szFile);
    //             return false;
    //         }
    //         pData[0] = 0x0;
    //         fread(pData, 1, fileLen, pFile);
    //         fclose(pFile);
            
    //         *ppbuffer = pData;
    //         *length = fileLen;
    //         return true;
    //     }
        
    //     File* pPlatFile = File::OpenFile(fPath.c_str(), true);
    //     if(pPlatFile)
    //     {
    //         size_t fileLen = pPlatFile->GetSize();
    //         char* pData = new char[fileLen];
    //         if(!pData)
    //         {
    //             delete pPlatFile;
    //             log_warning("Not enough memory when read %s!", szFile);
    //             return false;
    //         }
    //         pData[0] = 0x0;
    //         pPlatFile->Read(pData, fileLen);
    //         *ppbuffer = pData;
    //         *length = fileLen;
    //         delete pPlatFile;
    //         return true;
    //     }
    // }
    log_warning("Failed to read file %s!", szFile);
    return false;
}
void FileSystem::ReleaseFileBuffer(char* ppbuffer)
{
    if(!!ppbuffer)
    {
        delete [] ppbuffer;
        ppbuffer = NULL;
    }
}
bool FileSystem::FileExists(const char* szFile)
{
    //sep path
    //FILE* pFile = NULL;
    // if(FStd::FFileExists(szFile))// && (pFile = fopen(szFile, "rb")))
    // {
    //     //fclose(pFile);
    //     return true;
    // }
    // if(File::FileExists(szFile))
    // {
    //     return true;
    // }

    // for(auto& p : layers)
    // {
    //     std::string fPath = FStd::FJoinPath(p, szFile);
    //     if(File::FileExists(fPath.c_str()))
    //         return true;
    // }

    return false;
}
}
