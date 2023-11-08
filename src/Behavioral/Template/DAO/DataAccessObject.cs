
namespace Patterns.Behavioral.Template.DAO;

internal abstract class DataAccessObject{
    protected string connectionString;

 public virtual void Connect() {
      connectionString = "; data source=..\\..\\..\\db1";
    }
 
    public abstract object Select();
    public abstract string Parse( object o);
 
    public virtual void Disconnect() {
      connectionString = "";
    }

    public string Run() {
      Connect();
      var obj=  Select();
      string s=  Parse(obj);
      Disconnect();
      return s;
    }
  }