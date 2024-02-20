namespace MovieDB.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Movie
{
    [Key] // Specify that Id is the primary key
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Specify that the Id column is auto-generated
    public int Id { get; set; }
    
    public string Category { get; set; }
    public string Title { get; set; }
    public int Year { get; set; }
    public string Director { get; set; }
    public string Rating { get; set; }
    
    public bool? Edited { get; set; }
    public string? Lent { get; set; }
    
    public string? Notes { get; set; }
}