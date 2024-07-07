namespace  Patterns.Creational.Factory.Resume;

internal abstract class Document{
    private List<Page> _pages = new();
    // easier to initialize via constructor
    
	public Document() {
      CreatePages();
    }
	
    public List<Page> Pages=> _pages; 
   
    public abstract void CreatePages();
  }