//-----------------------------------------------------------------------------
// MAIN
//-----------------------------------------------------------------------------

// Set Title
// Gets the current version from init.cs and suffixes it to the window title
if ($vsVersion)
{
	VSGMGuiWindowCtrl.text = "GM Skills tool" @ $vsGMVersion;
}


// Window Toggle
// Does what it says really
function vsGMWindowToggle(%val)
{
	if (%val)
	{
		if (VSGMGuiWindow.isAwake())
		{
			PlayGui.remove(VSGMGuiWindow);

			// Save the window position
			vsGMSaveWindowPosition();

		} else
		{
			PlayGui.add(VSGMGuiWindow);

			// Sets the window position
			vsGMSetWindowPosition();
		}
	}
}

// Sets window toggle to the ALT + G combo
moveMap.bind(keyboard, "alt y", vsGMWindowToggle);


// Save the window position
function vsGMSaveWindowPosition()
{
	$pref::VSGMTools::WindowPosition = VSGMGuiWindowCtrl.position;

	export("$pref::*", "data/prefs.cs", False);//-----------------------------------------------------------------------------
// MAIN
//-----------------------------------------------------------------------------

// Set Title
// Gets the current version from init.cs and suffixes it to the window title
if ($vsVersion)
{
	VSGMGuiWindowCtrl.text = "GM Skills tool" @ $vsGMVersion;
}


// Window Toggle
// Does what it says really
function vsGMWindowToggle(%val)
{
	if (%val)
	{
		if (VSGMGuiWindow.isAwake())
		{
			PlayGui.remove(VSGMGuiWindow);

			// Save the window position
			vsGMSaveWindowPosition();

		} else
		{
			PlayGui.add(VSGMGuiWindow);

			// Sets the window position
			vsGMSetWindowPosition();
		}
	}
}

// Sets window toggle to the ALT + G combo
moveMap.bind(keyboard, "alt y", vsGMWindowToggle);


// Save the window position
function vsGMSaveWindowPosition()
{
	$pref::VSGMTools::WindowPosition = VSGMGuiWindowCtrl.position;

	export("$pref::*", "data/prefs.cs", False);
}


// Sets the window position
function vsGMSetWindowPosition()
{
	VSGMGuiWindowCtrl.position = $pref::VSGMTools::WindowPosition;
}


// Reload GM Tools
// Re-executes the GM Tools (mainly used for Debugging)
function vsGMReloadGMTools(%val)
{
	if (%val)
	{
		onChatMessage("<spush><color:ffff00>VS GM Tools Reloaded<spop>", null, null);

		warn("GM Skills Tool Reloaded");

		exec("mod/GM-skill-tool/init.cs");
	}
}

// Sets reload to F11 key
moveMap.bind(keyboard, "F6", vsGMReloadGMTools);

function vsGMListItems()
{
	openWeb("https://lifeisfeudal.com/billing/gmcommands.php#itemSearch");
}


// AddAmount
$sfgmAddAmount = 10;

if ($pref::SFGMTools::AddAmount  $= "") { $pref::SFGMTools::AddAmount = $sfgmAddAmount; } else { $sfgmAddAmount = $pref::SFGMTools::AddAmount; }

SFGMGuiAddAmount.setText($pref::SFGMTools::AddAmount);


// AddQuality
$sfgmAddQuality = 50;

if ($pref::SFGMTools::AddQuality  $= "") { $pref::SFGMTools::AddQuality = $sfgmAddQuality; } else { $sfgmAddQuality = $pref::SFGMTools::AddQuality; }

SFGMGuiAddQuality.setText($pref::SFGMTools::AddQuality);


// AddDurability
$sfgmAddDurability = 5000;

if ($pref::SFGMTools::AddDurability  $= "") { $pref::SFGMTools::AddDurability = $sfgmAddDurability; } else { $sfgmAddDurability = $pref::SFGMTools::AddDurability; }

SFGMGuiAddDurability.setText($pref::SFGMTools::AddDurability);

// Toggle Fly Mode
// Without the need to press F7 and F8 to toggle
// Also forces third person on when disabing



// Set PVE Skill
// Clears the list, adds all the gubbins
VSGMGuipveskill.clear();
VSGMGuipveskill.Add("Artisan", 0);
VSGMGuipveskill.Add("Construction", 1);
VSGMGuipveskill.Add("Masonry", 2);
VSGMGuipveskill.Add("Architecture", 3);
VSGMGuipveskill.Add("\"Building Maintain\"", 4);
VSGMGuipveskill.Add("Digging", 5);
VSGMGuipveskill.Add("Mining", 6);
VSGMGuipveskill.Add("\"Precious Prospecting\"", 7);
VSGMGuipveskill.Add("Materials Preparation", 8);
VSGMGuipveskill.Add("Smelting", 9);
VSGMGuipveskill.Add("Forging", 10);
VSGMGuipveskill.Add("Armorsmithing", 11);
VSGMGuipveskill.Add("Nature's Lore", 12);
VSGMGuipveskill.Add("Farming", 13);
VSGMGuipveskill.Add("Forestry", 14);
VSGMGuipveskill.Add("Advanced Farming", 15);
VSGMGuipveskill.Add("Cooking", 16);
VSGMGuipveskill.Add("Brewing", 17);
VSGMGuipveskill.Add("Herbalism", 18);
VSGMGuipveskill.Add("Healing", 19);
VSGMGuipveskill.Add("Alchemy", 20);
VSGMGuipveskill.Add("Hunting", 21);
VSGMGuipveskill.Add("Animal Lore", 22);
VSGMGuipveskill.Add("Procuration", 23);
VSGMGuipveskill.Add("Warhorse training", 24);
VSGMGuipveskill.Add("Tailoring", 25);

//PVP Skill
VSGMGuipvpskill.clear();
VSGMGuipvpskill.Add("Cavalry", 1);
VSGMGuipvpskill.Add("Knight", 2);
VSGMGuipvpskill.Add("Lancer", 3);
VSGMGuipvpskill.Add("Militia", 4);
VSGMGuipvpskill.Add("Spearman", 5);
VSGMGuipvpskill.Add("Guard", 6);
VSGMGuipvpskill.Add("Footman", 7);
VSGMGuipvpskill.Add("Swordsman", 8);
VSGMGuipvpskill.Add("Huscarl", 9);
VSGMGuipvpskill.Add("Slinger", 10);
VSGMGuipvpskill.Add("Archer", 11);
VSGMGuipvpskill.Add("Ranger", 12);
VSGMGuipvpskill.Add("Assaulter", 13);
VSGMGuipvpskill.Add("Vanguard", 14);
VSGMGuipvpskill.Add("Berserker", 15);
VSGMGuipvpskill.Add("\"Unit and formation\"", 16);
VSGMGuipvpskill.Add("\"Equipment maintain\"", 17);
VSGMGuipvpskill.Add("\"Battle Survival\"", 18);
VSGMGuipvpskill.Add("Demolition", 19);


// Set Animal List
// Clears the list, adds all the gubbins
VSGMGuistat.clear();
VSGMGuistat.Add("Strength", 0);
VSGMGuistat.Add("Agility", 1);
VSGMGuistat.Add("Constitution", 2);
VSGMGuistat.Add("Intellect", 3);
VSGMGuistat.Add("Willpower", 4);



//-----------------------------------------------------------------------------
// SET DEFAULT VARIABLES AND PREFS
//-----------------------------------------------------------------------------

// Password
$vsgmPassword = "gm_pass";

if ($pref::VSGMTools::Password  $= "") { $pref::VSGMTools::Password = $vsgmPassword; } else { $vsgmPassword = $pref::VSGMTools::Password; }

VSGMGuiPassword.setText($pref::VSGMTools::Password);








// pveskill
$vsgmpveskill = "0";

if ($pref::VSGMTools::pveskill  $= "") { $pref::VSGMTools::pveskill = $vsgmpveskill; } else { $vsgmpveskill = $pref::VSGMTools::pveskill; }

VSGMGuipveskill.setSelected($vsgmpveskill);





// Animal
$vsgmAnimal = "0";

if ($pref::VSGMTools::Animal  $= "") { $pref::VSGMTools::Animal = $vsgmAnimal; } else { $vsgmAnimal = $pref::VSGMTools::Animal; }

VSGMGuiAnimal.setSelected($vsgmAnimal);




// EXPORT ALL PREFS
export("$pref::*", "data/prefs.cs", False);

}


// Sets the window position
function vsGMSetWindowPosition()
{
	VSGMGuiWindowCtrl.position = $pref::VSGMTools::WindowPosition;
}


// Reload GM Tools
// Re-executes the GM Tools (mainly used for Debugging)
function vsGMReloadGMTools(%val)
{
	if (%val)
	{
		onChatMessage("<spush><color:ffff00>VS GM Tools Reloaded<spop>", null, null);

		warn("GM Skills Tool Reloaded");

		exec("mod/GM-skill-tool/init.cs");
	}
}

// Sets reload to F11 key
moveMap.bind(keyboard, "F4", vsGMReloadGMTools);

function vsGMListItems()
{
	openWeb("https://lifeisfeudal.com/billing/gmcommands.php#itemSearch");
}


// AddAmount
$sfgmAddAmount = 10;

if ($pref::SFGMTools::AddAmount  $= "") { $pref::SFGMTools::AddAmount = $sfgmAddAmount; } else { $sfgmAddAmount = $pref::SFGMTools::AddAmount; }

SFGMGuiAddAmount.setText($pref::SFGMTools::AddAmount);


// AddQuality
$sfgmAddQuality = 50;

if ($pref::SFGMTools::AddQuality  $= "") { $pref::SFGMTools::AddQuality = $sfgmAddQuality; } else { $sfgmAddQuality = $pref::SFGMTools::AddQuality; }

SFGMGuiAddQuality.setText($pref::SFGMTools::AddQuality);


// AddDurability
$sfgmAddDurability = 5000;

if ($pref::SFGMTools::AddDurability  $= "") { $pref::SFGMTools::AddDurability = $sfgmAddDurability; } else { $sfgmAddDurability = $pref::SFGMTools::AddDurability; }

SFGMGuiAddDurability.setText($pref::SFGMTools::AddDurability);

// Toggle Fly Mode
// Without the need to press F7 and F8 to toggle
// Also forces third person on when disabing



// Set PVE Skill
// Clears the list, adds all the gubbins
VSGMGuipveskill.clear();
VSGMGuipveskill.Add("Artisan", 0);
VSGMGuipveskill.Add("Construction", 1);
VSGMGuipveskill.Add("Masonry", 2);
VSGMGuipveskill.Add("Architecture", 3);
VSGMGuipveskill.Add("\"Building Maintain\"", 4);
VSGMGuipveskill.Add("Digging", 5);
VSGMGuipveskill.Add("Mining", 6);
VSGMGuipveskill.Add("\"Precious Prospecting\"", 7);
VSGMGuipveskill.Add("Materials Preparation", 8);
VSGMGuipveskill.Add("Smelting", 9);
VSGMGuipveskill.Add("Forging", 10);
VSGMGuipveskill.Add("Armorsmithing", 11);
VSGMGuipveskill.Add("Nature's Lore", 12);
VSGMGuipveskill.Add("Farming", 13);
VSGMGuipveskill.Add("Forestry", 14);
VSGMGuipveskill.Add("Advanced Farming", 15);
VSGMGuipveskill.Add("Cooking", 16);
VSGMGuipveskill.Add("Brewing", 17);
VSGMGuipveskill.Add("Herbalism", 18);
VSGMGuipveskill.Add("Healing", 19);
VSGMGuipveskill.Add("Alchemy", 20);
VSGMGuipveskill.Add("Hunting", 21);
VSGMGuipveskill.Add("Animal Lore", 22);
VSGMGuipveskill.Add("Procuration", 23);
VSGMGuipveskill.Add("Warhorse training", 24);
VSGMGuipveskill.Add("Tailoring", 25);

//PVP Skill
VSGMGuipvpskill.clear();
VSGMGuipvpskill.Add("Cavalry", 1);
VSGMGuipvpskill.Add("Knight", 2);
VSGMGuipvpskill.Add("Lancer", 3);
VSGMGuipvpskill.Add("Militia", 4);
VSGMGuipvpskill.Add("Spearman", 5);
VSGMGuipvpskill.Add("Guard", 6);
VSGMGuipvpskill.Add("Footman", 7);
VSGMGuipvpskill.Add("Swordsman", 8);
VSGMGuipvpskill.Add("Huscarl", 9);
VSGMGuipvpskill.Add("Slinger", 10);
VSGMGuipvpskill.Add("Archer", 11);
VSGMGuipvpskill.Add("Ranger", 12);
VSGMGuipvpskill.Add("Assaulter", 13);
VSGMGuipvpskill.Add("Vanguard", 14);
VSGMGuipvpskill.Add("Berserker", 15);
VSGMGuipvpskill.Add("\"Unit and formation\"", 16);
VSGMGuipvpskill.Add("\"Equipment maintain\"", 17);
VSGMGuipvpskill.Add("\"Battle Survival\"", 18);
VSGMGuipvpskill.Add("Demolition", 19);


// Set Animal List
// Clears the list, adds all the gubbins
VSGMGuistat.clear();
VSGMGuistat.Add("Strength", 0);
VSGMGuistat.Add("Agility", 1);
VSGMGuistat.Add("Constitution", 2);
VSGMGuistat.Add("Intellect", 3);
VSGMGuistat.Add("Willpower", 4);



//-----------------------------------------------------------------------------
// SET DEFAULT VARIABLES AND PREFS
//-----------------------------------------------------------------------------

// Password
$vsgmPassword = "gm_pass";

if ($pref::VSGMTools::Password  $= "") { $pref::VSGMTools::Password = $vsgmPassword; } else { $vsgmPassword = $pref::VSGMTools::Password; }

VSGMGuiPassword.setText($pref::VSGMTools::Password);








// pveskill
$vsgmpveskill = "0";

if ($pref::VSGMTools::pveskill  $= "") { $pref::VSGMTools::pveskill = $vsgmpveskill; } else { $vsgmpveskill = $pref::VSGMTools::pveskill; }

VSGMGuipveskill.setSelected($vsgmpveskill);





// Animal
$vsgmAnimal = "0";

if ($pref::VSGMTools::Animal  $= "") { $pref::VSGMTools::Animal = $vsgmAnimal; } else { $vsgmAnimal = $pref::VSGMTools::Animal; }

VSGMGuiAnimal.setSelected($vsgmAnimal);




// EXPORT ALL PREFS
export("$pref::*", "data/prefs.cs", False);
