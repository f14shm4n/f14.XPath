using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlAgilityPack;

namespace f14.XPath
{
    /// <summary>
    /// The XPath string selector instance.
    /// </summary>
    public class XPathStringSelector : XPathPattern, IXPathSelector<string>
    {
        public virtual string Select(HtmlDocument doc)
        {
            HtmlNode node = doc.DocumentNode.SelectSingleNode(XPath);
            if (node != null)
            {
                return XPathHelper.SelectFromNode(node, this);
            }
            return null;
        }
    }
}
