using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L6B1
{
    class Girls:Person
    {
        public delegate void AcceptDelegate();
        public event AcceptDelegate AcceptEvent;

        public delegate void AcceptDelegateOneBoy(string s);
        public event AcceptDelegateOneBoy AcceptOneBoyEvent;

        public Girls()
        {
        }
        public Girls(string i_name)
        {
            this.Name = i_name;
        }
        public override void Say(string words)
        {
            base.Say(words);
            if (words == "Dong y")
            {
                if (AcceptEvent != null)
                    AcceptEvent();
            }
        }
        public void SayAccept(string words, string _boyName)
        {
            base.Say(words);
            if (words == "Dong y")
            {
                if (AcceptOneBoyEvent != null)
                    AcceptOneBoyEvent(_boyName);
            }
        }
    }
}
