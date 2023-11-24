public class File : IFileSystem
{
    public File(string name)
    {
        FileName = name;
    }
    public string FileName { get; set; }
    public void PrintName()
    {
        Console.WriteLine(  "FileName is "+FileName);
    }
}
