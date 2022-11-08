using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telefonrehberi
{
    public class Textfiles
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string emailAddress { get; set; }
        public string password { get; set; }

        public char SaveTextFiles()
        {

            string filePath = @"C:\kullanıcı.txt";
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine($"Name:{name}");
                    writer.WriteLine($"Surname:{surname}");
                    writer.WriteLine($"Email:{emailAddress}");
                    writer.WriteLine($"Password:{password}");

                }
                return 'c';


            }
            catch (Exception)
            {
                return 'g';
            }
        }
        public char LoginTxtFiles()
        {

            string filePath = @"C:\kullanıcı.txt";
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        string[] lineArray = new string[2];
                        lineArray = line.Split(':');
                        if (lineArray[1] == password)
                        {


                            return 'b';
                        }
                        line = reader.ReadLine();
                    }
                    return 'd';
                }
            }
            catch (Exception)
            {


            }
            return 'm';
        }

        internal string LoginTextFiles()
        {
            throw new NotImplementedException();
        }
    }
}
