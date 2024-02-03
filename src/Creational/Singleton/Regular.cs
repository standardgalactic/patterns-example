namespace Patterns.Creational.Singleton;



/// <summary>
/// ..\runtime\src\libraries\Common\tests\System\Net\TestLogging.cs"
/// </summary>
public class TestLogging  
{
    private static readonly TestLogging s_instance = new TestLogging();

    private TestLogging()
    {
    }

    public static TestLogging GetInstance()
    {
        return s_instance;
    }
    
}


/// <summary>
 /// \src\sdk\artifacts\obj\Tests\Microsoft.DotNet.Cli.Utils\Debug\net8.0\Microsoft.DotNet.Cli.Utils.LocalizableStrings.cs
 /// </summary>
    internal static partial class LocalizableStrings
    {
        private static global::System.Resources.ResourceManager s_resourceManager;

        internal static global::System.Resources.ResourceManager ResourceManager => s_resourceManager ??
            (s_resourceManager = new global::System.Resources.ResourceManager(typeof(LocalizableStrings)));
    }
