using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;



namespace L6B2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hethong _hethong = new Hethong();
            Nguoigui _nguoigui1 = new Nguoigui("Thang");
            Nguoigui _nguoigui2 = new Nguoigui("Ngoc");

            _hethong.DangkyThamgia(_nguoigui1);
            _hethong.DangkyThamgia(_nguoigui2);

            _nguoigui1.GuiTinNhan("112");
            _nguoigui2.GuiTinNhan("112");
            _nguoigui1.GuiTinNhan("112");
            _nguoigui2.GuiTinNhan("113");
            _nguoigui1.GuiTinNhan("114");
            _nguoigui2.GuiTinNhan("117");
            _nguoigui1.GuiTinNhan("142");
            _nguoigui2.GuiTinNhan("111");
            _nguoigui1.GuiTinNhan("116");
            _nguoigui1.GuiTinNhan("115");

            Console.ReadLine();
            
        }
    }
}
