using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF23.BehavioralPatterns._01Adapter
{
    public class Adapter: Target
    {
        private Adaptee _adaptee = new Adaptee();

        public override void Request()
        {
            _adaptee.SpecificRequest();
        }
    }
}
