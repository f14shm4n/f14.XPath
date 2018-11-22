using System;
using System.Collections.Generic;
using System.Text;
using HtmlAgilityPack;

namespace f14.XPath
{
    /// <summary>
    /// The XPath date time selector.
    /// </summary>
    public class XPathDateSelector : XPathPattern, IXPathSelector<DateTimeOffset>
    {
        public DateTimeOffset Select(HtmlDocument doc)
        {
            HtmlNode node = doc.DocumentNode.SelectSingleNode(XPath);
            if (node != null)
            {
                string raw = XPathHelper.SelectFromNode(node, this);
                if (DateTimeOffset.TryParse(raw, out DateTimeOffset date))
                {
                    return date;
                }
            }
            return DateTimeOffset.MinValue;
        }
    }
}
