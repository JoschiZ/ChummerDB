namespace ChummerDB.Blazor.ComponentLibrary.Backend.Interfaces;

public interface IHasDependency
{
    HashSet<Type> Dependencies { get; set; }
}