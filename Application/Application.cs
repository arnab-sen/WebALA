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
            DataFlowConnector<string> id_47ace31f3dc14ff4b17faee008d65f26 = new DataFlowConnector<string>() { InstanceName = "Default", Data = "C:\\ProgramData\\WebALA\\generatedHtml.html" };
            FileWriter id_dbd58fbb50ef432ea6f555cc32608dc7 = new FileWriter() { InstanceName = "Default" };
            HTMLPage id_c06ae43f967744c19aeb9ad40778bff8 = new HTMLPage() { InstanceName = "Default" };
            // END AUTO-GENERATED INSTANTIATIONS FOR Application.xmind

            // BEGIN AUTO-GENERATED WIRING FOR Application.xmind
            appStart.WireTo(id_c06ae43f967744c19aeb9ad40778bff8, "fanoutList"); // (@EventConnector (appStart).fanoutList) -- [IEvent] --> (HTMLPage (id_c06ae43f967744c19aeb9ad40778bff8).getPage)
            id_c06ae43f967744c19aeb9ad40778bff8.WireTo(id_dbd58fbb50ef432ea6f555cc32608dc7, "htmlCodeOutput"); // (HTMLPage (id_c06ae43f967744c19aeb9ad40778bff8).htmlCodeOutput) -- [IDataFlow<string>] --> (FileWriter (id_dbd58fbb50ef432ea6f555cc32608dc7).fileContentInput)
            id_dbd58fbb50ef432ea6f555cc32608dc7.WireTo(id_47ace31f3dc14ff4b17faee008d65f26, "filePathInput"); // (FileWriter (id_dbd58fbb50ef432ea6f555cc32608dc7).filePathInput) -- [IDataFlowB<string>] --> (DataFlowConnector<string> (id_47ace31f3dc14ff4b17faee008d65f26).outputsB)
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
