namespace Patterns.Behavioral.Template.DAO;

internal class MSSQL : DataAccessObject{
    public override object Select() {
        object o = "abc";
        return o;
    }
 
    public override string Parse(object o) {
      return (string) o; 
    }
  }