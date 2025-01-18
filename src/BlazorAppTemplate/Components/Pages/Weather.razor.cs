using BlazorAppTemplate.Models;
using BlazorAppTemplate.Store.WeatherUseCase;
using BlazorAppTemplate.Store.WeatherUseCase.Actions;
using Fluxor;
using Microsoft.AspNetCore.Components;

namespace BlazorAppTemplate.Components.Pages;

public partial class Weather
{
    [Inject]
    private IState<WeatherState> WeatherState { get; set; }
    
    [Inject]
    private IDispatcher? Dispatcher { get; set; }

    protected override void OnInitialized()
    {
        base.OnInitialized();
        
        Dispatcher?.Dispatch(new FetchDataAction());
    }
}