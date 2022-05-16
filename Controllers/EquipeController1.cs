using eJogos.Models;
using Microsoft.AspNetCore.Mvc;

namespace eJogos.Controllers
{
    public class EquipeController1 : Controller
    {
        //ActionResult  representa os vários codigos de HTTP,


        Equipe equipeModel = new Equipe();

        public IActionResult Index()
        {

            //ViewBag = Reserva de espaço  para armazenar informações para recuperar na VIEW.
            // Tem a função de "carregar" as informações do controller para a VIEW

            ViewBag.Equipes = equipeModel.LerEquipes();

            return View();
        }
    }
}
