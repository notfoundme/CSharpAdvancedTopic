using System;
using System.IO;
// WAP to create a file named "sample.txt"  
// write "Hello World" in it
// append "Whats up" in it
// create another function that displays the file contents.

namespace CaptainMarvel
{
    class FileModification
    {
        public void createFile() {
            StreamWriter streamWriter = new StreamWriter("sample.txt", true);
            streamWriter.WriteLine("Hello World");
            streamWriter.WriteLine("Whats");
            streamWriter.Flush();
            streamWriter.Close();
        }

        public void readFile() {
            StreamReader stream = new StreamReader("sample.txt");
            Console.WriteLine(stream.ReadLine());
            Console.WriteLine(stream.ReadLine());
            Console.WriteLine(stream.ReadLine());
            Console.WriteLine(stream.ReadLine());
            stream.Close();
        }
    }
}
