using KB15492_WpfApp1.Infrastructure;
using KB15492_WpfApp1.Model;
using System.Collections.ObjectModel;

namespace KB15492_WpfApp1;
internal class MainWindowViewModel : ObservableObject
{
    public ObservableCollection<EnergyProduction> EnergyProductions { get; set; }

    public MainWindowViewModel()
    {
        EnergyProductions = new()
        {
            new () { Region = "America", Country = "CAN", Coal = 4000, Oil = 1000, Gas = 1750, Nuclear = 2250, Hydro = 3500 },
            new () { Region = "Asia", Country = "CHN", Coal = 9250, Oil = 2000, Gas = 3500, Nuclear = 4000, Hydro = 6250 },
            new () { Region = "Europe", Country = "RUS", Coal = 5500, Oil = 2000, Gas = 2500, Nuclear = 4750, Hydro = 4250 },
            new () { Region = "Asia", Country = "AUS", Coal = 4500, Oil = 1000, Gas = 1500, Nuclear = 1750, Hydro = 3500 },
            new () { Region = "America", Country = "USA", Coal = 8000, Oil = 2500, Gas = 4750, Nuclear = 5750, Hydro = 7500 },
            new () { Region = "Europe", Country = "FRA", Coal = 3750, Oil = 1500, Gas = 3500, Nuclear = 2750, Hydro = 3250 }
        };
    }
}