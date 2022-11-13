using MVVM.Repositories.Abstracts;
using MVVM.Repositories.Concretes;
using MVVM.ViewModels;
using MVVM.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MVVM
{
    public partial class App : Application
    {
        protected void ApplicationStart(object sender, StartupEventArgs e)
        {
            CarRepository carRepository = new CarRepository();
            ICarRepository repository = (ICarRepository)carRepository;
            MainView mainView = new MainView();
            mainView.DataContext = new MainViewModel(repository);
            mainView.ShowDialog();
        }
    }
}