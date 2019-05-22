using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsHandler2
{
    class PartyCellebrate
    {

        public event EventHandler<PartyEventArgs> BeforePartyStarted;

        private void OnBeforePartyStarted()
        {
            if (BeforePartyStarted != null)
            {
                BeforePartyStarted.Invoke(this, new PartyEventArgs { Location = "Tel Aviv" } );
            }
        }

        public void StartParty()
        {
            OnBeforePartyStarted();

            Console.WriteLine("Drinking...");
            Console.WriteLine("Dancing...");
        }
    }
}
