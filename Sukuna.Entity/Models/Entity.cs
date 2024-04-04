namespace Sukuna.Common.Models;

public class Entity
{
    public int Id { get; set; } // Id pour chaque modele // Set permet d'appelKer exmeple id = 3 et get permet de l'appeler 
    public DateTime UpdatedAt { get; set; } // Terme générique en test
    public DateTime CreatedAt { get; set; }

    // public void SetId(int id) {  Id = id; } Représenttation d'un Setter 
    // public void GetId() {  return Id; } Représenttation d'un Getter 

    public Entity() { }
}
