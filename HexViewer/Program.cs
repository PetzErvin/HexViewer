using System;
using System.IO;
using System.Text;

namespace HexViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("Usage: HexViewer <folderPath> <filename> <bytesPerLine>");
                return;
            }

            string folderPath = args[0];
            string fileName = args[1];
            if (!int.TryParse(args[2], out int bytesPerLine))
            {
                Console.WriteLine("Error: bytesPerLine is not a valid integer");
                return;
            }

            string fullPath = Path.Combine(folderPath, fileName);
            try
            {
                using (FileStream stream = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                {
                    int bytesRead;
                    byte[] buffer = new byte[bytesPerLine];
                    StringBuilder sb = new StringBuilder();

                    while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        for (int i = 0; i < bytesRead; i++)
                        {
                            sb.AppendFormat("{0:X2} ", buffer[i]);
                        }
                        sb.AppendLine();
                    }
                    Console.WriteLine(sb.ToString());
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error reading file: " + ex.Message);
            }
        }
    }
}
