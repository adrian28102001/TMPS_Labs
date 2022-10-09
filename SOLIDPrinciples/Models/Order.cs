namespace SOLIDPrinciples.Models;

public class Order : BaseEntity
{
    public int TableId { get; set; }
    public int WaiterId { get; set; }
    public int Priority { get; set; }
    public int MaxWait { get; set; }
}