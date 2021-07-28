using System;
using System.Threading;
using design_pattern;

namespace Design_Pattern.Prototype
{
    public class Prototype : IRun
    {
        public void Run()
        {
            var folder = new Folder("folder", "folder");
            var folder_1 = new Folder("folder_1", "folder");
            var folder_1_1 = new Folder("folder_1_1", "folder");
            var folder_1_2 = new Folder("folder_1_2", "folder");
            var file_1_1 = new File("file_1_1", "f", 32);
            var file_1_2 = new File("file_1_2", "f", 564);
            var file_1_3 = new File("file_1_3", "f", 400);

            folder_1.AddFolder(folder_1_1);
            folder_1.AddFolder(folder_1_2);
            folder_1.AddFilde(file_1_1);
            folder_1.AddFilde(file_1_2);
            folder_1.AddFilde(file_1_3);

            var folder_2 = new Folder("folder_2", "folder");
            var folder_2_1 = new Folder("folder_2_1", "folder");
            var file_2_1 = new File("file_2_1", "f", 60);
            var file_2_2 = new File("file_2_2", "f", 128);

            folder_2.AddFolder(folder_2_1);
            folder_2.AddFilde(file_2_1);
            folder_2.AddFilde(file_2_2);

            folder.AddFolder(folder_1);
            folder.AddFolder(folder_2);

            folder.Clone();
        }
        public static void AnimatedStr(string str, int timeout)
        {
            foreach (char ch in str)
            {
                Thread.Sleep(timeout);
                Console.Write(ch);
            }
        }
    }
}
