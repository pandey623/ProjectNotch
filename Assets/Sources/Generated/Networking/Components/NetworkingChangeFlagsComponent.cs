//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class NetworkingEntity {

    public ChangeFlagsComponent changeFlags { get { return (ChangeFlagsComponent)GetComponent(NetworkingComponentsLookup.ChangeFlags); } }
    public bool hasChangeFlags { get { return HasComponent(NetworkingComponentsLookup.ChangeFlags); } }

    public void AddChangeFlags(bool[] newFlags) {
        var index = NetworkingComponentsLookup.ChangeFlags;
        var component = CreateComponent<ChangeFlagsComponent>(index);
        component.flags = newFlags;
        AddComponent(index, component);
    }

    public void ReplaceChangeFlags(bool[] newFlags) {
        var index = NetworkingComponentsLookup.ChangeFlags;
        var component = CreateComponent<ChangeFlagsComponent>(index);
        component.flags = newFlags;
        ReplaceComponent(index, component);
    }

    public void RemoveChangeFlags() {
        RemoveComponent(NetworkingComponentsLookup.ChangeFlags);
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
public partial class NetworkingEntity : IChangeFlags { }

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class NetworkingMatcher {

    static Entitas.IMatcher<NetworkingEntity> _matcherChangeFlags;

    public static Entitas.IMatcher<NetworkingEntity> ChangeFlags {
        get {
            if (_matcherChangeFlags == null) {
                var matcher = (Entitas.Matcher<NetworkingEntity>)Entitas.Matcher<NetworkingEntity>.AllOf(NetworkingComponentsLookup.ChangeFlags);
                matcher.componentNames = NetworkingComponentsLookup.componentNames;
                _matcherChangeFlags = matcher;
            }

            return _matcherChangeFlags;
        }
    }
}
