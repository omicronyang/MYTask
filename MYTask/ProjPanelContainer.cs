using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace MYTask
{
    class ProjPanelContainer:Panel
    {
        public int ProjNum = 0;
        public int NowIndex = -1;
        public ProjPanel[] Pp = new ProjPanel[12];
        public List<MyProj> ProjList = new List<MyProj>();
        // ProjPanel size = 157,145
        

        public ProjPanelContainer()
        {
            BackColor = Color.RoyalBlue;
            Location = new Point(0, 0);
            Height = 0;
            Visible = true;
            for (int i = 0; i < 12; i++)
            {
                Pp[i] = new ProjPanel(3 + i % 4 * 160, 3 + i / 4 * 148);
                Pp[i].Visible = false;
                Controls.Add(Pp[i]);
                Controls.SetChildIndex(Pp[i], 0);
            }
        }

        
        public void AddProj(MyProj NewProj)
        {
            ProjList.Add(NewProj);
            if (ProjNum < 12)
            {
                ProjNum++;
                Pp[ProjNum - 1].UpdateProj(NewProj);
                Pp[ProjNum - 1].Visible = true;
            }
            else ProjNum++;
        }

        public void AddProj(MyProj[] NewProjList)
        {
            int oldnum = ProjNum;
            ProjNum += NewProjList.Length;
            ProjList.AddRange(NewProjList);

            if (ProjNum <= 12)
            {
                Height = 3 + ((ProjNum % 4 == 0) ? ProjNum / 4 : ProjNum / 4 + 1) * 148;
                for (int i = 0; i < ProjNum; i++)
                {
                    Pp[i].UpdateProj(ProjList[i]);
                    Pp[i].Visible = true;
                }
            }
            else
            {
                Height = 447;
                if (oldnum <12)
                    for (int i = oldnum; i < 12; i++)
                    {
                        Pp[i].UpdateProj(ProjList[i]);
                        Pp[i].Visible = true;
                    }
            }
            if (NowIndex < 0) NowIndex = 0;
        }

        public void ClearProj()
        {
            for (int i = 0; i < 12; i++)
                Pp[i].Visible = false;
            Height = 0;
            ProjNum = 0;
            ProjList.Clear();
            NowIndex = -1;
        }

        public void PageDown()
        {
            if (NowIndex + 12 > ProjNum - 1) return;
            NowIndex += 12;
            RenewProjPage();
        }
        public void PageUp()
        {
            if (NowIndex < 12) return;
            NowIndex -= 12;
            RenewProjPage();
        }

        private void RenewProjPage()
        {
            if (ProjNum-NowIndex >= 12)
            {
                for (int i = NowIndex; i < NowIndex + 12; i++)
                {
                    Pp[i - NowIndex].UpdateProj(ProjList[i]);
                    Pp[i - NowIndex].Visible = true;
                }
                Height = 447;
            } 
            else
            {
                for (int i = NowIndex; i < ProjNum; i++)
                    Pp[i - NowIndex].UpdateProj(ProjList[i]);
                for (int i = 12 - ProjNum; i < 12; i++)
                    Pp[i].Visible = false;

                int HeightNum = ProjNum - NowIndex;
                Height = 3 + ((HeightNum % 4 == 0) ? HeightNum / 4 : HeightNum / 4 + 1) * 148;
            }
        }

        public void RenewProjPage(int Index)
        {
            NowIndex = Index;
            RenewProjPage();
        }
    }
}
