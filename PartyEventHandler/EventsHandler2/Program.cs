using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsHandler2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            PartyCellebrate party = new PartyCellebrate();

            party.BeforePartyStarted += person.NewPartyStartedEventHandler;

            party.StartParty();
        }
    }
}
