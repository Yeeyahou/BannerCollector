using BannerCollector.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace BannerCollector
{
    internal class PlayerBuff : ModPlayer
    {
        private int tileUpdateTimer = 0; // 타일 업데이트를 위한 타이머
                                         // 
        public override void PreUpdate()
        {
            if (BannerCollectorConfig.Instance.EnableBannerBuff)
            {
                Player player = Main.LocalPlayer;
                tileUpdateTimer++;

                // 60 프레임마다 (1초에 한 번) 타일 업데이트
                if (tileUpdateTimer >= 30)
                {
                    tileUpdateTimer = 0; // 타이머 초기화
                    BannerBuffTile.UpdateTilePosition(player); // 타일 업데이트
                }
            }
        }
    }
}
