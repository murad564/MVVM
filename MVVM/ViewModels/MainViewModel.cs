using MVVM.Commands;
using MVVM.Models;
using MVVM.Repositories.Abstracts;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace MVVM.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private readonly ICarRepository _repository;
        public ObservableCollection<Car> Cars { get; set; }
        private Car _selectedCar { get; set; }
        public Car SelectedCar
        {
            get => _selectedCar;
            set
            {
                _selectedCar = value;
                NotifyPropertyChanged();
            }

        }

        public ICommand AddCommand { get; set; }
        public ICommand ShowCommand { get; set; }
        public ICommand EditCommand { get; set; }

        public MainViewModel(ICarRepository repository)
        {
            _repository = repository;

            Cars = new ObservableCollection<Car>(repository.GetList() ?? new List<Car>());

            // AddCommand = new RelayCommand(ExecuteAddCommand,CanExecuteAddCommand);
            // EditCommand = new RelayCommand(ExecuteEditCommand,CanExecuteEditCommand);
            //ShowCommand = new RelayCommand(ExecuteShowCommand, CanExecuteShowCommand);
            ShowCommand = new RelayCommand(ExecuteShowCommand);
        }

        private void ExecuteShowCommand(object parameter)
        {
            MessageBox.Show(SelectedCar?.Model);
        }

        //private bool CanExecuteShowCommand(object parameter)
        //    => SelectedCar is not null;
    }
}