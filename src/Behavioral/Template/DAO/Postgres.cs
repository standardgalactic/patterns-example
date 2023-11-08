namespace Patterns.Behavioral.Template.DAO;

internal class Postgres : DataAccessObject{
  public override object Select() {
    object o = "123";
    return o;
  }
 
  public override string Parse(object o) {
    return (string) o; 
  }
        
    }
