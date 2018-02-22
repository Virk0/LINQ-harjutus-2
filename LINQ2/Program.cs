using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LINQ2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Kasutades võimalikult palju LINQ võimalusi:
            1.Lugege kokku mitu sõna on tekstis.
            2.Mitu erinevat tähte on tekstis.
            3.Lugeda kokku mitu korda esineb erinevaid tähti tekstis ning kirjutada tulemused kasutajale välja järjestatult.
            4.Kirjutada kasutajale välja kõik sõnad nii, et ühtegi sõna poleks rohkem üks kord.
            */
            #region Harjutus 1
            string text = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "text");
            System.Console.ReadLine();
            using (StreamReader newText = new StreamReader(text + @"\tekst.txt"))
            {
                string count = newText.ReadToEnd();
                string[] ssize = count.Split(new char[] { ' ' });
                System.Console.WriteLine("There are {0} words in this file", ssize.Count());
                System.Console.ReadLine();
            }
            #endregion

            #region Harjutus 2
            
            #endregion

        }
    }
}
