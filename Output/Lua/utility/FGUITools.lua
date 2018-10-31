local FGUITools = FLua.Class("FGUITools")
do
	function FGUITools.setText(obj,text)
		obj.text = text
	end

	function FGUITools.setInputText(obj,text)
		obj.inputTextField.text = text
	end
	function FGUITools.getInputText(obj)
		return obj.inputTextField.text
	end

	function FGUITools.setTextColor(obj,col)
		
	end

	function FGUITools.setActive(obj,active)
		obj.visible = active
	end
end
return FGUITools