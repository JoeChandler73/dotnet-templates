using Fluxor;

namespace BlazorAppTemplate.Store.CounterUseCase;

public record CounterState
{
    public int ClickCount { get; init; }
}

public class CounterFeature : Feature<CounterState>
{
    public override string GetName() => "Counter";
    
    protected override CounterState GetInitialState() => new() { ClickCount = 0 };
}