---ECViewList的根代理，用于设置数量，获取数量等, ECViewListRootProxy为对外的接口类，ECViewListRootProxyImplXXX为实现

--********************代理实现基类***************--

local FViewListRootProxyImplBase = FLua.Class("FViewListRootProxyImplBase")
do
    function FViewListRootProxyImplBase:__constructor()
        self.m_RootWidget = nil
        self.m_ItemUpdateFunc = nil
    end

    function FViewListRootProxyImplBase:OnCreate()
    end

    function FViewListRootProxyImplBase:OnDestroy()
    end

    function FViewListRootProxyImplBase:SetCount(count)
    end

    function FViewListRootProxyImplBase:SetItemUpdateFunc(itemUpdateFunc)
        self.m_ItemUpdateFunc = itemUpdateFunc
    end

    function FViewListRootProxyImplBase:GetCount()
        return 0
    end

    function FViewListRootProxyImplBase:GetItemByIndex(index)
        return nil
    end
    function FViewListRootProxyImplBase:SetRootWidget(widget)
        self.m_RootWidget = widget
    end

    function FViewListRootProxyImplBase:GetRootWidget()
        return self.m_RootWidget
    end

    function FViewListRootProxyImplBase:IsValid()
        return IsValidObject(self.m_RootWidget)
    end
end
-------------------------------------------------------------





--************默认代理实现, 使用List控件创建的ViewList**********--

local FViewListRootProxyImplForListWidget = FLua.Class(FViewListRootProxyImplBase, "FViewListRootProxyImplForListWidget")
do
    function FViewListRootProxyImplForListWidget:OnCreate()
        if self.m_RootWidget:IsExtend("FairyGUI.GList") then
            self.m_RootWidget.itemRenderer = function(index, go)
                if self.m_ItemUpdateFunc then
                    self.m_ItemUpdateFunc(go, index+1)
                end
            end
        else
        end
    end

    function FViewListRootProxyImplForListWidget:OnDestroy()
        if self.m_RootWidget and self.m_RootWidget:IsExtend("FairyGUI.GList") then
            self.m_RootWidget.itemRenderer = nil
        end

        self.m_RootWidget = nil
    end

    function FViewListRootProxyImplForListWidget:SetCount(count)
        if not self:IsValid() then
            return
        end
        if self.m_RootWidget:IsExtend("FairyGUI.GList") then
            self.m_RootWidget.numItems = count
        else
        end
    end

    function FViewListRootProxyImplForListWidget:GetCount()
        if not self:IsValid() then
            return 0
        end
        if self.m_RootWidget:IsExtend("FairyGUI.GList") then
            return self.m_RootWidget.numItems
        else
            return 0
        end
    end


    function FViewListRootProxyImplForListWidget:GetItemByIndex(index)
        if not self:IsValid() then
            return nil
        end
        if self.m_RootWidget:IsExtend("FairyGUI.GList") then
            local childIndex = self.m_RootWidget:ItemIndexToChildIndex(index - 1)
            return self.m_RootWidget:GetChildAt(childIndex)
        else
            return nil
        end
    end
end
--------------------------------------------------------------

--******************对外接口类********************************--

local FViewListRootProxy = FLua.Class("ECViewListRootProxy")
function FViewListRootProxy:__constructor()
    self.m_ProxyImpl = nil
end

function FViewListRootProxy.createForListWidget()
    local object = FViewListRootProxy()
    object.m_ProxyImpl = FViewListRootProxyImplForListWidget()
    return object
end


function FViewListRootProxy:SetCount(count)
    self.m_ProxyImpl:SetCount(count)
end

function FViewListRootProxy:SetItemUpdateFunc(itemUpdateFunc)
    self.m_ProxyImpl:SetItemUpdateFunc(itemUpdateFunc)
end
function FViewListRootProxy:GetCount()
    return self.m_ProxyImpl:GetCount()
end

function FViewListRootProxy:GetItemByIndex(index)
    return self.m_ProxyImpl:GetItemByIndex(index)
end

function FViewListRootProxy:SetRootWidget(rootWidget)
    self.m_ProxyImpl:SetRootWidget(rootWidget)
end
function FViewListRootProxy:OnCreate()
    self.m_ProxyImpl:OnCreate()
end
function FViewListRootProxy:OnDestroy()
    self.m_ProxyImpl:OnDestroy()
end
return FViewListRootProxy