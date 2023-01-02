using TypeGen.Core.SpecGeneration;

namespace TypeGenIssueReproduction;

public class TypescriptGenerationSpec : GenerationSpec
{
    public override void OnBeforeGeneration(OnBeforeGenerationArgs args)
    {
        AddInterface<SomeTypeArgBase>();
        AddInterface<ConcreteListEntry>();
        AddInterface<SomeGenericBase<SomeTypeArgBase>>();
        AddInterface<ConcreteImplementation>();
    }
}
