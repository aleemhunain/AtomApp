using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace AtomApp
{
    internal class Atom
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
        public int Proton { get; set; }
        public int Neutron { get; set; }
        public double Weight { get; set; }
        public Atom() { }

        public Atom(string name, int proton, int neutron, double weight, string symbol){
            Name = name;
            Symbol = symbol;
            Proton = proton;
            Neutron = neutron;
            Weight = weight;
        }

        public static Atom Parse(string line)
        {
            try
            {
                string[] parsedAtom = line.Split(' ');
                if (parsedAtom.Length != 5) { throw new Exception(); }
                return new Atom(parsedAtom[0],
                    Convert.ToInt32(parsedAtom[1]),
                    Convert.ToInt32(parsedAtom[2]),
                    Convert.ToDouble(parsedAtom[3]),
                    parsedAtom[4]);
            }
            catch(Exception e)
            {
                Console.WriteLine("String does not yield 5 parts.");
            }
            return new Atom();
            
        }
        
        public override string ToString()
        {          
            return $"{Name} {Proton} {Neutron} {Weight} {Symbol}";   
        }

    }
}
