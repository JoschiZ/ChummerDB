using ChummerDB.Blazor.ComponentLibrary.Backend.Bases;
using Microsoft.Extensions.Logging;

namespace ChummerDB.Blazor.ComponentLibrary.Components;

public class TestViewModel: ViewModelBase
{
    private readonly ILogger<TestViewModel> _logger;

    public TestViewModel(ILogger<TestViewModel> logger)
    {
        _logger = logger;
    }

    public override Task OnInitializedAsync()
    {
        _logger.LogError("View Model Error");
        return Task.CompletedTask;
    }
}