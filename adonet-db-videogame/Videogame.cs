using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adonet_db_videogame
{
    public class Videogame
    {
        public long Id { get; private set; }
        public string Name { get; private set; }
        public  DateTime Relase_date { get; private set; }

        public Videogame(long id, string name, DateTime relase_date)
        {
            Id = id;
            Name = name;
            Relase_date = relase_date;
        }

        public override string ToString()
        {
            return $"ID:{Id}; Nome:'{Name}' rilasciato in data {Relase_date}";
        }
    }
}
