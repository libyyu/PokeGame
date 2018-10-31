/*
 * 虚拟文件系统
 * 
 *
 */
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using SharpZipLib = ICSharpCode.SharpZipLib;

namespace FGame
{
	public interface AssetsReaderSystem {
		bool ReadFile(string filename, out byte[] buffer);
		void Release();
		bool Valid { get; }
	}

	class ZipSystem : AssetsReaderSystem
	{
		bool isValid;
		SharpZipLib.Zip.ZipFile zip;

		public ZipSystem(string zipFileName, string password = null)
		{
			try
			{
				zip = new SharpZipLib.Zip.ZipFile(File.OpenRead(zipFileName));
				zip.Password = password;
				isValid = true;
			}
			catch(Exception e)
			{
				isValid = false;
				LogUtil.LogException(e);
			}
		}

		public bool Valid
		{
			get { return isValid; }
		}

		public void Release()
		{
			if(zip != null)
			{
				zip.Close();
				zip = null;
			}
			isValid = false;
		}

		public bool ReadFile(string filename, out byte[] buffer)
		{
			try
			{
				SharpZipLib.Zip.ZipEntry theEntry;
				if(!FindEntry(filename,out theEntry))
				{
					buffer = null;
					return false;
				}

				Stream stream = zip.GetInputStream(theEntry);
				using (MemoryStream mm = new MemoryStream())
				{
					int size = 2048;
					byte[] data = new byte[2048];
					while (true)
					{
						size = stream.Read(data, 0, data.Length);
						if (size > 0)
							mm.Write(data, 0, size);
						else
							break;
					}

					buffer = mm.ToArray();
					mm.Close();
				}
				
				return true;
			}
			catch(Exception e) 
			{
				buffer = null;
				LogUtil.LogException (e);
				return false;
			}
		}

		bool FindEntry(string entryname,out SharpZipLib.Zip.ZipEntry entry)
		{
			try
			{
				entry = zip.GetEntry(entryname);
				return entry != null;
			}
			catch (Exception e)
			{
				LogUtil.LogError(e.Message);
				entry = null;
				return false;
			}
		}
	}

	class DirectorySystem : AssetsReaderSystem
	{
		bool isValid;
		string releative_path;
		Dictionary<string,int> entry_map = new Dictionary<string, int>();
		Dictionary<int, string> entry_folder = new Dictionary<int, string>();
		public DirectorySystem(string path)
		{
			releative_path = path;
			int index = 0;
			Recursive(ref index, path);
			isValid = true;
		}

		public bool Valid
		{
			get { return isValid; }
		}

		public void Release()
		{
			entry_map.Clear();
			isValid = false;
		}

		void Recursive(ref int index, string path)
		{
			try
			{
				string[] names = Directory.GetFiles(path);
				string[] dirs = Directory.GetDirectories(path);
				foreach (string filename in names)
				{
					int pos = index ++;
					entry_folder[pos] = path;
					string fname = filename.Replace(releative_path,"").Replace('\\', '/');
					if(fname.StartsWith("/"))
						fname = fname.Substring(1,fname.Length-1);
					entry_map[fname] = pos;
				}
				foreach (string dir in dirs)
				{
					Recursive(ref index, dir);
				}
			}
			catch (Exception e)
			{
				LogUtil.LogWarning(e.Message);
			}
		}

		public bool ReadFile(string filename_, out byte[] buffer)
		{
			try
			{
				string filename = filename_.Replace("\\", "/");
				int index;
				if(!entry_map.TryGetValue(filename, out index)){
					buffer = null;
					return false;
				}
				if(!File.Exists(Path.Combine(releative_path, filename))){
					buffer = null;
					return false;
				}

				buffer = File.ReadAllBytes(Path.Combine(releative_path, filename));
				return true;
			}
			catch(Exception e) 
			{
				buffer = null;
				LogUtil.LogException (e);
				return false;
			}
		}
	}
	
	public class FileSystem
	{
		static FileSystem instance = new FileSystem();
		public static FileSystem Instance
		{
			get { return instance; }
		}

		string m_ResBaseDir;
		string m_AssetsDir;
		string m_PckDir;
		bool   m_EnablePck;
		bool   m_Inited;

		AssetsReaderSystem ZipResBaseReader;
		AssetsReaderSystem FilesResBaseReader;

		AssetsReaderSystem ZipAssetsReader;
		AssetsReaderSystem FilesAssetsReader;

		AssetsReaderSystem ZipPckReader;
		AssetsReaderSystem FilesPckReader;


		public string ResBaseDir
		{
			get { return m_ResBaseDir; }
			set { m_ResBaseDir = value; }
		}

		public string AssetsDir
		{
			get { return m_AssetsDir; }
			set { m_AssetsDir = value; }
		}

		public string PckDir
		{
			get { return m_PckDir; }
			set { m_PckDir = value; }
		}

		public bool EnablePck
		{
			get { return m_EnablePck; }
			set { m_EnablePck = value; }
		}

		public AssetsReaderSystem ResBaseReader
		{
			get { return ZipResBaseReader != null ? ZipResBaseReader : FilesResBaseReader; }
		}

		public AssetsReaderSystem AssetsReader
		{
			get { return ZipAssetsReader != null ? ZipAssetsReader : FilesAssetsReader; }
		}

		public AssetsReaderSystem PckReader
		{
			get { return ZipPckReader != null ? ZipPckReader : FilesPckReader; }
		}

		public bool InitAssets(string password = null)
		{
			if(m_Inited)
				return true;
			if (File.Exists (ResBaseDir))
				ZipResBaseReader = new ZipSystem (ResBaseDir,password);
			else if (Directory.Exists(ResBaseDir))
				FilesResBaseReader = new DirectorySystem (ResBaseDir);

			if (File.Exists (AssetsDir))
				ZipAssetsReader = new ZipSystem (AssetsDir,password);
			else if (Directory.Exists(AssetsDir))
				FilesAssetsReader = new DirectorySystem (AssetsDir);

			if (File.Exists (PckDir))
				ZipPckReader = new ZipSystem (PckDir,password);
			else if (Directory.Exists(PckDir))
				FilesPckReader = new DirectorySystem (PckDir);

			m_Inited = true;
			return false;
		}

		public void Release()
		{
			if(!m_Inited)
				return;

			if(ResBaseReader!=null) ResBaseReader.Release ();
			if(AssetsReader!=null) AssetsReader.Release ();
			if(PckReader!=null) PckReader.Release ();

			m_Inited = false;
		}

		public bool ReadAssetsFile(string filename, out byte[] buffer)
		{
			if (m_EnablePck && PckReader != null && PckReader.ReadFile (filename, out buffer)) {
				return true;
			} else if (AssetsReader != null && AssetsReader.ReadFile (filename, out buffer)) {
				return true;
			} else if (ResBaseReader != null && ResBaseReader.ReadFile (filename, out buffer)) {
				return true;
			} else {
				buffer = null;
				return false;
			}
		}
	}
}