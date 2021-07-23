using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using tienda.Models;

namespace tienda.Controllers
{

    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            
            return View();
        }
        
        
        public IActionResult Juegos(string game, string delete, string add_name, string add_info, string add_img)
        {
            ListaEnlazada lista = new ListaEnlazada();

            // Juegos adicionados ---------------------------------------------------------------
            lista.Adicionar("/img/godofwar.jpg"); 
            lista.Adicionar("God of War es un videojuego de acción-aventura desarrollado por SCE Santa Monica Studio y publicado por Sony Interactive Entertainment. Su lanzamiento se produjo el 20 de abril de 2018, en exclusiva para la consola PlayStation 4.");
            lista.Adicionar("God of War"); 

            lista.Adicionar("/img/infamous.jpg");
            lista.Adicionar("Infamous: Second Son, estilizado como inFAMOUS: Second Son, es un videojuego del género acción/aventura en tercera persona, no lineal, desarrollado por Sucker Punch Productions y publicado por Sony para la consola PlayStation 4 en exclusiva.​ Es el tercer juego de la saga");
            lista.Adicionar("Infamous Second Son"); 

            lista.Adicionar("/img/valhalla.jpg");
            lista.Adicionar("Assassin's Creed Valhalla es un videojuego desarrollado por Ubisoft Montreal y publicado por Ubisoft. Es el decimosegundo en importancia y el vigesimosegundo lanzado dentro de la saga de Assassin Creed, y sucesor al juego del 2018 Assassin's Creed Odyssey.");
            lista.Adicionar("Assasins Creed Valhalla");

            lista.Adicionar("/img/inexplorado.jpg");
            lista.Adicionar("Uncharted 4: El desenlace del ladrón, es un videojuego de acción-aventura en tercera persona, lanzado el 10 de mayo de 2016, distribuido por Sony Computer Entertainment y desarrollado por Naughty Dog exclusivamente para PlayStation 4");
            lista.Adicionar("Uncharted 4");

            lista.Adicionar("/img/hollow.png");
            lista.Adicionar("Hollow Knight es un videojuego perteneciente al género metroidvania desarrollado y publicado por Team Cherry. El videojuego fue inicialmente lanzado para Microsoft Windows en febrero de 2017, y más tarde para macOS y Linux en abril de 2017.​ La adaptación para Nintendo Switch fue lanzada el 12 de junio de 2018.");
            lista.Adicionar("Hollow Knight");

            lista.Adicionar("/img/dragon.jpg");
            lista.Adicionar("Dragon Ball FighterZ es un videojuego de lucha en 2D desarrollado por Arc System Works y distribuido por Bandai Namco Entertainment, basado en la franquicia Dragon Ball.​");
            lista.Adicionar("Dragon Ball Fighter Z");

            lista.Adicionar("/img/guerra.jpg");
            lista.Adicionar("Call of Duty: Black Ops Cold War es un videojuego de disparos en primera persona desarrollado por Treyarch y Raven Software y publicado por Activision. Es la quinta entrega Black Ops y el decimoséptimo Call of Duty. Cronológicamente el juego está ambientado después de los acontecimientos de Call of Duty: Black Ops.");
            lista.Adicionar("Call Of Duty Cold War");

            lista.Adicionar("/img/Empty.png");
            lista.Adicionar("No se encontro informacion del juego"); 
            lista.Adicionar("No se encontro el juego"); 

            //lista.Adicionar("Empty");

            // Infamous second son ------------------------------------------
            string Alfa1  = lista.BuscarString("Infamous Second Son");
            string Beta1 = lista.BuscarDatoAnterior(Alfa1); 
            string Charlie1 = lista.BuscarDatoAnterior(Beta1);

            ViewData["Alfa1"] = Alfa1;
            ViewData["Beta1"] = Beta1;
            ViewData["Charlie1"] = Charlie1;

            // God of war --------------------------------------------------
            string Alfa2 = lista.BuscarString("God of War");
            string Beta2 = lista.BuscarDatoAnterior(Alfa2); 
            string Charlie2 = lista.BuscarDatoAnterior(Beta2);

            ViewData["Alfa2"] = Alfa2;
            ViewData["Beta2"] = Beta2;
            ViewData["Charlie2"] = Charlie2;

            // Assasins creed valhalla -------------------------------------
            string Alfa3 = lista.BuscarString("Assasins Creed Valhalla");
            string Beta3 = lista.BuscarDatoAnterior(Alfa3); 
            string Charlie3 = lista.BuscarDatoAnterior(Beta3);

            ViewData["Alfa3"] = Alfa3;
            ViewData["Beta3"] = Beta3;
            ViewData["Charlie3"] = Charlie3;

            // Buscar ------------------------------------------------------
            string Alfa4 = lista.BuscarString(game);
            string Beta4 = lista.BuscarDatoAnterior(Alfa4); 
            string Charlie4 = lista.BuscarDatoAnterior(Beta4);

            ViewData["Alfa4"] = Alfa4;
            ViewData["Beta4"] = Beta4;
            ViewData["Charlie4"] = Charlie4;

            // Eliminar ---------------------------------------------------

            string Alfa5 = lista.BuscarString(delete);
            string Beta5 = lista.BuscarDatoAnterior(Alfa5); 
            string Charlie5 = lista.BuscarDatoAnterior(Beta5);

            lista.borrar(Alfa5);
            lista.borrar(Beta5);
            lista.borrar(Charlie5); 

            // Añadir juego -----------------------------------------------

            lista.Adicionar(add_img);
            lista.Adicionar(add_info); 
            lista.Adicionar(add_name); 

            string Alfa6 = lista.BuscarString(add_name);
            string Beta6 = lista.BuscarDatoAnterior(Alfa6); 
            string Charlie6 = lista.BuscarDatoAnterior(Beta6);

            ViewData["Alfa6"] = Alfa6;
            ViewData["Beta6"] = Beta6;
            ViewData["Charlie6"] = Charlie6;

            return View();
        }

        public IActionResult AcercaDe()
        {
            return View();
        }

        public IActionResult JuegoDelA()
        {
            Pila function = new Pila(); 

            function.Push("/img/godofwar.jpg"); 
            function.Push("/img/Sekiro.jpg"); 
            function.Push("/img/TheLast.jpg"); 

            Pila function2 = new Pila(); 

            function2.Push("God of War es un videojuego de acción-aventura desarrollado por SCE Santa Monica Studio y publicado por Sony Interactive Entertainment. Su lanzamiento se produjo el 20 de abril de 2018, en exclusiva para la consola PlayStation 4.");
            function2.Push("Sekiro: Shadows Die Twice es un videojuego de acción y aventura desarrollado por From Software y distribuido por Activision.​ El juego fue lanzado el 22 de marzo de 2019 en las plataformas PlayStation 4, Xbox One y Microsoft Windows.​");
            function2.Push("The Last of Us Part II es un juego de acción y aventuras de 2020 desarrollado por Naughty Dog y publicado por Sony Interactive Entertainment para PlayStation 4.​");  

            Pila function3 = new Pila(); 

            function3.Push("God Of War");
            function3.Push("Sekiro Shadows Die Twice");
            function3.Push("The Last Of Us Part II"); 

            string Alfa1 = function.Peek();
            string Beta1 = function2.Peek();
            string Charlie1 = function3.Peek(); 

            ViewData["Alfa1"] = Alfa1;
            ViewData["Beta1"] = Beta1;
            ViewData["Charlie1"] = Charlie1; 

            function.Pop(); 
            function2.Pop(); 
            function3.Pop(); 

            string Alfa2 = function.Peek();
            string Beta2 = function2.Peek();
            string Charlie2 = function3.Peek(); 

            ViewData["Alfa2"] = Alfa2;
            ViewData["Beta2"] = Beta2;
            ViewData["Charlie2"] = Charlie2; 

            function.Pop(); 
            function2.Pop(); 
            function3.Pop(); 

            string Alfa3 = function.Peek();
            string Beta3 = function2.Peek();
            string Charlie3 = function3.Peek(); 

            ViewData["Alfa3"] = Alfa3;
            ViewData["Beta3"] = Beta3;
            ViewData["Charlie3"] = Charlie3; 

            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        
    }
}
