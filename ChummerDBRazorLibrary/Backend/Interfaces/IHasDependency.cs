namespace ChummerDBRazorLibrary.Backend.Interfaces;

public interface IHasDependency
{
    HashSet<Type> Dependencies { get; set; }
}