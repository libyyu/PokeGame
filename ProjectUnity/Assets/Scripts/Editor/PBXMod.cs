#if UNITY_EDITOR
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

namespace Zulong.UnityEditor.iOS.Xcode
{
    public class PBXMod
    {
        public bool valid { get; private set; }
        public string name { get; private set; }
        public string path { get; private set; }
        private ArrayList _frameworks = null;
        private ArrayList _libs = null;
        private ArrayList _files = null;
        private ArrayList _embeds = null;
        private Hashtable _datastore = new Hashtable();

        public PBXMod(string filename)
		{	
			FileInfo projectFileInfo = new FileInfo( filename );
			if( !projectFileInfo.Exists ) {
                PBXLog.LogWarning(filename + " does not exist.");
                return;
			}
			
			name = Path.GetFileNameWithoutExtension( filename );
			path = Path.GetDirectoryName( filename );
			
			string contents = projectFileInfo.OpenText().ReadToEnd();
            PBXLog.Log(contents);

            _datastore = (Hashtable)JsonParser.jsonDecode(contents);
            if (_datastore == null || _datastore.Count == 0)
            {
                throw new Exception("Parse error in file " + Path.GetFileName(filename) + "! Check for typos such as unbalanced quotation marks, etc.");
            }

            valid = true;
		}

        public string group
        {
            get
            {
                if (_datastore != null && _datastore.Contains("group"))
                    return (string)_datastore["group"];
                return string.Empty;
            }
        }

        public ArrayList patches
        {
            get
            {
                return (ArrayList)_datastore["patches"];
            }
        }

        public ArrayList libs
        {
            get
            {
                if (!_datastore.Contains("libs"))
                    return new ArrayList();

                if (_libs == null)
                {
                    _libs = new ArrayList(((ArrayList)_datastore["libs"]).Count);
                    foreach (string fileRef in (ArrayList)_datastore["libs"])
                    {
                        _libs.Add(new XCModFile(fileRef));
                    }
                }
                return _libs;
            }
        }

        public ArrayList frameworks
        {
            get
            {
                if (!_datastore.Contains("frameworks"))
                    return new ArrayList();
                if (_frameworks == null)
                {
                    _frameworks = new ArrayList(((ArrayList)_datastore["frameworks"]).Count);
                    foreach (string fileRef in (ArrayList)_datastore["frameworks"])
                    {
                        _frameworks.Add(new XCModFile(fileRef));
                    }
                }
                return _frameworks;
            }
        }

        public ArrayList files
        {
            get
            {
                if (!_datastore.Contains("files"))
                    return new ArrayList();
                if (_files == null)
                {
                    _files = new ArrayList(((ArrayList)_datastore["files"]).Count);
                    foreach (string fileRef in (ArrayList)_datastore["files"])
                    {
                        _files.Add(new XCModFile(fileRef));
                    }
                }
                return _files;
            }
        }

        public ArrayList headerpaths
        {
            get
            {
                if (!_datastore.Contains("headerpaths"))
                    return new ArrayList();
                return (ArrayList)_datastore["headerpaths"];
            }
        }

        public ArrayList folders
        {
            get
            {
                if (!_datastore.Contains("folders"))
                    return new ArrayList();
                return (ArrayList)_datastore["folders"];
            }
        }

        public ArrayList excludes
        {
            get
            {
                if (!_datastore.Contains("excludes"))
                    return new ArrayList();
                return (ArrayList)_datastore["excludes"];
            }
        }

        public ArrayList compiler_flags
        {
            get
            {
                if (!_datastore.Contains("compiler_flags"))
                    return new ArrayList();
                return (ArrayList)_datastore["compiler_flags"];
            }
        }

        public ArrayList linker_flags
        {
            get
            {
                if (!_datastore.Contains("linker_flags"))
                    return new ArrayList();
                return (ArrayList)_datastore["linker_flags"];
            }
        }

        public ArrayList embed_binaries
        {
            get
            {
                if (!_datastore.Contains("embed_binaries"))
                    return new ArrayList();
                if (_embeds == null)
                {
                    _embeds = new ArrayList(((ArrayList)_datastore["embed_binaries"]).Count);
                    foreach (Hashtable fileRef in (ArrayList)_datastore["embed_binaries"])
                    {
                        _embeds.Add(new XCEmbedFile(fileRef));
                    }
                }
                return _embeds;
            }
        }

        public Hashtable capability
        {
            get
            {
                if (!_datastore.Contains("capability"))
                    return null;
                return (Hashtable)_datastore["capability"];
            }
        }

        public Hashtable plist
        {
            get
            {
                if (!_datastore.Contains("plist"))
                    return null;
                return (Hashtable)_datastore["plist"];
            }
        }
        //兼容以前的
        public ArrayList oldConfigs
        {
            get
            {
                try
                {
                    if (!_datastore.Contains("configs"))
                        return null;
                    return (ArrayList)_datastore["configs"];
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public Hashtable configs
        {
            get
            {
                try
                {
                    if (!_datastore.Contains("configs"))
                        return null;
                    return (Hashtable)_datastore["configs"];
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        //差分
        public ArrayList diff
        {
            get
            {
                if (!_datastore.Contains("diff"))
                    return null;
                return (ArrayList)_datastore["diff"];
            }
        }
    }

    public class XCModFile
    {
        public string filePath { get; private set; }
        public bool isWeak { get; private set; }

        public XCModFile(string inputString)
        {
            isWeak = false;

            if (inputString.Contains(":"))
            {
                string[] parts = inputString.Split(':');
                filePath = PBXPath.FixSlashes(parts[0]);
                isWeak = string.Equals(parts[1], "weak", StringComparison.OrdinalIgnoreCase);
            }
            else
            {
                filePath = inputString;
            }
        }
    }

    public class XCEmbedFile
    {
        public string filePath { get; private set; }
        public string bundle { get; private set; }
        public string infoplist { get; private set; }

        public XCEmbedFile(Hashtable dt)
        {
            foreach (DictionaryEntry de in dt)
            {
                if ((string)de.Key == "path")
                    filePath = (string)de.Value;
                else if ((string)de.Key == "bundleId")
                    bundle = (string)de.Value;
                else if ((string)de.Key == "infoplist")
                    infoplist = (string)de.Value;
            }
        }
    }
}

#endif
