using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static System.Console;

namespace ARAPlus.Mod07
{
    class Program
    {
        static void Main(string[] args)
        {

            Directory.CreateDirectory(@"c:\workshops\johann");
            var f = File.CreateText(@"c:\workshops\johann\hello.txt");

            Person p = new Person();
            p.GetInfo();

            string url = @"https:\\www.arapluls.com:442";
            if (string.IsNullOrWhiteSpace(url))
            {
                url = "https://world.episerver.com/cms/?q=pagetype";
            }
            var uri = new Uri(url);
            WriteLine($"URL: {url}");
            WriteLine($"Scheme: {uri.Scheme}");
            WriteLine($"Port: {uri.Port}");
            WriteLine($"Host: {uri.Host}");
            WriteLine($"Path: {uri.AbsolutePath}");
            WriteLine($"Query: {uri.Query}");

            Console.WriteLine("Hello World!");

            /*
            int i = 12;
            object o = i; //boxing
            int j = (int)o;//unboxing
            */
            for (int i = 0; i < 100; i++)
            {
                object o = i;
            }

            //Anzahl Object am Managed Heap?
            //immutable
            string vorname = "";
            vorname = "J";
            vorname += "o";
            vorname += "h";
            vorname += "a";
            vorname += "n";
            vorname += "n";

            StringBuilder sb = new StringBuilder();
            sb.Append("J");
            sb.Append("o");
            sb.Append("h");

            Console.WriteLine(sb.ToString());

            var erg = vorname.Split('a');

            System.Collections.ArrayList al = new System.Collections.ArrayList();
            al.Add(12);//boxing
            al.Add("Johann");
            al.Add(true);

            int zahl = (int)al[0]; //unboxing

            Dictionary<int, string> meineTeilnehmerInnen = new Dictionary<int, string>();
            meineTeilnehmerInnen.Add(1, "Mahr");
            meineTeilnehmerInnen.Add(2, "Fleck");

            foreach (KeyValuePair<int,string> tn in meineTeilnehmerInnen)
            {
                Console.WriteLine($"{tn.Key} Vorname: {tn.Value}");
            }




        }
    }
}
