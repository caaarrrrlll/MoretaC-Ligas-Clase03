using MoretaC_Ligas_Clase03.Models;

namespace MoretaC_Ligas_Clase03.Interface
{
    public interface iEquipoRepo
    {
        public List<Equipo> DevuelveListadoEquipos();
        public Equipo DevuelveInfoEquipo();
        bool ActualizarEquipo();
        bool CrearEquipo();
        public bool EliminarEquipo();
    }
}
