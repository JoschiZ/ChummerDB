using ChummerDB.Shared.Bases;
using ChummerDB.Shared.xml;
using ChummerDB.Shared.xml.Interfaces;

namespace ChummerDB.Shared.ViewModels;

public interface IDisplaySourceViewModel : IViewModelBase
{
    public IHasSource? SourceObject { get; set; }
    
    public Book? Book { get; }
}