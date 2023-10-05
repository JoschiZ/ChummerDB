using ChummerDB.Blazor.ComponentLibrary.Backend.Bases;
using ChummerDB.Blazor.ComponentLibrary.Backend.xml;
using ChummerDB.Blazor.ComponentLibrary.Backend.xml.Interfaces;

namespace ChummerDB.Blazor.ComponentLibrary.Components;

public interface IDisplaySourceViewModel : IViewModelBase
{
    public IHasSource? SourceObject { get; set; }
    
    public Book? Book { get; }
}