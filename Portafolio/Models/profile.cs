namespace Portafolio.Models
{
    public class profile
    {
        public string CategoryName { get; set; } = string.Empty;
        public List<string> Skills { get; set; } = new();
    }

    // Modelo para representarle cada proyecto
    public class Project
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty; // Ruta de la imagen (ej: /images/proyecto1.jpg)
        public string ProjectUrl { get; set; } = string.Empty;
    }

    public class ProfileViewModel
    {
        public string FullName { get; set; } = string.Empty;
        public string RoleTitle { get; set; } = string.Empty;
        public string Summary { get; set; } = string.Empty;
        public List<profile> Skillprofile { get; set; } = new();
        public List<string> LearningStack { get; set; } = new();

        // Nueva propiedad para tus proyectos
        public List<Project> Projects { get; set; } = new();

        public string GithubUrl { get; set; } = string.Empty;
        public string LinkedinUrl { get; set; } = string.Empty;
    }
}