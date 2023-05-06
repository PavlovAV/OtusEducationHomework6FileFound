// See https://aka.ms/new-console-template for more information
using OtusEducationHomework6;

Console.WriteLine("Hello, World!");

var myFileClass = new MyFileClass();
myFileClass.FileFound += FileFound;
myFileClass.Run(@"D:\");

static void FileFound(object sender, FileArgs e)
{
    Console.WriteLine($"File {e} found");
    Console.WriteLine("Continue (Y/N)?");
    e.Exit = Console.ReadKey().KeyChar == 'N';
    Console.WriteLine();
}

public class FileArgs : EventArgs
{
	string FileName;
    public bool Exit { get; set; }

	public FileArgs(string? fileName)
	{
		FileName = fileName ?? string.Empty;
        Exit = false;
	}
    public override string ToString()
    {
        return FileName;
    }
}