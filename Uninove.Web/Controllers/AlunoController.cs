using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Uninove.Web.Models;

namespace Uninove.Web.Controllers;

public class AlunoController : Controller 
{
    public IActionResult Index()
    {
        ViewBag.Nome = "Rodrigo Bertasso";
        ViewBag.Curso = "Analise e Desenvolivimento de Sistemas";
        ViewBag.Semestre = "Primeiro Semestre";

        return View();
    }
}