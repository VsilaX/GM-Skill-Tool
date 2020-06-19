//-----------------------------------------------------------------------------
// INFO BAR
//-----------------------------------------------------------------------------

singleton GuiControlProfile(VSGMGuiInfoBar : GuiControlProfile)
{
	opaque = true;
	border = true;
	border = 3;
	borderThickness = 2;
	fillColor = "30 30 30 100";
	borderColor = "255 255 255";
	justify = "right";
};

singleton GuiControlProfile(VSGMGuiInfoBarText : GuiTextProfile)
{
	fontSize = 15;
	fontColor = "255 255 255";
	justify = "center";
};

singleton GuiControlProfile(VSGMGuiInfoBarTextGreen : GuiTextProfile)
{
	fontSize = 15;
	fontColor = "64 254 64";
	justify = "center";
};

singleton GuiControlProfile(VSGMGuiInfoBarTextRed : GuiTextProfile)
{
	fontSize = 15;
	fontColor = "255 0 0";
	justify = "center";
};

//-----------------------------------------------------------------------------
// THE REST - Needs tidied up, tad lazy...
//-----------------------------------------------------------------------------

singleton GuiControlProfile(VSGuiTextEditAlphaProfile : GuiTextEditProfile)
{

};

singleton GuiControlProfile(VSGuiTextEditProfile : GuiTextEditProfile)
{
	numbersOnly = true;
};

singleton GuiControlProfile(VSGuiTextEditAlphaCenterProfile : GuiTextEditProfile)
{
	justify = "center";
};

singleton GuiControlProfile(VSGuiTextEditProfileCenter : GuiTextEditProfile)
{
	numbersOnly = true;
	justify = "center";
};

singleton GuiControlProfile(VSGuiTitleTextProfile : GuiBaseTextProfile)
{
	fontSize = 16;
};

singleton GuiControlProfile(VSGuiTextProfile : GuiBaseTextProfile)
{
};

singleton GuiControlProfile(VSGuiTextProfileRight : GuiBaseTextProfile)
{
	justify = "right";
};

singleton GuiControlProfile(VSGuiTextProfileCenter : GuiBaseTextProfile)
{
	justify = "center";
};

singleton GuiControlProfile(VSGuiTextClock : GuiBaseTextProfile)
{
	fontSize = 38;
	fontColor = "255 255 255";
	justify = "center";
};

singleton GuiControlProfile(VSGuiInv : GuiBaseTextProfile)
{
	fontSize = 12;
	fontType = "Arial";
};

singleton GuiControlProfile(VSGuiCheckBoxProfile : GuiCheckBoxProfile)
{
	fontSize = 12;
	//bitmap = "./images/checkbox";
	//hasBitmapArray = true;
};

singleton GuiControlProfile(VSGuiDropdownProfile : GuiBaseTextProfile)
{
	border = "";

	textOffset = "5 0";
	fontColor = "255 255 255";
	fontColorHL = "255 255 255";
	fontColorNA = "0 0 0";
	fontColorSEL= "0 0 0";
};

singleton GuiControlProfile(VSGuiDropdownCenterProfile : GuiBaseTextProfile)
{
	border = "";

	justify = "center";

	textOffset = "3 0";
	fontColor = "255 255 255";
	fontColorHL = "255 255 255";
	fontColorNA = "0 0 0";
	fontColorSEL= "0 0 0";
};

singleton GuiControlProfile(VSGuiWindowOverlayProfile : GuiOverlayProfile)
{
	modal = false;
	border = "rect1_color";
	borderColor = "0 0 0";


};

singleton GuiControlProfile(VSGuiSmallWindowProfile : GuiBaseCaptionProfile)
{
	opaque = false;
		border = "all_tiling";
		globalImageIndex = "small_window";
		fontSize = "20";
		textOffset = "15 0";
		fontColor = "255 255 255";
		fontColorHL = "0 0 0";
		bevelColorHL = "255 255 255";
		bevelColorLL = "0 0 0";

};

singleton GuiControlProfile(VSGuiButtonTabProfile : GuiButtonTabProfile)
{
	opaque = true;
	border = "rect1_color";

	fillColor = "28 28 28";
	fontColor = "175 175 175";
	fontColorHL = "255 255 255";
	fontColorNA = "94 78 60";
	fontColorSEL= "255 255 255";
	fixedExtent = false;
	justify = "center";
	canKeyFocus = false;
	bitmap = "";
	hasBitmapArray = false;
	category = "Core";
};
