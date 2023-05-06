using AutoMate.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMate.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }

        public RelayCommand SettingsViewCommand { get; set; }

        public HomeViewModel HomeVm { get; set; }
        public SettingsViewModel SettingsVm { get; set; }

        private object _currentView;

		public object CurrentView
		{
			get { return _currentView; }
			set { _currentView = value;
				OnPropertyChanged();
			}
		}


		public MainViewModel()
		{
			HomeVm = new HomeViewModel();
			SettingsVm = new SettingsViewModel();
			CurrentView = HomeVm;

			HomeViewCommand = new RelayCommand(o =>
			{
				CurrentView = HomeVm;
			});

            SettingsViewCommand = new RelayCommand(o =>
            {
                CurrentView = SettingsVm;
            });
        }
    }
}
