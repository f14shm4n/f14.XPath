using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Text;

namespace f14.XPath
{
    /// <summary>
    /// The base XPath selector object.
    /// </summary>
    /// <typeparam name="R">Type of the selecting object.</typeparam>
    public interface IXPathSelector<R>
    {
        /// <summary>
        /// Selects from given html the specified value uses defined XPath pattern.
        /// </summary>
        /// <param name="doc">The html document.</param>
        /// <returns>The specific value.</returns>
        R Select(HtmlDocument doc);
    }
}
