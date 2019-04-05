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
<<<<<<< HEAD

        
=======
>>>>>>> a0bd7af6b11afb6914169e921435fe3b715dce6c
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


<<<<<<< HEAD
        //统计每个单词的频率并按降序排列
        static Dictionary<string, int> WordFrequency(string filePath)

        {
            string str;
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            Dictionary<string, int> fre = new Dictionary<string, int>();
            while ((str = sr.ReadLine()) != null)
            {
                string s = str.ToLower();//将所有字母转换为小写
                string Pattern = @"\,|\.|\ |\n|\r|\?|\;|\:|\!|\(|\)|\042|\“|\”|\-|[0-9]";
                string[] words = Regex.Split(s,Pattern);
         
                foreach (string word in words)
                {
                    if (fre.ContainsKey(word))

                    {

                        fre[word]++;

                    }
                    else
                    {
                        if (word.Length > 3)
                        {
                            char[] ch = word.ToCharArray();
                            for(int i=0;i<4;i++)//判断单词长度
                            {
                                if (ch[i] >= 'a' && ch[i] <= 'z')//判断单词是否合法(前四个为字母）
                                    fre[word] = 1;
                                else break;
                            }
                            
                           
                        }
                    }

                }
                
            }
            fs.Close();

            List<KeyValuePair<string, int>> List = new List<KeyValuePair<string, int>>(fre);

            List.Sort(delegate (KeyValuePair<string, int> s1, KeyValuePair<string, int> s2)

            {

                return s2.Value.CompareTo(s1.Value);

            });

            fre.Clear();

            foreach (KeyValuePair<string, int> pair in List)

            {

                if (pair.Key != null && pair.Key != ":" && pair.Key != "," && pair.Key != ".")

                    fre.Add(pair.Key, pair.Value);

            }



            return fre;

        }
        
        

            static void Main()
=======



        static void Main()
>>>>>>> a0bd7af6b11afb6914169e921435fe3b715dce6c
            {
                string filePath = @"D:\\201731107105\\input.txt";
                string newfilePath = @"D:\\201731107105\\output.txt";
                StreamWriter sw = new StreamWriter(newfilePath,false, Encoding.Default);//false是覆盖已存在的文件
            
                sw.WriteLine("characters:{0}", CountChar(filePath));
<<<<<<< HEAD
                sw.WriteLine("lines:{0}", CountLines(filePath));
                
                Dictionary<string, int> a = WordFrequency(filePath);
                int temp = 1;
                
                
                foreach (KeyValuePair<string, int> pair in a)

                {
                    
                    temp++;
                    sw.WriteLine("{0}:{1}", pair.Key, pair.Value);
                    if (temp > 10) break;
                    

                }
               

=======
                sw.WriteLine("Words:{0}", CountLines(filePath));
>>>>>>> a0bd7af6b11afb6914169e921435fe3b715dce6c
                sw.Flush();
                sw.Close();

        }
        }
    }




