using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using System.Diagnostics;

namespace miperfil.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Creamos la información del perfil
            var profile = new ProfileViewModel
            {
                FullName = "Justin ALguera",
                RoleTitle = "Desarrollador de Software full stack",
                Summary = "Estudiante de Ingeniería de Sistemas interesado en el desarrollo de APIs en .NET, arquitectura de bases de datos, tecnologías web y soluciones en la nube.",
                GithubUrl = "https://github.com/alguerajustin20/appMovil.git",
                Skillprofile = new List<profile>
                {
                    new profile
                    {
                        CategoryName = "Backend & Bases de Datos",
                        Skills = new List<string> { "Entity framework core", ".NET / C#", "SQL Server" }
                    },
                    new profile
                    {
                        CategoryName = "Frontend & UI",
                        Skills = new List<string> { "HTML5", "CSS3", "JavaScript", "Diseño Responsivo", "Consumo de APIs REST" }
                    }
                },

                LearningStack = new List<string>
                {
                    "Docker",
                    "APIs REST",
                    "Despliegue en Azure",
                    "Metodologías ágiles",
                    "Trabajo en equipo",
                    "Resolución de problemas"
                },

                // Lista de proyectos utilizando las imágenes exactas de la carpeta wwwroot/imagenes
                Projects = new List<Project>
                {
                    new Project
                    {
                        Title = "Sistema web",
                        Description = "Sistema web para gestion de usuarios,control de ventas,facturacion y resumen financiero.",
                        ImageUrl = "/imagenes/WhatsApp Image 2026-10-05 at 9.05.09 PM.jpeg",
                        
                    },
                    new Project
                    {
                        Title = "Arquitectura de API",
                        Description = "Diseño e implementacion de web API REST, documentadas y estructuradas.",
                        ImageUrl = "/imagenes/WhatsApp Image 2026-10-05 at 9.05.39 PM.jpeg",

                    },

                    new Project
                    {
                        Title = "Despliegue y contenedores",
                        Description = "Configuracion de entornos de contenedores y despliegues con docker.",
                        ImageUrl = "/imagenes/WhatsApp Image 2026-10-05 at 9.06.40 PM.jpeg",
                      
                    }
                }
            };

            // Se envía el objeto 'profile' a la vista
            return View(profile);
        }
    }
}