local FCardInfo = FLua.Class("FCardInfo")
local l_instance = nil

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

do
	function FCardInfo:__ctor()
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

return FCardInfo