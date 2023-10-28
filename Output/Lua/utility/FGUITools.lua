local FGUITools = FLua.Class("FGUITools")
do
	function FGUITools.setText(obj,text)
		obj:GetComponent("Text").text = text
	end

	function FGUITools.setInputText(obj,text)
		obj:GetComponent("InputField").text = text
	end
	function FGUITools.getInputText(obj)
		return obj:GetComponent("InputField").text
	end

	function FGUITools.setTextColor(obj,col)
		
	end

	function FGUITools.setActive(obj,active)
		obj:SetActive(active)
	end
end
return FGUITools