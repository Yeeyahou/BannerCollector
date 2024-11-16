using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace BannerCollector.Dusts
{
    internal class BuffTileDust : ModDust
    {
        public override void OnSpawn(Dust dust)
        {
            dust.alpha = 0; // 불투명도
            dust.scale = 1f;  // 크기
            dust.velocity *= 0.5f; // 초기 속도
        }

        public override bool Update(Dust dust)
        {
            return true;
        }
    }
}
