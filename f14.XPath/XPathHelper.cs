using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace f14.XPath
{
    /// <summary>
    /// Provides regular methods to work with <see cref="IXPathSelector{R}"/>.
    /// </summary>
    public static class XPathHelper
    {
        /// <summary>
        /// [Core] Extracts target data from node uses given pattern.
        /// </summary>
        /// <param name="node">Html node.</param>
        /// <param name="selector">Pattern.</param>
        /// <returns>Data.</returns>
        public static string SelectFromNode(HtmlNode node, IXPathPattern selector)
        {
            if (node == null
                || selector == null
                || selector.SelectFrom == XPathValueSourceType.None
                || string.IsNullOrWhiteSpace(selector.XPath))
            {
                return null;
            }

            string value = null;
            switch (selector.SelectFrom)
            {
                case XPathValueSourceType.Attribute:
                    value = node.Attributes[selector.Attribute]?.Value.Trim();
                    break;
                case XPathValueSourceType.InnerHtml:
                    value = node.InnerHtml;
                    break;
                case XPathValueSourceType.InnerText:
                    value = node.InnerText.Trim();
                    break;
                case XPathValueSourceType.OuterHtml:
                    value = node.OuterHtml;
                    break;
                default:
                    throw new NotSupportedException($"The source type is not supported. Type: {selector.SelectFrom}.");
            }

            if (!string.IsNullOrWhiteSpace(selector.Regex))
            {
                try
                {
                    var m = Regex.Match(value, selector.Regex);
                    if (m.Success)
                    {
                        return m.Value;
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                }
            }
            return value;
        }
        /// <summary>
        /// Creates new html document from raw html.
        /// </summary>
        /// <param name="html">Raw html.</param>
        /// <returns>Html document.</returns>
        public static HtmlDocument CreateHtmlDocument(string html)
        {
            if (html == null)
            {
                return null;
            }

            var doc = new HtmlDocument();
            doc.LoadHtml(html);
            return doc;
        }
    }
}
