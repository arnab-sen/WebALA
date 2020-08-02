using System;
using Libraries;
using ProgrammingParadigms;
using DomainAbstractions;

namespace Application
{
    public class Application
    {
        EventConnector appStart = new EventConnector() { InstanceName = "appStart" };

        public Application()
        {
            // BEGIN AUTO-GENERATED INSTANTIATIONS FOR Application.xmind
            HTMLPage id_c06ae43f967744c19aeb9ad40778bff8 = new HTMLPage() { InstanceName = "Default" };
            // END AUTO-GENERATED INSTANTIATIONS FOR Application.xmind

            // BEGIN AUTO-GENERATED WIRING FOR Application.xmind
            appStart.WireTo(id_c06ae43f967744c19aeb9ad40778bff8, "fanoutList"); // (@EventConnector (appStart).fanoutList) -- [IEvent] --> (HTMLPage (id_c06ae43f967744c19aeb9ad40778bff8).getPage)
            // END AUTO-GENERATED WIRING FOR Application.xmind
        }

        static void Main(string[] args)
        {
            var app = new Application();
            Wiring.PostWiringInitialize();
            (app.appStart as IEvent).Execute();
        }
    }
}
