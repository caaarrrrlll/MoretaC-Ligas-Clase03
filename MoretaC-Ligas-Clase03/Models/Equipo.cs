using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MoretaC_Ligas_Clase03.Models
{
    public class Equipo
    {
        [Key]       
        public int Id { get; set; }
        [MaxLength]
        [DisplayName("Nombre Equipo: ")]
        [Required]
        public string Logo { get; set; }
        public string Nombre { get; set; }
        [Range(0,20)]
        public int PartidosJugados { get; set; }
        [Range(0, 20)]
        public int PartidosGanados { get; set; }
        [Range(0, 20)]
        public int PartidosPerdidos { get; set; }
        [Range(0, 20)]
        public int PartidosEmpatados { get; set; }
        
        public int Puntos {
            get
            {
                int puntos = PartidosGanados * 3 + PartidosEmpatados * 1;
                return puntos;
            }
            
        }
  
    }
}

