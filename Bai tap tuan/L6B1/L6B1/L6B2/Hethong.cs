using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L6B2
{
    class Hethong
    {
        private string SoTrungThuong = "111";

        public Hethong()
        {
            
        }
        public void DangkyThamgia(Nguoigui _nguoigui)
        {
            _nguoigui.SukienGuiTin += new Nguoigui.XulyGuiTin(_nguoigui_SukienGuiTin);
        }

        void _nguoigui_SukienGuiTin(Nguoigui _nguoigui, string s)
        {
            if (s == SoTrungThuong)
            {
                Console.WriteLine("Chuc mung ban {0} da trung thuong voi ma {1}", _nguoigui.Ten,s);
            }
            else
            {
                Console.WriteLine("Chuc ban {0} may man trong lan sau!", _nguoigui.Ten);
            }
        }

    }
}
