using System.ComponentModel.DataAnnotations;

public class Marker
{
    [Key]
    public string id { get; set; }
    public string? title { get; set; }
    public string? lat { get; set; }
    public string? lng { get; set; }
    public string? summary { get; set; }
}