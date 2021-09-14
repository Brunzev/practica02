using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using practica02.Models;

namespace practica02.Controllers
{
    public class FormularioController : Controller
    {
        public IActionResult Formulario(){
            return View();
        }
        [HttpPost]
        public IActionResult Formulario(string nombre, string apepa, string apema, string tipo, string descripcion, string telefono, string distrito, string direccion){
            Console.WriteLine(nombre);
            Console.WriteLine(apepa);
            Console.WriteLine(apema);
            Console.WriteLine(tipo);
            Console.WriteLine(descripcion);
            Console.WriteLine(telefono);
            Console.WriteLine(distrito);    
            Console.WriteLine(direccion); 
            return RedirectToAction("FormularioConfirmacion");        
        }
        public IActionResult FormularioConfirmacion(){
            return View();
        }
    }
}