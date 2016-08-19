using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithSystemDotIO
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowWindowsDirectoryInfo();
            Console.WriteLine();

            ModifyDirectory();
            Console.WriteLine();

            removeDirectory();
            Console.WriteLine();

            ListDrives();
            Console.WriteLine();

            ListDriveInfo();
            Console.WriteLine();

            SimpleFileIO();
            Console.WriteLine();

            FileStreamMethod();
            Console.WriteLine();

            StreamReaderWriter();
            Console.WriteLine();

            Console.ReadLine();
        }

        static void ShowWindowsDirectoryInfo()
        {
            Console.WriteLine("<= Directory Info");

            DirectoryInfo dir = new DirectoryInfo(@"C:\Windows");

            Console.WriteLine($"Full Name: {dir.FullName}");
            Console.WriteLine($"Name: {dir.Name}");
            Console.WriteLine($"Parent: {dir.Parent}");
            Console.WriteLine($"Creation Time: {dir.CreationTime}");
            Console.WriteLine($"Attributes: {dir.Attributes}");
            Console.WriteLine($"Root: {dir.Root}");

            Console.WriteLine();


        }

        static void ModifyDirectory()
        {
            Console.WriteLine("<= Modify Directory");

            DirectoryInfo dir = new DirectoryInfo(".");

            Console.WriteLine($"Current Directory is {dir.FullName}");

            DirectoryInfo subDirectory = dir.CreateSubdirectory("MyFolder");

            Console.WriteLine($"Sub Directory is {subDirectory.FullName}");


            Console.WriteLine();
        }

        static void removeDirectory()
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(@".\MyFolder");
                dir.Delete();
            }
            catch (DirectoryNotFoundException dnfex)
            {
                Console.WriteLine($"No Directory to delete - {dnfex.Message}");

            }
            catch (IOException ioex)
            {
                Console.WriteLine($"System.IO no like you! - {ioex.Message}");
            }
        }

        static void ListDrives()
        {
            Console.WriteLine("<= List Drives");

            string[] myDrives = Directory.GetLogicalDrives();

            foreach (var drive in myDrives)
            {
                Console.WriteLine(drive);
            }

            Console.WriteLine();
        }

        static void ListDriveInfo()
        {
            Console.WriteLine("<= List Drive Info");

            DriveInfo[] myDrives = DriveInfo.GetDrives();

            foreach (var drive in myDrives)
            {
                Console.WriteLine($"Name: {drive.Name}");
                Console.WriteLine($"Type: {drive.DriveType}");

                if (drive.IsReady)
                {
                    Console.WriteLine($"Free Space: {drive.TotalFreeSpace}");
                    Console.WriteLine($"Format: {drive.DriveFormat}");
                    Console.WriteLine($"Label: {drive.VolumeLabel}");
                }

                Console.WriteLine();
            }



            Console.WriteLine();
        }

        static void SimpleFileIO()
        {
            Console.WriteLine("<= simple FileIO");

            string[] myTasks =
            {
                "Reschedual Games",
                "Make Lineup",
                "coach game",
                "eat Dinner",
                "do something useful"
            };

            File.WriteAllLines(@".\tasks.txt", myTasks);

            foreach (var task in File.ReadAllLines(@".\tasks.txt"))
            {
                Console.WriteLine($"TODO {task}");
            }


            Console.WriteLine();
        }

        static void FileStreamMethod()
        {
            Console.WriteLine("<= FilestreamMethod");

            using (FileStream fsStream = File.Open(@"myMessages.dat", FileMode.Create))
            {
                string msg = "Hello!";
                byte[] msgAsBytes = Encoding.Default.GetBytes(msg);

                //write file output 
                fsStream.Write(msgAsBytes, 0, msgAsBytes.Length);

                //move file cursor back to start
                //this way we can read...
                fsStream.Position = 0;

                //read the file 1 byte at a time
                byte[] bytesFromFile = new byte[msgAsBytes.Length];

                for (int i = 0; i < msgAsBytes.Length; i++)
                {
                    bytesFromFile[i] = (byte) fsStream.ReadByte();
                    Console.Write(bytesFromFile[i]);
                }

                Console.WriteLine();
                Console.WriteLine(Encoding.Default.GetString(bytesFromFile));
            }

            Console.WriteLine();
        }

        static void StreamReaderWriter()
        {
            Console.WriteLine("<= stream reader Writer");

            using (StreamWriter sw = File.CreateText("reminder.txt"))
            {
                sw.WriteLine("dont forget your anniversery");
                sw.WriteLine("dont forget your birthday");
                sw.WriteLine("dont forget these numbers");
                for (int i = 0; i < 10; i++)
                {
                    sw.Write(i + " ");
                }

                sw.Write(sw.NewLine);
            }


            using (StreamReader sr = File.OpenText("reminder.txt"))
            {
                string input = null;

                while ((input = sr.ReadLine()) != null) 
                {
                    Console.WriteLine(input);
                }
            }

            Console.WriteLine();
        }
    }
}
