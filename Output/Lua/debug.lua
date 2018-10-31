
-- GameUtil.SendRequest("http://www.baidu.com","hello",3,true,function(req,resp)
--  	if resp.IsSuccess then
--  		local str=resp.DataAsText
--  		--print(str)
-- 		 f = io.open("test.html", "wb")
-- 		 f:write(str)
-- 		 f:close()
--  	else
-- 		print("error")
-- 	end
-- end)

-- GameUtil.DownLoad("http://www.baidu.com",
-- 	"E:/UnityWorks/t.txt",true,true,nil,function(a,b,c)
-- 		print("progress:",a,b,c)
-- 	end,function(req,resp)
-- 		print(req,resp)
-- 		if not req.Exception then
-- 			if resp.IsSuccess then
-- 				print("download completed.. now unzip")
-- 				--tmpfile=this.AssetRoot.."/tmp.zip"
-- 			end
-- 	    else 
-- 	    	print("DownLoad file err",resp)
-- 		end
-- 	end)

--GameUtil.AnsyLoadLevel("StartScreen",function(success)
--	print("LoadLevel:StartScreen",success)
--end)
_G.warn = print
local FLua = require "FLua"

local FCardInfo = FLua.Class("FCardInfo")

_G.CardType = {
	--大小王
    Joker = 0,
    --红桃
    Hearts = 1,
    --黑桃
    Spades = 2,
    --方片
    Diamonds = 3,
    --梅花
    Clubs = 4,
 }
function string:split(sep)
	local sep, fields = sep or ",", {}
	local pattern = string.format("([^%s]+)", sep)
	self:gsub(pattern, function(c) table.insert(fields, c) end)
	return fields
end

do
	function FCardInfo:_ctor()
		self.cardName = "" --卡片图片名
		self.cardType = 0  --卡片类型
		self.cardIndex = 0 --牌在所在类型的索引3-10,J,Q,K,A,2(0-12)
		self.isSelected = false --是否选中
	end

	function FCardInfo:MakeCard(cardName)
		self.cardName = cardName
		local spts = cardName:split('_')
		local h,l = tonumber(spts[1]), tonumber(spts[2])
		if h == 0 then
			self.cardType = CardType.Joker
			self.cardIndex = math.mod((l+10), 13)
		elseif h == 1 then
			self.cardType = CardType.Spades
			self.cardIndex = math.mod((l+10), 13)
		elseif h == 2 then
			self.cardType = CardType.Hearts
			self.cardIndex = math.mod((l+10), 13)
		elseif h == 3 then
			self.cardType = CardType.Clubs
			self.cardIndex = math.mod((l+10), 13)
		elseif h == 4 then
			self.cardType = CardType.Diamonds
			self.cardIndex = math.mod((l+10), 13)
		else
			error(string.format("卡牌文件名%s非法！", cardName))
		end
	end

	function FCardInfo:__lt(other)
		--如果当前是大小王
		if self.cardType == CardType.Joker then
			if other.cardType == CardType.Joker then
				return self.cardIndex < other.cardIndex
			end
			return 1
		else--如果是一般的牌
			if other.cardType == CardType.Joker then
				return -1
			else
				if self.cardIndex == other.cardIndex then
					return other.cardType < self.cardType
				else
					return self.cardIndex < other.cardIndex
				end
			end
		end
	end

	function FCardInfo:toString()
		return tostring(FCardInfo) .. ":CardName:" .. self.cardName
	end
end

do
	local p1 = FCardInfo.new()
	local p2 = FCardInfo.new()
	p1:MakeCard("0_17")
	p2:MakeCard("0_16")
	print("333333")
	print(p1 == p2)
end
