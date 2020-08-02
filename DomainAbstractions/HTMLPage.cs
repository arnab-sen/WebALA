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
        private List<INestedText> head = new List<INestedText>();
        private List<INestedText> body = new List<INestedText>();
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
            foreach (var nestedText in head)
            {
                sb.AppendLine(nestedText.GetText(1));
            }
            sb.AppendLine("</head>");

            sb.AppendLine("<body>");
            foreach (var nestedText in body)
            {
                sb.AppendLine(nestedText.GetText(1));
            }
            sb.AppendLine("</body>");

            sb.AppendLine("</html>");

            htmlCode = sb.ToString();

            if (htmlCodeOutput != null) htmlCodeOutput.Data = htmlCode;
        }
    }
}
