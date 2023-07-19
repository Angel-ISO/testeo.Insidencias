using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class TypeIncidence
{
    [Key]
    public int Id_TypeIncidence { get; set; }
    public DetailIncidence ? DetailIncidence   { get; set; }
    public string ?Name_TypeIncidence { get; set; }
    public string ?Description_TypeIncidence { get; set; }
}