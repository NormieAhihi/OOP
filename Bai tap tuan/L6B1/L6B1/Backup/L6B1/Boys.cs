using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L6B1
{
    class Boys:Person
    {
        private Girls _partner = new Girls();
        public Girls Partner
        {
            set
            {
                _partner = value;
                _partner.AcceptEvent += new Girls.AcceptDelegate(_partner_AcceptEvent);
                _partner.AcceptOneBoyEvent += new Girls.AcceptDelegateOneBoy(_partner_AcceptOneBoyEvent);
            }
            get
            {
                return _partner;
            }
        }

        void _partner_AcceptOneBoyEvent(string s)
        {
            if (s == this.Name)
            {
                this.Say("Cuoi ngay!");
            }
            else
            {
                this.Say("Xin em dung lay no!");
            }
        }

        public Boys()
        {
        }
        public Boys(string i_name)
        {
            this.Name = i_name;
        }

        void _partner_AcceptEvent()
        {
            this.Say("Cuoi ngay!");
        }
    }
}
