namespace Exam.Entity;

public class Tiket
{
    public int Id { get; set; }
    public decimal? Price { get; set; }
    public Part Part { get; set; }
    public int PartId { get; set; }
}