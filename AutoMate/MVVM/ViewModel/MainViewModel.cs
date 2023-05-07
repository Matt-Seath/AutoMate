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

		public RelayCommand AnalyticsViewCommand { get; set; }

		public RelayCommand TranscriptsViewCommand { get; set; }

        public RelayCommand SettingsViewCommand { get; set; }

        public HomeViewModel HomeVm { get; set; }

		public AnalyticsViewModel AnalyticsVm { get; set; }

		public TranscriptsViewModel TranscriptsVm { get; set; }

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
			AnalyticsVm = new AnalyticsViewModel();
			TranscriptsVm = new TranscriptsViewModel();
			SettingsVm = new SettingsViewModel();
			CurrentView = HomeVm;

			HomeViewCommand = new RelayCommand(o =>
			{
				CurrentView = HomeVm;
			});

            AnalyticsViewCommand = new RelayCommand(o =>
            {
                CurrentView = AnalyticsVm;
            });

            TranscriptsViewCommand = new RelayCommand(o =>
            {
                CurrentView = TranscriptsVm;
            });

            SettingsViewCommand = new RelayCommand(o =>
            {
                CurrentView = SettingsVm;
            });
        }
    }
}
