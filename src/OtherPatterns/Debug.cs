using System.ComponentModel.Design;
using System.Diagnostics;

namespace Patterns.OtherPatterns;

internal class DebugCheck
{
    internal void CheckVal()
    {
        bool result =
#if DEBUG
            SpinUntil(true);
#else
     SpinUntil(false);
#endif

#if DEBUG
        Debug.Assert(result);
#endif
    }

    private bool SpinUntil(bool v)
    {
        return v;
    }
}