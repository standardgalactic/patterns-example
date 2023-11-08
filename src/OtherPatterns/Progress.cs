namespace Patterns.OtherPatterns;

public class Progress1{
    [Fact]
    public async void Run() {
        var progress = new Progress<int> (i => Console.WriteLine (i + " %"));
        await Foo (progress);    
    }

    Task Foo (IProgress<int> onProgressPercentChanged)
    {
        return Task.Run (() =>
        {
            for (int i = 0; i < 1000; i++)
            {
                if (i % 10 == 0) onProgressPercentChanged.Report (i / 10);
                    
            }
        });
    }
}


