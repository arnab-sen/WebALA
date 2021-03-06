﻿using System;
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
        private List<INestedText> children = new List<INestedText>();

        public HTMLElement()
        {

        }

        // INestedText implementation
        string INestedText.GetText(int depth)
        {
            var sb = new StringBuilder();
            string indent = new string(' ', 4 * depth);

            sb.AppendLine($"{indent}<{Type}>");

            sb.AppendLine($"{indent}{Content}");

            foreach (var nestedText in children)
            {
                sb.AppendLine(nestedText.GetText(depth + 1));
            }

            sb.AppendLine($"{indent}</{Type}>");

            _htmlCode = sb.ToString();

            return _htmlCode;
        }
    }
}
