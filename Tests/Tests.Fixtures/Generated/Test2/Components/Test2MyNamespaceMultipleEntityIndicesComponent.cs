//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class Test2Entity {

    public My.Namespace.MultipleEntityIndicesComponent myNamespaceMultipleEntityIndices { get { return (My.Namespace.MultipleEntityIndicesComponent)GetComponent(Test2ComponentsLookup.MyNamespaceMultipleEntityIndices); } }
    public bool hasMyNamespaceMultipleEntityIndices { get { return HasComponent(Test2ComponentsLookup.MyNamespaceMultipleEntityIndices); } }

    public void AddMyNamespaceMultipleEntityIndices(string newValue, string newValue2) {
        var index = Test2ComponentsLookup.MyNamespaceMultipleEntityIndices;
        var component = CreateComponent<My.Namespace.MultipleEntityIndicesComponent>(index);
        component.value = newValue;
        component.value2 = newValue2;
        AddComponent(index, component);
    }

    public void ReplaceMyNamespaceMultipleEntityIndices(string newValue, string newValue2) {
        var index = Test2ComponentsLookup.MyNamespaceMultipleEntityIndices;
        var component = CreateComponent<My.Namespace.MultipleEntityIndicesComponent>(index);
        component.value = newValue;
        component.value2 = newValue2;
        ReplaceComponent(index, component);
    }

    public void RemoveMyNamespaceMultipleEntityIndices() {
        RemoveComponent(Test2ComponentsLookup.MyNamespaceMultipleEntityIndices);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityInterfaceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class Test2Entity : IMyNamespaceMultipleEntityIndices { }

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class Test2Matcher {

    static Entitas.IMatcher<Test2Entity> _matcherMyNamespaceMultipleEntityIndices;

    public static Entitas.IMatcher<Test2Entity> MyNamespaceMultipleEntityIndices {
        get {
            if (_matcherMyNamespaceMultipleEntityIndices == null) {
                var matcher = (Entitas.Matcher<Test2Entity>)Entitas.Matcher<Test2Entity>.AllOf(Test2ComponentsLookup.MyNamespaceMultipleEntityIndices);
                matcher.componentNames = Test2ComponentsLookup.componentNames;
                _matcherMyNamespaceMultipleEntityIndices = matcher;
            }

            return _matcherMyNamespaceMultipleEntityIndices;
        }
    }
}
