using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria;
using System.Windows.Forms;
using Terraria.UI;
using Terraria.GameContent.UI.Elements;
using Microsoft.Xna.Framework;
using Terraria.Graphics;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.ID;
using BannerCollector.Tiles;

namespace BannerCollector
{
    internal class BannerUISystem : ModSystem
    {
        public static BannerUISystem Instance { get; private set; }
        internal BannerUI bannerUI;
        internal UserInterface BannerInterface;

        public override void Load()
        {
            Instance = this;
            if (!Main.dedServ)
            {
                Main.instance.LoadTiles(91);
                bannerUI = new BannerUI();
                bannerUI.Activate();

                BannerInterface = new UserInterface();
                BannerInterface.SetState(bannerUI);

            }
        }

        public override void OnWorldLoad()
        {
            if (!Main.dedServ)
            {
                BannerLoad.ModList.Clear();
                BannerLoad.ModBannerTexture.Clear();
                // 특정 모드가 활성화되어 있는지 확인
                if (ModLoader.HasMod("CalamityMod"))
                {
                    BannerLoad.ModList.Add("CalamityMod");
                    BannerLoad.isModded = true;
                    Mod calamity = ModLoader.GetMod("CalamityMod");
                    Asset<Texture2D> bannerTexture = calamity.Assets.Request<Texture2D>("Tiles/MonsterBanner");
                    BannerLoad.ModBannerTexture.Add("CalamityMod", bannerTexture);
                }

                BannerLoad.LoadBanners();
                PlayerAssist.LoadPlayerBannerData();
                bannerUI.InitializePage();
                bannerUI.bannerList = BannerLoad.BannerDict.Values.ToList(); //딕셔너리 리스트로 복사.
                bannerUI.SetFirstPage();
                bannerUI.ButtonModSetDefault(); //모드 켜져있으면 나오는 모드 필터 버튼 초기화

            }
        }

        public override void OnWorldUnload()
        {
            // 모든 BannerBuffTile 제거
            for (int x = 0; x < Main.maxTilesX; x++)
            {
                for (int y = 0; y < Main.maxTilesY; y++)
                {
                    if (Main.tile[x, y].TileType == ModContent.TileType<BannerBuffTile>())
                    {
                        // 이펙트 없이 타일 제거
                        WorldGen.KillTile(x, y, false, false, false);
                    }
                }
            }
            PlayerAssist.SavePlayerBannerData();
        }

        public override void PreSaveAndQuit()
        {
            // 모든 BannerBuffTile 제거
            for (int x = 0; x < Main.maxTilesX; x++)
            {
                for (int y = 0; y < Main.maxTilesY; y++)
                {
                    if (Main.tile[x, y].TileType == ModContent.TileType<BannerBuffTile>())
                    {
                        // 이펙트 없이 타일 제거
                        WorldGen.KillTile(x, y, false, false, false);
                    }
                }
            }
        }

        public void ShowBannerCollection(bool show)
        {
            bannerUI.ShowBannerCollection(show);
        }

        public override void Unload()
        {
            BannerInterface = null;
        }
        public override void UpdateUI(GameTime gameTime)
        {
            BannerInterface?.Update(gameTime);
        }

        public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
        {
            int mouseTextIndex = layers.FindIndex(layer => layer.Name.Equals("Vanilla: Mouse Text"));

            if (mouseTextIndex != -1)
            {
                layers.Insert(mouseTextIndex, new LegacyGameInterfaceLayer("BannerCollector: Banner UI",
                     delegate {
                         BannerInterface.Draw(Main.spriteBatch, new GameTime());
                         return true;
                     },
                     InterfaceScaleType.UI)
                 );
            }
        }
    }
}
