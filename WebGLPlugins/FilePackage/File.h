#ifndef __FILE_H__
#define __FILE_H__
#pragma once
namespace FengEngine
{
class File
{
public:
    ~File();
    static File* OpenFile(const char* szFileName, bool readonly = true);
    static bool  FileExists(const char* szFileName);
    size_t GetSize();
    size_t GetOffset();
    int    Seek(int offset, unsigned int mode);
    size_t Read(void* p_buffer, size_t n_bytes_2_read);
    size_t Write(const void* p_buffer, size_t n_bytes_2_write);
    size_t ReadAll(void* p_buffer);
private:
    File();
    void close();
private:
    void* m_pFileHandle;
    bool  m_IsAndroidAssets;
};
    
}

#endif//__FILE_H__
