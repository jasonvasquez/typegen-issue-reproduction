namespace TypeGenIssueReproduction;

public abstract class SomeGenericBase<ListT> where ListT : SomeTypeArgBase
{
    public Guid Id { get; set; }

    public List<ListT> Entries { get; set; } = new();
}
