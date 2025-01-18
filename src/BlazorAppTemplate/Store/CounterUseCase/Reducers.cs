using BlazorAppTemplate.Store.CounterUseCase.Actions;
using Fluxor;

namespace BlazorAppTemplate.Store.CounterUseCase;

public static class Reducers
{
    [ReducerMethod]
    public static CounterState ReduceIncrementCounterAction(CounterState state, IncrementCounterAction action) =>
        new CounterState { ClickCount = state.ClickCount + 1 };
}