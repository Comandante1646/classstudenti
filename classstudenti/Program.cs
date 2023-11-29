using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classstudenti
{
    public class Scuola
    {
        public class Studente
        {
            public class Persona
            {
                public string name { get; set; }
                public string surname { get; set; }
                public DateTime birthdate { get; set; }
            }
            public class Voto 
            {
                public class Materia
                {
                    public string Description { get; set; }
                    public int id { get; set; }
                }
                public DateTime date { get; set; }
                public int value { get; set; }  
            }
        }
        public class Insegnante
        {
            public class Persona
            {
                public string name { get; set; }
                public string surname { get; set; }
                public DateTime birthdate { get; set; }
            }
            public class Materia
            {
                public string Description { get; set; }
                public int id { get; set; }
            }
        }
    }

}            