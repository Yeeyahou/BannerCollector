using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace BannerCollector.Tiles
{
    /// <summary>
    /// This is tile that only provide banner buffs User in game can't access this tile.
    /// </summary>
    internal class BannerBuffTile : ModTile
    {
        static List<BannerInfo> bannerListToBuff = new List<BannerInfo>();
        
        static int? preTileX;
        static int? preTileY;
        Mod calamity;
        ModNPC modNPC;
        public override void PostSetDefaults()
        {
            Main.tileSolid[Type] = false; // 견고한 블록이 아님
            Main.tileBlockLight[Type] = false; // 빛 차단
            Main.tileLighted[Type] = false; // 빛을 발산하지 않음
            Main.tileNoAttach[Type] = true; // 타일에 부착할 수 없음
            Main.tileCut[Type] = false; // 부술 수 없는 타일로 설정
        }

        public override void Load()
        {
            base.Load();
            
        }

        public override void NearbyEffects(int i, int j, bool closer)
        {
            if (BannerLoad.isModded)
            {
                if (BannerLoad.ModList.Contains("CalamityMod"))
                {
                    calamity = ModLoader.GetMod("CalamityMod");
                }
            }
            if (!BannerCollectorConfig.Instance.EnableBannerBuff)
            {
                Main.SceneMetrics.hasBanner = false;
                return;
            }
            else
            {
                int bannerIndex = 0;
                foreach (var banner in bannerListToBuff)
                {
                    if (banner.ModName == null)
                    { bannerIndex = banner.Index - 21; }
                    else if (banner.ModName == "CalamityMod")
                    {
                        if (calamity.TryFind(banner.ItemName.Replace("Banner",""), out modNPC))
                        {
                            bannerIndex = modNPC.Type;
                        }
                    }
                    Main.SceneMetrics.NPCBannerBuff[bannerIndex] = true;
                }
                Main.SceneMetrics.hasBanner = true;
            }
        }

        public static void UpdateTilePosition(Player player)
        {
            int tileX = (int)(player.position.X / 16);
            int tileY = (int)(player.position.Y / 16);
            //리스트 변경
            bannerListToBuff = BannerLoad.BannerDict.Values.ToList();
            bannerListToBuff.RemoveAll(banner => banner.BannerCount == 0);
            // 현재 위치에 아무런 타일이 없을 때만 배치
            if (Main.tile[tileX, tileY].TileType == 0)
            {
                if (preTileX != null && preTileY != null)
                {
                    bool tt = true;
                    bool ff = false;
                    TileLoader.GetTile(ModContent.TileType<BannerBuffTile>()).KillTile((int)preTileX, (int)preTileY, ref ff, ref ff, ref tt);
                    // 새로운 타일 배치
                    WorldGen.PlaceTile(tileX, tileY, ModContent.TileType<BannerBuffTile>(), true, true);
                    preTileX = tileX;
                    preTileY = tileY;
                }
                else
                {
                    WorldGen.PlaceTile(tileX, tileY, ModContent.TileType<BannerBuffTile>(), true, true);
                    preTileX = tileX;
                    preTileY = tileY;
                }
            }
        }
    }
}
