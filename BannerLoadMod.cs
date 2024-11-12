using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace BannerCollector
{
    internal static partial class BannerLoad
    {
        public static void LoadModBanners()
        {
            #region CalamityMod
            string modName = "CalamityMod";
            BannerInfo bannerInfo;
            if (ModList.Contains(modName))
            {
                Mod calamity = ModLoader.GetMod("CalamityMod");
                ModItem item;
                #region Slimes
                if (calamity.TryFind("EbonianBlightSlimeBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 88;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("CrimulanBlightSlimeBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 89;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("AeroSlimeBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 90;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                //HardMode
                if (calamity.TryFind("AstralSlimeBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 35;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("CryoSlimeBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 91;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("IrradiatedSlimeBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 97;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("InfernalCongealmentBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 93;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("PerennialSlimeBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 92;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("PestilentSlimeBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 79;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("BloomSlimeBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 94;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("GammaSlimeBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 122;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }
                #endregion

                #region Surface
                if (calamity.TryFind("PiggyBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 108;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("FearlessGoldfishWarriorBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 109;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("RotdogBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 53;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("WulfrumAmplifierBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 126;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("WulfrumDroneBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 52;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("WulfrumGyratorBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 123;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("WulfrumHovercraftBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 124;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("WulfrumRoverBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 125;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                #endregion

                #region Underground
                if (calamity.TryFind("AmethystCrawlerBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 66;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("SapphireCrawlerBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 68;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("TopazCrawlerBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 67;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                //HardMode
                if (calamity.TryFind("OverloadedSoldierBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 85;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }
                #endregion

                #region Cavern
                if (calamity.TryFind("DiamondCrawlerBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 71;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("EmeraldCrawlerBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 69;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("RubyCrawlerBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 70;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                //HardMode
                if (calamity.TryFind("EarthElementalBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 76;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("ArmoredDiggerBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 77;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                #endregion

                #region Desert
                if (calamity.TryFind("AmberCrawlerBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 72;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("CnidrionBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 63;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("StormlionBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 62;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                #endregion

                #region Sunken Sea
                if (calamity.TryFind("BabyGhostBellBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 102;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("SeaMinnowBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 105;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("ClamBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 99;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("EutrophicRayBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 100;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("GhostBellBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 101;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("PrismBackBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 98;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("SeaFloatyBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 103;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                //HardMode
                if (calamity.TryFind("BlindedAnglerBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 104;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("SeaSerpentBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 106;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                #endregion

                #region Ocean
                if (calamity.TryFind("BoxJellyfishBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 13;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("FrogfishBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 8;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("MorayEelBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 14;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("SeaUrchinBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 12;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                //HardMode
                if (calamity.TryFind("MantisShrimpBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 9;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }
                #endregion

                #region Snow
                if (calamity.TryFind("RimehoundBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 59;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                //HardMode
                if (calamity.TryFind("CryonBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 60;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("IceClasperBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 61;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                #endregion

                #region Jungle
                //HardMode
                if (calamity.TryFind("MelterBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 78;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("PlagueshellBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 80;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("PlagueChargerBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 81;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("VirulingBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 82;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }
                
                if (calamity.TryFind("PlaguebringerBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 83;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("BohldohrBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 87;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                #endregion

                #region Space
                if (calamity.TryFind("SunskaterBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 56;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                //HardMode
                if (calamity.TryFind("ShockstormShuttleBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 57;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("CloudElementalBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 58;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                #endregion

                #region Dungeon
                //HardMode
                if (calamity.TryFind("PhantomSpiritBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 84;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                #endregion

                #region The Hallow
                if (calamity.TryFind("CrystalCrawlerBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 73;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                //HardMode
                if (calamity.TryFind("ImpiousImmolatorBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 48;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("ProfanedEnergyBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 50;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("ScornEaterBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 49;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                #endregion

                #region Astral Infection
                //HardMode
                if (calamity.TryFind("AriesBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 34;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("AstralachneaBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 39;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("AstralProbeBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 31;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("AtlasBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 36;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("FusionFeederBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 42;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("HadarianBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 43;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("HiveBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 40;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("MantisBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 37;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("NovaBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 38;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("SightseerColliderBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 32;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("SightseerSpitterBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 33;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("StellarCulexBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 41;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                #endregion

                #region Brimstone Crag	
                if (calamity.TryFind("CalamityEyeBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 55;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("DespairStoneBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 46;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("HeatSpiritBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 44;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("ScryllarBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 45;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("SoulSlurperBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 47;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                //HardMode
                if (calamity.TryFind("RenegadeWarlockBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 95;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                #endregion

                #region Sulphurous Sea
                if (calamity.TryFind("BabyFlakCrabBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 119;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }
                
                if (calamity.TryFind("AquaticUrchinBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 7;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("GnasherBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 2;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("SulflounderBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 1;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("ToxicatfishBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 4;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("TrasherBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 3;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                //HardMode
                if (calamity.TryFind("AnthozoanCrabBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 120;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("BelchingCoralBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 121;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                #endregion

                #region Acid Rain
                if (calamity.TryFind("AcidEelBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 115;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("NuclearToadBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 116;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("RadiatorBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 110;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("SkyfinBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 113;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                //HardMode
                if (calamity.TryFind("FlakCrabBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 117;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("OrthoceraBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 112;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("SulphurousSkaterBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 118;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("TrilobiteBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 111;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                #endregion

                #region Abyss
                if (calamity.TryFind("BabyCannonballJellyfishBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 128;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("CannonballJellyfishBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 127;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("CuttlefishBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 16;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("LaserfishBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 21;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("LuminousCorvinaBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 19;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("OarfishBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 22;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("SlabCrabBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 5;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("ToxicMinnowBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 17;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("ViperfishBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 18;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                //HardMode
                if (calamity.TryFind("ChaoticPufferBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 30;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("DevilFishBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 15;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("EidolistBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 25;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("GiantSquidBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 20;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("GulperEelBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 26;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("MirageJellyBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 24;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("BloatfishBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 28;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("BobbitWormBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 29;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("ColossalSquidBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 23;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("ReaperSharkBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 96;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("EidolonWyrmJuvenileBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = true;
                    bannerInfo.Index = 27;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                #endregion

                #region EX
                if (calamity.TryFind("AndroombaBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 6;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                if (calamity.TryFind("RepairUnitBanner", out item))
                {
                    bannerInfo = new BannerInfo();
                    bannerInfo.ItemId = item.Type;
                    bannerInfo.ItemName = item.Name;
                    bannerInfo.BannerCount = 0;
                    bannerInfo.IsHardMode = false;
                    bannerInfo.Index = 0;
                    bannerInfo.ModName = modName;
                    BannerDict.Add(bannerInfo.ItemId, bannerInfo);
                }

                #endregion
            }
            #endregion
        }
    }
}
