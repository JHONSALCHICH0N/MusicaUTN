using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicaUTN.Modelos
{
    public class Autor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Anos { get; set; }

        //Relacion
        public List<Pista>? Pistas { get; set; }

    }
}
