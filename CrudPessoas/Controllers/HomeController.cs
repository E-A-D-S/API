using System.Diagnostics;
using CrudPessoas.Models;
using Microsoft.AspNetCore.Mvc;

/// <summary>
/// Controlador para gerenciar as rotas principais da aplicação.
/// </summary>
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    /// <summary>
    /// Construtor para a classe HomeController.
    /// </summary>
    /// <param name="logger">Logger injetado para o controlador.</param>
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// Ação para a página inicial.
    /// </summary>
    /// <returns>Retorna a view para a página inicial.</returns>
    public IActionResult Index()
    {
        return View();
    }

    /// <summary>
    /// Ação para a página de privacidade.
    /// </summary>
    /// <returns>Retorna a view para a página de privacidade.</returns>
    public IActionResult Privacy()
    {
        return View();
    }

    /// <summary>
    /// Ação para a página de erro.
    /// </summary>
    /// <returns>Retorna a view para a página de erro com o modelo apropriado.</returns>
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
