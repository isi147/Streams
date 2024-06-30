//File => static class-dir.File yaradib uzerinde ish gore bilerik
// FileInfo      => Normal class-dir Objectini yaradib hansisa bir  file PATH  vererek o file haqqinda melumatlari ala bilerik
// Directory     => static class-dir.Folderler uzerinde ish gormek ucundur. FOlder yarada sile ves. ede bilerik
// DirectoryInfo => Normal classdir objectini yaradib Folder uzerinde ishleye bilerik.
// Path          => static class-dir.Path yarada veya hazir path uzerinde ishleye bilerik

//using System.Text;

//using (FileStream fs = new FileStream("demo.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
//{
//    Console.Write("Enter some text: ");
//    string str = Console.ReadLine();
//    byte[] buffer = Encoding.Default.GetBytes(str);
//    fs.Write(buffer, 0, buffer.Length);
//    fs.Read(buffer, 0, buffer.Length);
//}

//using ConsoleApp10;

//using StreamWriter sw = new StreamWriter("books.txt");

//List<Book> books = new()
// {
//     new Book(1, "Joseph Albahari", "C# in a Nutshell", "Programming"),
//     new Book(2, "Jeffrey Richter", "CLR VIA C#", "Programming"),
//     new Book(3, "Antoine de Saint-Exupéry", "The Little Prince", "Kid")
// };

//books.ForEach(book => sw.WriteLine(book));

//using StreamReader sr = new StreamReader("books.txt");
//Console.WriteLine(sr.ReadToEnd());



//Console.WriteLine(Directory.GetCurrentDirectory());
//Directory.CreateDirectory("C:\\Users\\Seyidmammadli_i\\Desktop\\demo");
//Directory.Delete("C:\\Users\\Seyidmammadli_i\\Desktop\\demo");



//Console.Write("Enter some text: ");
//string str = Console.ReadLine();

//Directory.CreateDirectory($"C:\\Users\\Seyidmammadli_i\\Desktop\\{str}");



//File.WriteAllText("file.txt", "content");
//var str = File.ReadAllText("file.txt");
//Console.WriteLine(str);


//Console.WriteLine(File.Exists("file.txt"));