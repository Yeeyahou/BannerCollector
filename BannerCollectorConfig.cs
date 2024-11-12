using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader.Config;

namespace BannerCollector
{
    internal class BannerCollectorConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;
        [Label("Enable banner buffs in collection")]
        [DefaultValue(true)]
        public bool EnableBannerBuff { get; set; }

        // 정적 인스턴스
        public static BannerCollectorConfig Instance { get; private set; }

        // 인스턴스 초기화
        public override void OnLoaded()
        {
            Instance = this; // 설정이 로드될 때 인스턴스를 초기화
        }
    }
}
