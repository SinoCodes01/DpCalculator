using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Models
{
    public class Assessment
    {
        public int Id { get; set; }
        
        [Required, MaxLength(100)]
        public string Name { get; set; } = "New Assessment";
        
        [Range(0, 100)]
        public double Weight { get; set; } = 30;
        
        [Range(0, 100)]
        public double Score { get; set; } = 0;
        
        public int ModuleId { get; set; }
        
        [ForeignKey("ModuleId")]
        public Module? Module { get; set; }  // Add this navigation property
    }
}