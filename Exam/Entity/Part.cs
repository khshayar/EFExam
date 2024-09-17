namespace Exam.Entity;

public class Part
{
    public int Id { get; set; }
    public string Name { get; set; }
    public long Masahat { get; set; }
    public int ZooId { get; set; }
    public Zoo Zoo { get; set; }
    public string TedadAnimal { get; set; }
    public string Titel { get; set; }
    public Animal Animal { get; set; }
    
    public List<Tiket> Tikets { get; set; }
}