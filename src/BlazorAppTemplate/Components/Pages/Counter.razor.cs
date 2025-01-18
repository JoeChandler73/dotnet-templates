using System.Diagnostics.CodeAnalysis;
using BlazorAppTemplate.Store.CounterUseCase;
using BlazorAppTemplate.Store.CounterUseCase.Actions;
using Fluxor;
using Microsoft.AspNetCore.Components;

namespace BlazorAppTemplate.Components.Pages;

public partial class Counter
{
    [Inject]
    private IState<CounterState> CounterState { get; set; }
    
    [Inject]
    public IDispatcher? Dispatcher { get; set; }

    private void IncrementCount()
    {
        var action = new IncrementCounterAction();
        
        Dispatcher?.Dispatch(action);
    }
}