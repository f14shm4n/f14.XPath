using System;
using System.Collections.Generic;
using System.Text;

namespace f14.XPath
{
    /// <summary>
    /// Base interface for XPath patterns.
    /// </summary>
    public interface IXPathPattern
    {
        /// <summary>
        /// Specifies the data source.
        /// </summary>
        XPathValueSourceType SelectFrom { get; set; }
        /// <summary>
        /// The attribute name.
        /// </summary>
        string Attribute { get; set; }
        /// <summary>
        /// The XPath pattern.
        /// </summary>
        string XPath { get; set; }
        /// <summary>
        /// The regex pattern to extract text data after selection.
        /// </summary>
        string Regex { get; set; }
    }
}
