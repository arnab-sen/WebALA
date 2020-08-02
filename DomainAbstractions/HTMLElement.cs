using System;
using System.Collections.Generic;
using System.Text;
using Libraries;
using ProgrammingParadigms;

namespace DomainAbstractions
{
    public class HTMLElement : INestedText
    {
        // Public fields and properties
        public string InstanceName = "Default";
        public string Type { get; set; }
        public string Content { get; set; }

        // Private fields
        private string _htmlCode;

        // Ports
        private List<INestedText> childContent = new List<INestedText>();

        public HTMLElement()
        {

        }

        // INestedText implementation
        string INestedText.GetText()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"<{Type}>");

            sb.AppendLine(Content);

            foreach (var nestedText in childContent)
            {
                sb.AppendLine(nestedText.GetText());
            }

            sb.AppendLine($"/<{Type}>");

            _htmlCode = sb.ToString();

            return _htmlCode;
        }
    }
}
