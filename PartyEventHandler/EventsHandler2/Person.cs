using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsHandler2
{

    class Person
    {
        public void NewPartyStartedEventHandler(object sender, PartyEventArgs e)
        {
            Console.WriteLine($"Person is calling all of his Friends! going to party in {e.Location}!");
        }
    }
}
