using Microsoft.AspNetCore.Mvc;
using MoretaC_Ligas_Clase03.EquipoRepo1;
using MoretaC_Ligas_Clase03.Models;

namespace MoretaC_Ligas_Clase03.Controllers
{
    public class EquipoController : Controller
    {
        public IActionResult ListTeam()
        {
            EquipoRepo equipoRepo = new EquipoRepo();
            var equipos = equipoRepo.DevuelveListadoEquipos();
            return View(equipos);

        }

        public IActionResult Edit(int Id)
        {
            EquipoRepo repo = new EquipoRepo();
            var equipo = repo.DevuelveInfoEquipo(Id);
            return View(equipo);

        }
    }
}



