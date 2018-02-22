using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LINQ2
{
    class Program
    {
        /*
        Kasutades võimalikult palju LINQ võimalusi:
        1.Lugege kokku mitu sõna on tekstis.
        2.Mitu erinevat tähte on tekstis.
        3.Lugeda kokku mitu korda esineb erinevaid tähti tekstis ning kirjutada tulemused kasutajale välja järjestatult.
        4.Kirjutada kasutajale välja kõik sõnad nii, et ühtegi sõna poleks rohkem üks kord.
        */
        struct Character
        {
            public char character;
            public int count;
        };
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText("../../tekst.txt");

            #region Harjutus 1
            //string text = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "text");
            //System.Console.ReadLine();
            //using (StreamReader newText = new StreamReader(text + @"\tekst.txt"))
            //{
            //    string count = newText.ReadToEnd();
            //    string[] ssize = count.Split(new char[] { ' ' });
            //    System.Console.WriteLine("There are {0} words in this file", ssize.Count());
            //    System.Console.ReadLine();
            //}
            int count = (from word in text.Split( ' ' )
                         select word).Count();

            Console.WriteLine("Number of words: {0}",count);



            #endregion
            Console.ReadKey();
            #region Harjutus 2
            int count1 = (from word in text.Substring(0)
                         select word).Count();

            Console.WriteLine("Number of letters: {0}", count1);
            #endregion
            Console.ReadKey();
            Console.WriteLine("Will write out every single letter used in this file");
            Console.WriteLine("Press to continue");
            Console.ReadKey();
            #region Harjutus 3
            Character[] characters = new Character[256];

            for (int i = 0; i < 256; i++)
            {
                characters[i].character = Convert.ToChar(i);
                characters[i].count = (from letter in text.ToList()
                                       where letter == Convert.ToChar(i)
                                       select letter).Count();
            }

            var a = characters.OrderByDescending(w => w.count).ToList();

            for (int i = 0; i < a.Count(); i++)
            {
                if (a.ElementAt(i).count != 0)
                {
                    Console.WriteLine(a.ElementAt(i).character + ": " + a.ElementAt(i).count);
                }
            }
            #endregion
            Console.ReadKey();
            Console.WriteLine("Will write out every single words used in this file");
            Console.WriteLine("Press to continue");
            Console.ReadKey();
            #region Harjutus 4
            {
                var l = (from i in text.Split(new char[] {' ', '?', '!', '(', ')', '.' }).Distinct()
                         select i);

                for (int i = 0; i < l.Count(); i++)
                    Console.WriteLine(l.ElementAt(i));
            }
            #endregion 
            Console.ReadKey();
        }
    }
}
