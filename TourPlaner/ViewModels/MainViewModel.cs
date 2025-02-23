using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TourPlaner.ViewModels;

public class Tour
{
    public string Name { get; set; }
    public string Description { get; set; }
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
            new Tour { Name = "Floridsdorf", Description = "Sehr schwere Route." },
            new Tour { Name = "Brigitenau", Description = "Eine einfache Route." }
        };
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}