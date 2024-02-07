using System.Diagnostics.Tracing;

namespace Patterns.OtherPatterns;

public class Initializer
{
      
    private StreamWriter _writer;

    private Initializer()
    {
    }
        internal static Initializer Create(string logDirectory)
        {
            // Only create a listener if the log directory exists.
            
            Initializer eventListener = null;
            try
            {
                eventListener = new Initializer();
                eventListener.Initialize(logDirectory);
            }
            catch
            {
               
            }

            return eventListener;
        }

        private void Initialize(string logDirectory)
        {
            // new StreamWriter
        }
}