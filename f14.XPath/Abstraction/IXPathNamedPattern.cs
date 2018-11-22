using System;
using System.Collections.Generic;
using System.Text;

namespace f14.XPath
{
    /// <summary>
    /// Provides a named <see cref="XPathPattern"/>.
    /// </summary>
    public interface IXPathNamedPattern : IXPathPattern
    {
        /// <summary>
        /// Identifies a specific value to facilitate its search in the collection.
        /// </summary>
        string Name { get; set; }
    }
}
