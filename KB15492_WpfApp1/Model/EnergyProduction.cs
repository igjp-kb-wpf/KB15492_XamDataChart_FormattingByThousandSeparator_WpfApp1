using KB15492_WpfApp1.Infrastructure;

namespace KB15492_WpfApp1.Model;
internal class EnergyProduction : ObservableObject
{
    private String _country = String.Empty;
    public String Country
    {
        get { return _country; }
        set
        {
            _country = value;
            OnPropertyChanged();
        }
    }

    private String _region = String.Empty;
    public String Region
    {
        get { return _region; }
        set
        {
            _region = value;
            OnPropertyChanged();
        }
    }

    private String _year = String.Empty;
    public String Year
    {
        get { return _year; }
        set
        {
            _year = value;
            OnPropertyChanged();
        }
    }

    private double _nuclear;
    public double Nuclear
    {
        get { return _nuclear; }
        set
        {
            _nuclear = value;
            OnPropertyChanged();
        }
    }

    private double _coal;
    public double Coal
    {
        get { return _coal; }
        set
        {
            _coal = value;
            OnPropertyChanged();
        }
    }

    private double _oil;
    public double Oil
    {
        get { return _oil; }
        set
        {
            _oil = value;
            OnPropertyChanged();
        }
    }

    private double _gas;
    public double Gas
    {
        get { return _gas; }
        set
        {
            _gas = value;
            OnPropertyChanged();
        }
    }

    private double _hydro;
    public double Hydro
    {
        get { return _hydro; }
        set
        {
            _hydro = value;
            OnPropertyChanged();
        }
    }

    public EnergyProduction()
    {
    }
}