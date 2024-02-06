using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTuan04
{
    public class PhanSo
    {
        private int ts;
        private int ms;
        public PhanSo()
        {
            ts = 0;
            ms = 1;
        }
        public PhanSo(int ts, int ms)
        {
            this.ts = ts;
            this.ms = ms;
            this.Rutgon();
        }
        /// <summary>
        /// ví dụ "1/2"
        /// </summary>
        /// <param name="s"></param>
        public PhanSo(string s)
        {
            string[] xau = s.Split('/');
            ts = int.Parse(xau[0]);
            ms = int.Parse(xau[1]);
        }
        public void Nhap(int ts, int ms)
        {
            this.ts = ts;
            this.ms = ms;
            this.Rutgon();
        }
        /// <summary>
        /// Nhập một phân số
        /// </summary>
        /// <param name="s">ví dụ "1/2"</param>
        public static PhanSo Nhap(string s)
        {
            string[] xau = s.Split('/');
            return new PhanSo(int.Parse(xau[0]), int.Parse(xau[1]));
        }
        public static PhanSo Cong(PhanSo ps1, PhanSo ps2)
        {
            PhanSo _kq = new PhanSo();
            _kq.ts = ps1.ts * ps2.ms + ps2.ts + ps1.ms;
            _kq.ms = ps1.ms * ps2.ms;
            _kq.Rutgon();
            return _kq;
        }
        public static PhanSo operator+(PhanSo ps1, PhanSo ps2)
        {
            //PhanSo _kq = new PhanSo();
            //_kq = PhanSo.Cong(ps1, ps2);
            //return _kq;
            return PhanSo.Cong(ps1, ps2);
        }

        public static PhanSo operator+(PhanSo ps1, int ps2)
        {
            PhanSo _kq = ps1 + new PhanSo(ps2, 1);
            return _kq;
        }
        public PhanSo Cong(PhanSo ps)
        {
            PhanSo _kq = new PhanSo();
            _kq = this + ps;
            //_kq = Cong(this, ps);
            return _kq;
        }
        public PhanSo Rutgon()
        { 
            return this; 
        }
        public static PhanSo operator-(PhanSo ps)
        {
            PhanSo _kq = new PhanSo(-ps.ts,ps.ms);
            return _kq;
        }
        public static PhanSo operator-(PhanSo ps1, PhanSo ps2)
        {
            return ps1 + (-ps2);
        }
        public PhanSo Tru(PhanSo ps)
        {
            return this-ps;
        }
    }
}
