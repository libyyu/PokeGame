
local l_instance = nil
local FAssetBundleUtil = FLua.Class("FAssetBundleUtil")
do
	function FAssetBundleUtil:_ctor()
		self.m_AssetsMgr = nil
	end
	function FAssetBundleUtil.Instance()
		if not l_instance then
			l_instance = FAssetBundleUtil.new()
		end
		return l_instance
	end
	function FAssetBundleUtil:InitAssetBundle()
		self.m_AssetsMgr = ResourceManager.Instance
		self.m_AssetsMgr.EnableSepFile = GameUtil.CanSepAssets
		self.m_AssetsMgr.SepDownloadURL = GameUtil.SepPath .. "/StreamingAssets"
		self.m_AssetsMgr.UpdateDownloadURL = GameUtil.AssetRoot .. "/StreamingAssets"
		self.m_AssetsMgr.BaseDownloadingURL = GameUtil.BaseStreamAssetPath .. "/res_base/StreamingAssets"
		self.m_AssetsMgr.BundleExt = ".assetbundle"
		DontDestroyOnLoad(self.m_AssetsMgr.gameObject)
	end

	function FAssetBundleUtil:AsyncLoad(assetBundleName,assetName,cb)
		print("LoadAssetBundle:" .. assetBundleName .. "@" .. unpack(assetName))
		self.m_AssetsMgr:LoadAsset(assetBundleName,assetName,function(objs)
			if cb then cb({objs}) end
		end)
	end

	function FAssetBundleUtil:AsyncLoadBundle(assetBundleName, cb)
		print("LoadBundle:" .. assetBundleName)
		self.m_AssetsMgr:LoadBundle(assetBundleName, function(bundle)
			if cb then cb(bundle) end
		end)
	end

	function FAssetBundleUtil:UnloadAssetBundle(assetBundleName,unload)
		if not assetBundleName or assetBundleName:len() == 0 then 
			return
		end

		self.m_AssetsMgr:UnloadAssetBundle(assetBundleName, unload)
	end
end

return FAssetBundleUtil