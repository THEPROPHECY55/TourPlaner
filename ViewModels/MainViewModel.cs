using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TourPlaner.ViewModels;

public class Tour
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string From { get; set; }
    public string To { get; set; }
    public string TransportType { get; set; }
    public double TourDistance { get; set; } // in km
    public string EstimatedTime { get; set; } // e.g., "2h 30m"
}

public class MainViewModel : INotifyPropertyChanged
{
    private Tour _selectedTour;
    public ObservableCollection<Tour> Tours { get; set; }

    public Tour SelectedTour
    {
        get => _selectedTour;
        set
        {
            _selectedTour = value;
            OnPropertyChanged();
        }
    }

    public MainViewModel()
    {
        Tours = new ObservableCollection<Tour>
        {
            new Tour 
            { 
                Name = "Floridsdorf", 
                Description = "Eine sehr schwierige Route.", 
                From = "Wien", 
                To = "Floridsdorf", 
                TransportType = "Fahrrad", 
                TourDistance = 12.5, 
                EstimatedTime = "45 Min."
            },
            new Tour 
            { 
                Name = "Brigittenau", 
                Description = "Eine einfache Route für Anfänger.", 
                From = "Wien", 
                To = "Brigittenau", 
                TransportType = "Zu Fuß", 
                TourDistance = 4.2, 
                EstimatedTime = "1 Std. 15 Min."
            },
            new Tour 
            { 
                Name = "Alpenabenteuer", 
                Description = "Eine malerische Bergstrecke mit atemberaubender Aussicht.", 
                From = "Innsbruck", 
                To = "Zell am See", 
                TransportType = "Auto", 
                TourDistance = 160.0, 
                EstimatedTime = "2 Std. 30 Min."
            },
            new Tour 
            { 
                Name = "Donaukreuzfahrt", 
                Description = "Eine entspannende Bootstour entlang der Donau.", 
                From = "Wien", 
                To = "Bratislava", 
                TransportType = "Boot", 
                TourDistance = 55.0, 
                EstimatedTime = "1 Std. 15 Min."
            }
        };
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
