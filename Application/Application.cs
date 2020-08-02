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
            Data<string> id_239a4fa07d31409f9756b1579c7470cc = new Data<string>() { InstanceName = "Default" };
            DataFlowConnector<string> id_47ace31f3dc14ff4b17faee008d65f26 = new DataFlowConnector<string>() { InstanceName = "Default", Data = "C:\\ProgramData\\WebALA\\generatedHtml.html" };
            FileWriter id_dbd58fbb50ef432ea6f555cc32608dc7 = new FileWriter() { InstanceName = "Default" };
            HTMLElement id_07f624989a6046a59f686e79c31c748b = new HTMLElement() { InstanceName = "Default", Type = "p", Content = "Text body test!" };
            HTMLElement id_22a2ca41b8b64b53b93fc8a12b0939be = new HTMLElement() { InstanceName = "Default", Type = "p", Content = "Another new line" };
            HTMLElement id_ed29353228994117a42a8601bd8b4afe = new HTMLElement() { InstanceName = "Default", Type = "title", Content = "Hello world!" };
            HTMLElement id_f13385cc3c23495eac9f62ed3fc6389e = new HTMLElement() { InstanceName = "Default", Type = "p", Content = "New line" };
            HTMLPage id_c6bda01d77ce4d94916ddf9359bc5a29 = new HTMLPage() { InstanceName = "Default" };
            // END AUTO-GENERATED INSTANTIATIONS FOR Application.xmind

            // BEGIN AUTO-GENERATED WIRING FOR Application.xmind
            appStart.WireTo(id_c6bda01d77ce4d94916ddf9359bc5a29, "fanoutList"); // (@EventConnector (appStart).fanoutList) -- [IEvent] --> (HTMLPage (id_c6bda01d77ce4d94916ddf9359bc5a29).createPage)
            id_c6bda01d77ce4d94916ddf9359bc5a29.WireTo(id_ed29353228994117a42a8601bd8b4afe, "head"); // (HTMLPage (id_c6bda01d77ce4d94916ddf9359bc5a29).head) -- [INestedText] --> (HTMLElement (id_ed29353228994117a42a8601bd8b4afe).htmlContent)
            id_c6bda01d77ce4d94916ddf9359bc5a29.WireTo(id_07f624989a6046a59f686e79c31c748b, "body"); // (HTMLPage (id_c6bda01d77ce4d94916ddf9359bc5a29).body) -- [INestedText] --> (HTMLElement (id_07f624989a6046a59f686e79c31c748b).htmlContent)
            id_c6bda01d77ce4d94916ddf9359bc5a29.WireTo(id_f13385cc3c23495eac9f62ed3fc6389e, "body"); // (HTMLPage (id_c6bda01d77ce4d94916ddf9359bc5a29).body) -- [INestedText] --> (HTMLElement (id_f13385cc3c23495eac9f62ed3fc6389e).htmlContent)
            id_c6bda01d77ce4d94916ddf9359bc5a29.WireTo(id_22a2ca41b8b64b53b93fc8a12b0939be, "body"); // (HTMLPage (id_c6bda01d77ce4d94916ddf9359bc5a29).body) -- [INestedText] --> (HTMLElement (id_22a2ca41b8b64b53b93fc8a12b0939be).htmlContent)
            id_c6bda01d77ce4d94916ddf9359bc5a29.WireTo(id_dbd58fbb50ef432ea6f555cc32608dc7, "htmlCodeOutput"); // (HTMLPage (id_c6bda01d77ce4d94916ddf9359bc5a29).htmlCodeOutput) -- [IDataFlow<string>] --> (FileWriter (id_dbd58fbb50ef432ea6f555cc32608dc7).fileContentInput)
            id_dbd58fbb50ef432ea6f555cc32608dc7.WireTo(id_47ace31f3dc14ff4b17faee008d65f26, "filePathInput"); // (FileWriter (id_dbd58fbb50ef432ea6f555cc32608dc7).filePathInput) -- [IDataFlowB<string>] --> (DataFlowConnector<string> (id_47ace31f3dc14ff4b17faee008d65f26).outputsB)
            id_dbd58fbb50ef432ea6f555cc32608dc7.WireTo(id_239a4fa07d31409f9756b1579c7470cc, "complete"); // (FileWriter (id_dbd58fbb50ef432ea6f555cc32608dc7).complete) -- [IEvent] --> (Data<string> (id_239a4fa07d31409f9756b1579c7470cc).start)
            id_239a4fa07d31409f9756b1579c7470cc.WireTo(id_47ace31f3dc14ff4b17faee008d65f26, "inputDataB"); // (Data<string> (id_239a4fa07d31409f9756b1579c7470cc).inputDataB) -- [IDataFlowB<string>] --> (DataFlowConnector<string> (id_47ace31f3dc14ff4b17faee008d65f26).outputsB)
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
