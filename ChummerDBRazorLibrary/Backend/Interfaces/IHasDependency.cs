namespace ChummerDBRazorLibrary.Interfaces;

public interface IHasDependency
{
    HashSet<Type> Dependencies { get; set; }
}