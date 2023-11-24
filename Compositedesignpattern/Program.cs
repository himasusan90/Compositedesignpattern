Directory movieDir = new Directory("Movies");

File file = new File("Border");

movieDir.AddFile(file);

Directory comedyDir = new Directory("Comedies");
File file2 = new File("Hulchul");
comedyDir.AddFile(file2);

movieDir.AddFile(comedyDir);

movieDir.PrintName();

Console.ReadLine();
