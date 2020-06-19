//Original code from sf mods

function vsGMToggleMode(%val)
{
	if (%val)
	{
		// Get password from password text box
		%password = VSGMGuiPassword.GetValue();

		// Join the /GM command and password togther
		%cmd = "/GM " @ %password;

		// Logs the command in system chat
		// Usually we'd show the actual command made using %cmd, but since we want
		// to hide the password, we'll just display "/GM" and some bullet points
		onChatMessage("<spush><color:FF4500>/GM ••••<spop>", null, null);





		// Execute command
		doSlashCommand(%cmd);

		// Disables cursor
		VSGMGuiPassword.setActive(false); VSGMGuiPassword.setActive(true);

		// Saves password in prefs
		$pref::VSGMTools::Password = %password;

		// Exports to prefs.cs
		export("$pref::*", "data/prefs.cs", False);
	}
}

// Sets GM Toggle to Alt + U key
moveMap.bind(keyboard, "alt u", vsGMToggleMode);

//Sets pve Skill
function vsGMpveskill()
{
	%pveskill = VSGMGuipveskill.getSelected();
	%pveskillText = VSGMGuipveskill.getText();
  %pveskilllvl = VSGMGuipveskilllvl.GetValue();

	%cmd = "/setmyskill " @ %pveskillText @ " " @ %pveskilllvl;

	onChatMessage("<spush><color:FF4500>" @ %cmd @ "<spop>", null, null);

	doSlashCommand(%cmd);

	// SAVE PREFS
	$pref::VSGMTools::pveskill = %pveskill;

	// EXPORT ALL PREFS
	export("$pref::*", "data/prefs.cs", False);
}
function vsGMpvpskill()
{
	%pvpskill = VSGMGuipvpskill.getSelected();
	%pvpskillText = VSGMGuipvpskill.getText();
  %pvpskilllvl = VSGMGuipvpskilllvl.GetValue();

	%cmd = "/setmyskill " @ %pvpskillText @ " " @ %pvpskilllvl;

	onChatMessage("<spush><color:FF4500>" @ %cmd @ "<spop>", null, null);

	doSlashCommand(%cmd);

	// SAVE PREFS
	$pref::VSGMTools::pvpskill = %pvpskill;

	// EXPORT ALL PREFS
	export("$pref::*", "data/prefs.cs", False);
}
function vsGMstat()
{
	%stat = VSGMGuistat.getSelected();
	%statText = VSGMGuistat.getText();
  %statlvl = VSGMGuistatlvl.GetValue();

	%cmd = "/setmystat " @ %statText @ " " @ %statlvl;

	onChatMessage("<spush><color:FF4500>" @ %cmd @ "<spop>", null, null);

	doSlashCommand(%cmd);

	// SAVE PREFS
	$pref::VSGMTools::stat = %stat;

	// EXPORT ALL PREFS
	export("$pref::*", "data/prefs.cs", False);
}
function vsGMAddItem()
{
	%item = VSGMGuiAddItemID.GetValue();
	%amount = VSGMGuiAddAmount.GetValue();
	%quality = VSGMGuiAddQuality.GetValue();
	%durability = VSGMGuiAddDurability.GetValue();

	%cmd = "/ADD " @ %item @ " " @ %amount @ " " @ %quality @ " " @ %durability;

	onChatMessage("<spush><color:FF4500>" @ %cmd @ "<spop>", null, null);

	doSlashCommand(%cmd);

	// Disable cursors
	VSGMGuiAddItemID.setActive(false); VSGMGuiAddItemID.setActive(true);
	VSGMGuiAddAmount.setActive(false); VSGMGuiAddAmount.setActive(true);
	VSGMGuiAddQuality.setActive(false); VSGMGuiAddQuality.setActive(true);
	VSGMGuiAddDurability.setActive(false); VSGMGuiAddDurability.setActive(true);

	// SAVE PREFS
	$pref::VSGMTools::AddItemID = %item;
	$pref::VSGMTools::AddAmount = %amount;
	$pref::VSGMTools::AddQuality = %quality;
	$pref::VSGMTools::AddDurability = %durability;

	// EXPORT ALL PREFS
	export("$pref::*", "data/prefs.cs", False);
}
function vsGMRemoveEffects()
{
	%cmd = "/REMOVEEFFECTS";

	onChatMessage("<spush><color:FF4500>" @ %cmd @ "<spop>", null, null);

	doSlashCommand(%cmd);
}
function vsGMHealSelf()
{
	%cmd = "/HEALSELF";

	onChatMessage("<spush><color:FF4500>" @ %cmd @ "<spop>", null, null);

	doSlashCommand(%cmd);
}
function vsGMAllSkills()
{
	// Set Stats to Max
	for (%i = 0; %i < 5; %i++)
	{
		%cmd = "/SETMYSTAT " @ %i @ " 100";

		onChatMessage("<spush><color:FF4500>" @ %cmd @ "<spop>", null, null);

		doSlashCommand(%cmd);
	}

	// Set Skills to Max
	for (%i = 1; %i < 66; %i++)
	{
		%cmd = "/SETMYSKILL " @ %i @ " 100";

		onChatMessage("<spush><color:FF4500>" @ %cmd @ "<spop>", null, null);

		doSlashCommand(%cmd);
	}
}
function vsGMFood()
{
	%cmd = "/setmyhunger 100";

	onChatMessage("<spush><color:FF4500>" @ %cmd @ "<spop>", null, null);

	doSlashCommand(%cmd);
}
