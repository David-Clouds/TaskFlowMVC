using Microsoft.AspNetCore.Mvc;
using TaskFlowMVC.Models;

namespace TaskFlowMVC.Controllers;

public class TasksController : Controller
{
    private static readonly List<TaskItem> Tasks = new()
    {
        new TaskItem
        {
            Id = 1,
            Title = "Crear proyecto MVC",
            Description = "Configurar la aplicación con C# y ASP.NET Core.",
            Priority = "Alta",
            IsCompleted = true,
            CreatedAt = DateTime.Now.AddDays(-3)
        },

        new TaskItem
        {
            Id = 2,
            Title = "Configurar Git y GitHub",
            Description = "Crear el repositorio y realizar los primeros commits.",
            Priority = "Alta",
            IsCompleted = false,
            CreatedAt = DateTime.Now.AddDays(-2)
        },

        new TaskItem
        {
            Id = 3,
            Title = "Publicar aplicación",
            Description = "Preparar Docker y realizar el despliegue en Render.",
            Priority = "Media",
            IsCompleted = false,
            CreatedAt = DateTime.Now.AddDays(-1)
        }
    };

    public IActionResult Index()
    {
        var orderedTasks = Tasks
            .OrderByDescending(task => task.CreatedAt)
            .ToList();

        return View(orderedTasks);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(TaskItem task)
    {
        if (!ModelState.IsValid)
        {
            return View(task);
        }

        task.Id = Tasks.Count == 0
            ? 1
            : Tasks.Max(x => x.Id) + 1;

        task.CreatedAt = DateTime.Now;

        Tasks.Add(task);

        TempData["Success"] = "La tarea fue creada correctamente.";

        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Complete(int id)
    {
        var task = Tasks.FirstOrDefault(x => x.Id == id);

        if (task is null)
        {
            return NotFound();
        }

        task.IsCompleted = !task.IsCompleted;

        TempData["Success"] = task.IsCompleted
            ? "La tarea fue completada."
            : "La tarea volvió a estado pendiente.";

        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Delete(int id)
    {
        var task = Tasks.FirstOrDefault(x => x.Id == id);

        if (task is null)
        {
            return NotFound();
        }

        Tasks.Remove(task);

        TempData["Success"] = "La tarea fue eliminada.";

        return RedirectToAction(nameof(Index));
    }
}