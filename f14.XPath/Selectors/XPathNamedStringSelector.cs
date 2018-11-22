using System;
using System.Collections.Generic;
using System.Text;
using HtmlAgilityPack;
using Newtonsoft.Json;

namespace f14.XPath
{
    /// <summary>
    /// Provides the named XPath selector that select the string values.
    /// </summary>
    public class XPathNamedStringSelector : XPathStringSelector, IXPathNamedPattern
    {
        public string Name { get; set; }
    }
}
