using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Models;
using Services;
using System;
using System.Collections.ObjectModel;

namespace SomeView.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IDataService service;

        public RelayCommand GetCarsInfoComand { get; set; }

        private ObservableCollection<Car> carsCollection;

        public ObservableCollection<Car> CarsCollection
        {
            get { return carsCollection; }
            set { Set(ref carsCollection, value); }
        }


        public MainViewModel(IDataService service)
        {

            GetCarsInfoComand = new RelayCommand(GetCarsInfo);
            this.service = service;
        }

        private async void GetCarsInfo()
        {
            CarsCollection = new ObservableCollection<Car>(await service.GetCarsAsync());
            
        }
}
    }