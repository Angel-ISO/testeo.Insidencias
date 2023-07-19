using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Contact
{
    [Key]
    public int Id_Contact { get; set; }
    public int Id_User { get; set; }
    public ICollection<User> ?Users { get; set; }
    public int Id_ContactType { get; set; }
    public ContactType ? ContactType { get; set; }

     public User ? User { get; set; }
    public int Id_CategoryContact { get; set; }
        public CategoryContact ? CategoryContact { get; set; }

    public string ?Description_Contact { get; set; }
}