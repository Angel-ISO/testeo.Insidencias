using System.ComponentModel.DataAnnotations;

namespace Core.Entities;
public class Peripheral
{
    [Key]
    public int Id_Peripheral { get; set; }
    public ICollection<DetailIncidence> ?DetailIncidences { get; set; }
    public string ?Name_Peripheral { get; set; }
}