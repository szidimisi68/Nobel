using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dij> dijak = new List<Dij>();
            File.ReadAllLines("nobel.csv").Skip(1).ToList().ForEach(x => dijak.Add(new Dij(x.Split(';'))));

            Console.WriteLine($"3. feladat: {dijak.Where(x => x.KeresztNev == "Arthur B." && x.VezetekNev == "McDonald").ToList().First().Tipus}");
            dijak.Where(x => x.Evszam == "2017" && x.Tipus == "irodalmi").ToList().ForEach(x => Console.WriteLine($"4. feladat: {x.KeresztNev} {x.VezetekNev}"));

            Console.WriteLine("5. feladat:");
            dijak.Where(x => int.Parse(x.Evszam) >= 1990 && x.VezetekNev == "").ToList().ForEach(x => Console.WriteLine($"\t{x.Evszam}: {x.KeresztNev}"));

            Console.WriteLine("6. feladat:");
            dijak.Where(x => x.VezetekNev.Contains("Curie")).ToList().ForEach(x => Console.WriteLine($"\t{x.Evszam}: {x.KeresztNev} {x.VezetekNev}({x.Tipus})"));

            Console.WriteLine("7.feladat:");
            dijak.GroupBy(x => x.Tipus).ToList().OrderByDescending(x => x.Count()).ToList().ForEach(x => Console.WriteLine($"\t{x.Key}".PadRight(30) + $"{x.Count()} db"));

            var rendezettDijak = dijak.Where(x => x.Tipus == "orvosi").ToList().OrderBy(x => x.Evszam).ToList().Select(x => $"{x.Evszam}:{x.KeresztNev} {x.VezetekNev}").ToList();
            File.WriteAllLines("orvosi.txt", rendezettDijak);
            Console.WriteLine("8. feladat: orvosi.txt");
        }
    }
}
