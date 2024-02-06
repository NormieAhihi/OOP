using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L6B2
{
    class Nguoigui
    {
        public Nguoigui()
        {
        }
        public Nguoigui(string i_Ten)
        {
            _Ten = i_Ten;
        }
        private string _Ten;
        public string Ten
        {
            set
            {
                _Ten = value;
            }
            get
            {
                return _Ten;
            }
        }
        public delegate void XulyGuiTin(Nguoigui _nguoigui, string s);
        public event XulyGuiTin SukienGuiTin;
        public void GuiTinNhan(string _tinnhan)
        {
            if (SukienGuiTin != null)
            {
                SukienGuiTin(this,_tinnhan);
            }

        }
    }
}
