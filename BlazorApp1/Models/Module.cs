// Module.cs
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Models
{
    public class Module
    {
        public int Id { get; set; }
        
        [Required, MaxLength(100)]
        public string Name { get; set; } = "New Module";
        
        [Range(0, 100)]
        public double? TargetAverage { get; set; }
        
        public List<Assessment> Assessments { get; set; } = new();
        
        [NotMapped]
        public double? CurrentAverage { get; set; }
    }
}