using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class DetailIncidence
{
    [Key]
    public int Id_DetailIncidence { get; set; }
    public int Id_Peripheral { get; set; }
    public Peripheral ? Peripheral { get; set; }
    public int Id_TypeIncidence { get; set; }
    public ICollection<TypeIncidence> ?TypeIncidences { get; set; }
    public int Id_LevelIncidence { get; set; }
    public LevelIncidence ? LevelIncidence { get; set; }
    public int Id_State { get; set; }
       public ICollection<Incidence> ?Incidences  { get; set; }
    public string ?Description_DetailIncidence { get; set; }
}
