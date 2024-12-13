public class Transaction
{
    public Guid Id { get; init; }
    public decimal Amount { get; private set; }
    public string Description { get; private set; }
    public string Category { get; private set; }

    public Transaction() { }

    public Transaction(decimal amount, string description, string category)
    {
        Id = Guid.NewGuid();
        Amount = amount;
        Description = description;
        Category = category;
    }
}