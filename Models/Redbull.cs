using RedbullAPI.Interfaces;

namespace RedbullAPI.Models;

public class Redbull : IRedbull
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    
    public double Price { get; set; }
}