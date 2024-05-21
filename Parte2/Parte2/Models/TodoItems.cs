using System.ComponentModel.DataAnnotations;

namespace Parte2.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Title { get; set; } // Vulnerabilidad: Falta de validación de entrada
        public string Description { get; set; } // Vulnerabilidad: Falta de validación de entrada
    }
}
