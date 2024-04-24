using System.ComponentModel.DataAnnotations;

namespace Sleep_Tracker_WebApi.Models;

public class SleepData
{
    public int Id { get; set; }
    [Required]
    public DateTime Date { get; set; }
    [Range(0, int.MaxValue, ErrorMessage = "Hours cannot be negative.")]
    public int Hours { get; set; }
    [Range(0, 60, ErrorMessage = "Minutes must be between 0 and 60.")]
    public int Minutes { get; set; }
    [MaxLength(200)]
    public string Notes { get; set; }
}