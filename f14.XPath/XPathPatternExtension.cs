using System;
using System.Collections.Generic;
using System.Text;

namespace f14.XPath
{
    public static class XPathPatternExtension
    {
        /// <summary>
        /// Determines whether the pattern has a name.
        /// </summary>
        /// <param name="pattern">Pattern to check.</param>
        /// <returns>True - if name is present; False - otherwise.</returns>
        public static bool HasName(this IXPathNamedPattern pattern) => !string.IsNullOrWhiteSpace(pattern.Name);
    }
}
