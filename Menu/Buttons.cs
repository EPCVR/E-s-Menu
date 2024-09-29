using StupidTemplate.Classes;
using StupidTemplate.Mods;
using static StupidTemplate.Settings;

namespace StupidTemplate.Menu
{
    internal class Buttons
    {
        #region Buttons On Menu
        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
            new ButtonInfo[] {
                new ButtonInfo { buttonText = "Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Opens the main settings page for the menu."},

                new ButtonInfo { buttonText = "Disconnect", method =() => Disconnect.RegularDisconnect(), toolTip = "Disconnects you (D)", isTogglable = false},
                new ButtonInfo { buttonText = "Panic", method =() => Panic.PANIC(), toolTip = "Disconnects you (D)", isTogglable = false},
                new ButtonInfo { buttonText = "Anti-Report ", method =() => Room.AntiReportMod(), enabled = true ,toolTip = "Makes it so no one can report you",  isTogglable = true},
                new ButtonInfo { buttonText = "Disconnect Secondary ", method =() => Disconnect.DisconnectPrimary(), toolTip = "Disconnects you if you press B ", isTogglable = true},
                new ButtonInfo { buttonText = "Disconnect Primary", method =() => Disconnect.DisconnectSecondary(), toolTip = "Disconnects you if you press A ", isTogglable = true},
                new ButtonInfo { buttonText = "Comp Mode (UD)", method =() => Advanteges.COMPSTUFF(), toolTip = "Gives settings for comp (UD) ",isTogglable = true},
                new ButtonInfo { buttonText = "SpeedBoost (D)", method =() => SpeedBoost.SpeedBoostMod(), toolTip = "Gives a SpeedBoost (D)", isTogglable = true},
                new ButtonInfo { buttonText = "PC Destroyer (D)", method =() => PCD.PCMod(), toolTip = "Breaks Game (D)", isTogglable = true},
                new ButtonInfo { buttonText = "Fly (D)", method =() => Fly.FlyMod(), toolTip = "Lets you fly (D)", isTogglable = true},
                new ButtonInfo { buttonText = "Noclip (D)", method =() => NoClip.NoclipMod(), toolTip = "Makes you fall through the ground (D)", isTogglable = true},
                new ButtonInfo { buttonText = "Punch Mod (NW)", method =() => PunchMod.BetterPunchMod(), toolTip = "Lets people punch you", isTogglable = true},
                new ButtonInfo { buttonText = "Small Speed Boost (UD)", method =() => SpeedBoostSmall.SmallSpeedBoost(), toolTip = "Small SpeedBoost (UD)"},
                new ButtonInfo { buttonText = "Fast Fly (D)", method =() => Fast_Fly.FlyFast(), toolTip = "Lets you fly Really fast (D)", isTogglable = true},
                new ButtonInfo { buttonText = "Anti-RPC (UD)", method =() => Anti_RPC.RPCProtection(), toolTip = "Disables RPCs (UD)", isTogglable = true},
                new ButtonInfo { buttonText = "CarMonke (UD)", method =() => CarMonke.CarMonkeMod(), toolTip = "Let's you drive like a car (kinda Broken)|(UD)", isTogglable = true},
                new ButtonInfo { buttonText = "Plats (G)(UD)", method =() => Platforms.PlatformsMod(), toolTip = "Gives Platforms(kinda Broken)(UD)", isTogglable = true},
                new ButtonInfo { buttonText = "Ghost Monke (SS) (a)(UD)", method =() => Important.GhostMonkey(), toolTip = "Oooh spooky(UD)", isTogglable = true},
                new ButtonInfo { buttonText = "Invis (SS) (a) (UD)", method =() => Advanteges.InvisMonke(), toolTip = "Makes you invisible (SS) (UD)", isTogglable = true},
                new ButtonInfo { buttonText = "CrashGame", method =() => Quit_Game.CrashSelf(), toolTip = "CrashGame", isTogglable = false},
                new ButtonInfo { buttonText = "SpazMonke(UD)", method =() => SpazzMonke.Spaz(), toolTip = "Spazzes you (UD)", isTogglable = true},
                new ButtonInfo { buttonText = "Long Arms (UD)", method =() => LongArmMod.LongArms(),  disableMethod = LongArmMod.resetarms, toolTip = "Makes your arms longer (its undetected)", isTogglable = true},
                new ButtonInfo { buttonText = "Rlly Long Arms (UD)", method =() => LongArmMod.RllyLongArms(),  disableMethod = LongArmMod.resetarms, toolTip = "Makes your arms a LOT LONGER (its undetected)", isTogglable = true},
                new ButtonInfo { buttonText = "Grip SpeedBoost (D)", method =() => GSB.GSpB(), toolTip = "Gives a SpeedBoost if you Grip (D)", isTogglable = true},
                new ButtonInfo { buttonText = "NoClip Fly (D)", method =() => NoClipFly.NoclipAndFly(), toolTip = "Lets you fly and go through the ground (UD)", isTogglable = true},
                new ButtonInfo { buttonText = "Trigger Fly (D)", method =() => TFly.TriggerFly(), toolTip = "Lets you fly (RT) (UD)", isTogglable = true},
                new ButtonInfo { buttonText = "TP Gun (UD)", method =() => tpg.TPGun(), toolTip = "It teleports u (UD)", isTogglable = true},
                new ButtonInfo { buttonText = "Set Master  (OP) (UD)", method =() => tpg.TPGun(), toolTip = "Makes you master (UD)", isTogglable = false},
                new ButtonInfo { buttonText = "Master Check  (OP) (UD)", method =() => Overpowerd.MasterCheck(), toolTip = "Checks if you master (UD)", isTogglable = false},
                new ButtonInfo { buttonText = "Slow Speed 💀 (UD)", method =() => Slow_Speed.SSpeed(), toolTip = "Gives you slow speed 💀 (UD)", isTogglable = true},
                new ButtonInfo { buttonText = "Slow Fly (UD)", method =() => Slow_fly.SFly(), toolTip = "Lets you fly slowly 💀 (UD)", isTogglable = true},
                new ButtonInfo { buttonText = "Upsidedown Head (UD)", method =() => Random_Ass_Fly.UpsideDownHead(),  disableMethod = Random_Ass_Fly.FixHead, toolTip = "Makes Your head upside down", isTogglable = true},
                new ButtonInfo { buttonText = "Inf Shiny Rocks (UD)", method =() => Plats_Fix.InfShinyRocks(), toolTip = "Gives you infinite Shiny Ricks $$$$", isTogglable = true},
                new ButtonInfo { buttonText = "Teleports you to stump (UD)", method =() => TPTS.TpToStump(), toolTip = "TPs you to stump", isTogglable = true},
                new ButtonInfo { buttonText = "Backwords Flys (UD)", method =() => backwords_Fly.FlyMod(), toolTip = "Makes you fly backwords", isTogglable = true},
                new ButtonInfo { buttonText = "Grab bat (UD)", method =() => Fun.GrabBatMod(), toolTip = "Makes you fly backwords", isTogglable = true},
                new ButtonInfo { buttonText = "Grab card (UD)", method =() => Fun.GrabIDCard(), toolTip = "Makes you fly backwords", isTogglable = true},
                new ButtonInfo { buttonText = "Tag aura (UD)", method =() => Advanteges.TagAura(), toolTip = "Tags people within a 5m Raidus", isTogglable = true},
                new ButtonInfo { buttonText = "ESP/XRAY (UD)", method =() => Advanteges.ESPMod(), toolTip = "Lets you see people through walls", isTogglable = true},
                new ButtonInfo { buttonText = "Grab Rig (SS) (UD)", method =() => Fun.GrabRig(),  toolTip = "Lets you Grab your body SS (UD)", isTogglable = true},
                new ButtonInfo { buttonText = "Tag Gun (UD)", method =() => Advanteges.TagGunMod(),  toolTip = "(UD)", isTogglable = true},
            },
#endregion

            new ButtonInfo[] { // Hey0
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Menu", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
                new ButtonInfo { buttonText = "Movement/Projectile", method =() => SettingsMods.MovementSettings(), isTogglable = false, toolTip = "Opens the movement/projectile settings for the menu."},
                new ButtonInfo { buttonText = "Map Settings", method =() => SettingsMods.ProjectileSettings(), isTogglable = false, toolTip = "Opens the projectile settings for the menu" },
            },

            new ButtonInfo[] { // Menu Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "Right Hand", enableMethod =() => SettingsMods.RightHand(), disableMethod =() => SettingsMods.LeftHand(), toolTip = "Puts the menu on your right hand."},
                new ButtonInfo { buttonText = "Notifications", enableMethod =() => SettingsMods.EnableNotifications(), disableMethod =() => SettingsMods.DisableNotifications(), enabled = !disableNotifications, toolTip = "Toggles the notifications."},
                new ButtonInfo { buttonText = "FPS Counter", enableMethod =() => SettingsMods.EnableFPSCounter(), disableMethod =() => SettingsMods.DisableFPSCounter(), enabled = fpsCounter, toolTip = "Toggles the FPS counter."},
            },

            new ButtonInfo[] { // Movement Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
            },

            new ButtonInfo[] { // Map Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
                new ButtonInfo { buttonText = "Purple Sky (UD)", method =() => PurpleSky.PurpleSkyMod(),disableMethod = PurpleSky.PurpleSkyDisable, toolTip = "Makes the purporl Sky (UD)", isTogglable = true},
                new ButtonInfo { buttonText = "Blue Sky (UD)", method =() => Blue_Sky.BlueSkyMod(),disableMethod = Blue_Sky.fixSKy, toolTip = "Makes They Sky blue(UD)", isTogglable = true},
                new ButtonInfo { buttonText = "Red Sky (UD)", method =() => Blue_Sky.RedSkyMod(),disableMethod = Blue_Sky.fixSKy, toolTip = "Makes They Sky red(CS)(UD)", isTogglable = true},
                new ButtonInfo { buttonText = "MorningTime", method =() => DayS.MorningTime(), toolTip = "swithes to Morning", isTogglable = false},
                new ButtonInfo { buttonText = "DayTime", method =() => DayS.DayTime(), toolTip = "Swithes to Day", isTogglable = false},
                new ButtonInfo { buttonText = "EveningTime", method =() => DayS.EveningTime(), toolTip = "Turns It to AFTERNOON", isTogglable = false},
                new ButtonInfo { buttonText = "NightTime", method =() => DayS.NightTime(), toolTip = "Swithes To Night", isTogglable = false},
                new ButtonInfo { buttonText = "Rain", method =() => Weather.Rain(), toolTip = "Makes it rainy", isTogglable = false},
                new ButtonInfo { buttonText = "NoRain", method =() => Weather.NoRain(), toolTip = "No Rain :-)", isTogglable = false},
                new ButtonInfo { buttonText = "Bright (W?)", method =() => Weather.Fullbright(), toolTip = "Makes the sky bright", isTogglable = false},
                new ButtonInfo { buttonText = "Shade (W?)", method =() => Weather.Fullshade(), toolTip = "Gives a shade", isTogglable = false},
            },
        };
    }
}
