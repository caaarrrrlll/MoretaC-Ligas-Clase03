using MoretaC_Ligas_Clase03.Interface;
using MoretaC_Ligas_Clase03.Models;

namespace MoretaC_Ligas_Clase03.EquipoRepo1
{
    public class EquipoRepo : iEquipoRepo
    {
        public bool ActualizarEquipo()
        {
            throw new NotImplementedException();
        }

        public bool CrearEquipo()
        {
            throw new NotImplementedException();
        }

        public Equipo DevuelveInfoEquipo(int Id)
        {
            var Equipos = DevuelveListadoEquipos();
            var Equipo = Equipos.Where(item => item.Id == Id).First();
            return Equipo;
        }

        public List<Equipo> DevuelveListadoEquipos()
        {
            List<Equipo> equipos = new List<Equipo>();
            Equipo ldu = new Equipo
            {
                Id = 1,
                Nombre = "Ldu",
                PartidosGanados = 10,
                PartidosEmpadaos = 0,
                PartidosJugados = 10,
                PartidosPerdidos = 0
            };
            equipos.Add(ldu);

            Equipo bsc = new Equipo
            {
                Id = 2,
                Nombre = "Barcelona",
                PartidosGanados = 1,
                PartidosEmpadaos = 1,
                PartidosJugados = 10,
                PartidosPerdidos = 0
            };
            equipos.Add(bsc);

            return (equipos);
        }

        public bool EliminarEquipo()
        {
            throw new NotImplementedException();
        }
    }
}
