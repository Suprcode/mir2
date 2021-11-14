﻿using Client.MirControls;
using Client.MirGraphics;
using Client.MirObjects;
using Client.MirSounds;
using System;
using System.Drawing;
using System.Windows.Forms;
using C = ClientPackets;
using Client.MirNetwork;

namespace Client.MirScenes.Dialogs
{
	public sealed class WorldMapDialog : MirImageControl
	{
		public MirButton closeButton, nextButton, backButton;
		public MirLabel titleLabel, pageLabel;
		public MirImageControl worldMap;
		public MirAnimatedControl locationAnimation;

		public MirLabel dungeonNameLabel, informationLabel, suggestedLevelLabel, suggestedLevel, goldlabel, gold, questdropLabel, informationArea, dropLabel, drop01, drop02, drop03, drop04, drop05;

		public MirButton OmaCaveLvLButton1, OmaCaveLvLButton2, OmaCaveLvLButton3, PastBichonButton1, PastBichonButton2, PastBichonButton3, ChaosTempleLvLButton1, ChaosTempleLvLButton2, ChaosTempleLvLButton3;
		public MirButton PainCavernButton1, PainCavernButton2, PainCavernButton3, TriTempleButton1, TriTempleButton2, TriTempleButton3;
		public MirButton LostCaveButton1, LostCaveButton2, LostCaveButton3, LittleIslandButton1, LittleIslandButton2, LittleIslandButton3;
		public MirButton StoneTempleLvLButton1, StoneTempleLvLButton2, StoneTempleLvLButton3, CursedLandButton1, CursedLandButton2, CursedLandButton3;

		public MirLabel OmaCaveLvLLabel1, OmaCaveLvLLabel2, OmaCaveLvLLabel3, PastBichonLabel1, PastBichonLabel2, PastBichonLabel3, ChaosTempleLvLLabel1, ChaosTempleLvLLabel2, ChaosTempleLvLLabel3;
		public MirLabel PainCavernLabel1, PainCavernLabel2, PainCavernLabel3, TriTempleLabel1, TriTempleLabel2, TriTempleLabel3;
		public MirLabel LostCaveLabel1, LostCaveLabel2, LostCaveLabel3, LittleIslandLabel1, LittleIslandLabel2, LittleIslandLabel3;
		public MirLabel StoneTempleLvLLabel1, StoneTempleLvLLabel2, StoneTempleLvLLabel3, CursedLandLabel1, CursedLandLabel2, CursedLandLabel3;

		#region Labels + Buttons
		public MirButton TeleportButton, TeleportHomeButton, OmaCaveTeleport, ZombieCaveTeleport, SerpentCaveTeleport, InsectCaveTeleport, BugCaveTeleport, StoneTempleTeleport, ZumaTempleTeleport, WoomaTempleTeleport; 
		public MirButton PrajnaCaveTeleport,PrajnaTempleTeleport,SpiderCaveTeleport,FrozenTempleTeleport,SwampCaveTeleport,NumaTempleTeleport,TrollTempleTeleport,DemonTempleTeleport;
		public MirButton AngelTempleTeleport, HellCaveTeleport, FoxCaveTeleport, OrcTempleTeleport, EvilCaveTeleport, LizardCaveTeleport, SunkenCaveTeleport, KnightTempleTeleport;
		public MirButton HavokTempleTeleport,SkullCaveTeleport,LostTempleTeleport,IceTempleTeleport,ForgottenTempleTeleport,TurtleLairTeleport,CaveOfNicanorTeleport; 
		public MirButton CaveOfTroubleTeleport, GardenOfDeathTeleport,CaveOfHorrorTeleport,CaveOfDespairTeleport,TempleOfHeroesTeleport,SacredTempleTeleport,DarkTempleTeleport;
		public MirButton SealedCaveTeleport, MysticTempleTeleport, ShadowCaveTeleport, AncientTempleTeleport, CursedCaveTeleport, ChaosTempleTeleport, RockTempleTeleport, RampantTempleTeleport, PhantomTempleTeleport, HellishCaveTeleport;
		public MirButton OmaCaveLvLTeleport, OmaCaveLvLTeleport1, OmaCaveLvLTeleport2, OmaCaveLvLTeleport3;
		public MirButton PastBichonLvLTeleport, PastBichonLvLTeleport1, PastBichonLvLTeleport2, PastBichonLvLTeleport3;
		public MirButton ChaosTempleLvLTeleport, ChaosTempleLvLTeleport1, ChaosTempleLvLTeleport2, ChaosTempleLvLTeleport3;
		public MirButton PainCavernLvLTeleport, PainCavernLvLTeleport1, PainCavernLvLTeleport2, PainCavernLvLTeleport3;
		public MirButton TriTempleLvLTeleport, TriTempleLvLTeleport1, TriTempleLvLTeleport2, TriTempleLvLTeleport3;
		public MirButton LostCaveLvLTeleport, LostCaveLvLTeleport1, LostCaveLvLTeleport2, LostCaveLvLTeleport3;
		public MirButton LittleIslandLvLTeleport, LittleIslandLvLTeleport1, LittleIslandLvLTeleport2, LittleIslandLvLTeleport3;
		public MirButton StoneTempleLvLTeleport, StoneTempleLvLTeleport1, StoneTempleLvLTeleport2, StoneTempleLvLTeleport3;
		public MirButton CursedLandLvLTeleport, CursedLandLvLTeleport1, CursedLandLvLTeleport2, CursedLandLvLTeleport3;

		public MirButton GroupMapList1, GroupMapList2, GroupMapList3, GroupMapList4, GroupMapList5, GroupMapList6, GroupMapList7, GroupMapList8, GroupMapList9, GroupMapList10;
		public MirButton LevelingButton1, GroupMapList12, GroupMapList13, GroupMapList14, GroupMapList15, GroupMapList16;

		public MirButton MapList1, MapList2, MapList3, MapList4, MapList5, MapList6, MapList7, MapList8, MapList9, MapList10;
		public MirButton MapList11, MapList12, MapList13, MapList14, MapList15, MapList16, MapList17, MapList18, MapList19, MapList20;
		public MirButton MapList21, MapList22, MapList23, MapList24, MapList25, MapList26, MapList27, MapList28, MapList29, MapList30;
		public MirButton MapList31, MapList32, MapList33, MapList34, MapList35, MapList36, MapList37, MapList38, MapList39, MapList40;
		public MirButton MapList41, MapList42, MapList43, MapList44, MapList45, MapList46, MapList47, MapList48, MapList49, MapList50;

		public MirButton OmaCaveLvLButton, PastBichonButton, ChaosTempleLvLButton, PainCavernButton, TriTempleButton, LostCaveButton, LittleIslandButton, StoneTempleLvLButton, CursedLandButton;

		public MirLabel GroupMapListLabel1, GroupMapListLabel2, GroupMapListLabel3, GroupMapListLabel4, GroupMapListLabel5, GroupMapListLabel6, GroupMapListLabel7, GroupMapListLabel8, GroupMapListLabel9, GroupMapListLabel10;
		public MirLabel LevelingLabel1, GroupMapListLabel12, GroupMapListLabel13, GroupMapListLabel14, GroupMapListLabel15, GroupMapListLabel16;

		public MirLabel MapListLabel1, MapListLabel2, MapListLabel3, MapListLabel4, MapListLabel5, MapListLabel6, MapListLabel7, MapListLabel8, MapListLabel9, MapListLabel10;
		public MirLabel MapListLabel11, MapListLabel12, MapListLabel13, MapListLabel14, MapListLabel15, MapListLabel16, MapListLabel17, MapListLabel18, MapListLabel19, MapListLabel20;
		public MirLabel MapListLabel21, MapListLabel22, MapListLabel23, MapListLabel24, MapListLabel25, MapListLabel26, MapListLabel27, MapListLabel28, MapListLabel29, MapListLabel30;
		public MirLabel MapListLabel31, MapListLabel32, MapListLabel33, MapListLabel34, MapListLabel35, MapListLabel36, MapListLabel37, MapListLabel38, MapListLabel39, MapListLabel40;
		public MirLabel MapListLabel41, MapListLabel42, MapListLabel43, MapListLabel44, MapListLabel45, MapListLabel46, MapListLabel47, MapListLabel48, MapListLabel49, MapListLabel50;
		public MirLabel OmaCaveLvLLabel, PastBichonLabel, ChaosTempleLvLLabel, PainCavernLabel, TriTempleLabel, LostCaveLabel, LittleIslandLabel, StoneTempleLvLLabel, CursedLandLabel;

		public MirButton ParaLordTeleport, MirKingTeleport, CrystalKingTeleport, OmaKingSpiritTeleport, DarkOmaKingTeleport, BloodKingTeleport, EvilMirTeleport, HellKingTeleport;
		public MirButton BattleAreasButton, ParaLordButton, MirKingButton, CrystalKingButton, OmaKingSpiritButton, DarkOmaKingButton, BloodKingButton, EvilMirButton, HellKingButton;
		public MirLabel BattleAreasLabel, ParaLordLabel, MirKingLabel, CrystalKingLabel, OmaKingSpiritLabel, DarkOmaKingLabel, BloodKingLabel, EvilMirLabel, HellKingLabel;

		public MirButton BlackDragonDungeonTeleport, DomainOfAnquishTeleport, RedDragonDungeonTeleport, ZephyrTempleTeleport, OldSkoolTempleTeleport;
		public MirButton GroupAreasButton, BlackDragonDungeonButton, DomainOfAnquishButton, RedDragonDungeonButton, ZephyrTempleButton, OldSkoolTempleButton;
		public MirLabel GroupAreasLabel, BlackDragonDungeonLabel, DomainOfAnquishLabel, RedDragonDungeonLabel, ZephyrTempleLabel, OldSkoolTempleLabel;

		public MirButton LastManStandingButton, LastManStandingTeleport, ChallengeButton, ChallengeTeleport, InstanceButton, InstanceTeleport, SabukWallButton, SabukWallTeleport, BossLandButton, BossLandTeleport;
		public MirLabel LastManStandingLabel, ChallengeLabel, InstanceLabel, SabukWallLabel, BossLandLabel;
		#endregion

		public static UserObject User
		{
			get
			{
				return MapObject.User;
			}
			set
			{
				MapObject.User = value;
			}
		}

		public WorldMapDialog()
		{
			Index = 79;
			Library = Libraries.WorldMap;
			Movable = true;
			Location = new Point(Settings.ScreenWidth / 2 - Size.Width / 2, Settings.ScreenHeight / 4 - Size.Height / 4);

			closeButton = new MirButton
			{
				Index = 361,
				HoverIndex = 362,
				PressedIndex = 363,
				Location = new Point(484, 5),
				Library = Libraries.Prguse,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Close"
			};
			closeButton.Click += delegate (object o, EventArgs e)
			{
				Hide();
			};

			titleLabel = new MirLabel
			{
				Font = new Font(Settings.FontName, 10f, FontStyle.Bold),
				ForeColour = Color.NavajoWhite,
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Text = "World Map",
				Size = new Size(80, 18),
				Location = new Point(210, 8),
				Parent = this,
				NotControl = true
			};

			backButton = new MirButton
			{
				Index = 240,
				HoverIndex = 241,
				PressedIndex = 242,
				Library = Libraries.Prguse2,
				Location = new Point(294, 50),
				Sound = SoundList.ButtonA,
				Parent = this,
				Visible = true,
				Hint = "Back Page"
			};
			backButton.Click += delegate (object o, EventArgs e)
			{
				Page(0);
			};

			nextButton = new MirButton
			{
				Index = 243,
				HoverIndex = 244,
				PressedIndex = 245,
				Library = Libraries.Prguse2,
				Location = new Point(360, 50),
				Sound = SoundList.ButtonA,
				Parent = this,
				Visible = true,
				Hint = "Next Page"
			};
			nextButton.Click += delegate (object o, EventArgs e)
			{
				Page(1);
			};

			pageLabel = new MirLabel
			{
				Size = new Size(70, 18),
				Location = new Point(300, 50),
				DrawFormat = TextFormatFlags.HorizontalCenter,
				Text = "0",
				NotControl = true,
				Parent = this,
				Visible = true
			};

			TeleportButton = new MirButton
			{
				Index = 943,
				HoverIndex = 944,
				PressedIndex = 945,
				Location = new Point(380, 403),
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};

			TeleportHomeButton = new MirButton
			{
				Index = 940,
				HoverIndex = 941,
				PressedIndex = 942,
				Location = new Point(20, 403),
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport Home",
				Visible = true
			};
			TeleportHomeButton.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@Home" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			dungeonNameLabel = new MirLabel
			{
				Font = new Font(Settings.FontName, 11f, FontStyle.Bold | FontStyle.Italic),
				ForeColour = Color.Orange,
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Text = "",
				Size = new Size(300, 24),
				//Location = new Point(270, 42),
				Location = new Point(265, 232),
				Parent = this,
				NotControl = true
			};
			informationLabel = new MirLabel
			{
				Font = new Font(Settings.FontName, 8f, FontStyle.Bold),
				ForeColour = Color.NavajoWhite,
				DrawFormat = (TextFormatFlags.Left | TextFormatFlags.VerticalCenter),
				Text = "",
				Size = new Size(150, 23),
				Location = new Point(340, 260),
				Parent = this,
				NotControl = true,
				Visible = false
			};
			suggestedLevelLabel = new MirLabel
			{
				Font = new Font(Settings.FontName, 7f, FontStyle.Bold),
				ForeColour = Color.NavajoWhite,
				DrawFormat = (TextFormatFlags.Left | TextFormatFlags.VerticalCenter),
				Text = "",
				Size = new Size(150, 23),
				Location = new Point(340, 280),
				Parent = this,
				NotControl = true
			};
			suggestedLevel = new MirLabel
			{
				Font = new Font(Settings.FontName, 9f, FontStyle.Bold),
				ForeColour = Color.Red,
				DrawFormat = (TextFormatFlags.Left | TextFormatFlags.VerticalCenter),
				Text = "",
				Size = new Size(250, 23),
				Location = new Point(430, 280),
				Parent = this,
				NotControl = true
			};
			goldlabel = new MirLabel
			{
				Font = new Font(Settings.FontName, 9f, FontStyle.Bold),
				ForeColour = Color.NavajoWhite,
				DrawFormat = (TextFormatFlags.Left | TextFormatFlags.VerticalCenter),
				Text = "",
				Size = new Size(250, 23),
				Location = new Point(340, 300),
				Parent = this,
				NotControl = true
			};
			gold = new MirLabel
			{
				Font = new Font(Settings.FontName, 9f, FontStyle.Bold),
				ForeColour = Color.Gold,
				DrawFormat = (TextFormatFlags.Left | TextFormatFlags.VerticalCenter),
				Text = "",
				Size = new Size(250, 23),
				Location = new Point(380, 300),
				Parent = this,
				NotControl = true
			};
			dropLabel = new MirLabel
			{
				Font = new Font(Settings.FontName, 7f, FontStyle.Bold),
				ForeColour = Color.NavajoWhite,
				DrawFormat = (TextFormatFlags.Left | TextFormatFlags.VerticalCenter),
				Text = "",
				Size = new Size(190, 23),
				Location = new Point(340, 320),
				Parent = this,
				NotControl = true,
				Visible = false
			};
			drop01 = new MirLabel
			{
				Font = new Font(Settings.FontName, 7f),
				ForeColour = Color.Silver,
				DrawFormat = (TextFormatFlags.Left | TextFormatFlags.VerticalCenter),
				Text = "",
				Size = new Size(150, 16),
				Location = new Point(340, 340),
				Parent = this,
				NotControl = true
			};
			drop02 = new MirLabel
			{
				Font = new Font(Settings.FontName, 7f),
				ForeColour = Color.Silver,
				DrawFormat = (TextFormatFlags.Left | TextFormatFlags.VerticalCenter),
				Text = "",
				Size = new Size(150, 16),
				Location = new Point(340, 360),
				Parent = this,
				NotControl = true,
		};
			drop03 = new MirLabel
			{
				Font = new Font(Settings.FontName, 7f),
				ForeColour = Color.Silver,
				DrawFormat = (TextFormatFlags.Left | TextFormatFlags.VerticalCenter),
				Text = "",
				Size = new Size(150, 16),
				Location = new Point(340, 376),
				Parent = this,
				NotControl = true
			};
			drop04 = new MirLabel
			{
				Font = new Font(Settings.FontName, 7f),
				ForeColour = Color.Silver,
				DrawFormat = (TextFormatFlags.Left | TextFormatFlags.VerticalCenter),
				Text = "",
				Size = new Size(211, 16),
				Location = new Point(340, 376),
				Parent = this,
				NotControl = true
			};
			drop05 = new MirLabel
			{
				Font = new Font(Settings.FontName, 7f),
				ForeColour = Color.Silver,
				DrawFormat = (TextFormatFlags.Left | TextFormatFlags.VerticalCenter),
				Text = "",
				Size = new Size(150, 16),
				Location = new Point(340, 245),
				Parent = this,
				NotControl = true
			};
			informationArea = new MirLabel
			{
				Font = new Font(Settings.FontName, 7f, FontStyle.Bold),
				ForeColour = Color.Silver,
				DrawFormat = (TextFormatFlags.Left | TextFormatFlags.VerticalCenter),
				Text = "",
				Size = new Size(229, 100),
				Location = new Point(340, 410),
				Parent = this,
				NotControl = true
			};

			//HUNT MAPS
			#region GroupMapList 1 + MapList 1 2 3 4 5 6 7 8
			GroupMapList1 = new MirButton
			{
				Size = new Size(157, 15),
				Index = 26,
				HoverIndex = 25,
				//Location = new Point(462, 79),
				Location = new Point(13, 38),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA
			};
			GroupMapListLabel1 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Font = new Font(Settings.FontName, 8f, FontStyle.Bold),
				Size = new Size(157, 15),
				Location = new Point(0, 1),
				Parent = GroupMapList1,
				NotControl = true,
				ForeColour = Color.Silver,
				Text = ""
			};
			GroupMapList1.Click += delegate (object o, EventArgs e)
			{
				HideInformation();
				ResetTabs();
				GroupMapList1.Index = 26;
				MapList1.Visible = true;
				MapList2.Visible = true;
				MapList3.Visible = true;
				MapList4.Visible = true;
				MapList5.Visible = true;
				MapList6.Visible = true;
				MapList7.Visible = true;
				MapList8.Visible = true;
				SetLocations(1);
			};

			MapList1 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			MapListLabel1 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = MapList1,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			MapList1.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + MapListLabel1.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "20+";
				goldlabel.Text = "Gold:";
				gold.Text = "1.000";
				bool flag = User.Level > 20;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "";
				drop01.Text = "";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				MapList1.Index = 28;
				TeleportButtonsHide();
				OmaCaveTeleport.Visible = true;
			};
			OmaCaveTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			OmaCaveTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTOmaCave" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			MapList2 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			MapListLabel2 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = MapList2,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			MapList2.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + MapListLabel2.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "30+";
				goldlabel.Text = "Gold:";
				gold.Text = "2.000";
				bool flag = User.Level > 30;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "";
				drop01.Text = "";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				MapList2.Index = 28;
				TeleportButtonsHide();
				ZombieCaveTeleport.Visible = true;
			};
			ZombieCaveTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			ZombieCaveTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTZombieCave" });
				GameScene.Scene.WorldMapDialog.Hide();
			};


			MapList3 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			MapListLabel3 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = MapList3,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			MapList3.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + MapListLabel3.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "40+";
				goldlabel.Text = "Gold:";
				gold.Text = "5.000";
				bool flag = User.Level > 40;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "";
				drop01.Text = "";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				MapList3.Index = 28;
				TeleportButtonsHide();
				SerpentCaveTeleport.Visible = true;
			};
			SerpentCaveTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			SerpentCaveTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTSerpentCave" });
				GameScene.Scene.WorldMapDialog.Hide();
			};


			MapList4 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			MapListLabel4 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = MapList4,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			MapList4.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + MapListLabel4.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "50+";
				goldlabel.Text = "Gold:";
				gold.Text = "10.000";
				bool flag = User.Level > 50;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "";
				drop01.Text = "";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				MapList4.Index = 28;
				TeleportButtonsHide();
				InsectCaveTeleport.Visible = true;
			};
			InsectCaveTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			InsectCaveTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTInsectCave" });
				GameScene.Scene.WorldMapDialog.Hide();
			};


			MapList5 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			MapListLabel5 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = MapList5,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			MapList5.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + MapListLabel5.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "60+";
				goldlabel.Text = "Gold:";
				gold.Text = "15.000";
				bool flag = User.Level > 60;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "";
				drop01.Text = "";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				MapList5.Index = 28;
				TeleportButtonsHide();
				BugCaveTeleport.Visible = true;
			};
			BugCaveTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			BugCaveTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTBugCave" });
				GameScene.Scene.WorldMapDialog.Hide();
			};


			MapList6 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			MapListLabel6 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = MapList6,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			MapList6.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + MapListLabel6.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "70+";
				goldlabel.Text = "Gold:";
				gold.Text = "20.000";
				bool flag = User.Level > 70;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "";
				drop01.Text = "";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				MapList6.Index = 28;
				TeleportButtonsHide();
				StoneTempleTeleport.Visible = true;
			};
			StoneTempleTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			StoneTempleTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTStoneTemple" });
				GameScene.Scene.WorldMapDialog.Hide();
			};


			MapList7 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			MapListLabel7 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = MapList7,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			MapList7.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + MapListLabel7.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "80+";
				goldlabel.Text = "Gold:";
				gold.Text = "30.000";
				bool flag = User.Level > 80;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "";
				drop01.Text = "";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				MapList7.Index = 28;
				TeleportButtonsHide();
				ZumaTempleTeleport.Visible = true;
			};
			ZumaTempleTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			ZumaTempleTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTZumaTemple" });
				GameScene.Scene.WorldMapDialog.Hide();
			};


			MapList8 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			MapListLabel8 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = MapList8,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			MapList8.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + MapListLabel8.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "90+";
				goldlabel.Text = "Gold:";
				gold.Text = "40.000";
				bool flag = User.Level > 90;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "";
				drop01.Text = "";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				MapList8.Index = 28;
				TeleportButtonsHide();
				WoomaTempleTeleport.Visible = true;
			};
			WoomaTempleTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			WoomaTempleTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTWoomaTemple" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			#endregion

			#region GroupMapList 2 + MapList  9 10 11 12 13 14 15 16 17 18
			GroupMapList2 = new MirButton
			{
				Size = new Size(157, 15),
				Index = 26,
				HoverIndex = 25,
				Location = new Point(13, 58),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA
			};
			GroupMapListLabel2 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Font = new Font(Settings.FontName, 8f, FontStyle.Bold),
				Size = new Size(157, 15),
				Location = new Point(0, 1),
				Parent = GroupMapList2,
				NotControl = true,
				ForeColour = Color.Silver,
				Text = ""
			};
			GroupMapList2.Click += delegate (object o, EventArgs e)
			{
				HideInformation();
				ResetTabs();
				GroupMapList2.Index = 25;
				MapList9.Visible = true;
				MapList10.Visible = true;
				MapList11.Visible = true;
				MapList12.Visible = true;
				MapList13.Visible = true;
				MapList14.Visible = true;
				MapList15.Visible = true;
				MapList16.Visible = true;
				MapList17.Visible = true;
				MapList18.Visible = true;
				SetLocations(2);
			};

			MapList9 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			MapListLabel9 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = MapList9,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			MapList9.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + MapListLabel9.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "100+";
				goldlabel.Text = "Gold:";
				gold.Text = "60.000";
				bool flag = User.Level > 100;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "";
				drop01.Text = "";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				MapList9.Index = 28;
				TeleportButtonsHide();
				PrajnaCaveTeleport.Visible = true;
			};
			PrajnaCaveTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			PrajnaCaveTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTPrajnaCave" });
				GameScene.Scene.WorldMapDialog.Hide();
			};


			MapList10 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			MapListLabel10 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = MapList10,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			MapList10.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + MapListLabel10.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "110+";
				goldlabel.Text = "Gold:";
				gold.Text = "80.000";
				bool flag = User.Level > 110;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "";
				drop01.Text = "";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				MapList10.Index = 28;
				TeleportButtonsHide();
				PrajnaTempleTeleport.Visible = true;
			};
			PrajnaTempleTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			PrajnaTempleTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTPrajnaTemple" });
				GameScene.Scene.WorldMapDialog.Hide();
			};


			MapList11 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			MapListLabel11 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = MapList11,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			MapList11.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + MapListLabel11.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "120+";
				goldlabel.Text = "Gold:";
				gold.Text = "100.000";
				bool flag = User.Level > 120;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "";
				drop01.Text = "";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				MapList11.Index = 28;
				TeleportButtonsHide();
				SpiderCaveTeleport.Visible = true;
			};
			SpiderCaveTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			SpiderCaveTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTSpiderCave" });
				GameScene.Scene.WorldMapDialog.Hide();
			};


			MapList12 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			MapListLabel12 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = MapList12,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			MapList12.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + MapListLabel12.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "130+";
				goldlabel.Text = "Gold:";
				gold.Text = "120.000";
				bool flag = User.Level > 130;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "";
				drop01.Text = "";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				MapList12.Index = 28;
				TeleportButtonsHide();
				FrozenTempleTeleport.Visible = true;
			};
			FrozenTempleTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			FrozenTempleTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTFrozenTemple" });
				GameScene.Scene.WorldMapDialog.Hide();
			};


			MapList13 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			MapListLabel13 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = MapList13,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			MapList13.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + MapListLabel13.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "140+";
				goldlabel.Text = "Gold:";
				gold.Text = "140.000";
				bool flag = User.Level > 140;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "";
				drop01.Text = "";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				MapList13.Index = 28;
				TeleportButtonsHide();
				SwampCaveTeleport.Visible = true;
			};
			SwampCaveTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			SwampCaveTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTSwampCave" });
				GameScene.Scene.WorldMapDialog.Hide();
			};


			MapList14 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			MapListLabel14 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = MapList14,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			MapList14.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + MapListLabel14.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "150+";
				goldlabel.Text = "Gold:";
				gold.Text = "160.000";
				bool flag = User.Level > 160;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "";
				drop01.Text = "";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				MapList14.Index = 28;
				TeleportButtonsHide();
				NumaTempleTeleport.Visible = true;
			};
			NumaTempleTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			NumaTempleTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTNumaTemple" });
				GameScene.Scene.WorldMapDialog.Hide();
			};


			MapList15 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			MapListLabel15 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = MapList15,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			MapList15.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + MapListLabel15.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "160+";
				goldlabel.Text = "Gold:";
				gold.Text = "180.000";
				bool flag = User.Level > 160;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "";
				drop01.Text = "";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				MapList15.Index = 28;
				TeleportButtonsHide();
				TrollTempleTeleport.Visible = true;
			};
			TrollTempleTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			TrollTempleTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTTrollTemple" });
				GameScene.Scene.WorldMapDialog.Hide();
			};


			MapList16 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			MapListLabel16 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = MapList16,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			MapList16.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + MapListLabel16.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "170+";
				goldlabel.Text = "Gold:";
				gold.Text = "200.000";
				bool flag = User.Level > 170;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "";
				drop01.Text = "";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				MapList16.Index = 28;
				TeleportButtonsHide();
				DemonTempleTeleport.Visible = true;
			};
			DemonTempleTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			DemonTempleTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTDemonTemple" });
				GameScene.Scene.WorldMapDialog.Hide();
			};


			MapList17 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			MapListLabel17 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = MapList17,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			MapList17.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + MapListLabel17.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "180+";
				goldlabel.Text = "Gold:";
				gold.Text = "240.000";
				bool flag = User.Level > 180;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "";
				drop01.Text = "";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				MapList17.Index = 28;
				TeleportButtonsHide();
				AngelTempleTeleport.Visible = true;
			};
			AngelTempleTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			AngelTempleTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTAngelTemple" });
				GameScene.Scene.WorldMapDialog.Hide();
			};


			MapList18 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			MapListLabel18 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = MapList18,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			MapList18.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + MapListLabel18.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "190+";
				goldlabel.Text = "Gold:";
				gold.Text = "280.000";
				bool flag = User.Level > 190;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "";
				drop01.Text = "";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				MapList18.Index = 28;
				TeleportButtonsHide();
				HellCaveTeleport.Visible = true;
			};
			HellCaveTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			HellCaveTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTHellCave" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			#endregion

			#region GroupMapList 3 + MapList  19 20 21 22 23 24 25 26 27 28
			GroupMapList3 = new MirButton
			{
				Size = new Size(157, 15),
				Index = 26,
				HoverIndex = 25,
				Location = new Point(13, 78),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA
			};
			GroupMapListLabel3 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Font = new Font(Settings.FontName, 8f, FontStyle.Bold),
				Size = new Size(157, 15),
				Location = new Point(0, 1),
				Parent = GroupMapList3,
				NotControl = true,
				ForeColour = Color.Silver,
				Text = ""
			};
			GroupMapList3.Click += delegate (object o, EventArgs e)
			{
				HideInformation();
				ResetTabs();
				GroupMapList3.Index = 25;
				MapList19.Visible = true;
				MapList20.Visible = true;
				MapList21.Visible = true;
				MapList22.Visible = true;
				MapList23.Visible = true;
				MapList24.Visible = true;
				MapList25.Visible = true;
				MapList26.Visible = true;
				MapList27.Visible = true;
				MapList28.Visible = true;
				SetLocations(3);
			};

			MapList19 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			MapListLabel19 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = MapList19,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			MapList19.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + MapListLabel19.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "200+";
				goldlabel.Text = "Gold:";
				gold.Text = "320.000";
				bool flag = User.Level > 200;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "";
				drop01.Text = "";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				MapList19.Index = 28;
				TeleportButtonsHide();
				FoxCaveTeleport.Visible = true;
			};
			FoxCaveTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			FoxCaveTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTFoxCave" });
				GameScene.Scene.WorldMapDialog.Hide();
			};


			MapList20 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			MapListLabel20 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = MapList20,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			MapList20.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + MapListLabel20.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "210+";
				goldlabel.Text = "Gold:";
				gold.Text = "360.000";
				bool flag = User.Level > 210;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "";
				drop01.Text = "";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				MapList20.Index = 28;
				TeleportButtonsHide();
				OrcTempleTeleport.Visible = true;
			};
			OrcTempleTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			OrcTempleTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTOrcTemple" });
				GameScene.Scene.WorldMapDialog.Hide();
			};


			MapList21 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			MapListLabel21 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = MapList21,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			MapList21.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + MapListLabel21.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "220+";
				goldlabel.Text = "Gold:";
				gold.Text = "400.000";
				bool flag = User.Level > 220;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "";
				drop01.Text = "";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				MapList21.Index = 28;
				TeleportButtonsHide();
				EvilCaveTeleport.Visible = true;
			};
			EvilCaveTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			EvilCaveTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTEvilCave" });
				GameScene.Scene.WorldMapDialog.Hide();
			};


			MapList22 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			MapListLabel22 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = MapList22,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			MapList22.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + MapListLabel22.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "230+";
				goldlabel.Text = "Gold:";
				gold.Text = "480.000";
				bool flag = User.Level > 230;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "";
				drop01.Text = "";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				MapList22.Index = 28;
				TeleportButtonsHide();
				LizardCaveTeleport.Visible = true;
			};
			LizardCaveTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			LizardCaveTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTLizardCave" });
				GameScene.Scene.WorldMapDialog.Hide();
			};


			MapList23 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			MapListLabel23 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = MapList23,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			MapList23.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + MapListLabel23.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "240+";
				goldlabel.Text = "Gold:";
				gold.Text = "560.000";
				bool flag = User.Level > 240;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "";
				drop01.Text = "";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				MapList23.Index = 28;
				TeleportButtonsHide();
				SunkenCaveTeleport.Visible = true;
			};
			SunkenCaveTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			SunkenCaveTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTSunkenCave" });
				GameScene.Scene.WorldMapDialog.Hide();
			};


			MapList24 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			MapListLabel24 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = MapList24,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			MapList24.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + MapListLabel24.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "250+";
				goldlabel.Text = "Gold:";
				gold.Text = "640.000";
				bool flag = User.Level > 250;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "";
				drop01.Text = "";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				MapList24.Index = 28;
				TeleportButtonsHide();
				KnightTempleTeleport.Visible = true;
			};
			KnightTempleTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			KnightTempleTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTKnightTemple" });
				GameScene.Scene.WorldMapDialog.Hide();
			};


			MapList25 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			MapListLabel25 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = MapList25,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			MapList25.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + MapListLabel25.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "260+";
				goldlabel.Text = "Gold:";
				gold.Text = "720.000";
				bool flag = User.Level > 260;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "";
				drop01.Text = "";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				MapList25.Index = 28;
				TeleportButtonsHide();
				HavokTempleTeleport.Visible = true;
			};
			HavokTempleTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			HavokTempleTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTHavokTemple" });
				GameScene.Scene.WorldMapDialog.Hide();
			};


			MapList26 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			MapListLabel26 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = MapList26,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			MapList26.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + MapListLabel26.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "270+";
				goldlabel.Text = "Gold:";
				gold.Text = "800.000";
				bool flag = User.Level > 270;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "";
				drop01.Text = "";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				MapList26.Index = 28;
				TeleportButtonsHide();
				SkullCaveTeleport.Visible = true;
			};
			SkullCaveTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			SkullCaveTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTSkullCave" });
				GameScene.Scene.WorldMapDialog.Hide();
			};


			MapList27 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			MapListLabel27 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = MapList27,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			MapList27.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + MapListLabel27.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "280+";
				goldlabel.Text = "Gold:";
				gold.Text = "1.000.000";
				bool flag = User.Level > 280;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "";
				drop01.Text = "";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				MapList27.Index = 28;
				TeleportButtonsHide();
				LostTempleTeleport.Visible = true;
			};
			LostTempleTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			LostTempleTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTLostTemple" });
				GameScene.Scene.WorldMapDialog.Hide();
			};


			MapList28 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			MapListLabel28 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = MapList28,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			MapList28.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + MapListLabel28.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "290+";
				goldlabel.Text = "Gold:";
				gold.Text = "1.200.000";
				bool flag = User.Level > 290;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "";
				drop01.Text = "";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				MapList28.Index = 28;
				TeleportButtonsHide();
				IceTempleTeleport.Visible = true;
			};
			IceTempleTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			IceTempleTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTIceTemple" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			#endregion

			#region GroupMapList 4 + MapList  29 30 31 32 33 34 35 36 37 38
			GroupMapList4 = new MirButton
			{
				Size = new Size(157, 15),
				Index = 26,
				HoverIndex = 25,
				Location = new Point(13, 98),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA
			};
			GroupMapListLabel4 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Font = new Font(Settings.FontName, 8f, FontStyle.Bold),
				Size = new Size(157, 15),
				Location = new Point(0, 1),
				Parent = GroupMapList4,
				NotControl = true,
				ForeColour = Color.Silver,
				Text = ""
			};
			GroupMapList4.Click += delegate (object o, EventArgs e)
			{
				HideInformation();
				ResetTabs();
				GroupMapList4.Index = 25;
				MapList29.Visible = true;
				MapList30.Visible = true;
				MapList31.Visible = true;
				MapList32.Visible = true;
				MapList33.Visible = true;
				MapList34.Visible = true;
				MapList35.Visible = true;
				MapList36.Visible = true;
				MapList37.Visible = true;
				MapList38.Visible = true;
				SetLocations(4);
			};

			MapList29 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			MapListLabel29 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = MapList29,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			MapList29.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + MapListLabel29.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "300+";
				goldlabel.Text = "Gold:";
				gold.Text = "1.400.000";
				bool flag = User.Level > 300;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "";
				drop01.Text = "";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				MapList29.Index = 28;
				TeleportButtonsHide();
				ForgottenTempleTeleport.Visible = true;
			};
			ForgottenTempleTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			ForgottenTempleTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTForgottenTemple" });
				GameScene.Scene.WorldMapDialog.Hide();
			};


			MapList30 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			MapListLabel30 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = MapList30,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			MapList30.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + MapListLabel30.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "310+";
				goldlabel.Text = "Gold:";
				gold.Text = "1.600.000";
				bool flag = User.Level > 310;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "";
				drop01.Text = "";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				MapList30.Index = 28;
				TeleportButtonsHide();
				TurtleLairTeleport.Visible = true;
			};
			TurtleLairTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			TurtleLairTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTTurtleLair" });
				GameScene.Scene.WorldMapDialog.Hide();
			};


			MapList31 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			MapListLabel31 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = MapList31,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			MapList31.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + MapListLabel31.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "320+";
				goldlabel.Text = "Gold:";
				gold.Text = "1.800.000";
				bool flag = User.Level > 320;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "";
				drop01.Text = "";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				MapList31.Index = 28;
				TeleportButtonsHide();
				CaveOfNicanorTeleport.Visible = true;
			};
			CaveOfNicanorTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			CaveOfNicanorTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTCaveOfNicanor" });
				GameScene.Scene.WorldMapDialog.Hide();
			};


			MapList32 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			MapListLabel32 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = MapList32,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			MapList32.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + MapListLabel32.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "330+";
				goldlabel.Text = "Gold:";
				gold.Text = "2.000.000";
				bool flag = User.Level > 330;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "";
				drop01.Text = "";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				MapList32.Index = 28;
				TeleportButtonsHide();
				CaveOfTroubleTeleport.Visible = true;
			};
			CaveOfTroubleTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			CaveOfTroubleTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTCaveOfTrouble" });
				GameScene.Scene.WorldMapDialog.Hide();
			};


			MapList33 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			MapListLabel33 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = MapList33,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			MapList33.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + MapListLabel33.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "340+";
				goldlabel.Text = "Gold:";
				gold.Text = "2.500.000";
				bool flag = User.Level > 340;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "";
				drop01.Text = "";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				MapList33.Index = 28;
				TeleportButtonsHide();
				GardenOfDeathTeleport.Visible = true;
			};
			GardenOfDeathTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			GardenOfDeathTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTGardenOfDeath" });
				GameScene.Scene.WorldMapDialog.Hide();
			};


			MapList34 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			MapListLabel34 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = MapList34,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			MapList34.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + MapListLabel34.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "350+";
				goldlabel.Text = "Gold:";
				gold.Text = "3.000.000";
				bool flag = User.Level > 350;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "";
				drop01.Text = "";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				MapList34.Index = 28;
				TeleportButtonsHide();
				CaveOfHorrorTeleport.Visible = true;
			};
			CaveOfHorrorTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			CaveOfHorrorTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTCaveOfHorror" });
				GameScene.Scene.WorldMapDialog.Hide();
			};


			MapList35 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			MapListLabel35 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = MapList35,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			MapList35.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + MapListLabel35.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "360+";
				goldlabel.Text = "Gold:";
				gold.Text = "3.500.000";
				bool flag = User.Level > 360;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "";
				drop01.Text = "";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				MapList35.Index = 28;
				TeleportButtonsHide();
				CaveOfDespairTeleport.Visible = true;
			};
			CaveOfDespairTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			CaveOfDespairTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTCaveOfDespair" });
				GameScene.Scene.WorldMapDialog.Hide();
			};


			MapList36 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			MapListLabel36 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = MapList36,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			MapList36.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + MapListLabel36.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "370+";
				goldlabel.Text = "Gold:";
				gold.Text = "4.000.000";
				bool flag = User.Level > 370;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "";
				drop01.Text = "";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				MapList36.Index = 28;
				TeleportButtonsHide();
				TempleOfHeroesTeleport.Visible = true;
			};
			TempleOfHeroesTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			TempleOfHeroesTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTTempleOfHeroes" });
				GameScene.Scene.WorldMapDialog.Hide();
			};


			MapList37 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			MapListLabel37 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = MapList37,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			MapList37.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + MapListLabel37.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "380+";
				goldlabel.Text = "Gold:";
				gold.Text = "5.000.000";
				bool flag = User.Level > 380;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "";
				drop01.Text = "";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				MapList37.Index = 28;
				TeleportButtonsHide();
				SacredTempleTeleport.Visible = true;
			};
			SacredTempleTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			SacredTempleTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTSacredTemple" });
				GameScene.Scene.WorldMapDialog.Hide();
			};


			MapList38 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			MapListLabel38 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = MapList38,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			MapList38.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + MapListLabel38.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "390+";
				goldlabel.Text = "Gold:";
				gold.Text = "6.000.000";
				bool flag = User.Level > 390;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "";
				drop01.Text = "";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				MapList38.Index = 28;
				TeleportButtonsHide();
				DarkTempleTeleport.Visible = true;
			};
			DarkTempleTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			DarkTempleTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTDarkTemple" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			#endregion

			#region GroupMapList 5 + MapList  39 40 41 42 43 44 45 46 47 48
			GroupMapList5 = new MirButton
			{
				Size = new Size(157, 15),
				Index = 26,
				HoverIndex = 25,
				Location = new Point(13, 118),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA
			};
			GroupMapListLabel5 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Font = new Font(Settings.FontName, 8f, FontStyle.Bold),
				Size = new Size(157, 15),
				Location = new Point(0, 1),
				Parent = GroupMapList5,
				NotControl = true,
				ForeColour = Color.Silver,
				Text = ""
			};
			GroupMapList5.Click += delegate (object o, EventArgs e)
			{
				HideInformation();
				ResetTabs();
				GroupMapList5.Index = 25;
				MapList39.Visible = true;
				MapList40.Visible = true;
				MapList41.Visible = true;
				MapList42.Visible = true;
				MapList43.Visible = true;
				MapList44.Visible = true;
				MapList45.Visible = true;
				MapList46.Visible = true;
				MapList47.Visible = true;
				MapList48.Visible = true;
				SetLocations(5);
			};

			MapList39 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			MapListLabel39 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = MapList39,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			MapList39.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + MapListLabel39.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "400+";
				goldlabel.Text = "Gold:";
				gold.Text = "7.000.000";
				bool flag = User.Level > 400;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "";
				drop01.Text = "";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				MapList39.Index = 28;
				TeleportButtonsHide();
				SealedCaveTeleport.Visible = true;
			};
			SealedCaveTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			SealedCaveTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTSealedCave" });
				GameScene.Scene.WorldMapDialog.Hide();
			};


			MapList40 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			MapListLabel40 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = MapList40,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			MapList40.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + MapListLabel40.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "410+";
				goldlabel.Text = "Gold:";
				gold.Text = "8.000.000";
				bool flag = User.Level > 410;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "";
				drop01.Text = "";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				MapList40.Index = 28;
				TeleportButtonsHide();
				MysticTempleTeleport.Visible = true;
			};
			MysticTempleTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			MysticTempleTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTMysticTemple" });
				GameScene.Scene.WorldMapDialog.Hide();
			};


			MapList41 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			MapListLabel41 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = MapList41,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			MapList41.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + MapListLabel41.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "420+";
				goldlabel.Text = "Gold:";
				gold.Text = "10.000.000";
				bool flag = User.Level > 420;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "";
				drop01.Text = "";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				MapList41.Index = 28;
				TeleportButtonsHide();
				ShadowCaveTeleport.Visible = true;
			};
			ShadowCaveTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			ShadowCaveTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTShadowCave" });
				GameScene.Scene.WorldMapDialog.Hide();
			};


			MapList42 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			MapListLabel42 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = MapList42,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			MapList42.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + MapListLabel42.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "430+";
				goldlabel.Text = "Gold:";
				gold.Text = "12.000.000";
				bool flag = User.Level > 430;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "";
				drop01.Text = "";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				MapList42.Index = 28;
				TeleportButtonsHide();
				AncientTempleTeleport.Visible = true;
			};
			AncientTempleTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			AncientTempleTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTAncientTemple" });
				GameScene.Scene.WorldMapDialog.Hide();
			};


			MapList43 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			MapListLabel43 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = MapList43,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			MapList43.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + MapListLabel43.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "440+";
				goldlabel.Text = "Gold:";
				gold.Text = "14.000.000";
				bool flag = User.Level > 440;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "";
				drop01.Text = "";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				MapList43.Index = 28;
				TeleportButtonsHide();
				CursedCaveTeleport.Visible = true;
			};
			CursedCaveTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			CursedCaveTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTCursedCave" });
				GameScene.Scene.WorldMapDialog.Hide();
			};


			MapList44 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			MapListLabel44 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = MapList44,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			MapList44.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + MapListLabel44.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "450+";
				goldlabel.Text = "Gold:";
				gold.Text = "16.000.000";
				bool flag = User.Level > 450;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "";
				drop01.Text = "";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				MapList44.Index = 28;
				TeleportButtonsHide();
				ChaosTempleTeleport.Visible = true;
			};
			ChaosTempleTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			ChaosTempleTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTChaosTemple" });
				GameScene.Scene.WorldMapDialog.Hide();
			};


			MapList45 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			MapListLabel45 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = MapList45,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			MapList45.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + MapListLabel45.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "460+";
				goldlabel.Text = "Gold:";
				gold.Text = "18.000.000";
				bool flag = User.Level > 460;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "";
				drop01.Text = "";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				MapList45.Index = 28;
				TeleportButtonsHide();
				RockTempleTeleport.Visible = true;
			};
			RockTempleTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			RockTempleTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTRockTemple" });
				GameScene.Scene.WorldMapDialog.Hide();
			};


			MapList46 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			MapListLabel46 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = MapList46,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			MapList46.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + MapListLabel46.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "470+";
				goldlabel.Text = "Gold:";
				gold.Text = "20.000.000";
				bool flag = User.Level > 470;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "";
				drop01.Text = "";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				MapList46.Index = 28;
				TeleportButtonsHide();
				RampantTempleTeleport.Visible = true;
			};
			RampantTempleTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			RampantTempleTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTRampantTemple" });
				GameScene.Scene.WorldMapDialog.Hide();
			};


			MapList47 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			MapListLabel47 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = MapList47,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			MapList47.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + MapListLabel47.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "480+";
				goldlabel.Text = "Gold:";
				gold.Text = "25.000.000";
				bool flag = User.Level > 480;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "";
				drop01.Text = "";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				MapList47.Index = 28;
				TeleportButtonsHide();
				PhantomTempleTeleport.Visible = true;
			};
			PhantomTempleTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			PhantomTempleTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTPhantomTemple" });
				GameScene.Scene.WorldMapDialog.Hide();
			};


			MapList48 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			MapListLabel48 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = MapList48,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			MapList48.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + MapListLabel48.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "490+";
				goldlabel.Text = "Gold:";
				gold.Text = "30.000.000";
				bool flag = User.Level > 490;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "";
				drop01.Text = "";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				MapList48.Index = 28;
				TeleportButtonsHide();
				HellishCaveTeleport.Visible = true;
			};
			HellishCaveTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			HellishCaveTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTHellishCave" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			#endregion

			//LEVELING MAPS
			#region Leveling Maps
			LevelingButton1 = new MirButton
			{
				Size = new Size(157, 15),
				Index = 26,
				HoverIndex = 25,
				Location = new Point(13, 138),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA
			};
			LevelingLabel1 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Font = new Font(Settings.FontName, 8f, FontStyle.Bold),
				Size = new Size(157, 15),
				Location = new Point(0, 1),
				Parent = LevelingButton1,
				NotControl = true,
				ForeColour = Color.Silver,
				Text = ""
			};
			LevelingButton1.Click += delegate (object o, EventArgs e)
			{
				HideInformation();
				ResetTabs();
				LevelingButton1.Index = 25;
				OmaCaveLvLButton.Visible = true;
				PastBichonButton.Visible = true;
				ChaosTempleLvLButton.Visible = true;
				PainCavernButton.Visible = true;
				TriTempleButton.Visible = true;
				LostCaveButton.Visible = true;
				LittleIslandButton.Visible = true;
				StoneTempleLvLButton.Visible = true;
				CursedLandButton.Visible = true;
				SetLocations(11);
			};

			OmaCaveLvLButton = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			OmaCaveLvLLabel = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = OmaCaveLvLButton,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			OmaCaveLvLButton.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + OmaCaveLvLLabel.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "50+";
				goldlabel.Text = "Gold:";
				gold.Text = "5.000.000";
				bool flag = User.Level > 50;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				
				dropLabel.Text = "Cave Detail`s";
				drop01.Text = "Exp Normal";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "Time 30 Min";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				OmaCaveLvLButton.Index = 28;
				SubHideInformation();
				TeleportButtonsHide();
				OmaCaveLvLButton1.Visible = true;
				OmaCaveLvLButton2.Visible = true;
				OmaCaveLvLButton3.Visible = true;
				SubSetLocations(1);
				OmaCaveLvLTeleport.Visible = true;
			};
			OmaCaveLvLTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			OmaCaveLvLTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTOmaCaveS" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			OmaCaveLvLButton1 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			OmaCaveLvLLabel1 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = OmaCaveLvLButton1,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			OmaCaveLvLButton1.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + OmaCaveLvLLabel1.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "";
				suggestedLevel.Text = "";
				goldlabel.Text = "";
				gold.Text = "";
				
				dropLabel.Text = "Cave Detail`s";
				drop01.Text = "Exp 100%";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "Time 20 Min";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "OmaCaveToken(M)";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				OmaCaveLvLButton1.Index = 28;
				TeleportButtonsHide();
				OmaCaveLvLTeleport1.Visible = true;
			};
			OmaCaveLvLTeleport1 = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			OmaCaveLvLTeleport1.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTOmaCaveM" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			OmaCaveLvLButton2 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			OmaCaveLvLLabel2 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = OmaCaveLvLButton2,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			OmaCaveLvLButton2.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + OmaCaveLvLLabel2.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "";
				suggestedLevel.Text = "";
				goldlabel.Text = "";
				gold.Text = "";
				
				dropLabel.Text = "Cave Detail`s";
				drop01.Text = "Exp 150%";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "Time 15 Min";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "OmaCaveToken(L)";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				OmaCaveLvLButton2.Index = 28;
				TeleportButtonsHide();
				OmaCaveLvLTeleport2.Visible = true;
			};
			OmaCaveLvLTeleport2 = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			OmaCaveLvLTeleport2.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTOmaCaveL" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			OmaCaveLvLButton3 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			OmaCaveLvLLabel3 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = OmaCaveLvLButton3,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			OmaCaveLvLButton3.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + OmaCaveLvLLabel3.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "";
				suggestedLevel.Text = "";
				goldlabel.Text = "";
				gold.Text = "";
				
				dropLabel.Text = "Cave Detail`s";
				drop01.Text = "Exp 200%";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "Time 10 Min";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "OmaCaveToken(XL)";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				OmaCaveLvLButton3.Index = 28;
				TeleportButtonsHide();
				OmaCaveLvLTeleport3.Visible = true;
			};
			OmaCaveLvLTeleport3 = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			OmaCaveLvLTeleport3.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTOmaCaveXL" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			PastBichonButton = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			PastBichonLabel = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = PastBichonButton,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			PastBichonButton.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + PastBichonLabel.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "100+";
				goldlabel.Text = "Gold:";
				gold.Text = "10.000.000";
				bool flag = User.Level > 100;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				
				dropLabel.Text = "Cave Detail`s";
				drop01.Text = "Exp Normal";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "Time 30 Min";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				PastBichonButton.Index = 28;
				SubHideInformation();
				TeleportButtonsHide();
				PastBichonButton1.Visible = true;
				PastBichonButton2.Visible = true;
				PastBichonButton3.Visible = true;
				SubSetLocations(2);
				PastBichonLvLTeleport.Visible = true;
			};
			PastBichonLvLTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			PastBichonLvLTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTPastBichonS" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			PastBichonButton1 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			PastBichonLabel1 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = PastBichonButton1,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			PastBichonButton1.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + PastBichonLabel1.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "";
				suggestedLevel.Text = "";
				goldlabel.Text = "";
				gold.Text = "";
				
				dropLabel.Text = "Cave Detail`s";
				drop01.Text = "Exp 100%";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "Time 20 Min";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "PastBichonToken(M)";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				PastBichonButton1.Index = 28;
				TeleportButtonsHide();
				PastBichonLvLTeleport1.Visible = true;
			};
			PastBichonLvLTeleport1 = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			PastBichonLvLTeleport1.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTPastBichonM" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			PastBichonButton2 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			PastBichonLabel2 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = PastBichonButton2,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			PastBichonButton2.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + PastBichonLabel2.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "";
				suggestedLevel.Text = "";
				goldlabel.Text = "";
				gold.Text = "";
				
				dropLabel.Text = "Cave Detail`s";
				drop01.Text = "Exp 150%";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "Time 15 Min";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "PastBichonToken(L)";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				PastBichonButton2.Index = 28;
				TeleportButtonsHide();
				PastBichonLvLTeleport2.Visible = true;
			};
			PastBichonLvLTeleport2 = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			PastBichonLvLTeleport2.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTPastBichonL" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			PastBichonButton3 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			PastBichonLabel3 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = PastBichonButton3,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			PastBichonButton3.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + PastBichonLabel3.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "";
				suggestedLevel.Text = "";
				goldlabel.Text = "";
				gold.Text = "";

				dropLabel.Text = "Cave Detail`s";
				drop01.Text = "Exp 200%";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "Time 10 Min";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "PastBichonToken(XL)";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				PastBichonButton3.Index = 28;
				TeleportButtonsHide();
				PastBichonLvLTeleport3.Visible = true;
			};
			PastBichonLvLTeleport3 = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			PastBichonLvLTeleport3.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTPastBichonXL" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			ChaosTempleLvLButton = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			ChaosTempleLvLLabel = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = ChaosTempleLvLButton,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			ChaosTempleLvLButton.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + ChaosTempleLvLLabel.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "150+";
				goldlabel.Text = "Gold:";
				gold.Text = "15.000.000";
				bool flag = User.Level > 150;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				
				dropLabel.Text = "Cave Detail`s";
				drop01.Text = "Exp Normal";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "Time 30 Min";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				ChaosTempleLvLButton.Index = 28;
				SubHideInformation();
				TeleportButtonsHide();
				ChaosTempleLvLButton1.Visible = true;
				ChaosTempleLvLButton2.Visible = true;
				ChaosTempleLvLButton3.Visible = true;
				SubSetLocations(3);
				ChaosTempleLvLTeleport.Visible = true;
			};
			ChaosTempleLvLTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			ChaosTempleLvLTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTChaosTempleS" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			ChaosTempleLvLButton1 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			ChaosTempleLvLLabel1 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = ChaosTempleLvLButton1,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			ChaosTempleLvLButton1.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + ChaosTempleLvLLabel1.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "";
				suggestedLevel.Text = "";
				goldlabel.Text = "";
				gold.Text = "";

				dropLabel.Text = "Cave Detail`s";
				drop01.Text = "Exp 100%";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "Time 20 Min";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "ChaosTempleToken(M)";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				ChaosTempleLvLButton1.Index = 28;
				TeleportButtonsHide();
				ChaosTempleLvLTeleport1.Visible = true;
			};
			ChaosTempleLvLTeleport1 = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			ChaosTempleLvLTeleport1.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTChaosTempleM" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			ChaosTempleLvLButton2 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			ChaosTempleLvLLabel2 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = ChaosTempleLvLButton2,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			ChaosTempleLvLButton2.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + ChaosTempleLvLLabel2.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "";
				suggestedLevel.Text = "";
				goldlabel.Text = "";
				gold.Text = "";

				dropLabel.Text = "Cave Detail`s";
				drop01.Text = "Exp 150%";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "Time 15 Min";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "ChaosTempleToken(L)";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				ChaosTempleLvLButton2.Index = 28;
				TeleportButtonsHide();
				ChaosTempleLvLTeleport2.Visible = true;
			};
			ChaosTempleLvLTeleport2 = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			ChaosTempleLvLTeleport2.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTChaosTempleL" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			ChaosTempleLvLButton3 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			ChaosTempleLvLLabel3 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = ChaosTempleLvLButton3,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			ChaosTempleLvLButton3.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + ChaosTempleLvLLabel3.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevelLabel.Text = "";
				suggestedLevel.Text = "";
				goldlabel.Text = "";
				gold.Text = "";

				dropLabel.Text = "Cave Detail`s";
				drop01.Text = "Exp 200%";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "Time 10 Min";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "ChaosTempleToken(XL)";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				ChaosTempleLvLButton3.Index = 28;
				TeleportButtonsHide();
				ChaosTempleLvLTeleport3.Visible = true;
			};
			ChaosTempleLvLTeleport3 = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			ChaosTempleLvLTeleport3.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTChaosTempleXL" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			PainCavernButton = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			PainCavernLabel = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = PainCavernButton,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			PainCavernButton.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + PainCavernLabel.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "200+";
				goldlabel.Text = "Gold:";
				gold.Text = "20.000.000";
				bool flag = User.Level > 200;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				
				dropLabel.Text = "Cave Detail`s";
				drop01.Text = "Exp Normal";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "Time 30 Min";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				PainCavernButton.Index = 28;
				SubHideInformation();
				TeleportButtonsHide();
				PainCavernButton1.Visible = true;
				PainCavernButton2.Visible = true;
				PainCavernButton3.Visible = true;
				SubSetLocations(4);
				PainCavernLvLTeleport.Visible = true;
			};
			PainCavernLvLTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			PainCavernLvLTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTPainCavernS" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			PainCavernButton1 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			PainCavernLabel1 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = PainCavernButton1,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			PainCavernButton1.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + PainCavernLabel1.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "";
				suggestedLevel.Text = "";
				goldlabel.Text = "";
				gold.Text = "";

				dropLabel.Text = "Cave Detail`s";
				drop01.Text = "Exp 100%";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "Time 20 Min";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "PainCavernToken(M)";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				PainCavernButton1.Index = 28;
				TeleportButtonsHide();
				PainCavernLvLTeleport1.Visible = true;
			};
			PainCavernLvLTeleport1 = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			PainCavernLvLTeleport1.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTPainCavernL" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			PainCavernButton2 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			PainCavernLabel2 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = PainCavernButton2,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			PainCavernButton2.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + PainCavernLabel2.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "";
				suggestedLevel.Text = "";
				goldlabel.Text = "";
				gold.Text = "";

				dropLabel.Text = "Cave Detail`s";
				drop01.Text = "Exp 150%";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "Time 15 Min";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "PainCavernToken(L)";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				PainCavernButton2.Index = 28;
				TeleportButtonsHide();
				PainCavernLvLTeleport2.Visible = true;
			};
			PainCavernLvLTeleport2 = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			PainCavernLvLTeleport2.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTPainCavernL" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			PainCavernButton3 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			PainCavernLabel3 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = PainCavernButton3,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			PainCavernButton3.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + PainCavernLabel3.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "";
				suggestedLevel.Text = "";
				goldlabel.Text = "";
				gold.Text = "";

				dropLabel.Text = "Cave Detail`s";
				drop01.Text = "Exp 200%";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "Time 10 Min";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "PainCavernToken(XL)";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				PainCavernButton3.Index = 28;
				TeleportButtonsHide();
				PainCavernLvLTeleport3.Visible = true;
			};
			PainCavernLvLTeleport3 = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			PainCavernLvLTeleport3.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTPainCavernXL" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			TriTempleButton = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			TriTempleLabel = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = TriTempleButton,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			TriTempleButton.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + TriTempleLabel.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "250+";
				goldlabel.Text = "Gold:";
				gold.Text = "30.000.000";
				bool flag = User.Level > 250;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				
				dropLabel.Text = "Cave Detail`s";
				drop01.Text = "Exp Normal";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "Time 30 Min";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				TriTempleButton.Index = 28;
				SubHideInformation();
				TeleportButtonsHide();
				TriTempleButton1.Visible = true;
				TriTempleButton2.Visible = true;
				TriTempleButton3.Visible = true;
				SubSetLocations(5);
				TriTempleLvLTeleport.Visible = true;
			};
			TriTempleLvLTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			TriTempleLvLTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTTriTempleS" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			TriTempleButton1 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			TriTempleLabel1 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = TriTempleButton1,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			TriTempleButton1.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + TriTempleLabel1.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "";
				suggestedLevel.Text = "";
				goldlabel.Text = "";
				gold.Text = "";

				dropLabel.Text = "Cave Detail`s";
				drop01.Text = "Exp 100%";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "Time 20 Min";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "TriTempleToken(M)";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				TriTempleButton1.Index = 28;
				TeleportButtonsHide();
				TriTempleLvLTeleport1.Visible = true;
			};
			TriTempleLvLTeleport1 = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			TriTempleLvLTeleport1.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTTriTempleM" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			TriTempleButton2 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			TriTempleLabel2 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = TriTempleButton2,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			TriTempleButton2.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + TriTempleLabel2.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "";
				suggestedLevel.Text = "";
				goldlabel.Text = "";
				gold.Text = "";

				dropLabel.Text = "Cave Detail`s";
				drop01.Text = "Exp 150%";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "Time 15 Min";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "TriTempleToken(L)";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				TriTempleButton2.Index = 28;
				TeleportButtonsHide();
				TriTempleLvLTeleport2.Visible = true;
			};
			TriTempleLvLTeleport2 = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			TriTempleLvLTeleport2.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTTriTempleL" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			TriTempleButton3 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			TriTempleLabel3 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = TriTempleButton3,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			TriTempleButton3.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + TriTempleLabel3.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "";
				suggestedLevel.Text = "";
				goldlabel.Text = "";
				gold.Text = "";

				dropLabel.Text = "Cave Detail`s";
				drop01.Text = "Exp 200%";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "Time 10 Min";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "TriTempleToken(XL)";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				TriTempleButton3.Index = 28;
				TeleportButtonsHide();
				TriTempleLvLTeleport3.Visible = true;
			};
			TriTempleLvLTeleport3 = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			TriTempleLvLTeleport3.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTTriTempleXL" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			LostCaveButton = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			LostCaveLabel = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = LostCaveButton,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			LostCaveButton.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + LostCaveLabel.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "300+";
				goldlabel.Text = "Gold:";
				gold.Text = "40.000.000";
				bool flag = User.Level > 300;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}

				dropLabel.Text = "Cave Detail`s";
				drop01.Text = "Exp Normal";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "Time 30 Min";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				LostCaveButton.Index = 28;
				SubHideInformation();
				TeleportButtonsHide();
				LostCaveButton1.Visible = true;
				LostCaveButton2.Visible = true;
				LostCaveButton3.Visible = true;
				SubSetLocations(6);
				LostCaveLvLTeleport.Visible = true;
			};
			LostCaveLvLTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			LostCaveLvLTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTLostCaveS" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			LostCaveButton1 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			LostCaveLabel1 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = LostCaveButton1,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			LostCaveButton1.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + LostCaveLabel1.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "";
				suggestedLevel.Text = "";
				goldlabel.Text = "";
				gold.Text = "";

				dropLabel.Text = "Cave Detail`s";
				drop01.Text = "Exp 100%";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "Time 20 Min";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "LostCaveToken(M)";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				LostCaveButton1.Index = 28;
				TeleportButtonsHide();
				LostCaveLvLTeleport1.Visible = true;
			};
			LostCaveLvLTeleport1 = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			LostCaveLvLTeleport1.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTLostCaveM" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			LostCaveButton2 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			LostCaveLabel2 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = LostCaveButton2,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			LostCaveButton2.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + LostCaveLabel2.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "";
				suggestedLevel.Text = "";
				goldlabel.Text = "";
				gold.Text = "";

				dropLabel.Text = "Cave Detail`s";
				drop01.Text = "Exp 150%";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "Time 15 Min";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "LostCaveToken(L)";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				LostCaveButton2.Index = 28;
				TeleportButtonsHide();
				LostCaveLvLTeleport2.Visible = true;
			};
			LostCaveLvLTeleport2 = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			LostCaveLvLTeleport2.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTLostCaveL" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			LostCaveButton3 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			LostCaveLabel3 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = LostCaveButton3,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			LostCaveButton3.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + LostCaveLabel3.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "";
				suggestedLevel.Text = "";
				goldlabel.Text = "";
				gold.Text = "";

				dropLabel.Text = "Cave Detail`s";
				drop01.Text = "Exp 200%";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "Time 10 Min";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "LostCaveToken(XL)";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				LostCaveButton3.Index = 28;
				TeleportButtonsHide();
				LostCaveLvLTeleport3.Visible = true;
			};
			LostCaveLvLTeleport3 = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			LostCaveLvLTeleport3.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTLostCaveXL" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			LittleIslandButton = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			LittleIslandLabel = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = LittleIslandButton,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			LittleIslandButton.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + LittleIslandLabel.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "305+";
				goldlabel.Text = "Gold:";
				gold.Text = "50.000.000";
				bool flag = User.Level > 350;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}

				dropLabel.Text = "Cave Detail`s";
				drop01.Text = "Exp Normal";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "Time 30 Min";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				LittleIslandButton.Index = 28;
				SubHideInformation();
				TeleportButtonsHide();
				LittleIslandButton1.Visible = true;
				LittleIslandButton2.Visible = true;
				LittleIslandButton3.Visible = true;
				SubSetLocations(7);
				LittleIslandLvLTeleport.Visible = true;
			};
			LittleIslandLvLTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			LittleIslandLvLTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTLittleIslandS" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			LittleIslandButton1 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			LittleIslandLabel1 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = LittleIslandButton1,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			LittleIslandButton1.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + LittleIslandLabel1.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "";
				suggestedLevel.Text = "";
				goldlabel.Text = "";
				gold.Text = "";

				dropLabel.Text = "Cave Detail`s";
				drop01.Text = "Exp 100%";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "Time 20 Min";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "LittleIslandToken(M)";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				LittleIslandButton1.Index = 28;
				TeleportButtonsHide();
				LittleIslandLvLTeleport1.Visible = true;
			};
			LittleIslandLvLTeleport1 = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			LittleIslandLvLTeleport1.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTLittleIslandM" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			LittleIslandButton2 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			LittleIslandLabel2 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = LittleIslandButton2,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			LittleIslandButton2.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + LittleIslandLabel2.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "";
				suggestedLevel.Text = "";
				goldlabel.Text = "";
				gold.Text = "";

				dropLabel.Text = "Cave Detail`s";
				drop01.Text = "Exp 150%";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "Time 15 Min";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "LittleIslandToken(L)";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				LittleIslandButton2.Index = 28;
				TeleportButtonsHide();
				LittleIslandLvLTeleport2.Visible = true;
			};
			LittleIslandLvLTeleport2 = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			LittleIslandLvLTeleport2.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTLittleIslandL" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			LittleIslandButton3 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			LittleIslandLabel3 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = LittleIslandButton3,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			LittleIslandButton3.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + LittleIslandLabel3.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "";
				suggestedLevel.Text = "";
				goldlabel.Text = "";
				gold.Text = "";

				dropLabel.Text = "Cave Detail`s";
				drop01.Text = "Exp 200%";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "Time 10 Min";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "LittleIslandToken(XL)";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				LittleIslandButton3.Index = 28;
				TeleportButtonsHide();
				LittleIslandLvLTeleport3.Visible = true;
			};
			LittleIslandLvLTeleport3 = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			LittleIslandLvLTeleport3.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTLittleIslandXL" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			StoneTempleLvLButton = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			StoneTempleLvLLabel = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = StoneTempleLvLButton,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			StoneTempleLvLButton.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + StoneTempleLvLLabel.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "400+";
				goldlabel.Text = "Gold:";
				gold.Text = "60.000.000";
				bool flag = User.Level > 400;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}

				dropLabel.Text = "Cave Detail`s";
				drop01.Text = "Exp Normal";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "Time 30 Min";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				StoneTempleLvLButton.Index = 28;
				SubHideInformation();
				TeleportButtonsHide();
				StoneTempleLvLButton1.Visible = true;
				StoneTempleLvLButton2.Visible = true;
				StoneTempleLvLButton3.Visible = true;
				SubSetLocations(8);
				StoneTempleLvLTeleport.Visible = true;
			};
			StoneTempleLvLTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			StoneTempleLvLTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTStoneTempleS" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			StoneTempleLvLButton1 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			StoneTempleLvLLabel1 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = StoneTempleLvLButton1,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			StoneTempleLvLButton1.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + StoneTempleLvLLabel1.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "";
				suggestedLevel.Text = "";
				goldlabel.Text = "";
				gold.Text = "";

				dropLabel.Text = "Cave Detail`s";
				drop01.Text = "Exp 100%";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "Time 20 Min";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "StoneTempleLvLToken(M)";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				StoneTempleLvLButton1.Index = 28;
				TeleportButtonsHide();
				StoneTempleLvLTeleport1.Visible = true;
			};
			StoneTempleLvLTeleport1 = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			StoneTempleLvLTeleport1.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTStoneTempleM" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			StoneTempleLvLButton2 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			StoneTempleLvLLabel2 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = StoneTempleLvLButton2,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			StoneTempleLvLButton2.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + StoneTempleLvLLabel2.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "";
				suggestedLevel.Text = "";
				goldlabel.Text = "";
				gold.Text = "";

				dropLabel.Text = "Cave Detail`s";
				drop01.Text = "Exp 150%";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "Time 15 Min";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "StoneTempleLvLToken(L)";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				StoneTempleLvLButton2.Index = 28;
				TeleportButtonsHide();
				StoneTempleLvLTeleport2.Visible = true;
			};
			StoneTempleLvLTeleport2 = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			StoneTempleLvLTeleport2.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTStoneTempleL" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			StoneTempleLvLButton3 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			StoneTempleLvLLabel3 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = StoneTempleLvLButton3,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			StoneTempleLvLButton3.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + StoneTempleLvLLabel3.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "";
				suggestedLevel.Text = "";
				goldlabel.Text = "";
				gold.Text = "";

				dropLabel.Text = "Cave Detail`s";
				drop01.Text = "Exp 200%";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "Time 10 Min";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "StoneTempleLvLToken(XL)";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				StoneTempleLvLButton3.Index = 28;
				TeleportButtonsHide();
				StoneTempleLvLTeleport3.Visible = true;
			};
			StoneTempleLvLTeleport3 = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			StoneTempleLvLTeleport3.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTStoneTempleXL" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			CursedLandButton = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			CursedLandLabel = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = CursedLandButton,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			CursedLandButton.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + CursedLandLabel.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "450+";
				goldlabel.Text = "Gold:";
				gold.Text = "70.000.000";
				bool flag = User.Level > 450;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}

				dropLabel.Text = "Cave Detail`s";
				drop01.Text = "Exp Normal";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "Time 30 Min";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				CursedLandButton.Index = 28;
				SubHideInformation();
				TeleportButtonsHide();
				CursedLandButton1.Visible = true;
				CursedLandButton2.Visible = true;
				CursedLandButton3.Visible = true;
				SubSetLocations(9);
				CursedLandLvLTeleport.Visible = true;
			};
			CursedLandLvLTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			CursedLandLvLTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTCursedLandS" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			CursedLandButton1 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			CursedLandLabel1 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = CursedLandButton1,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			CursedLandButton1.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + CursedLandLabel1.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "";
				suggestedLevel.Text = "";
				goldlabel.Text = "";
				gold.Text = "";

				dropLabel.Text = "Cave Detail`s";
				drop01.Text = "Exp 100%";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "Time 20 Min";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "CursedLandToken(M)";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				CursedLandButton1.Index = 28;
				TeleportButtonsHide();
				CursedLandLvLTeleport1.Visible = true;
			};
			CursedLandLvLTeleport1 = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			CursedLandLvLTeleport1.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTCursedLandM" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			CursedLandButton2 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			CursedLandLabel2 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = CursedLandButton2,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			CursedLandButton2.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + CursedLandLabel2.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "";
				suggestedLevel.Text = "";
				goldlabel.Text = "";
				gold.Text = "";

				dropLabel.Text = "Cave Detail`s";
				drop01.Text = "Exp 150%";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "Time 15 Min";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "CursedLandToken(L)";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				CursedLandButton2.Index = 28;
				TeleportButtonsHide();
				CursedLandLvLTeleport2.Visible = true;
			};
			CursedLandLvLTeleport2 = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			CursedLandLvLTeleport2.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTCursedLandL" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			CursedLandButton3 = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			CursedLandLabel3 = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = CursedLandButton3,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			CursedLandButton3.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + CursedLandLabel3.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "";
				suggestedLevel.Text = "";
				goldlabel.Text = "";
				gold.Text = "";

				dropLabel.Text = "Cave Detail`s";
				drop01.Text = "Exp 200%";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "Time 10 Min";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "CursedLandToken(XL)";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				CursedLandButton3.Index = 28;
				TeleportButtonsHide();
				CursedLandLvLTeleport3.Visible = true;
			};
			CursedLandLvLTeleport3 = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			CursedLandLvLTeleport3.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTCursedLandXL" });
				GameScene.Scene.WorldMapDialog.Hide();
			};
			#endregion

			//BOSSES KR


			//BATTLEAREAS
			#region BattleAreas
			BattleAreasButton = new MirButton
			{
				Size = new Size(157, 15),
				Index = 26,
				HoverIndex = 25,
				Location = new Point(175, 38),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA
			};
			BattleAreasLabel = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Font = new Font(Settings.FontName, 8f, FontStyle.Bold),
				Size = new Size(157, 15),
				Location = new Point(0, 1),
				Parent = BattleAreasButton,
				NotControl = true,
				ForeColour = Color.Silver,
				Text = ""
			};
			BattleAreasButton.Click += delegate (object o, EventArgs e)
			{
				HideInformation();
				ResetTabs();
				BattleAreasButton.Index = 25;
				ParaLordButton.Visible = true;
				MirKingButton.Visible = true;
				CrystalKingButton.Visible = true;
				OmaKingSpiritButton.Visible = true;
				DarkOmaKingButton.Visible = true;
				BloodKingButton.Visible = true;
				EvilMirButton.Visible = true;
				HellKingButton.Visible = true;
				SetLocations(17);
			};

			ParaLordButton = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			ParaLordLabel = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = ParaLordButton,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			ParaLordButton.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + ParaLordLabel.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "50+";
				goldlabel.Text = "Gold:";
				gold.Text = "1.000.000";
				bool flag = User.Level > 50;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "Teleport Cool-Down";
				drop01.Text = "15 Seconds";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				ParaLordButton.Index = 28;
				TeleportButtonsHide();
				ParaLordTeleport.Visible = true;
			};
			ParaLordTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			ParaLordTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTParaLord" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			MirKingButton = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			MirKingLabel = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = MirKingButton,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			MirKingButton.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + MirKingLabel.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "100+";
				goldlabel.Text = "Gold:";
				gold.Text = "3.000.000";
				bool flag = User.Level > 100;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "Teleport Cool-Down";
				drop01.Text = "15 Seconds";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				MirKingButton.Index = 28;
				TeleportButtonsHide();
				MirKingTeleport.Visible = true;
			};
			MirKingTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			MirKingTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTMirKing" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			CrystalKingButton = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			CrystalKingLabel = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = CrystalKingButton,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			CrystalKingButton.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + CrystalKingLabel.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "150+";
				goldlabel.Text = "Gold:";
				gold.Text = "6.000.000";
				bool flag = User.Level > 150;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "Teleport Cool-Down";
				drop01.Text = "15 Seconds";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				CrystalKingButton.Index = 28;
				TeleportButtonsHide();
				CrystalKingTeleport.Visible = true;
			};
			CrystalKingTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			CrystalKingTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTCrystalKing" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			OmaKingSpiritButton = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			OmaKingSpiritLabel = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = OmaKingSpiritButton,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			OmaKingSpiritButton.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + OmaKingSpiritLabel.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "200+";
				goldlabel.Text = "Gold:";
				gold.Text = "10.000.000";
				bool flag = User.Level > 200;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "Teleport Cool-Down";
				drop01.Text = "15 Seconds";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				OmaKingSpiritButton.Index = 28;
				TeleportButtonsHide();
				OmaKingSpiritTeleport.Visible = true;
			};
			OmaKingSpiritTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			OmaKingSpiritTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTOmaKingSpirit" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			DarkOmaKingButton = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			DarkOmaKingLabel = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = DarkOmaKingButton,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			DarkOmaKingButton.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + DarkOmaKingLabel.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "250+";
				goldlabel.Text = "Gold:";
				gold.Text = "15.000.000";
				bool flag = User.Level > 250;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "Teleport Cool-Down";
				drop01.Text = "15 Seconds";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				DarkOmaKingButton.Index = 28;
				TeleportButtonsHide();
				DarkOmaKingTeleport.Visible = true;
			};
			DarkOmaKingTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			DarkOmaKingTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTDarkOmaKing" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			BloodKingButton = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			BloodKingLabel = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = BloodKingButton,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			BloodKingButton.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + BloodKingLabel.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "300+";
				goldlabel.Text = "Gold:";
				gold.Text = "20.000.000";
				bool flag = User.Level > 300;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "Teleport Cool-Down";
				drop01.Text = "15 Seconds";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				BloodKingButton.Index = 28;
				TeleportButtonsHide();
				BloodKingTeleport.Visible = true;
			};
			BloodKingTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			BloodKingTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTBloodKing" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			EvilMirButton = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			EvilMirLabel = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = EvilMirButton,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			EvilMirButton.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + EvilMirLabel.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "350+";
				goldlabel.Text = "Gold:";
				gold.Text = "30.000.000";
				bool flag = User.Level > 350;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "Teleport Cool-Down";
				drop01.Text = "15 Seconds";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				EvilMirButton.Index = 28;
				TeleportButtonsHide();
				EvilMirTeleport.Visible = true;
			};
			EvilMirTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			EvilMirTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTEvilMir" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			HellKingButton = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			HellKingLabel = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = HellKingButton,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			HellKingButton.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + HellKingLabel.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "400+";
				goldlabel.Text = "Gold:";
				gold.Text = "40.000.000";
				bool flag = User.Level > 400;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "Teleport Cool-Down";
				drop01.Text = "15 Seconds";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				HellKingButton.Index = 28;
				TeleportButtonsHide();
				HellKingTeleport.Visible = true;
			};
			HellKingTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			HellKingTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTHellKing" });
				GameScene.Scene.WorldMapDialog.Hide();
			};
			#endregion

			//GROUP MAPS
			#region GroupAreas
			GroupAreasButton = new MirButton
			{
				Size = new Size(157, 15),
				Index = 26,
				HoverIndex = 25,
				Location = new Point(175, 58),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA
			};
			GroupAreasLabel = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Font = new Font(Settings.FontName, 8f, FontStyle.Bold),
				Size = new Size(157, 15),
				Location = new Point(0, 1),
				Parent = GroupAreasButton,
				NotControl = true,
				ForeColour = Color.Silver,
				Text = ""
			};
			GroupAreasButton.Click += delegate (object o, EventArgs e)
			{
				HideInformation();
				ResetTabs();
				GroupAreasButton.Index = 25;
				BlackDragonDungeonButton.Visible = true;
				DomainOfAnquishButton.Visible = true;
				RedDragonDungeonButton.Visible = true;
				ZephyrTempleButton.Visible = true;
				OldSkoolTempleButton.Visible = true;
				SetLocations(18);
			};

			BlackDragonDungeonButton = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			BlackDragonDungeonLabel = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = BlackDragonDungeonButton,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			BlackDragonDungeonButton.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + BlackDragonDungeonLabel.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "100+";
				goldlabel.Text = "Gold:";
				gold.Text = "10.000.000";
				bool flag = User.Level > 100;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "Group Cave";
				drop01.Text = "";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "Group Count: 3-6";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				BlackDragonDungeonButton.Index = 28;
				TeleportButtonsHide();
				BlackDragonDungeonTeleport.Visible = true;
			};
			BlackDragonDungeonTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			BlackDragonDungeonTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTBlackDragonDungeon" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			DomainOfAnquishButton = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			DomainOfAnquishLabel = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = DomainOfAnquishButton,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			DomainOfAnquishButton.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + DomainOfAnquishLabel.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "50+";
				goldlabel.Text = "Gold:";
				gold.Text = "1.000.000";
				bool flag = User.Level > 50;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "Teleport Cool-Down";
				drop01.Text = "15 Seconds";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				DomainOfAnquishButton.Index = 28;
				TeleportButtonsHide();
				DomainOfAnquishTeleport.Visible = true;
			};
			DomainOfAnquishTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			DomainOfAnquishTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTDomainOfAnquish" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			RedDragonDungeonButton = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			RedDragonDungeonLabel = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = RedDragonDungeonButton,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			RedDragonDungeonButton.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + RedDragonDungeonLabel.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "50+";
				goldlabel.Text = "Gold:";
				gold.Text = "1.000.000";
				bool flag = User.Level > 50;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "Teleport Cool-Down";
				drop01.Text = "15 Seconds";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				RedDragonDungeonButton.Index = 28;
				TeleportButtonsHide();
				RedDragonDungeonTeleport.Visible = true;
			};
			RedDragonDungeonTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			RedDragonDungeonTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTRedDragonDungeon" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			ZephyrTempleButton = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			ZephyrTempleLabel = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = ZephyrTempleButton,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			ZephyrTempleButton.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + ZephyrTempleLabel.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "50+";
				goldlabel.Text = "Gold:";
				gold.Text = "1.000.000";
				bool flag = User.Level > 50;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "Teleport Cool-Down";
				drop01.Text = "15 Seconds";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				ZephyrTempleButton.Index = 28;
				TeleportButtonsHide();
				ZephyrTempleTeleport.Visible = true;
			};
			ZephyrTempleTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			ZephyrTempleTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTZephyrTemple" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			OldSkoolTempleButton = new MirButton
			{
				Size = new Size(122, 15),
				Index = 27,
				HoverIndex = 28,
				Location = new Point(480, 260),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Visible = false
			};
			OldSkoolTempleLabel = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Size = new Size(122, 15),
				Location = new Point(0, 1),
				Parent = OldSkoolTempleButton,
				Text = "",
				NotControl = true,
				ForeColour = Color.Silver
			};
			OldSkoolTempleButton.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + OldSkoolTempleLabel.Text;
				informationLabel.Text = "Location Information:";
				suggestedLevelLabel.Text = "Suggested Level:";
				suggestedLevel.Text = "50+";
				goldlabel.Text = "Gold:";
				gold.Text = "1.000.000";
				bool flag = User.Level > 50;
				if (flag)
				{
					suggestedLevel.ForeColour = Color.Green;
				}
				else
				{
					suggestedLevel.ForeColour = Color.Red;
				}
				dropLabel.Text = "Teleport Cool-Down";
				drop01.Text = "15 Seconds";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				OldSkoolTempleButton.Index = 28;
				TeleportButtonsHide();
				OldSkoolTempleTeleport.Visible = true;
			};
			OldSkoolTempleTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "Teleport",
				Visible = false
			};
			OldSkoolTempleTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTOldSkoolTemple" });
				GameScene.Scene.WorldMapDialog.Hide();
			};
			#endregion

			//LASTMANSTANDING
			LastManStandingButton = new MirButton
			{
				Index = 88,
				HoverIndex = 87,
				Location = new Point(338, 38),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "",
				Visible = true
			};
			LastManStandingLabel = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Font = new Font(Settings.FontName, 8f, FontStyle.Bold),
				Size = new Size(157, 15),
				Location = new Point(0, 1),
				Parent = LastManStandingButton,
				NotControl = true,
				ForeColour = Color.Silver,
				Text = ""
			};
			LastManStandingButton.Click += delegate (object o, EventArgs e)
			{
				HideInformation();
				dungeonNameLabel.Text = "" + LastManStandingLabel.Text;
				informationLabel.Text = "";
				suggestedLevelLabel.Text = "";
				suggestedLevel.Text = "";
				goldlabel.Text = "";
				gold.Text = "";
				dropLabel.Text = "Information:";
				drop01.Text = "FFA take place EVERYDAY at";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "01:50 05:50 09:50 AM/PM";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				LastManStandingButton.Index = 87;
				TeleportButtonsHide();
				LastManStandingTeleport.Visible = true;
				SetLocations(100);
			};
			LastManStandingTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "",
				Visible = false
			};
			LastManStandingTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTLastManStanding" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			//CHALLENGE
			ChallengeButton = new MirButton
			{
				Index = 88,
				HoverIndex = 87,
				Location = new Point(338, 58),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "",
				Visible = true
			};
			ChallengeLabel = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Font = new Font(Settings.FontName, 8f, FontStyle.Bold),
				Size = new Size(157, 15),
				Location = new Point(0, 1),
				Parent = ChallengeButton,
				NotControl = true,
				ForeColour = Color.Silver,
				Text = ""
			};
			ChallengeButton.Click += delegate (object o, EventArgs e)
			{
				HideInformation();
				dungeonNameLabel.Text = "" + ChallengeLabel.Text;
				informationLabel.Text = "";
				suggestedLevelLabel.Text =	"";
				suggestedLevel.Text =		"";
				goldlabel.Text =			"";
				gold.Text = "";
				dropLabel.Text = "Information:";
				drop01.Text = "Challenge Room is made for 1";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "player only, No groups allowed";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				ChallengeButton.Index = 87;
				TeleportButtonsHide();
				ChallengeTeleport.Visible = true;
				SetLocations(100);
			};
			ChallengeTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "",
				Visible = false
			};
			ChallengeTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTChallenge" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			//INSTANCE
			InstanceButton = new MirButton
			{
				Index = 88,
				HoverIndex = 87,
				Location = new Point(338, 78),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "",
				Visible = true
			};
			InstanceLabel = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Font = new Font(Settings.FontName, 8f, FontStyle.Bold),
				Size = new Size(157, 15),
				Location = new Point(0, 1),
				Parent = InstanceButton,
				NotControl = true,
				ForeColour = Color.Silver,
				Text = ""
			};
			InstanceButton.Click += delegate (object o, EventArgs e)
			{
				HideInformation();
				dungeonNameLabel.Text = "" + InstanceLabel.Text;
				informationLabel.Text = "";
				suggestedLevelLabel.Text = "";
				suggestedLevel.Text = "";
				goldlabel.Text = "";
				gold.Text = "";
				dropLabel.Text = "Information:";
				drop01.Text = "Instance Room is made for 1";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "player only, No groups allowed";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				InstanceButton.Index = 87;
				TeleportButtonsHide();
				InstanceTeleport.Visible = true;
				SetLocations(100);
			};
			InstanceTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "",
				Visible = false
			};
			InstanceTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTInstance" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			//SABUKWALL
			SabukWallButton = new MirButton
			{
				Index = 88,
				HoverIndex = 87,
				Location = new Point(338, 98),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "",
				Visible = true
			};
			SabukWallLabel = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Font = new Font(Settings.FontName, 8f, FontStyle.Bold),
				Size = new Size(157, 15),
				Location = new Point(0, 1),
				Parent = SabukWallButton,
				NotControl = true,
				ForeColour = Color.Silver,
				Text = ""
			};
			SabukWallButton.Click += delegate (object o, EventArgs e)
			{
				HideInformation();
				dungeonNameLabel.Text = "" + SabukWallLabel.Text;
				informationLabel.Text = "";
				suggestedLevelLabel.Text = "";
				suggestedLevel.Text = "";
				goldlabel.Text = "";
				gold.Text = "";
				dropLabel.Text = "Information:";
				drop01.Text = "SabukWall Onwers prize";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "   -SabukWall Medal";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "   -SabukWall Exp";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				SabukWallButton.Index = 87;
				TeleportButtonsHide();
				SabukWallTeleport.Visible = true;
				SetLocations(100);
			};
			SabukWallTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "",
				Visible = false
			};
			SabukWallTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTSabukWall" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			//BOSSLAND
			BossLandButton = new MirButton
			{
				Index = 88,
				HoverIndex = 87,
				Location = new Point(338, 118),
				Library = Libraries.WorldMap,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "",
				Visible = true
			};
			BossLandLabel = new MirLabel
			{
				DrawFormat = (TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter),
				Font = new Font(Settings.FontName, 8f, FontStyle.Bold),
				Size = new Size(157, 15),
				Location = new Point(0, 1),
				Parent = BossLandButton,
				NotControl = true,
				ForeColour = Color.Silver,
				Text = ""
			};
			BossLandButton.Click += delegate (object o, EventArgs e)
			{
				dungeonNameLabel.Text = "" + BossLandLabel.Text;
				informationLabel.Text = "";
				suggestedLevelLabel.Text = "";
				suggestedLevel.Text = "";
				goldlabel.Text = "";
				gold.Text = "";
				dropLabel.Text = "Information:";
				drop01.Text = "prize";
				drop01.ForeColour = Color.YellowGreen;
				drop02.Text = "   -Trinket";
				drop02.ForeColour = Color.YellowGreen;
				drop03.Text = "";
				drop03.ForeColour = Color.YellowGreen;
				drop04.Text = "";
				drop04.ForeColour = Color.YellowGreen;
				drop05.Text = "";
				drop05.ForeColour = Color.YellowGreen;
				ResetTabs();
				BossLandButton.Index = 87;
				TeleportButtonsHide();
				HideInformation();
				BossLandTeleport.Visible = true;
				SetLocations(100);
			};
			BossLandTeleport = new MirButton
			{
				Index = TeleportButton.Index,
				HoverIndex = TeleportButton.HoverIndex,
				PressedIndex = TeleportButton.PressedIndex,
				Location = TeleportButton.Location,
				Library = Libraries.Title,
				Parent = this,
				Sound = SoundList.ButtonA,
				Hint = "",
				Visible = false
			};
			BossLandTeleport.Click += delegate (object o, EventArgs e)
			{
				Network.Enqueue(new C.Chat { Message = "@WMTBossLand" });
				GameScene.Scene.WorldMapDialog.Hide();
			};

			// LABELS INFO
			#region Hunt Labels
			GroupMapListLabel1.Text = "Hunting Map 20-80";
			MapListLabel1.Text = "OmaCave";
			MapListLabel2.Text = "ZombieCave";
			MapListLabel3.Text = "SerpentCave";
			MapListLabel4.Text = "InsectCave";
			MapListLabel5.Text = "BugCave";
			MapListLabel6.Text = "StoneTemple";
			MapListLabel7.Text = "ZumaTemple";
			MapListLabel8.Text = "WoomaTemple";
			GroupMapListLabel2.Text = "Hunting Map 100-180";
			MapListLabel9.Text = "PrajnaCave";
			MapListLabel10.Text = "PrajnaTemple";
			MapListLabel11.Text = "SpiderCave";
			MapListLabel12.Text = "FrozenTemple";
			MapListLabel13.Text = "SwampCave";
			MapListLabel14.Text = "NumaTemple";
			MapListLabel15.Text = "TrollTemple";
			MapListLabel16.Text = "DemonTemple";
			MapListLabel17.Text = "AngelTemple";
			MapListLabel18.Text = "HellCave";
			GroupMapListLabel3.Text = "Hunting Map 200-280";
			MapListLabel19.Text = "FoxCave";
			MapListLabel20.Text = "OrcTemple";
			MapListLabel21.Text = "EvilCave";
			MapListLabel22.Text = "LizardCave";
			MapListLabel23.Text = "SunkenCave";
			MapListLabel24.Text = "KnightTemple";
			MapListLabel25.Text = "HavokTemple";
			MapListLabel26.Text = "SkullCave";
			MapListLabel27.Text = "LostTemple";
			MapListLabel28.Text = "IceTemple";
			GroupMapListLabel4.Text = "Hunting Map 300-380";
			MapListLabel29.Text = "ForgottenTemple";
			MapListLabel30.Text = "TurtleLair";
			MapListLabel31.Text = "CaveOfNicanor";
			MapListLabel32.Text = "CaveOfTrouble";
			MapListLabel33.Text = "GardenOfDeath";
			MapListLabel34.Text = "CaveOfHorror";
			MapListLabel35.Text = "CaveOfDespair";
			MapListLabel36.Text = "TempleOfHeroes";
			MapListLabel37.Text = "SacredTemple";
			MapListLabel38.Text = "DarkTemple";
			GroupMapListLabel5.Text = "Hunting Map 400-480";
			MapListLabel39.Text = "SealedCave";
			MapListLabel40.Text = "MysticTemple";
			MapListLabel41.Text = "ShadowCave";
			MapListLabel42.Text = "AncientTemple";
			MapListLabel43.Text = "CursedCave";
			MapListLabel44.Text = "ChaosTemple";
			MapListLabel45.Text = "RockTemple";
			MapListLabel46.Text = "RampantTemple";
			MapListLabel47.Text = "PhantomTemple";
			MapListLabel48.Text = "HellishCave";
            #endregion

            LevelingLabel1.Text = "Leveling Map";
			OmaCaveLvLLabel.Text = "OmaCave(S)";
			OmaCaveLvLLabel1.Text = "OmaCave(M)";
			OmaCaveLvLLabel2.Text = "OmaCave(L)";
			OmaCaveLvLLabel3.Text = "OmaCave(XL)";
			PastBichonLabel.Text = "PastBichon(S)";
			PastBichonLabel1.Text = "PastBichon(M)";
			PastBichonLabel2.Text = "PastBichon(L)";
			PastBichonLabel3.Text = "PastBichon(XL)";
			ChaosTempleLvLLabel.Text = "ChaosTemple(S)";
			ChaosTempleLvLLabel1.Text = "ChaosTemple(M)";
			ChaosTempleLvLLabel2.Text = "ChaosTemple(L)";
			ChaosTempleLvLLabel3.Text = "ChaosTemple(XL)";
			PainCavernLabel.Text = "PainCavern(S)";
			PainCavernLabel1.Text = "PainCavern(M)";
			PainCavernLabel2.Text = "PainCavern(L)";
			PainCavernLabel3.Text = "PainCavern(XL)";
			TriTempleLabel.Text = "TriTemple(S)";
			TriTempleLabel1.Text = "TriTemple(M)";
			TriTempleLabel2.Text = "TriTemple(L)";
			TriTempleLabel3.Text = "TriTemple(XL)";
			LostCaveLabel.Text = "LostCave(S)";
			LostCaveLabel1.Text = "LostCave(M)";
			LostCaveLabel2.Text = "LostCave(L)";
			LostCaveLabel3.Text = "LostCave(XL)";
			LittleIslandLabel.Text = "LittleIsland(S)";
			LittleIslandLabel1.Text = "LittleIsland(M)";
			LittleIslandLabel2.Text = "LittleIsland(L)";
			LittleIslandLabel3.Text = "LittleIsland(XL)";
			StoneTempleLvLLabel.Text = "StoneTemple(S)";
			StoneTempleLvLLabel1.Text = "StoneTemple(M)";
			StoneTempleLvLLabel2.Text = "StoneTemple(L)";
			StoneTempleLvLLabel3.Text = "StoneTemple(XL)";
			CursedLandLabel.Text = "CursedLand(S)";
			CursedLandLabel1.Text = "CursedLand(M)";
			CursedLandLabel2.Text = "CursedLand(L)";
			CursedLandLabel3.Text = "CursedLand(XL)";

			BattleAreasLabel.Text = "BattleAreas";
			ParaLordLabel.Text = "ParaLord";
			MirKingLabel.Text = "MirKing";
			CrystalKingLabel.Text = "CrystalKing";
			OmaKingSpiritLabel.Text = "OmaKingSpirit";
			DarkOmaKingLabel.Text = "DarkOmaKing";
			BloodKingLabel.Text = "BloodKing";
			EvilMirLabel.Text = "EvilMir";
			HellKingLabel.Text = "HellKing";

			GroupAreasLabel.Text = "GroupAreas";
			BlackDragonDungeonLabel.Text = "BlackDragonDungeon";
			DomainOfAnquishLabel.Text = "DomainOfAnquish";
			RedDragonDungeonLabel.Text = "RedDragonDungeon";
			ZephyrTempleLabel.Text = "ZephyrTemple";
			OldSkoolTempleLabel.Text = "OldSkoolTemple";

			LastManStandingLabel.Text = "LastManStanding";
			ChallengeLabel.Text = "Challenge";
			InstanceLabel.Text = "Instance";
			SabukWallLabel.Text = "SabukWall";
			BossLandLabel.Text = "BossLand";


			backButton.Visible = false;
			nextButton.Visible = false;
			pageLabel.Visible = false;
		}
		public void SetLocations(int Loc) // Button under main town name
		{
			switch (Loc)
			{
				case 0:
				case 1:
					LastManStandingButton.Index = 88;
					ChallengeButton.Index = 88;
					InstanceButton.Index = 88;
					SabukWallButton.Index = 88;
					BossLandButton.Index = 88;

					BattleAreasButton.Index = 26;
					BattleAreasLabel.ForeColour = Color.Silver;

					GroupMapListLabel1.ForeColour = Color.NavajoWhite;
					GroupMapList1.Location = new Point(13, 38);
					GroupMapList1.Index = 25;

						MapList1.Location = new Point(33, GroupMapList1.Location.Y + 20);
						MapList2.Location = new Point(33, MapList1.Location.Y + 20);
						MapList3.Location = new Point(33, MapList2.Location.Y + 20);
						MapList4.Location = new Point(33, MapList3.Location.Y + 20);
						MapList5.Location = new Point(33, MapList4.Location.Y + 20);
						MapList6.Location = new Point(33, MapList5.Location.Y + 20);
						MapList7.Location = new Point(33, MapList6.Location.Y + 20);
						MapList8.Location = new Point(33, MapList7.Location.Y + 20);

					GroupAreasButton.Location = new Point(175, BattleAreasButton.Location.Y + 20);
					GroupAreasButton.Index = 26;
					GroupAreasLabel.ForeColour = Color.Silver;

					GroupMapList2.Location = new Point(13, MapList8.Location.Y + 20);
					GroupMapList2.Index = 26;
					GroupMapListLabel2.ForeColour = Color.Silver;

					GroupMapList3.Location = new Point(13, GroupMapList2.Location.Y + 20);
					GroupMapList3.Index = 26;
					GroupMapListLabel3.ForeColour = Color.Silver;

					GroupMapList4.Location = new Point(13, GroupMapList3.Location.Y + 20);
					GroupMapList4.Index = 26;
					GroupMapListLabel4.ForeColour = Color.Silver;

					GroupMapList5.Location = new Point(13, GroupMapList4.Location.Y + 20);
					GroupMapList5.Index = 26;
					GroupMapListLabel5.ForeColour = Color.Silver;

					LevelingButton1.Location = new Point(13, GroupMapList5.Location.Y + 20);
					LevelingButton1.Index = 26;
					LevelingLabel1.ForeColour = Color.Silver;
					break;
				case 2:
					LastManStandingButton.Index = 88;
					ChallengeButton.Index = 88;
					InstanceButton.Index = 88;
					SabukWallButton.Index = 88;
					BossLandButton.Index = 88;

					BattleAreasButton.Index = 26;
					BattleAreasLabel.ForeColour = Color.Silver;

					GroupMapListLabel1.ForeColour = Color.Silver;
					GroupMapList1.Location = new Point(13, 38);
					GroupMapList1.Index = 26;

					GroupMapListLabel2.ForeColour = Color.NavajoWhite;
					GroupMapList2.Location = new Point(13, GroupMapList1.Location.Y + 20);
					GroupMapList2.Index = 25;

						MapList9.Location = new Point(33, GroupMapList2.Location.Y + 20);
						MapList10.Location = new Point(33, MapList9.Location.Y + 20);
						MapList11.Location = new Point(33, MapList10.Location.Y + 20);
						MapList12.Location = new Point(33, MapList11.Location.Y + 20);
						MapList13.Location = new Point(33, MapList12.Location.Y + 20);
						MapList14.Location = new Point(33, MapList13.Location.Y + 20);
						MapList15.Location = new Point(33, MapList14.Location.Y + 20);
						MapList16.Location = new Point(33, MapList15.Location.Y + 20);
						MapList17.Location = new Point(33, MapList16.Location.Y + 20);
						MapList18.Location = new Point(33, MapList17.Location.Y + 20);

					GroupAreasButton.Location = new Point(175, BattleAreasButton.Location.Y + 20);
					GroupAreasButton.Index = 26;
					GroupAreasLabel.ForeColour = Color.Silver;

					GroupMapList3.Location = new Point(13, MapList18.Location.Y + 20);
					GroupMapList3.Index = 26;
					GroupMapListLabel3.ForeColour = Color.Silver;

					GroupMapList4.Location = new Point(13, GroupMapList3.Location.Y + 20);
					GroupMapList4.Index = 26;
					GroupMapListLabel4.ForeColour = Color.Silver;

					GroupMapList5.Location = new Point(13, GroupMapList4.Location.Y + 20);
					GroupMapList5.Index = 26;
					GroupMapListLabel5.ForeColour = Color.Silver;

					LevelingButton1.Location = new Point(13, GroupMapList5.Location.Y + 20);
					LevelingButton1.Index = 26;
					LevelingLabel1.ForeColour = Color.Silver;
					break;
				case 3:
					LastManStandingButton.Index = 88;
					ChallengeButton.Index = 88;
					InstanceButton.Index = 88;
					SabukWallButton.Index = 88;
					BossLandButton.Index = 88;

					BattleAreasButton.Index = 26;
					BattleAreasLabel.ForeColour = Color.Silver;

					GroupMapList1.Location = new Point(13, 38);
					GroupMapList1.Index = 26;
					GroupMapListLabel1.ForeColour = Color.Silver;

					GroupMapList2.Location = new Point(13, GroupMapList1.Location.Y + 20);
					GroupMapList2.Index = 26;
					GroupMapListLabel2.ForeColour = Color.Silver;

					GroupMapList3.Location = new Point(13, GroupMapList2.Location.Y + 20);
					GroupMapList3.Index = 25;
					GroupMapListLabel3.ForeColour = Color.NavajoWhite;

						MapList19.Location = new Point(33, GroupMapList3.Location.Y + 20);
						MapList20.Location = new Point(33, MapList19.Location.Y + 20);
						MapList21.Location = new Point(33, MapList20.Location.Y + 20);
						MapList22.Location = new Point(33, MapList21.Location.Y + 20);
						MapList23.Location = new Point(33, MapList22.Location.Y + 20);
						MapList24.Location = new Point(33, MapList23.Location.Y + 20);
						MapList25.Location = new Point(33, MapList24.Location.Y + 20);
						MapList26.Location = new Point(33, MapList25.Location.Y + 20);
						MapList27.Location = new Point(33, MapList26.Location.Y + 20);
						MapList28.Location = new Point(33, MapList27.Location.Y + 20);

					GroupAreasButton.Location = new Point(175, BattleAreasButton.Location.Y + 20);
					GroupAreasButton.Index = 26;
					GroupAreasLabel.ForeColour = Color.Silver;

					GroupMapList4.Location = new Point(13, MapList28.Location.Y + 20);
					GroupMapList4.Index = 26;
					GroupMapListLabel4.ForeColour = Color.Silver;

					GroupMapList5.Location = new Point(13, GroupMapList4.Location.Y + 20);
					GroupMapList5.Index = 26;
					GroupMapListLabel5.ForeColour = Color.Silver;

					LevelingButton1.Location = new Point(13, GroupMapList5.Location.Y + 20);
					LevelingButton1.Index = 26;
					LevelingLabel1.ForeColour = Color.Silver;
					break;
				case 4:
					LastManStandingButton.Index = 88;
					ChallengeButton.Index = 88;
					InstanceButton.Index = 88;
					SabukWallButton.Index = 88;
					BossLandButton.Index = 88;

					BattleAreasButton.Index = 26;
					BattleAreasLabel.ForeColour = Color.Silver;

					GroupMapList1.Location = new Point(13, 38);
					GroupMapList1.Index = 26;
					GroupMapListLabel1.ForeColour = Color.Silver;

					GroupMapList2.Location = new Point(13, GroupMapList1.Location.Y + 20);
					GroupMapList2.Index = 26;
					GroupMapListLabel2.ForeColour = Color.Silver;

					GroupMapList3.Location = new Point(13, GroupMapList2.Location.Y + 20);
					GroupMapList3.Index = 26;
					GroupMapListLabel3.ForeColour = Color.Silver;

					GroupMapList4.Location = new Point(13, GroupMapList3.Location.Y + 20);
					GroupMapList4.Index = 25;
					GroupMapListLabel4.ForeColour = Color.NavajoWhite;

						MapList29.Location = new Point(33, GroupMapList4.Location.Y + 20);
						MapList30.Location = new Point(33, MapList29.Location.Y + 20);
						MapList31.Location = new Point(33, MapList30.Location.Y + 20);
						MapList32.Location = new Point(33, MapList31.Location.Y + 20);
						MapList33.Location = new Point(33, MapList32.Location.Y + 20);
						MapList34.Location = new Point(33, MapList33.Location.Y + 20);
						MapList35.Location = new Point(33, MapList34.Location.Y + 20);
						MapList36.Location = new Point(33, MapList35.Location.Y + 20);
						MapList37.Location = new Point(33, MapList36.Location.Y + 20);
						MapList38.Location = new Point(33, MapList37.Location.Y + 20);

					GroupAreasButton.Location = new Point(175, BattleAreasButton.Location.Y + 20);
					GroupAreasButton.Index = 26;
					GroupAreasLabel.ForeColour = Color.Silver;

					GroupMapList5.Location = new Point(13, MapList38.Location.Y + 20);
					GroupMapList5.Index = 26;
					GroupMapListLabel5.ForeColour = Color.Silver;

					LevelingButton1.Location = new Point(13, GroupMapList5.Location.Y + 20);
					LevelingButton1.Index = 26;
					LevelingLabel1.ForeColour = Color.Silver;
					break;
				case 5:
					LastManStandingButton.Index = 88;
					ChallengeButton.Index = 88;
					InstanceButton.Index = 88;
					SabukWallButton.Index = 88;
					BossLandButton.Index = 88;

					BattleAreasButton.Index = 26;
					BattleAreasLabel.ForeColour = Color.Silver;

					GroupMapList1.Location = new Point(13, 38);
					GroupMapList1.Index = 26;
					GroupMapListLabel1.ForeColour = Color.Silver;

					GroupMapList2.Location = new Point(13, GroupMapList1.Location.Y + 20);
					GroupMapList2.Index = 26;
					GroupMapListLabel2.ForeColour = Color.Silver;

					GroupMapList3.Location = new Point(13, GroupMapList2.Location.Y + 20);
					GroupMapList3.Index = 26;
					GroupMapListLabel3.ForeColour = Color.Silver;

					GroupMapList4.Location = new Point(13, GroupMapList3.Location.Y + 20);
					GroupMapList4.Index = 26;
					GroupMapListLabel4.ForeColour = Color.Silver;

					GroupMapList5.Location = new Point(13, GroupMapList4.Location.Y + 20);
					GroupMapList5.Index = 25;
					GroupMapListLabel5.ForeColour = Color.NavajoWhite;
						MapList39.Location = new Point(33, GroupMapList5.Location.Y + 20);
						MapList40.Location = new Point(33, MapList39.Location.Y + 20);
						MapList41.Location = new Point(33, MapList40.Location.Y + 20);
						MapList42.Location = new Point(33, MapList41.Location.Y + 20);
						MapList43.Location = new Point(33, MapList42.Location.Y + 20);
						MapList44.Location = new Point(33, MapList43.Location.Y + 20);
						MapList45.Location = new Point(33, MapList44.Location.Y + 20);
						MapList46.Location = new Point(33, MapList45.Location.Y + 20);
						MapList47.Location = new Point(33, MapList46.Location.Y + 20);
						MapList48.Location = new Point(33, MapList47.Location.Y + 20);

					GroupAreasButton.Location = new Point(175, BattleAreasButton.Location.Y + 20);
					GroupAreasButton.Index = 26;
					GroupAreasLabel.ForeColour = Color.Silver;

					LevelingButton1.Location = new Point(13, MapList48.Location.Y + 20);
					LevelingButton1.Index = 26;
					LevelingLabel1.ForeColour = Color.Silver;
					break;
				case 11:
					LastManStandingButton.Index = 88;
					ChallengeButton.Index = 88;
					InstanceButton.Index = 88;
					SabukWallButton.Index = 88;
					BossLandButton.Index = 88;

					BattleAreasButton.Index = 26;
					BattleAreasLabel.ForeColour = Color.Silver;

					GroupMapList1.Location = new Point(13, 38);
					GroupMapList1.Index = 26;
					GroupMapListLabel1.ForeColour = Color.Silver;

					GroupMapList2.Location = new Point(13, GroupMapList1.Location.Y + 20);
					GroupMapList2.Index = 26;
					GroupMapListLabel2.ForeColour = Color.Silver;

					GroupMapList3.Location = new Point(13, GroupMapList2.Location.Y + 20);
					GroupMapList3.Index = 26;
					GroupMapListLabel3.ForeColour = Color.Silver;

					GroupMapList4.Location = new Point(13, GroupMapList3.Location.Y + 20);
					GroupMapList4.Index = 26;
					GroupMapListLabel4.ForeColour = Color.Silver;

					GroupMapList5.Location = new Point(13, GroupMapList4.Location.Y + 20);
					GroupMapList5.Index = 26;
					GroupMapListLabel5.ForeColour = Color.Silver;

					LevelingButton1.Location = new Point(13, GroupMapList5.Location.Y + 20);
					LevelingButton1.Index = 25;
					LevelingLabel1.ForeColour = Color.NavajoWhite;
						OmaCaveLvLButton.Location = new Point(33, LevelingButton1.Location.Y + 20);
						PastBichonButton.Location = new Point(33, OmaCaveLvLButton.Location.Y + 20);
						ChaosTempleLvLButton.Location = new Point(33, PastBichonButton.Location.Y + 20);
						PainCavernButton.Location = new Point(33, ChaosTempleLvLButton.Location.Y + 20);
						TriTempleButton.Location = new Point(33, PainCavernButton.Location.Y + 20);
						LostCaveButton.Location = new Point(33, TriTempleButton.Location.Y + 20);
						LittleIslandButton.Location = new Point(33, LostCaveButton.Location.Y + 20);
						StoneTempleLvLButton.Location = new Point(33, LittleIslandButton.Location.Y + 20);
						CursedLandButton.Location = new Point(33, StoneTempleLvLButton.Location.Y + 20);

					GroupAreasButton.Location = new Point(175, BattleAreasButton.Location.Y + 20);
					GroupAreasButton.Index = 26;
					GroupAreasLabel.ForeColour = Color.Silver;
					break;
				case 17:
					LastManStandingButton.Index = 88;
					ChallengeButton.Index = 88;
					InstanceButton.Index = 88;
					SabukWallButton.Index = 88;
					BossLandButton.Index = 88;

					GroupMapList1.Location = new Point(13, 38);
					GroupMapList1.Index = 26;
					GroupMapListLabel1.ForeColour = Color.Silver;

					GroupMapList2.Location = new Point(13, GroupMapList1.Location.Y + 20);
					GroupMapList2.Index = 26;
					GroupMapListLabel2.ForeColour = Color.Silver;

					GroupMapList3.Location = new Point(13, GroupMapList2.Location.Y + 20);
					GroupMapList3.Index = 26;
					GroupMapListLabel3.ForeColour = Color.Silver;

					GroupMapList4.Location = new Point(13, GroupMapList3.Location.Y + 20);
					GroupMapList4.Index = 26;
					GroupMapListLabel4.ForeColour = Color.Silver;

					GroupMapList5.Location = new Point(13, GroupMapList4.Location.Y + 20);
					GroupMapList5.Index = 26;
					GroupMapListLabel5.ForeColour = Color.Silver;

					LevelingButton1.Location = new Point(13, GroupMapList5.Location.Y + 20);
					LevelingButton1.Index = 26;
					LevelingLabel1.ForeColour = Color.Silver;

					BattleAreasButton.Location = new Point(175, 38);
					BattleAreasLabel.ForeColour = Color.NavajoWhite;
					BattleAreasButton.Index = 25;
						ParaLordButton.Location = new Point(195, BattleAreasButton.Location.Y + 20);
						MirKingButton.Location = new Point(195, ParaLordButton.Location.Y + 20);
						CrystalKingButton.Location = new Point(195, MirKingButton.Location.Y + 20);
						OmaKingSpiritButton.Location = new Point(195, CrystalKingButton.Location.Y + 20);
						DarkOmaKingButton.Location = new Point(195, OmaKingSpiritButton.Location.Y + 20);
						BloodKingButton.Location = new Point(195, DarkOmaKingButton.Location.Y + 20);
						EvilMirButton.Location = new Point(195, BloodKingButton.Location.Y + 20);
						HellKingButton.Location = new Point(195, EvilMirButton.Location.Y + 20);

					GroupAreasButton.Location = new Point(175, HellKingButton.Location.Y + 20);
					GroupAreasLabel.ForeColour = Color.Silver;
					GroupAreasButton.Index = 26;
					break;
				case 18:
					LastManStandingButton.Index = 88;
					ChallengeButton.Index = 88;
					InstanceButton.Index = 88;
					SabukWallButton.Index = 88;
					BossLandButton.Index = 88;

					GroupMapList1.Location = new Point(13, 38);
					GroupMapList1.Index = 26;
					GroupMapListLabel1.ForeColour = Color.Silver;

					GroupMapList2.Location = new Point(13, GroupMapList1.Location.Y + 20);
					GroupMapList2.Index = 26;
					GroupMapListLabel2.ForeColour = Color.Silver;

					GroupMapList3.Location = new Point(13, GroupMapList2.Location.Y + 20);
					GroupMapList3.Index = 26;
					GroupMapListLabel3.ForeColour = Color.Silver;

					GroupMapList4.Location = new Point(13, GroupMapList3.Location.Y + 20);
					GroupMapList4.Index = 26;
					GroupMapListLabel4.ForeColour = Color.Silver;

					GroupMapList5.Location = new Point(13, GroupMapList4.Location.Y + 20);
					GroupMapList5.Index = 26;
					GroupMapListLabel5.ForeColour = Color.Silver;

					LevelingButton1.Location = new Point(13, GroupMapList5.Location.Y + 20);
					LevelingButton1.Index = 26;
					LevelingLabel1.ForeColour = Color.Silver;

					BattleAreasButton.Location = new Point(175, 38);
					BattleAreasButton.Index = 26;
					BattleAreasLabel.ForeColour = Color.Silver;

					GroupAreasButton.Location = new Point(175, BattleAreasButton.Location.Y + 20);
					GroupAreasLabel.ForeColour = Color.NavajoWhite;
					GroupAreasButton.Index = 25;
						BlackDragonDungeonButton.Location = new Point(195, GroupAreasButton.Location.Y + 20);
						DomainOfAnquishButton.Location = new Point(195, BlackDragonDungeonButton.Location.Y + 20);
						RedDragonDungeonButton.Location = new Point(195, DomainOfAnquishButton.Location.Y + 20);
						ZephyrTempleButton.Location = new Point(195, RedDragonDungeonButton.Location.Y + 20);
						OldSkoolTempleButton.Location = new Point(195, ZephyrTempleButton.Location.Y + 20);
					break;
				case 30:
					LastManStandingButton.Index = 88;
					ChallengeButton.Index = 88;
					InstanceButton.Index = 88;
					SabukWallButton.Index = 88;
					BossLandButton.Index = 88;

					GroupMapList1.Location = new Point(13, 38);
					GroupMapList1.Index = 26;
					GroupMapListLabel1.ForeColour = Color.Silver;

					GroupMapList2.Location = new Point(13, GroupMapList1.Location.Y + 20);
					GroupMapList2.Index = 26;
					GroupMapListLabel2.ForeColour = Color.Silver;

					GroupMapList3.Location = new Point(13, GroupMapList2.Location.Y + 20);
					GroupMapList3.Index = 26;
					GroupMapListLabel3.ForeColour = Color.Silver;

					GroupMapList4.Location = new Point(13, GroupMapList3.Location.Y + 20);
					GroupMapList4.Index = 26;
					GroupMapListLabel4.ForeColour = Color.Silver;

					GroupMapList5.Location = new Point(13, GroupMapList4.Location.Y + 20);
					GroupMapList5.Index = 26;
					GroupMapListLabel5.ForeColour = Color.Silver;

					LevelingButton1.Location = new Point(13, GroupMapList5.Location.Y + 20);
					LevelingButton1.Index = 26;
					LevelingLabel1.ForeColour = Color.Silver;

					BattleAreasButton.Location = new Point(175, 38);
					BattleAreasButton.Index = 26;
					BattleAreasLabel.ForeColour = Color.Silver;

					GroupAreasButton.Location = new Point(175, BattleAreasButton.Location.Y + 20);
					GroupAreasLabel.ForeColour = Color.Silver;
					GroupAreasButton.Index = 26;
					break;
				case 100:
					GroupMapList1.Location = new Point(13, 38);
					GroupMapListLabel1.ForeColour = Color.Silver;
					GroupMapList1.Index = 26;
					GroupMapList2.Location = new Point(13, GroupMapList1.Location.Y + 20);
					GroupMapListLabel2.ForeColour = Color.Silver;
					GroupMapList2.Index = 26;
					GroupMapList3.Location = new Point(13, GroupMapList2.Location.Y + 20);
					GroupMapListLabel3.ForeColour = Color.Silver;
					GroupMapList3.Index = 26;
					GroupMapList4.Location = new Point(13, GroupMapList3.Location.Y + 20);
					GroupMapListLabel4.ForeColour = Color.Silver;
					GroupMapList4.Index = 26;
					GroupMapList5.Location = new Point(13, GroupMapList4.Location.Y + 20);
					GroupMapListLabel5.ForeColour = Color.Silver;
					GroupMapList5.Index = 26;
					LevelingButton1.Location = new Point(13, GroupMapList5.Location.Y + 20);
					LevelingLabel1.ForeColour = Color.Silver;
					LevelingButton1.Index = 26;
					BattleAreasButton.Location = new Point(175, 38);
					BattleAreasLabel.ForeColour = Color.Silver;
					BattleAreasButton.Index = 26;
					GroupAreasButton.Location = new Point(175, BattleAreasButton.Location.Y + 20);
					GroupAreasLabel.ForeColour = Color.Silver;
					GroupAreasButton.Index = 26;
					break;

			}
		}
		public void SubSetLocations(int Loc) // Button under main town name
		{
			switch (Loc)
			{
				case 0:
				case 1:
					OmaCaveLvLButton.Location = new Point(13, LevelingButton1.Location.Y + 20);
					OmaCaveLvLButton1.Location = new Point(33, OmaCaveLvLButton.Location.Y + 20);
					OmaCaveLvLButton2.Location = new Point(33, OmaCaveLvLButton1.Location.Y + 20);
					OmaCaveLvLButton3.Location = new Point(33, OmaCaveLvLButton2.Location.Y + 20);
					PastBichonButton.Location = new Point(13, OmaCaveLvLButton3.Location.Y + 20);
					ChaosTempleLvLButton.Location = new Point(13, PastBichonButton.Location.Y + 20);
					PainCavernButton.Location = new Point(13, ChaosTempleLvLButton.Location.Y + 20);
					TriTempleButton.Location = new Point(13, PainCavernButton.Location.Y + 20);
					LostCaveButton.Location = new Point(13, TriTempleButton.Location.Y + 20);
					LittleIslandButton.Location = new Point(13, LostCaveButton.Location.Y + 20);
					StoneTempleLvLButton.Location = new Point(13, LittleIslandButton.Location.Y + 20);
					CursedLandButton.Location = new Point(13, StoneTempleLvLButton.Location.Y + 20);
					break;
				case 2:
					OmaCaveLvLButton.Location = new Point(13, LevelingButton1.Location.Y + 20);
					PastBichonButton.Location = new Point(13, OmaCaveLvLButton.Location.Y + 20);
						PastBichonButton1.Location = new Point(33, PastBichonButton.Location.Y + 20);
						PastBichonButton2.Location = new Point(33, PastBichonButton1.Location.Y + 20);
						PastBichonButton3.Location = new Point(33, PastBichonButton2.Location.Y + 20);
					ChaosTempleLvLButton.Location = new Point(13, PastBichonButton3.Location.Y + 20);
					PainCavernButton.Location = new Point(13, ChaosTempleLvLButton.Location.Y + 20);
					TriTempleButton.Location = new Point(13, PainCavernButton.Location.Y + 20);
					LostCaveButton.Location = new Point(13, TriTempleButton.Location.Y + 20);
					LittleIslandButton.Location = new Point(13, LostCaveButton.Location.Y + 20);
					StoneTempleLvLButton.Location = new Point(13, LittleIslandButton.Location.Y + 20);
					CursedLandButton.Location = new Point(13, StoneTempleLvLButton.Location.Y + 20);
					break;
				case 3:
					OmaCaveLvLButton.Location = new Point(13, LevelingButton1.Location.Y + 20);
					PastBichonButton.Location = new Point(13, OmaCaveLvLButton.Location.Y + 20);
					ChaosTempleLvLButton.Location = new Point(13, PastBichonButton.Location.Y + 20);
					ChaosTempleLvLButton1.Location = new Point(33, ChaosTempleLvLButton.Location.Y + 20);
					ChaosTempleLvLButton2.Location = new Point(33, ChaosTempleLvLButton1.Location.Y + 20);
					ChaosTempleLvLButton3.Location = new Point(33, ChaosTempleLvLButton2.Location.Y + 20);
					PainCavernButton.Location = new Point(13, ChaosTempleLvLButton3.Location.Y + 20);
					TriTempleButton.Location = new Point(13, PainCavernButton.Location.Y + 20);
					LostCaveButton.Location = new Point(13, TriTempleButton.Location.Y + 20);
					LittleIslandButton.Location = new Point(13, LostCaveButton.Location.Y + 20);
					StoneTempleLvLButton.Location = new Point(13, LittleIslandButton.Location.Y + 20);
					CursedLandButton.Location = new Point(13, StoneTempleLvLButton.Location.Y + 20);
					break;
				case 4:
					OmaCaveLvLButton.Location = new Point(13, LevelingButton1.Location.Y + 20);
					PastBichonButton.Location = new Point(13, OmaCaveLvLButton.Location.Y + 20);
					ChaosTempleLvLButton.Location = new Point(13, PastBichonButton.Location.Y + 20);
					PainCavernButton.Location = new Point(13, ChaosTempleLvLButton.Location.Y + 20);
						PainCavernButton1.Location = new Point(33, PainCavernButton.Location.Y + 20);
						PainCavernButton2.Location = new Point(33, PainCavernButton1.Location.Y + 20);
						PainCavernButton3.Location = new Point(33, PainCavernButton2.Location.Y + 20);
					TriTempleButton.Location = new Point(13, PainCavernButton3.Location.Y + 20);
					LostCaveButton.Location = new Point(13, TriTempleButton.Location.Y + 20);
					LittleIslandButton.Location = new Point(13, LostCaveButton.Location.Y + 20);
					StoneTempleLvLButton.Location = new Point(13, LittleIslandButton.Location.Y + 20);
					CursedLandButton.Location = new Point(13, StoneTempleLvLButton.Location.Y + 20);
					break;
				case 5:
					OmaCaveLvLButton.Location = new Point(13, LevelingButton1.Location.Y + 20);
					PastBichonButton.Location = new Point(13, OmaCaveLvLButton.Location.Y + 20);
					ChaosTempleLvLButton.Location = new Point(13, PastBichonButton.Location.Y + 20);
					PainCavernButton.Location = new Point(13, ChaosTempleLvLButton.Location.Y + 20);
					TriTempleButton.Location = new Point(13, PainCavernButton.Location.Y + 20);
						TriTempleButton1.Location = new Point(33, TriTempleButton.Location.Y + 20);
						TriTempleButton2.Location = new Point(33, TriTempleButton1.Location.Y + 20);
						TriTempleButton3.Location = new Point(33, TriTempleButton2.Location.Y + 20);
					LostCaveButton.Location = new Point(13, TriTempleButton3.Location.Y + 20);
					LittleIslandButton.Location = new Point(13, LostCaveButton.Location.Y + 20);
					StoneTempleLvLButton.Location = new Point(13, LittleIslandButton.Location.Y + 20);
					CursedLandButton.Location = new Point(13, StoneTempleLvLButton.Location.Y + 20);
					break;
				case 6:
					OmaCaveLvLButton.Location = new Point(13, LevelingButton1.Location.Y + 20);
					PastBichonButton.Location = new Point(13, OmaCaveLvLButton.Location.Y + 20);
					ChaosTempleLvLButton.Location = new Point(13, PastBichonButton.Location.Y + 20);
					PainCavernButton.Location = new Point(13, ChaosTempleLvLButton.Location.Y + 20);
					TriTempleButton.Location = new Point(13, PainCavernButton.Location.Y + 20);
					LostCaveButton.Location = new Point(13, TriTempleButton.Location.Y + 20);
						LostCaveButton1.Location = new Point(33, LostCaveButton.Location.Y + 20);
						LostCaveButton2.Location = new Point(33, LostCaveButton1.Location.Y + 20);
						LostCaveButton3.Location = new Point(33, LostCaveButton2.Location.Y + 20);
					LittleIslandButton.Location = new Point(13, LostCaveButton3.Location.Y + 20);
					StoneTempleLvLButton.Location = new Point(13, LittleIslandButton.Location.Y + 20);
					CursedLandButton.Location = new Point(13, StoneTempleLvLButton.Location.Y + 20);
					break;
				case 7:
					OmaCaveLvLButton.Location = new Point(13, LevelingButton1.Location.Y + 20);
					PastBichonButton.Location = new Point(13, OmaCaveLvLButton.Location.Y + 20);
					ChaosTempleLvLButton.Location = new Point(13, PastBichonButton.Location.Y + 20);
					PainCavernButton.Location = new Point(13, ChaosTempleLvLButton.Location.Y + 20);
					TriTempleButton.Location = new Point(13, PainCavernButton.Location.Y + 20);
					LostCaveButton.Location = new Point(13, TriTempleButton.Location.Y + 20);
					LittleIslandButton.Location = new Point(13, LostCaveButton.Location.Y + 20);
						LittleIslandButton1.Location = new Point(13, LittleIslandButton.Location.Y + 20);
						LittleIslandButton2.Location = new Point(13, LittleIslandButton1.Location.Y + 20);
						LittleIslandButton3.Location = new Point(13, LittleIslandButton2.Location.Y + 20);
					StoneTempleLvLButton.Location = new Point(13, LittleIslandButton3.Location.Y + 20);
					CursedLandButton.Location = new Point(13, StoneTempleLvLButton.Location.Y + 20);
					break;
				case 8:
					OmaCaveLvLButton.Location = new Point(13, LevelingButton1.Location.Y + 20);
					PastBichonButton.Location = new Point(13, OmaCaveLvLButton.Location.Y + 20);
					ChaosTempleLvLButton.Location = new Point(13, PastBichonButton.Location.Y + 20);
					PainCavernButton.Location = new Point(13, ChaosTempleLvLButton.Location.Y + 20);
					TriTempleButton.Location = new Point(13, PainCavernButton.Location.Y + 20);
					LostCaveButton.Location = new Point(13, TriTempleButton.Location.Y + 20);
					LittleIslandButton.Location = new Point(13, LostCaveButton.Location.Y + 20);
					StoneTempleLvLButton.Location = new Point(13, LittleIslandButton.Location.Y + 20);
						StoneTempleLvLButton1.Location = new Point(33, StoneTempleLvLButton.Location.Y + 20);
						StoneTempleLvLButton2.Location = new Point(33, StoneTempleLvLButton1.Location.Y + 20);
						StoneTempleLvLButton3.Location = new Point(33, StoneTempleLvLButton2.Location.Y + 20);
					CursedLandButton.Location = new Point(13, StoneTempleLvLButton3.Location.Y + 20);
					break;
				case 9:
					OmaCaveLvLButton.Location = new Point(13, LevelingButton1.Location.Y + 20);
					PastBichonButton.Location = new Point(13, OmaCaveLvLButton.Location.Y + 20);
					ChaosTempleLvLButton.Location = new Point(13, PastBichonButton.Location.Y + 20);
					PainCavernButton.Location = new Point(13, ChaosTempleLvLButton.Location.Y + 20);
					TriTempleButton.Location = new Point(13, PainCavernButton.Location.Y + 20);
					LostCaveButton.Location = new Point(13, TriTempleButton.Location.Y + 20);
					LittleIslandButton.Location = new Point(13, LostCaveButton.Location.Y + 20);
					StoneTempleLvLButton.Location = new Point(13, LittleIslandButton.Location.Y + 20);
					CursedLandButton.Location = new Point(13, StoneTempleLvLButton.Location.Y + 20);
						CursedLandButton1.Location = new Point(33, CursedLandButton.Location.Y + 20);
						CursedLandButton2.Location = new Point(33, CursedLandButton1.Location.Y + 20);
						CursedLandButton3.Location = new Point(33, CursedLandButton2.Location.Y + 20);
					break;
			}
		}

		public void ResetTabs()  //reset iamges
		{
			OmaCaveLvLButton.Index = 27;
			OmaCaveLvLButton1.Index = 27;
			OmaCaveLvLButton2.Index = 27;
			OmaCaveLvLButton3.Index = 27;
			PastBichonButton.Index = 27;
			PastBichonButton1.Index = 27;
			PastBichonButton2.Index = 27;
			PastBichonButton3.Index = 27;
			ChaosTempleLvLButton.Index = 27;
			ChaosTempleLvLButton1.Index = 27;
			ChaosTempleLvLButton2.Index = 27;
			ChaosTempleLvLButton3.Index = 27;
			PainCavernButton.Index = 27;
			PainCavernButton1.Index = 27;
			PainCavernButton2.Index = 27;
			PainCavernButton3.Index = 27;
			TriTempleButton.Index = 27;
			TriTempleButton1.Index = 27;
			TriTempleButton2.Index = 27;
			TriTempleButton3.Index = 27;
			LostCaveButton.Index = 27;
			LostCaveButton1.Index = 27;
			LostCaveButton2.Index = 27;
			LostCaveButton3.Index = 27;
			LittleIslandButton.Index = 27;
			LittleIslandButton1.Index = 27;
			LittleIslandButton2.Index = 27;
			LittleIslandButton3.Index = 27;
			StoneTempleLvLButton.Index = 27;
			StoneTempleLvLButton1.Index = 27;
			StoneTempleLvLButton2.Index = 27;
			StoneTempleLvLButton3.Index = 27;
			CursedLandButton.Index = 27;
			CursedLandButton1.Index = 27;
			CursedLandButton2.Index = 27;
			CursedLandButton3.Index = 27;

			#region Hunt Buttons
			MapList1.Index = 27;
			MapList2.Index = 27;
			MapList3.Index = 27;
			MapList4.Index = 27;
			MapList5.Index = 27;
			MapList6.Index = 27;
			MapList7.Index = 27;
			MapList8.Index = 27;
			MapList9.Index = 27;
			MapList10.Index = 27;
			MapList11.Index = 27;
			MapList12.Index = 27;
			MapList13.Index = 27;
			MapList14.Index = 27;
			MapList15.Index = 27;
			MapList16.Index = 27;
			MapList17.Index = 27;
			MapList18.Index = 27;
			MapList19.Index = 27;
			MapList20.Index = 27;
			MapList21.Index = 27;
			MapList22.Index = 27;
			MapList23.Index = 27;
			MapList24.Index = 27;
			MapList25.Index = 27;
			MapList26.Index = 27;
			MapList27.Index = 27;
			MapList28.Index = 27;
			MapList29.Index = 27;
			MapList30.Index = 27;
			MapList31.Index = 27;
			MapList32.Index = 27;
			MapList33.Index = 27;
			MapList34.Index = 27;
			MapList35.Index = 27;
			MapList36.Index = 27;
			MapList37.Index = 27;
			MapList38.Index = 27;
			MapList39.Index = 27;
			MapList40.Index = 27;
			MapList41.Index = 27;
			MapList42.Index = 27;
			MapList43.Index = 27;
			MapList44.Index = 27;
			MapList45.Index = 27;
			MapList46.Index = 27;
			MapList47.Index = 27;
			MapList48.Index = 27;
            #endregion

			#region Battle Button Index
			ParaLordButton.Index = 27;
			MirKingButton.Index = 27;
			CrystalKingButton.Index = 27;
			OmaKingSpiritButton.Index = 27;
			DarkOmaKingButton.Index = 27;
			BloodKingButton.Index = 27;
			EvilMirButton.Index = 27;
			HellKingButton.Index = 27;
			#endregion

			BlackDragonDungeonButton.Index = 27;
			DomainOfAnquishButton.Index = 27;
			RedDragonDungeonButton.Index = 27;
			ZephyrTempleButton.Index = 27;
			OldSkoolTempleButton.Index = 27;

			LastManStandingButton.Index = 88;
			ChallengeButton.Index = 88;
			InstanceButton.Index = 88;
			SabukWallButton.Index = 88;
			BossLandButton.Index = 88;
		}
        public void TeleportButtonsHide()
		{
            #region INFO
            dungeonNameLabel.Visible = true;
			informationLabel.Visible = true;
			suggestedLevelLabel.Visible = true;
			suggestedLevel.Visible = true;
			goldlabel.Visible = true;
			gold.Visible = true;
			informationArea.Visible = true;
			dropLabel.Visible = true;
			drop01.Visible = true;
			drop02.Visible = true;
			drop03.Visible = true;
			drop04.Visible = true;
			drop05.Visible = true;
			#endregion

			#region Hunt Buttons
			OmaCaveTeleport.Visible = false;
			ZombieCaveTeleport.Visible = false;
			SerpentCaveTeleport.Visible = false;
			InsectCaveTeleport.Visible = false;
			BugCaveTeleport.Visible = false;
			StoneTempleTeleport.Visible = false;
			ZumaTempleTeleport.Visible = false;
			WoomaTempleTeleport.Visible = false;
			PrajnaCaveTeleport.Visible = false;
			PrajnaTempleTeleport.Visible = false;
			SpiderCaveTeleport.Visible = false;
			FrozenTempleTeleport.Visible = false;
			SwampCaveTeleport.Visible = false;
			NumaTempleTeleport.Visible = false;
			TrollTempleTeleport.Visible = false;
			DemonTempleTeleport.Visible = false;
			AngelTempleTeleport.Visible = false;
			HellCaveTeleport.Visible = false;
			FoxCaveTeleport.Visible = false;
			OrcTempleTeleport.Visible = false;
			EvilCaveTeleport.Visible = false;
			LizardCaveTeleport.Visible = false;
			SunkenCaveTeleport.Visible = false;
			KnightTempleTeleport.Visible = false;
			HavokTempleTeleport.Visible = false;
			SkullCaveTeleport.Visible = false;
			LostTempleTeleport.Visible = false;
			IceTempleTeleport.Visible = false;
			ForgottenTempleTeleport.Visible = false;
			TurtleLairTeleport.Visible = false;
			CaveOfNicanorTeleport.Visible = false;
			CaveOfTroubleTeleport.Visible = false;
			GardenOfDeathTeleport.Visible = false;
			CaveOfHorrorTeleport.Visible = false;
			CaveOfDespairTeleport.Visible = false;
			TempleOfHeroesTeleport.Visible = false;
			SacredTempleTeleport.Visible = false;
			DarkTempleTeleport.Visible = false;
			SealedCaveTeleport.Visible = false;
			MysticTempleTeleport.Visible = false;
			ShadowCaveTeleport.Visible = false;
			AncientTempleTeleport.Visible = false;
			CursedCaveTeleport.Visible = false;
			ChaosTempleTeleport.Visible = false;
			RockTempleTeleport.Visible = false;
			RampantTempleTeleport.Visible = false;
			PhantomTempleTeleport.Visible = false;
			HellishCaveTeleport.Visible = false;
            #endregion
            OmaCaveLvLTeleport.Visible = false;
			OmaCaveLvLTeleport1.Visible = false;
			OmaCaveLvLTeleport2.Visible = false;
			OmaCaveLvLTeleport3.Visible = false;
			PastBichonLvLTeleport.Visible = false;
			PastBichonLvLTeleport1.Visible = false;
			PastBichonLvLTeleport2.Visible = false;
			PastBichonLvLTeleport3.Visible = false;
			ChaosTempleLvLTeleport.Visible = false;
			ChaosTempleLvLTeleport1.Visible = false;
			ChaosTempleLvLTeleport2.Visible = false;
			ChaosTempleLvLTeleport3.Visible = false;
			PainCavernLvLTeleport.Visible = false;
			PainCavernLvLTeleport1.Visible = false;
			PainCavernLvLTeleport2.Visible = false;
			PainCavernLvLTeleport3.Visible = false;
			TriTempleLvLTeleport.Visible = false;
			TriTempleLvLTeleport1.Visible = false;
			TriTempleLvLTeleport2.Visible = false;
			TriTempleLvLTeleport3.Visible = false;
			LostCaveLvLTeleport.Visible = false;
			LostCaveLvLTeleport1.Visible = false;
			LostCaveLvLTeleport2.Visible = false;
			LostCaveLvLTeleport3.Visible = false;
			LittleIslandLvLTeleport.Visible = false;
			LittleIslandLvLTeleport1.Visible = false;
			LittleIslandLvLTeleport2.Visible = false;
			LittleIslandLvLTeleport3.Visible = false;
			StoneTempleLvLTeleport.Visible = false;
			StoneTempleLvLTeleport1.Visible = false;
			StoneTempleLvLTeleport2.Visible = false;
			StoneTempleLvLTeleport3.Visible = false;
			CursedLandLvLTeleport.Visible = false;
			CursedLandLvLTeleport1.Visible = false;
			CursedLandLvLTeleport2.Visible = false;
			CursedLandLvLTeleport3.Visible = false;
			#region Battle Teleport Name Visible
			ParaLordTeleport.Visible = false;
			MirKingTeleport.Visible = false;
			CrystalKingTeleport.Visible = false;
			OmaKingSpiritTeleport.Visible = false;
			DarkOmaKingTeleport.Visible = false;
			BloodKingTeleport.Visible = false;
			EvilMirTeleport.Visible = false;
			HellKingTeleport.Visible = false;
			#endregion

			BlackDragonDungeonTeleport.Visible = false;
			DomainOfAnquishTeleport.Visible = false;
			RedDragonDungeonTeleport.Visible = false;
			ZephyrTempleTeleport.Visible = false;
			OldSkoolTempleTeleport.Visible = false;

			LastManStandingTeleport.Visible = false;
			ChallengeTeleport.Visible = false;
			InstanceTeleport.Visible = false;
			SabukWallTeleport.Visible = false;
			BossLandTeleport.Visible = false;
		}
        public void HideInformation()
		{
            #region INFO
            dungeonNameLabel.Visible = false;
			informationLabel.Visible = false;
			suggestedLevelLabel.Visible = false;
			suggestedLevel.Visible = false;
			goldlabel.Visible = false;
			gold.Visible = false;
			informationArea.Visible = false;
			dropLabel.Visible = false;
			drop01.Visible = false;
			drop02.Visible = false;
			drop03.Visible = false;
			drop04.Visible = false;
			drop05.Visible = false;
			#endregion

			#region Hunt Buttons
			OmaCaveTeleport.Visible = false;
			ZombieCaveTeleport.Visible = false;
			SerpentCaveTeleport.Visible = false;
			InsectCaveTeleport.Visible = false;
			BugCaveTeleport.Visible = false;
			StoneTempleTeleport.Visible = false;
			ZumaTempleTeleport.Visible = false;
			WoomaTempleTeleport.Visible = false;
			PrajnaCaveTeleport.Visible = false;
			PrajnaTempleTeleport.Visible = false;
			SpiderCaveTeleport.Visible = false;
			FrozenTempleTeleport.Visible = false;
			SwampCaveTeleport.Visible = false;
			NumaTempleTeleport.Visible = false;
			TrollTempleTeleport.Visible = false;
			DemonTempleTeleport.Visible = false;
			AngelTempleTeleport.Visible = false;
			HellCaveTeleport.Visible = false;
			FoxCaveTeleport.Visible = false;
			OrcTempleTeleport.Visible = false;
			EvilCaveTeleport.Visible = false;
			LizardCaveTeleport.Visible = false;
			SunkenCaveTeleport.Visible = false;
			KnightTempleTeleport.Visible = false;
			HavokTempleTeleport.Visible = false;
			SkullCaveTeleport.Visible = false;
			LostTempleTeleport.Visible = false;
			IceTempleTeleport.Visible = false;
			ForgottenTempleTeleport.Visible = false;
			TurtleLairTeleport.Visible = false;
			CaveOfNicanorTeleport.Visible = false;
			CaveOfTroubleTeleport.Visible = false;
			GardenOfDeathTeleport.Visible = false;
			CaveOfHorrorTeleport.Visible = false;
			CaveOfDespairTeleport.Visible = false;
			TempleOfHeroesTeleport.Visible = false;
			SacredTempleTeleport.Visible = false;
			DarkTempleTeleport.Visible = false;
			SealedCaveTeleport.Visible = false;
			MysticTempleTeleport.Visible = false;
			ShadowCaveTeleport.Visible = false;
			AncientTempleTeleport.Visible = false;
			CursedCaveTeleport.Visible = false;
			ChaosTempleTeleport.Visible = false;
			RockTempleTeleport.Visible = false;
			RampantTempleTeleport.Visible = false;
			PhantomTempleTeleport.Visible = false;
			HellishCaveTeleport.Visible = false;
            #endregion
            OmaCaveLvLTeleport.Visible = false;
			OmaCaveLvLTeleport1.Visible = false;
			OmaCaveLvLTeleport2.Visible = false;
			OmaCaveLvLTeleport3.Visible = false;
			PastBichonLvLTeleport.Visible = false;
			PastBichonLvLTeleport1.Visible = false;
			PastBichonLvLTeleport2.Visible = false;
			PastBichonLvLTeleport3.Visible = false;
			ChaosTempleLvLTeleport.Visible = false;
			ChaosTempleLvLTeleport1.Visible = false;
			ChaosTempleLvLTeleport2.Visible = false;
			ChaosTempleLvLTeleport3.Visible = false;
			PainCavernLvLTeleport.Visible = false;
			PainCavernLvLTeleport1.Visible = false;
			PainCavernLvLTeleport2.Visible = false;
			PainCavernLvLTeleport3.Visible = false;
			TriTempleLvLTeleport.Visible = false;
			TriTempleLvLTeleport1.Visible = false;
			TriTempleLvLTeleport2.Visible = false;
			TriTempleLvLTeleport3.Visible = false;
			LostCaveLvLTeleport.Visible = false;
			LostCaveLvLTeleport1.Visible = false;
			LostCaveLvLTeleport2.Visible = false;
			LostCaveLvLTeleport3.Visible = false;
			LittleIslandLvLTeleport.Visible = false;
			LittleIslandLvLTeleport1.Visible = false;
			LittleIslandLvLTeleport2.Visible = false;
			LittleIslandLvLTeleport3.Visible = false;
			StoneTempleLvLTeleport.Visible = false;
			StoneTempleLvLTeleport1.Visible = false;
			StoneTempleLvLTeleport2.Visible = false;
			StoneTempleLvLTeleport3.Visible = false;
			CursedLandLvLTeleport.Visible = false;
			CursedLandLvLTeleport1.Visible = false;
			CursedLandLvLTeleport2.Visible = false;
			CursedLandLvLTeleport3.Visible = false;

			#region Hunt Buttons
			MapList1.Visible = false;
			MapList2.Visible = false;
			MapList3.Visible = false;
			MapList4.Visible = false;
			MapList5.Visible = false;
			MapList6.Visible = false;
			MapList7.Visible = false;
			MapList8.Visible = false;
			MapList9.Visible = false;
			MapList10.Visible = false;
			MapList11.Visible = false;
			MapList12.Visible = false;
			MapList13.Visible = false;
			MapList14.Visible = false;
			MapList15.Visible = false;
			MapList16.Visible = false;
			MapList17.Visible = false;
			MapList18.Visible = false;
			MapList19.Visible = false;
			MapList20.Visible = false;
			MapList21.Visible = false;
			MapList22.Visible = false;
			MapList23.Visible = false;
			MapList24.Visible = false;
			MapList25.Visible = false;
			MapList26.Visible = false;
			MapList27.Visible = false;
			MapList28.Visible = false;
			MapList29.Visible = false;
			MapList30.Visible = false;
			MapList31.Visible = false;
			MapList32.Visible = false;
			MapList33.Visible = false;
			MapList34.Visible = false;
			MapList35.Visible = false;
			MapList36.Visible = false;
			MapList37.Visible = false;
			MapList38.Visible = false;
			MapList39.Visible = false;
			MapList40.Visible = false;
			MapList41.Visible = false;
			MapList42.Visible = false;
			MapList43.Visible = false;
			MapList44.Visible = false;
			MapList45.Visible = false;
			MapList46.Visible = false;
			MapList47.Visible = false;
			MapList48.Visible = false;
            #endregion

			#region Battle Button Name Visible
			ParaLordButton.Visible = false;
			MirKingButton.Visible = false;
			CrystalKingButton.Visible = false;
			OmaKingSpiritButton.Visible = false;
			DarkOmaKingButton.Visible = false;
			BloodKingButton.Visible = false;
			EvilMirButton.Visible = false;
			HellKingButton.Visible = false;
			#endregion
			#region Battle Button Teleport Visible
			ParaLordTeleport.Visible = false;
			MirKingTeleport.Visible = false;
			CrystalKingTeleport.Visible = false;
			OmaKingSpiritTeleport.Visible = false;
			DarkOmaKingTeleport.Visible = false;
			BloodKingTeleport.Visible = false;
			EvilMirTeleport.Visible = false;
			HellKingTeleport.Visible = false;
			#endregion

			BlackDragonDungeonButton.Visible = false;
			DomainOfAnquishButton.Visible = false;
			RedDragonDungeonButton.Visible = false;
			ZephyrTempleButton.Visible = false;
			OldSkoolTempleButton.Visible = false;
			BlackDragonDungeonTeleport.Visible = false;
			DomainOfAnquishTeleport.Visible = false;
			RedDragonDungeonTeleport.Visible = false;
			ZephyrTempleTeleport.Visible = false;
			OldSkoolTempleTeleport.Visible = false;

			LastManStandingTeleport.Visible = false;
			ChallengeTeleport.Visible = false;
			InstanceTeleport.Visible = false;
			SabukWallTeleport.Visible = false;
			BossLandTeleport.Visible = false;

			OmaCaveLvLButton.Visible = false;
			OmaCaveLvLButton1.Visible = false;
			OmaCaveLvLButton2.Visible = false;
			OmaCaveLvLButton3.Visible = false;
			PastBichonButton.Visible = false;
			PastBichonButton1.Visible = false;
			PastBichonButton2.Visible = false;
			PastBichonButton3.Visible = false;
			ChaosTempleLvLButton.Visible = false;
			ChaosTempleLvLButton1.Visible = false;
			ChaosTempleLvLButton2.Visible = false;
			ChaosTempleLvLButton3.Visible = false;
			PainCavernButton.Visible = false;
			PainCavernButton1.Visible = false;
			PainCavernButton2.Visible = false;
			PainCavernButton3.Visible = false;
			TriTempleButton.Visible = false;
			TriTempleButton1.Visible = false;
			TriTempleButton2.Visible = false;
			TriTempleButton3.Visible = false;
			LostCaveButton.Visible = false;
			LostCaveButton1.Visible = false;
			LostCaveButton2.Visible = false;
			LostCaveButton3.Visible = false;
			LittleIslandButton.Visible = false;
			LittleIslandButton1.Visible = false;
			LittleIslandButton2.Visible = false;
			LittleIslandButton3.Visible = false;
			StoneTempleLvLButton.Visible = false;
			StoneTempleLvLButton1.Visible = false;
			StoneTempleLvLButton2.Visible = false;
			StoneTempleLvLButton3.Visible = false;
			CursedLandButton.Visible = false;
			CursedLandButton1.Visible = false;
			CursedLandButton2.Visible = false;
			CursedLandButton3.Visible = false;
		}
		public void SubHideInformation()
		{
			dungeonNameLabel.Visible = false;
			informationLabel.Visible = false;
			suggestedLevelLabel.Visible = false;
			suggestedLevel.Visible = false;
			goldlabel.Visible = false;
			gold.Visible = false;
			informationArea.Visible = false;
			dropLabel.Visible = false;
			drop01.Visible = false;
			drop02.Visible = false;
			drop03.Visible = false;
			drop04.Visible = false;
			drop05.Visible = false;
			OmaCaveLvLButton1.Visible = false;
			OmaCaveLvLButton2.Visible = false;
			OmaCaveLvLButton3.Visible = false;
			PastBichonButton1.Visible = false;
			PastBichonButton2.Visible = false;
			PastBichonButton3.Visible = false;
			ChaosTempleLvLButton1.Visible = false;
			ChaosTempleLvLButton2.Visible = false;
			ChaosTempleLvLButton3.Visible = false;
			PainCavernButton1.Visible = false;
			PainCavernButton2.Visible = false;
			PainCavernButton3.Visible = false;
			TriTempleButton1.Visible = false;
			TriTempleButton2.Visible = false;
			TriTempleButton3.Visible = false;
			LostCaveButton1.Visible = false;
			LostCaveButton2.Visible = false;
			LostCaveButton3.Visible = false;
			LittleIslandButton1.Visible = false;
			LittleIslandButton2.Visible = false;
			LittleIslandButton3.Visible = false;
			StoneTempleLvLButton1.Visible = false;
			StoneTempleLvLButton2.Visible = false;
			StoneTempleLvLButton3.Visible = false;
			CursedLandButton1.Visible = false;
			CursedLandButton2.Visible = false;
			CursedLandButton3.Visible = false;
		}
		public void Page(byte Page)
		{
			switch (Page)
			{
				case 0:
					pageLabel.Text = "0";
					GroupMapList1.Visible = true;
					MapList1.Visible = false;
					MapList2.Visible = false;
					MapList3.Visible = false;
					GroupMapList2.Visible = false;
					MapList4.Visible = false;
					MapList5.Visible = false;
					MapList6.Visible = false;
					break;
				case 1:
					pageLabel.Text = "1";
					GroupMapList1.Visible = false;
					MapList1.Visible = false;
					MapList2.Visible = false;
					MapList3.Visible = false;
					GroupMapList2.Visible = true;
					MapList4.Visible = false;
					MapList5.Visible = false;
					MapList6.Visible = false;
					break;
			}
		}
		public void Show()
		{
			Visible = true;
		}
		public void Hide()
		{
			Visible = false;
		}
	}
}
