using System;
using Libraries;
using ProgrammingParadigms;
using DomainAbstractions;

namespace WebALA
{
    class Application
    {
        private EventConnector appStart = new EventConnector() { InstanceName = "appStart" };

        // BEGIN AUTO-GENERATED INSTANTIATIONS FOR Application.xmind
        // END AUTO-GENERATED INSTANTIATIONS FOR Application.xmind

        // BEGIN AUTO-GENERATED WIRING FOR Application.xmind
        // END AUTO-GENERATED WIRING FOR Application.xmind

        static void Main(string[] args)
        {
            var app = new Application();
            Wiring.PostWiringInitialize();
            (app.appStart as IEvent).Execute();
        }
    }
}
