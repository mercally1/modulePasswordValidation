using Microsoft.AspNetCore.Mvc;
using validacion.Models;

namespace validacion.Controllers;


public class UsuariosController: Controller
{
    public JsonResult ValidarEmail(string email)
    {
         bool emailExistente = false;

        if (email == "Text@example.com"){
            emailExistente = true;
        }

        return Json(!emailExistente);
    }

    [HttpGet]
    public IActionResult Registrar()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Registrar(Usuario usuario)
    {
        if(ModelState.IsValid)
        {
            ViewBag.Mensaje = "Usuario registrado con exito";
            return View();
        }
        else
            return View(usuario);
    }
}
