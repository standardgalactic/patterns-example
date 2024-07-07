// See https://aka.ms/new-console-template for more information

using System.Security.AccessControl;
using System.Text;
using static System.Console;

const string repo = @"D:\Dmitry\EDX\_Test\patterns-example";
string root = Path.Combine(repo, "src");
string output = Path.Combine(repo, "output");
int rootLength = root.Length;

var rootdirs = getRootDirs();
Provider(rootdirs);

void Provider(IEnumerable<string> dirs)
{
    foreach (var dir in dirs)
    {
       Bild(dir);
      var subdirs = Directory.EnumerateDirectories(dir);
      Provider(subdirs);
    }
}

void Bild(string dir)
{
    
    var files = Directory.EnumerateFiles(dir).ToArray();
    var bld = new StringBuilder();
        
    if (files.Length > 0)
    {
            
        foreach (var file in files)
        {
            string filecontent = File.ReadAllText(file);
            bld.AppendLine(filecontent);
            bld.AppendLine();
        }

        string filename = GetFileName(dir);
        string path = Path.Combine(output, filename + ".cs");
        string content = bld.ToString();

        File.WriteAllText(path, content);
    }
    
    
}
string GetFileName(string dir)
{
    var section = dir.Substring(rootLength+1);
    return section.Replace('\\', '-');
}


IEnumerable<string> getRootDirs()
{
    string[] dirs = { "Behavioral", "Creational", "Structural" };
    foreach (var dir in dirs)
    {
        yield return Path.Combine(root, dir);
    }
}


ReadLine();