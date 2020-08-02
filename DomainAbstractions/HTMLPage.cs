using System;
using System.Collections.Generic;
using System.Text;
using Libraries;
using ProgrammingParadigms;

namespace DomainAbstractions
{
    public class HTMLPage : IEvent
    {
        // Private fields and properties
        public string InstanceName = "Default";

        // Private fields
        private string htmlCode = "";

        // Ports
        private INestedText htmlHeadInput;
        private INestedText htmlBodyInput;
        private IDataFlow<string> htmlCodeOutput;

        public HTMLPage()
        {

        }

        // IEvent implementation
        void IEvent.Execute()
        {
            var sb = new StringBuilder();

            sb.AppendLine("<html>");

            sb.AppendLine("<head>");
            if (htmlHeadInput != null) sb.AppendLine(htmlHeadInput.GetText());
            sb.AppendLine("</head>");

            sb.AppendLine("<body>");
            if (htmlBodyInput != null) sb.AppendLine(htmlBodyInput.GetText());
            sb.AppendLine("</body>");

            sb.AppendLine("</html>");

            htmlCode = sb.ToString();

            if (htmlCodeOutput != null) htmlCodeOutput.Data = htmlCode;
        }
    }
}
