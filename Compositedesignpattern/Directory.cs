public class Directory : IFileSystem
{
    public string DirectoryName { get; set; }
    public List<IFileSystem> Files { get; set; }
    public Directory(string name)
    {
        Files = new List<IFileSystem>();
        DirectoryName = name;
    }
    public void AddFile(IFileSystem fs) {
        Files.Add(fs);
    }
    public void PrintName()
    {
        Console.WriteLine("DirectoryName is " + DirectoryName);
       foreach(IFileSystem file in Files)
        {
            file.PrintName();
        }
    }
}
