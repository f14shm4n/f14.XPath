using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlAgilityPack;

namespace f14.XPath
{
    /// <summary>
    /// The XPath strings selector instance.
    /// </summary>
    public class XPathStringsSelector : XPathPattern, IXPathSelector<List<string>>, IXPathSplitPattern
    {
        public string Separator { get; set; }
        public bool SplitString { get; set; } = false;

        public List<string> Select(HtmlDocument doc)
        {
            List<string> results = new List<string>();
            HtmlNodeCollection nodes = doc.DocumentNode.SelectNodes(XPath);
            if (nodes != null)
            {
                foreach (var n in nodes)
                {
                    string value = XPathHelper.SelectFromNode(n, this);
                    if (!string.IsNullOrWhiteSpace(value))
                    {
                        if (SplitString)
                        {
                            string[] values = value.Split(new string[] { Separator }, StringSplitOptions.RemoveEmptyEntries);
                            if (values.Length == 0)
                            {
                                continue;
                            }

                            results.AddRange(values.Select(t => t.Trim()));
                        }
                        else
                        {
                            results.Add(value.Trim());
                        }
                    }
                }
            }
            return results;
        }
    }
}
