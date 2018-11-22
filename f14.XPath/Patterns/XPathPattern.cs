using HtmlAgilityPack;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Xml.XPath;

namespace f14.XPath
{
    /// <summary>
    /// Base class for implementing XPath patterns.
    /// </summary>
    [DebuggerDisplay("XPath = {XPath} From = {SelectFrom} Attr = {Attribute} Regex = {Regex}")]
    public class XPathPattern : IXPathPattern
    {
        /// <summary>
        /// Specifies the data source.
        /// </summary>
        public XPathValueSourceType SelectFrom { get; set; }
        /// <summary>
        /// The attribute name.
        /// </summary>
        public string Attribute { get; set; }
        /// <summary>
        /// The XPath pattern.
        /// </summary>
        public string XPath { get; set; }
        /// <summary>
        /// The regex pattern to extract text data after selection.
        /// </summary>
        public string Regex { get; set; }
    }
}
