using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L6B1
{
    class Boys:Person
    {
        private Girl _partner = new Girl();
        public Girl Partner
        {
            set
            {
                _partner = value;
                _partner.AcceptEvent += new Girl.AcceptDelegate(_partner_AcceptEvent);
                _partner.AcceptOneBoyEvent += new Girl.AcceptDelegateOneBoy(_partner_AcceptOneBoyEvent);
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
                this.Say("STOP!");
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
