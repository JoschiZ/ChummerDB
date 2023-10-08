namespace ChummerDB.Shared.ViewModels;

public interface ICard<T>
{
    public T? Item { get; set; }
}