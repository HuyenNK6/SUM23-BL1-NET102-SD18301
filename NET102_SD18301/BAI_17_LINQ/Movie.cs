using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_17_LINQ
{
    internal class Movie
    {
        private Guid id;
        private string name;
        private string type;
        private int year;
        private List<string> actors;

        public Movie()
        {

        }

        public Movie(Guid id, string name, string type, int year, List<string> actors)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.year = year;
            this.actors = actors;
        }

        public Guid Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public int Year { get => year; set => year = value; }
        public List<string> Actors { get => actors; set => actors = value; }

        public void InThongTin()
        {
            Console.Write($"{id}| {name}| {type}| {year}| ");
            foreach (var item in actors)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
