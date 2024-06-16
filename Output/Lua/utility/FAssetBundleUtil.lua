
local l_instance = nil
local FAssetBundleUtil = FLua.Class("FAssetBundleUtil")
do
	function FAssetBundleUtil:__constructor()
		self.m_AssetsMgr = nil
	end
	function FAssetBundleUtil.Instance()
		if not l_instance then
			l_instance = FAssetBundleUtil()
			l_instance:InitAssetBundle()
		end
		return l_instance
	end

	function FAssetBundleUtil:InitAssetBundle()
		self.m_AssetsMgr = FResourceLoader.inst
	end

	function FAssetBundleUtil:AsyncLoad(assetBundleName, assetName, cb)
		print("LoadAsset:" .. assetBundleName .. "@" .. assetName)
		self.m_AssetsMgr:LoadAssetAsync(assetBundleName, assetName, function(obj)
			if cb then cb(obj) end
		end)
	end

	function FAssetBundleUtil:AsyncLoadArray(assetBundleName, assetsName, cb)
		print("LoadAsset:" .. assetBundleName .. "@{" .. table.concat(assetsName, ", ") .. "}")
		self.m_AssetsMgr:LoadAssetArrayAsync(assetBundleName, assetsName, function(objs)
			if cb then cb(objs) end
		end)
	end

	function FAssetBundleUtil:AsyncLoadABundle(assetBundleName, cb)
		print("LoadABundle:" .. assetBundleName)
		self.m_AssetsMgr:LoadABundleAsync(assetBundleName, function(obj)
			if cb then cb(obj) end
		end)
	end

	function FAssetBundleUtil:UnloadABundle(assetBundleName, unload)
		if not assetBundleName or assetBundleName:len() == 0 then 
			return
		end

		self.m_AssetsMgr:UnloadAssetBundle(assetBundleName, unload)
	end
end

return FAssetBundleUtil