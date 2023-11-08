namespace Patterns.Creational.Singleton.Balancer;

internal class Legacy{
    private static Legacy _instance;
    private List<string> _servers = new ();
    private Random _random = new();

    private static object locker = new object();

    protected Legacy() {
        _servers.Add("ServerI");
        _servers.Add("ServerII");
        _servers.Add("ServerIII");
        _servers.Add("ServerIV");
        _servers.Add("ServerV");
    }

    public static Legacy GetLoadBalancer() {
        if (_instance == null){
            lock (locker){
                if (_instance == null){
                    _instance = new Legacy();
                }
            }
        }

        return _instance;
    }

    private int _count;
    public int Count => ++_count;

    public string Server{
        get{
            int r = _random.Next(_servers.Count);
            return _servers[r].ToString();
        }
    }
}