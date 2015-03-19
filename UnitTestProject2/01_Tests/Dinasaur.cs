using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using NUnit.Framework;


namespace UnitTestProject2._01_Tests
{
    class Dinasaur
    {
            [Test]
            public static void Dino()
    {
        Collection<string> dinosaurs = new Collection<string>();

        dinosaurs.Add("Psitticosaurus");
        dinosaurs.Add("Caudipteryx");
        dinosaurs.Add("Compsognathus");
        dinosaurs.Add("Muttaburrasaurus");

        Console.WriteLine("{0} dinosaurs:", dinosaurs.Count);
        Display(dinosaurs);

        Console.WriteLine("\nIndexOf(\"Muttaburrasaurus\"): {0}", 
            dinosaurs.IndexOf("Muttaburrasaurus"));

        Console.WriteLine("\nContains(\"Caudipteryx\"): {0}", 
            dinosaurs.Contains("Caudipteryx"));

        Console.WriteLine("\nInsert(2, \"Nanotyrannus\")");
        dinosaurs.Insert(2, "Nanotyrannus");
        Display(dinosaurs);

        Console.WriteLine("\ndinosaurs[2]: {0}", dinosaurs[2]);

        Console.WriteLine("\ndinosaurs[2] = \"Microraptor\"");
        dinosaurs[2] = "Microraptor";
        Display(dinosaurs);

        Console.WriteLine("\nRemove(\"Microraptor\")");
        dinosaurs.Remove("Microraptor");
        Display(dinosaurs);

        Console.WriteLine("\nRemoveAt(0)");
        dinosaurs.RemoveAt(0);
        Display(dinosaurs);

        Console.WriteLine("\ndinosaurs.Clear()");
        dinosaurs.Clear();
        Console.WriteLine("Count: {0}", dinosaurs.Count);
    }

        
    private static void Display(Collection<string> cs)
    {
        Console.WriteLine();
        foreach( string item in cs )
        {
            Console.WriteLine(item);
        }
    }
}
    }

