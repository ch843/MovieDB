namespace MovieDB.Models;

public class Movie
{
    public string Category { get; set; }
    public string Title { get; set; }
    public int Year { get; set; }
    public string Director { get; set; }
    public string Rating { get; set; }
    
    public bool Edited { get; set; }
    public string Lent { get; set; }
    
    public string Notes { get; set; }
}