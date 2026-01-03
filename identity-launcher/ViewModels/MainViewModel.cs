using identity_launcher.Views.Pages;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace identity_launcher.ViewModels
{
    public class MainViewModel : MvxViewModel
    {

        private Page _dashboardPage = new DashboardPage();

        #region Текущая страница
        private Page _currentPage;

        public Page ContentPage
        {
            get => _currentPage;
            set => SetProperty(ref _currentPage, value);
        }
        #endregion

        public MainViewModel()
        {
            ContentPage = _dashboardPage;
        }

    }
}
