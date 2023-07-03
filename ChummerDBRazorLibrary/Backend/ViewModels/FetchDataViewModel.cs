using System.Collections.ObjectModel;
using ChummerDBRazorLibrary.Backend;
using ChummerDBRazorLibrary.Bases;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ChummerDBRazorLibrary.ViewModels;

public partial class FetchDataViewModel: ViewModelBase
{
    private WeatherForecastService WeatherForecastService { get; init; }

    public FetchDataViewModel(WeatherForecastService weatherForecastService)
    {
        WeatherForecastService = weatherForecastService;
    }

    [ObservableProperty]
    private ObservableCollection<WeatherForecast> _WeatherForecasts = new();

    public override async Task Loaded()
    {
        if (await WeatherForecastService.GetForecastAsync(DateTime.Now) is { } result)
        {
            WeatherForecasts = new ObservableCollection<WeatherForecast>(result);
        }
    }
}