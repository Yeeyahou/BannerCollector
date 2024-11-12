using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.UI;
using BannerCollector.Resources;
using System.Windows.Forms;
using rail;
using Microsoft.Xna.Framework;
using Terraria.ModLoader.UI;
using Terraria;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Audio;
using Terraria.ID;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace BannerCollector
{
    class BannerUI : UIState
    {
        BannerButton bannerButton;
        BannerPanel bannerPanel;
        ButtonLeft buttonLeft;
        ButtonRight buttonRight;
        ButtonSort buttonSort;
        ButtonFilter buttonFilter;
        ButtonFilterMode buttonFilterMode;
        ButtonFilterMod buttonFilterMod;
        ButtonClose buttonClose;
        BannerSlot[] bannerSlot;
        ButtonPage[] buttonPage;
        public List<BannerInfo> bannerList;

        private int page = 1;
        private int totalPages = 0;

        private bool bannerCollectorVisible;
        private bool Sorting = false;
        private int filter = 0; //0: 전체, 1: 보유함. 2:미보유
        private int filterMode = 0; //0: 전체, 1: 하드모드 이전. 2:하드모드
        private int filterMod = 0; //0: 모든 모드, 1~모드목록
        public void SetFirstPage()
        {
            page = 1;
            buttonPage[0].SetPage();
            for (int i = 1; i < totalPages; i++)
            {
                buttonPage[i].UnSetPage();
            }
        }

        public bool BannerCollectorVisible
        {
            get => bannerCollectorVisible;
            set
            {
                if (value)
                {
                    float pX, pY, pW, pH; //UI의 가로 세로 너비 높이

                    bannerButton.hoverText = "Banner Collection Opened";
                    Append(bannerPanel);
                    Append(buttonLeft);
                    Append(buttonRight);
                    Append(buttonSort);
                    Append(buttonFilter);
                    Append(buttonFilterMode);
                    if (BannerLoad.isModded)
                    {
                        Append(buttonFilterMod);
                    }
                    Append(buttonClose);

                    pX = bannerPanel.GetDimensions().X;
                    pY = bannerPanel.GetDimensions().Y;
                    pW = bannerPanel.GetDimensions().Width;
                    pH = bannerPanel.GetDimensions().Height;

                    buttonLeft.Left.Set(pX + 9f, 0f);
                    buttonLeft.Top.Set(pY + 82f, 0f);
                    buttonRight.Left.Set(pX + pW - 27f, 0f);
                    buttonRight.Top.Set(pY + 82f, 0f);
                    buttonSort.Left.Set(pX + 43, 0f);
                    buttonSort.Top.Set(pY + 14, 0f);
                    buttonFilter.Left.Set(pX + 73, 0f);
                    buttonFilter.Top.Set(pY + 14, 0f);
                    buttonFilterMode.Left.Set(pX + 103, 0f);
                    buttonFilterMode.Top.Set(pY + 14, 0f);
                    buttonFilterMod.Left.Set(pX + 133, 0f);
                    buttonFilterMod.Top.Set(pY + 14, 0f);
                    buttonClose.Left.Set(pX + pW - 63, 0f);
                    buttonClose.Top.Set(pY + 14, 0f);

                    int pageWidth = 16 * totalPages;
                    for (int i = 0; i < totalPages; i++)
                    {
                        buttonPage[i].Top.Set(pY + 176, 0f);
                        buttonPage[i].Left.Set((pW - pageWidth) / 2 + i * 16 + pX, 0f);
                        Append(buttonPage[i]);
                    }

                    AppendBannerSlot(pX, pY);
                    PageLoad();
                }
                else
                {
                    bannerButton.hoverText = "Banner Collection Closed";
                    RemoveChild(bannerPanel);
                    RemoveChild(buttonLeft);
                    RemoveChild(buttonRight);
                    RemoveChild(buttonSort);
                    RemoveChild(buttonFilter);
                    RemoveChild(buttonFilterMode);
                    if (BannerLoad.isModded)
                    {
                        RemoveChild(buttonFilterMod);
                    }
                    RemoveChild(buttonClose);

                    for (int i = 0; i < totalPages; i++)
                    {
                        RemoveChild(buttonPage[i]);
                    }
                    for (int i = 0; i < 20; i++)
                    {
                        RemoveChild(bannerSlot[i]);
                    }
                }
                bannerCollectorVisible = value;
            }
        }

        private void PageLoad()
        {
            if (totalPages == 1 || totalPages == 0)
            {
                RemoveChild(buttonLeft);
                RemoveChild(buttonRight);

            }
            else if (page == 1)
            {
                RemoveChild(buttonLeft);
                Append(buttonRight);

            }
            else if (page == totalPages)
            {
                Append(buttonLeft);
                RemoveChild(buttonRight);
            }
            else
            {
                Append(buttonLeft);
                Append(buttonRight);
            }

            for (int i = 0; i < 20; i++)
            {
                if (i + 20 * (page - 1) >= bannerList.Count)
                {
                    RemoveChild(bannerSlot[i]);
                }
                else
                {
                    Append(bannerSlot[i]);
                    bannerSlot[i].SetBannerInfo(bannerList[i + 20 * (page - 1)]);
                }
            }
        }

        private void AppendBannerSlot(float pX, float pY)
        {
            for (int i = 0; i < 10; i++)
            {
                bannerSlot[i].Left.Set(pX + 47 + (i * 35), 0f);
                bannerSlot[i].Top.Set(pY + 51, 0f);

                bannerSlot[i + 10].Left.Set(pX + 47 + (i * 35), 0f);
                bannerSlot[i + 10].Top.Set(pY + 115, 0f);

                Append(bannerSlot[i]);
                Append(bannerSlot[i + 10]);
            }
        }

        private void SortFilterList()
        {
            bannerList = BannerLoad.BannerDict.Values.ToList();

            //페이지 변경
            for (int i = 0; i < totalPages; i++)
            {
                RemoveChild(buttonPage[i]);
            }

            //정렬
            if (Sorting)
            {
                if (filter == 2) //많은순으로 정렬은 미보유 필터 끄기
                {
                    buttonFilter.ChangeState(0);
                    filter = 0;
                    SortFilterList();
                }
                bannerList = bannerList.OrderByDescending(b => b.BannerCount).ToList();
            }

            switch (filter)
            {
                case 0: //전체
                    break;
                case 1: //보유
                    bannerList.RemoveAll(banner => banner.BannerCount == 0);
                    break;
                case 2: //미보유
                    bannerList.RemoveAll(banner => banner.BannerCount > 0);
                    break;
            }

            switch (filterMode)
            {
                case 0: //전체
                    break;
                case 1: //하드모드 이전
                    bannerList.RemoveAll(banner => banner.IsHardMode == true);
                    break;
                case 2: //하드모드
                    bannerList.RemoveAll(banner => banner.IsHardMode == false);
                    break;
            }

            if (BannerLoad.isModded)
            {
                if (filterMod == 0) { }
                else
                {
                    bannerList.RemoveAll(banner => banner.ModName != BannerLoad.ModList[filterMod - 1]);
                }
            }

            totalPages = (int)Math.Ceiling((double)bannerList.Count / 20);
            int pageWidth = 16 * totalPages;
            float pX = bannerPanel.GetDimensions().X;
            float pY = bannerPanel.GetDimensions().Y;
            float pW = bannerPanel.GetDimensions().Width;
            for (int i = 0; i < totalPages; i++)
            {
                buttonPage[i].Top.Set(pY + 176, 0f);
                buttonPage[i].Left.Set((pW - pageWidth) / 2 + i * 16 + pX, 0f);
                Append(buttonPage[i]);
            }
            buttonPage[page - 1].UnSetPage();
            buttonPage[0].SetPage();
            page = 1;
            PageLoad();
        }
        public void InitializePage()
        {
            totalPages = (int)Math.Ceiling((double)BannerLoad.BannerDict.Count / 20);
            buttonPage = new ButtonPage[totalPages]; //Y촤표 176 간격 16픽셀씩
            for (int i = 0; i < totalPages; i++)
            {
                int index = i;
                buttonPage[index] = new ButtonPage();
                buttonPage[index].thisPage = index + 1;
                buttonPage[index].OnLeftClick += (evt, listeningElement) => ButtonPageClicked(evt, listeningElement, index);
            }
            buttonPage[page - 1].SetPage();

        }
        public override void OnInitialize()
        {
            BannerCollectorResources.PreloadAssets();

            //UI로드
            bannerButton = new BannerButton(BannerCollectorResources.Button_Banner);
            bannerButton.Left.Set(0f, 0f);
            bannerButton.Top.Set(232f, 0f);
            bannerButton.OnLeftClick += BannerButtonClicked;

            bannerPanel = new BannerPanel();
            bannerPanel.Top.Set(258, 0f);
            bannerPanel.Left.Set(20f, 0f);
            bannerPanel.OnLeftClick += BannerPanelLeftClicked;

            //패널의 UI들은 bannerCollecterVisible에서 좌표 정함.
            buttonLeft = new ButtonLeft();
            buttonLeft.OnLeftClick += ButtonLeftClicked;
            buttonLeft.OnMouseOver += ButtonMouseOver;
            buttonRight = new ButtonRight();
            buttonRight.OnLeftClick += ButtonRightClicked;
            buttonRight.OnMouseOver += ButtonMouseOver;
            buttonSort = new ButtonSort();
            buttonSort.OnLeftClick += ButtonSortClicked;
            buttonSort.OnMouseOver += ButtonMouseOver;
            buttonFilter = new ButtonFilter();
            buttonFilter.OnLeftClick += ButtonFilterClicked;
            buttonFilter.OnRightClick += ButtonFilterRightClicked;
            buttonFilter.OnMouseOver += ButtonMouseOver;
            buttonFilterMode = new ButtonFilterMode();
            buttonFilterMode.OnLeftClick += ButtonFilterModeClicked;
            buttonFilterMode.OnRightClick += ButtonFilterModeRightClicked;
            buttonFilterMode.OnMouseOver += ButtonMouseOver;
            buttonFilterMod = new ButtonFilterMod();
            buttonFilterMod.OnLeftClick += ButtonFilterModClicked;
            buttonFilterMod.OnRightClick += ButtonFilterModRightClicked;
            buttonFilterMod.OnMouseOver += ButtonMouseOver;
            buttonClose = new ButtonClose();
            buttonClose.OnLeftClick += ButtonCloseClicked;
            buttonClose.OnMouseOver += ButtonMouseOver;

            
            bannerSlot = new BannerSlot[20];
            for (int i = 0; i < 20; i++)
            {
                int index = i;
                bannerSlot[index] = new BannerSlot();
                bannerSlot[index].OnLeftMouseDown += (evt, listeningElement) => BannerSlotLeftMouseDown(evt, listeningElement, index); //슬롯 전체 아이템 마우스에 올리기
                bannerSlot[index].OnRightMouseDown += (evt, listeningElement) => BannerSlotRightMouseDown(evt, listeningElement, index); //슬롯 아이템 1개씩 올리기
                bannerSlot[index].OnRightMouseUp += BannerSlotRightMouseUp;
                bannerSlot[index].OnMouseOut += BannerSlotMouseOut;
            }
        }
        public void ButtonModSetDefault()
        {
            buttonFilterMod.SetDefault();
        }
        
        public override void Update(GameTime gameTime)
        {
            this.AddOrRemoveChild(bannerButton, Main.playerInventory);
            if (Main.playerInventory == false)
            {
                BannerCollectorVisible = false;
            }
            base.Update(gameTime);
        }

        #region 이벤트 관련 메서드
        private void ButtonFilterModClicked(UIMouseEvent evt, UIElement listeningElement)
        {
            buttonFilterMod.ChangeState((buttonFilterMod.filterIndex + 1) % buttonFilterMod.modNum);
            filterMod = buttonFilterMod.filterIndex;
            SortFilterList();
        }

        private void ButtonFilterModRightClicked(UIMouseEvent evt, UIElement listeningElement)
        {
            buttonFilterMod.ChangeState((buttonFilterMod.filterIndex + buttonFilterMod.modNum -1) % buttonFilterMod.modNum);
            filterMod = buttonFilterMod.filterIndex;
            SortFilterList();
        }

        private void ButtonMouseOver(UIMouseEvent evt, UIElement listeningElement)
        {
            SoundEngine.PlaySound(SoundID.MenuTick);
        }
        private void ButtonCloseClicked(UIMouseEvent evt, UIElement listeningElement)
        {
            BannerCollectorVisible = false;
        }
        private void ButtonFilterModeClicked(UIMouseEvent evt, UIElement listeningElement)
        {
            buttonFilterMode.ChangeState((buttonFilterMode.filterIndex + 1) % 3);
            filterMode = buttonFilterMode.filterIndex;
            SortFilterList();
        }
        private void ButtonFilterModeRightClicked(UIMouseEvent evt, UIElement listeningElement)
        {
            buttonFilterMode.ChangeState((buttonFilterMode.filterIndex + 2) % 3);
            filterMode = buttonFilterMode.filterIndex;
            SortFilterList();
        }

        private void ButtonFilterClicked(UIMouseEvent evt, UIElement listeningElement)
        {
            buttonFilter.ChangeState((buttonFilter.filterIndex + 1) % 3);
            filter = buttonFilter.filterIndex;
            SortFilterList();
        }

        private void ButtonFilterRightClicked(UIMouseEvent evt, UIElement listeningElement)
        {
            buttonFilter.ChangeState((buttonFilter.filterIndex + 2) % 3);
            filter = buttonFilter.filterIndex;
            SortFilterList();
        }


        private void ButtonSortClicked(UIMouseEvent evt, UIElement listeningElement)
        {
            if (Sorting)
            {
                Sorting = false;
                buttonSort.hoverText = buttonSort.sortingText1;
            }
            else
            {
                Sorting = true;
                buttonSort.hoverText = buttonSort.sortingText2;

            }
            SortFilterList();
        }

        private void ButtonPageClicked(UIMouseEvent evt, UIElement listeningElement, int i)
        {
            buttonPage[page - 1].UnSetPage();
            buttonPage[i].SetPage();
            page = i + 1;
            PageLoad();
        }

        private void MouseItemToSlot()
        {
            if (BannerLoad.BannerDict.ContainsKey(Main.mouseItem.type))
            {
                SoundEngine.PlaySound(SoundID.Grab);
                if (BannerLoad.BannerDict[Main.mouseItem.type].BannerCount >= 9999)
                {
                    //Main.NewText(1);
                    BannerLoad.BannerDict[Main.mouseItem.type].BannerCount = Main.mouseItem.stack;
                    Main.mouseItem.stack = 9999;

                }
                else if (BannerLoad.BannerDict[Main.mouseItem.type].BannerCount + Main.mouseItem.stack > 9999)
                {
                    //Main.NewText(2);
                    Main.mouseItem.stack = BannerLoad.BannerDict[Main.mouseItem.type].BannerCount + Main.mouseItem.stack - 9999;
                    BannerLoad.BannerDict[Main.mouseItem.type].BannerCount = 9999;
                }
                else
                {
                    BannerLoad.BannerDict[Main.mouseItem.type].BannerCount += Main.mouseItem.stack;
                    Main.mouseItem.stack = 0;
                }
                //bannerList = BannerLoad.BannerDict.Values.ToList();
            }
        }
        private void BannerSlotLeftMouseDown(UIMouseEvent evt, UIElement listeningElement, int i)
        {
            //마우스에 아이템을 들고있을 경우
            if (Main.mouseItem.stack > 0)
            {
                MouseItemToSlot();
            }
            else
            { //배너 슬롯에서 꺼내기
                if (bannerSlot[i].bannerInfo.BannerCount > 0)
                {
                    SoundEngine.PlaySound(SoundID.Grab);
                    Main.mouseItem = new Item(bannerSlot[i].bannerInfo.ItemId);
                    Main.mouseItem.stack = bannerSlot[i].bannerInfo.BannerCount;
                    BannerLoad.BannerDict[bannerSlot[i].bannerInfo.ItemId].BannerCount = 0;
                }
            }

        }

        private int clickDelay = 450; // 초기 지연 시간 (밀리초)
        private double currentDelay; // 현재 지연 시간
        private bool isRightMouseDown = false; // 우클릭 상태
        private int turn;

        // 아이템 쌓기 시작
        private void StartItemStacking(int i)
        {
            Task.Run(async () =>
            {
                while (isRightMouseDown)
                {
                    //슬롯에 아이템 없을경우
                    if (bannerSlot[i].bannerInfo.BannerCount <= 0)
                    {
                        return;
                    }
                    //슬롯과 들고있는 아이템이 다른경우
                    if (Main.mouseItem.type != bannerSlot[i].bannerInfo.ItemId && Main.mouseItem.type != ItemID.None)
                    {
                        return;
                    }
                    else
                    {
                        if (turn <= 10) SoundEngine.PlaySound(SoundID.MenuTick);
                        if (Main.mouseItem.stack == 0)
                            Main.mouseItem = new Item(bannerSlot[i].bannerInfo.ItemId);
                        else
                            Main.mouseItem.stack += 1;
                        BannerLoad.BannerDict[bannerSlot[i].bannerInfo.ItemId].BannerCount--;
                    }

                    // 지연 시간 조정
                    await Task.Delay((int)currentDelay);
                    turn++;
                    if (turn <= 10)
                    {
                        currentDelay = 70;
                    }
                    else if (turn > 10)
                    {
                        // 지연 시간 줄이기 (최소 지연 시간 설정 가능)
                        if (currentDelay > 1) // 예: 100ms 이하로는 줄이지 않음
                        {
                            currentDelay -= 0.5; // 지연 시간 감소
                        }
                    }
                }
            });
        }


        private void BannerSlotRightMouseDown(UIMouseEvent evt, UIElement listeningElement, int i)
        {
            isRightMouseDown = true;
            currentDelay = clickDelay; // 초기 지연 시간 설정
            turn = 1;
            StartItemStacking(i); // 아이템 쌓기 시작
        }
        private void BannerSlotRightMouseUp(UIMouseEvent evt, UIElement listeningElement)
        {
            isRightMouseDown = false;
        }
        private void BannerSlotMouseOut(UIMouseEvent evt, UIElement listeningElement)
        {
            isRightMouseDown = false;
        }
        private void BannerPanelLeftClicked(UIMouseEvent evt, UIElement listeningElement)
        {
            MouseItemToSlot();
        }

        private void BannerButtonClicked(UIMouseEvent evt, UIElement listeningElement)
        {
            if (bannerCollectorVisible == true)
            {
                BannerCollectorVisible = false;
            }
            else
            {
                BannerCollectorVisible = true;
            }

        }
        private void ButtonLeftClicked(UIMouseEvent evt, UIElement listeningElement)
        {
            buttonPage[(page--) - 1].UnSetPage();
            buttonPage[page - 1].SetPage();
            PageLoad();
        }

        private void ButtonRightClicked(UIMouseEvent evt, UIElement listeningElement)
        {
            buttonPage[(page++) - 1].UnSetPage();
            buttonPage[page - 1].SetPage();
            PageLoad();
        }
        #endregion
    }
}
