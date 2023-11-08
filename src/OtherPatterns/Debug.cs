using System.ComponentModel.Design;
using System.Diagnostics;

namespace Patterns.OtherPatterns;

internal class DebugCheck{

  internal  void CheckVal() {
#if DEBUG
        bool result =
#endif
            SpinUntil(true);
#if DEBUG
        Debug.Assert(result);
#endif
    }

  private bool SpinUntil(bool v) {
      return v;
  }
}