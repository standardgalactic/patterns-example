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