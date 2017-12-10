using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteBatchFile
{
    class Program
    {
        static int Main(string[] args)
        {
            if (args.Length < 2 )
            {
                return ShowHelp();
            }

            string text = args[1];
            if (!text.Contains("\r\n"))
            {
                text = text.Replace("\n", "\r\n");
            }

            try
            {
                File.WriteAllText(args[0], text, Encoding.Default);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 1;
            }
            
            return 0;
        }

        static int ShowHelp(int code = 2)
        {
            Console.WriteLine("Usage: WriteBatchFile <file> <text>");
            Console.WriteLine("https://github.com/yanxyz/WriteBatchFile#readme");
            return code;
        }
    }
}
