namespace Patterns.OtherPatterns;
class BarrierPostPhaseException: Exception{
    public BarrierPostPhaseException(Exception ex) {
    }
 }

public class Catch {

   /// <summary>
   ///  Throw in finally block
   /// </summary>
   /// <exception cref="BarrierPostPhaseException"></exception>
    [Fact]
    void Do() {
        Exception _exception= null;
        try {
            _exception = null; // reset the exception if it was set previously
        }
        catch (Exception ex){
            _exception = ex;
        }
        finally{
            if (_exception != null)
                throw new BarrierPostPhaseException(_exception);
        }
    }
    
    
    [Fact]
    void ExceptionHAndling() {
        Task task = Task.Run(() => { throw null; });
        try{
            
            task.Wait();
        }
        catch (AggregateException aex){
            if (aex.InnerException is NullReferenceException)
                Console.WriteLine("Null!");
            else
                throw;

        }
    }


}    
