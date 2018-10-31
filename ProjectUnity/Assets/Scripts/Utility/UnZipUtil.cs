
using System;
using System.IO;
using SharpZipLib = ICSharpCode.SharpZipLib;

namespace UnZipUtil
{
    public class XSharpUnZip
    {
		public static string _password = "LuaGame";
        
        public static bool ZipDirectory(string zipFileName,string directory,string password = null,string filefilter = null)
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(zipFileName));
                SharpZipLib.Zip.FastZipEvents events = new SharpZipLib.Zip.FastZipEvents();
                events.CompletedFile += (object sender, SharpZipLib.Core.ScanEventArgs e) =>
                {
                    LogUtil.Log("Zip Directory{0} Successed.", e.Name);
                };

                SharpZipLib.Zip.FastZip fz = new SharpZipLib.Zip.FastZip(events);
                fz.CreateEmptyDirectories = true;
                fz.Password = password;
                fz.CreateZip(zipFileName, directory, true, filefilter);
                fz = null;
                return true;
            }
            catch(Exception e)
            {
                LogUtil.LogError(e.Message);
                return false;
            }
        }

        //directory : end of "/" or "\\"
        public static bool UnZipDirectory(string zipFileName,string directory,string password = null,Action<string,float,long,long> cb = null)
        {
            try
            {
                /*if (!Directory.Exists(directory))
                    Directory.CreateDirectory(directory);
                directory = directory.Replace('\\', '/');
                if (directory.EndsWith("/"))
                    directory = directory.Substring(0, directory.Length - 1);
                SharpZipLib.Zip.FastZipEvents events = new SharpZipLib.Zip.FastZipEvents();
                events.Progress += (object sender, SharpZipLib.Core.ProgressEventArgs e) =>
                {
                    if(cb != null)
                    {
                        cb(e.Name, e.PercentComplete, e.Processed, e.Target);
                    }
                    else
                    {
                        LogUtil.Log("UnZip {0} {1}/{2}--{3}",e.Name, e.Processed, e.Target,e.PercentComplete);  
                    }
                };
                SharpZipLib.Zip.FastZip fz = new SharpZipLib.Zip.FastZip(events);
                fz.Password = password;
                fz.ExtractZip(zipFileName,directory, SharpZipLib.Zip.FastZip.Overwrite.Always,null,null,null,true);
                */
                if (!Directory.Exists(directory))
                    Directory.CreateDirectory(directory);

				SharpZipLib.Zip.ZipFile szip = new SharpZipLib.Zip.ZipFile(zipFileName);
				szip.Password = password;
				long count = szip.Count;
				szip.Close();

                SharpZipLib.Zip.ZipInputStream s = new SharpZipLib.Zip.ZipInputStream(File.OpenRead(zipFileName));
                s.Password = password;
                SharpZipLib.Zip.ZipEntry theEntry;
				int n = 0;
                while ((theEntry = s.GetNextEntry()) != null)
                {

                    string directoryName = Path.GetDirectoryName(theEntry.Name);
                    string fileName = Path.GetFileName(theEntry.Name);

                    if (directoryName != string.Empty)
						Directory.CreateDirectory(Path.Combine(directory, directoryName));

                    if (fileName != string.Empty)
                    {
                        string fileEntryPath = Path.Combine(directory, theEntry.Name);
                        if (File.Exists (fileEntryPath)) {
                            File.Delete (fileEntryPath);
                        }
						FileStream streamWriter = File.Create(fileEntryPath);
                        LogUtil.Log("-------------->Begin UnZip {0},Size:{1}", theEntry.Name,theEntry.Size);
                        int size = 1024*4;
						byte[] data = new byte[size];
                        while (true)
                        {
                            size = s.Read(data, 0, data.Length);
                            if (size > 0)
                                streamWriter.Write(data, 0, size);
                            else
                                break;

                            if (cb != null)
                            {
                                cb(theEntry.Name, theEntry.Size >0 ? 100*streamWriter.Length * 1.0f / theEntry.Size : 100,streamWriter.Length, theEntry.Size);
                            }
                            // else
                            // {
                            //     LogUtil.Log("UnZip {0} {1}/{2}--{3}", theEntry.Name, streamWriter.Length, theEntry.Size, theEntry.Size > 0 ? 100*streamWriter.Length*1.0f / theEntry.Size : 100);
                            // }
                        }

                        streamWriter.Close();
						n ++;
						LogUtil.Log("-------------->End UnZip {0}, {1}/{2}", theEntry.Name, n, count);
                    }
                }
                s.Close();
                return true;
            }
            catch(Exception e)
            {
                LogUtil.LogError(e.Message);
                return false;
            }
        }

		public static void EnumZip(string zipFileName, string password)
		{
			SharpZipLib.Zip.ZipInputStream s = new SharpZipLib.Zip.ZipInputStream(File.OpenRead(zipFileName));
			s.Password = password;
			SharpZipLib.Zip.ZipEntry theEntry;
			while ((theEntry = s.GetNextEntry ()) != null) {
				LogUtil.Log (theEntry.Name+","+theEntry.ZipFileIndex+","+theEntry.Offset);
			}
		}

        static bool FindEntry(SharpZipLib.Zip.ZipInputStream s, string entryname,out SharpZipLib.Zip.ZipEntry entry)
        {
            try
            {
                entry = null;
                SharpZipLib.Zip.ZipEntry theEntry;
                while ((theEntry = s.GetNextEntry()) != null)
                {
                    string name = theEntry.Name;
                    if (0 == string.Compare(name.Replace('\\', '/'), entryname.Replace('\\', '/'), false))
                    {
                        entry = theEntry;
                        break;
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                LogUtil.LogError(e.Message);
                entry = null;
                return false;
            }
        }

        public static byte[] ReadEntry(string zipFileName,string entryname,string password = null)
        {
            try
            {
                SharpZipLib.Zip.ZipInputStream s = new SharpZipLib.Zip.ZipInputStream(File.OpenRead(zipFileName));
                s.Password = password;

                SharpZipLib.Zip.ZipEntry theEntry;
                if(!FindEntry(s,entryname,out theEntry))
                {
                    s.Close();
                    return null;
                }
                byte[] buffer = null;
                using (MemoryStream mm = new MemoryStream())
                {
                    int size = 2048;
                    byte[] data = new byte[2048];
                    while (true)
                    {
                        size = s.Read(data, 0, data.Length);
                        if (size > 0)
                            mm.Write(data, 0, size);
                        else
                            break;
                    }

                    buffer = mm.ToArray();
                    mm.Close();
                }

                s.Close();
                return buffer;
            }
            catch(Exception e)
            {
                LogUtil.LogError(e.Message);
                return null;
            }
        }

        public static bool UpdateEntry(string zipFileName,string entryname,string filename,string password = null)
        {
            try
            {
                SharpZipLib.Zip.ZipFile s = new SharpZipLib.Zip.ZipFile(zipFileName);
                s.Password = password;
                SharpZipLib.Zip.StaticDiskDataSource data = new SharpZipLib.Zip.StaticDiskDataSource(filename);
                s.BeginUpdate();
                s.Add(data, entryname);
                s.CommitUpdate();
                s.Close();
                return true;
            }
            catch(Exception e)
            {
                LogUtil.LogError(e.Message);
                return false;
            }
        }
        public static bool UpdateEntry(string zipFileName, string entryname, byte[] buffer, string password = null)
        {
            try
            {
                string dir = Path.GetDirectoryName(zipFileName);
                string tmpfile = Path.Combine(dir, entryname + ".tmp");
                if (File.Exists(tmpfile))
                    File.Delete(tmpfile);
                FileStream streamWriter = File.Create(tmpfile);
                streamWriter.Write(buffer, 0, buffer.Length);
                SharpZipLib.Zip.ZipFile s = new SharpZipLib.Zip.ZipFile(zipFileName);
                s.Password = password;

                SharpZipLib.Zip.StaticDiskDataSource data = new SharpZipLib.Zip.StaticDiskDataSource(tmpfile);
                s.BeginUpdate();
                s.Add(data, entryname);
                s.CommitUpdate();
                s.Close();
                streamWriter.Close();
                if (File.Exists(tmpfile))
                    File.Delete(tmpfile);
                return true;
            }
            catch (Exception e)
            {
                LogUtil.LogError(e.Message);
                return false;
            }
        }

        public static bool DeleteEntry(string zipFileName,string entryname,string password = null)
        {
            try
            {
                SharpZipLib.Zip.ZipFile s = new SharpZipLib.Zip.ZipFile(zipFileName);
                s.Password = password;
                SharpZipLib.Zip.ZipEntry entry = s.GetEntry(entryname);
                if (null == entry)
                {
                    s.Close();
                    return true;
                }
                s.BeginUpdate();
                s.Delete(entry);
                s.CommitUpdate();
                s.Close();
                return true;
            }
            catch (Exception e)
            {
                LogUtil.LogError(e.Message);
                return false;
            }
        }
    }
}
