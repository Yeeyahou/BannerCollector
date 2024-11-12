using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace BannerCollector
{
    public class ItemAssist : GlobalItem
    {
        public override bool OnPickup(Item item, Player player)
        {
            if (BannerLoad.BannerDict.ContainsKey(item.type))
            {
                InventoryToCollection(player, item.type, item.stack);
                return true;
            }
            else { return true; }
        }
        public void InventoryToCollection(Player player, int itemType, int count)
        {
            Task.Run(async () =>
            {
                await Task.Delay(100);
                for (int i = 0; i < player.inventory.Length; i++)
                {
                    // 현재 아이템이 찾고자 하는 아이템인지 확인
                    if (player.inventory[i].type == itemType)
                    {
                        //배너 컬렉션에 배너 9999개면 안넣기
                        if (BannerLoad.BannerDict[itemType].BannerCount == 9999) { break; }

                        //먹은 아이템이 9999개를 초과해서 인벤토리아이템 스택이 먹은 아이템스텍보다 작은 경우
                        if (player.inventory[i].stack < count) { continue; }

                        //인벤토리 아이템과 컬렉션 아이템 스텍 합이 9999를 넘음
                        if (count + BannerLoad.BannerDict[itemType].BannerCount > 9999)
                        {
                            player.inventory[i].stack = count + BannerLoad.BannerDict[itemType].BannerCount - 9999;
                            BannerLoad.BannerDict[itemType].BannerCount = 9999;
                            break;
                        }
                        else
                        {
                            BannerLoad.BannerDict[itemType].BannerCount += count;
                            player.inventory[i].stack -= count;
                            if (player.inventory[i].stack == 0)
                                player.inventory[i].TurnToAir();
                            break;
                        }
                    }
                }
            });
        }
    }
}
