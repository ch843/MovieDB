namespace MovieDB.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Movie
{
    [Key]
    [Required]
    public int MovieId { get; set; }
    [ForeignKey("CategoryId")]
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    public int Year { get; set; }
    public string Director { get; set; }
    public string Rating { get; set; }
    [Required]
    
    public int? Edited { get; set; }
    public string? Lent { get; set; }
    [Required]
    public int CopiedToFlex { get; set; }
    public string? Notes { get; set; }
}