using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections;


namespace ConsoleApp1
{
    class WordCounter
    {
        //判断文本字符数
        static int CountChar(string filePath)
        {
            int count = 0;
            try
            {
                string line;
                FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                using (StreamReader sr = new StreamReader(fs))
                {
                    line = sr.ReadLine();
                    while (line != null)
                    {
                        foreach (var ch in line)
                        {
                            count++;
                        }
                        line = sr.ReadLine();
                    }
                }
                fs.Close();
              
                return count;
            }
            catch (Exception e)
            {
                
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            return 0;
        }
        //统计行数
        public static int CountLines(string filepath)
        {
            int lines = 0;
            FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            while (sr.ReadLine() != null)
            {

                //if (sr.ReadLine() != "") 
                lines++;
                //else sr.ReadLine();
            }

            fs.Close();


            return lines;

        }





        static void Main()
            {
                string filePath = @"D:\\201731107105\\input.txt";
                string newfilePath = @"D:\\201731107105\\output.txt";
                StreamWriter sw = new StreamWriter(newfilePath,false, Encoding.Default);//false是覆盖已存在的文件
            
                sw.WriteLine("characters:{0}", CountChar(filePath));
                sw.WriteLine("Words:{0}", CountLines(filePath));
                sw.Flush();
                sw.Close();

        }
        }
    }




