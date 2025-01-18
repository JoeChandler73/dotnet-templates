using BlazorAppTemplate.Store.WeatherUseCase.Actions;
using Fluxor;

namespace BlazorAppTemplate.Store.WeatherUseCase;

public static class Reducers
{
    [ReducerMethod]
    public static WeatherState ReduceFetchDataAction(WeatherState state, FetchDataAction action) =>
        new WeatherState { IsLoading = true };
    
    [ReducerMethod]
    public static WeatherState ReduceFetchDataResultAction(WeatherState state, FetchDataResultAction action) =>
        new WeatherState{ IsLoading = false, Forecasts = action.Forecasts };
}