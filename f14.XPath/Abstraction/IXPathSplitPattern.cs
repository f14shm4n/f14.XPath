using System;
using System.Collections.Generic;
using System.Text;

namespace f14.XPath
{
    /// <summary>
    /// Interface for patterns which should support string splitting.
    /// </summary>
    public interface IXPathSplitPattern : IXPathPattern
    {
        /// <summary>
        /// The string separator.
        /// </summary>
        string Separator { get; set; }
        /// <summary>
        /// Determines whether the pattern should split the string.
        /// </summary>
        bool SplitString { get; set; }
    }
}
