using System.ComponentModel.DataAnnotations;

namespace MusicaUTN.Modelos
{
    public class Pista
    {
        [Key]
        public int ID { get; set; } //pk, sugerencia de tipo Id
        public string Nombre { get; set; }
        public string Genero { get; set; }
        public string Album { get; set; }

        //Relacio
        public int AutoresId { get; set; } //FK
        public Autor? Autores { get; set; }


    }
}