using System;
using System.Collections.Generic;
using System.Text;

namespace f14.XPath
{
    /// <summary>
    /// Defines a xpath selector value source.
    /// </summary>
    public enum XPathValueSourceType
    {
        None,
        InnerText,
        InnerHtml,
        Attribute,
        OuterHtml
    }
}
