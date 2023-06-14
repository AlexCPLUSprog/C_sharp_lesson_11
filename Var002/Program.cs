using System.IO;
using System.Text;
using System.Threading;

namespace Var002
{
    internal class Program
    {
        static void ShowType(object value)
        {
            Console.WriteLine($"Переменная имеет тип " +
                $"{value.GetType()} имеет hash {value.GetHashCode()}");
        }
        static void Main(string[] args)
        {
            long a = 10;

            ShowType(a);
            //Console.WriteLine(a.GetType());
            string tmp = "ABCD";
            int number;
            Random random = new Random();
            StringBuilder sb = new StringBuilder(); 
            ShowType(sb);
            for (int i = 0; i < 10; i++)
            {
                number = random.Next(1,100);
                Thread.Sleep(300);
                DateTimeOffset dto = new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.Zero);
                number = (number + dto.Millisecond)%100;
                sb.Append(number + " ");
                Console.WriteLine(number);
            }
            using (StreamWriter sw = new StreamWriter("output.txt", true))
            {
                sw.WriteLine(sb);
            }
            using (StreamReader sr = new StreamReader("output.txt"))
            {
                Console.WriteLine( sr.ReadToEnd() ); 
            }

            //var path = Environment.CurrentDirectory;
            //Console.WriteLine(path);
            //var myDoc = Environment.SpecialFolder.MyDocuments;  
            //DirectoryInfo dir = new DirectoryInfo(path);
            //var files = dir.EnumerateFiles();
            
            //foreach (var file in files) 
            //{
            //    //var FullFileName = path +"\\"+ file;
            //    FileInfo fileInfo = new FileInfo(file.ToString());
            //    Console.WriteLine($"{file} {fileInfo.LastWriteTime}" );
            //}
            
            Console.ReadKey();
        }
    }
}