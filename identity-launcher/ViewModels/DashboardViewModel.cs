using identity_launcher.Models;
using identity_launcher.Views.Pages;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace identity_launcher.ViewModels
{
    public class DashboardViewModel : MvxViewModel
    {

        #region Текущая страница
        private ObservableCollection<IServer> _serversList = new ObservableCollection<IServer>();

        public ObservableCollection<IServer> ServersList
        {
            get => _serversList;
            set => SetProperty(ref _serversList, value);
        }
        #endregion


        public DashboardViewModel()
        {
            BitmapImage bitmapImage = new BitmapImage();

            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(@"C:\\Users\\andre\\source\\repos\\identity-launcher\\identity-launcher\\Views\\Resources\\Images\\logo.png");
            bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
            bitmapImage.EndInit();
            ServersList.Add(new Server
            {
                Name = "Identity",
                Image = bitmapImage
            });

            ServersList.Add(new Server
            {
                Name = "Penis",
                Image = bitmapImage
            });

            ServersList.Add(new Server
            {
                Name = "Penis",
                Image = bitmapImage
            });
            ServersList.Add(new Server
            {
                Name = "Penis",
                Image = bitmapImage
            });
            ServersList.Add(new Server
            {
                Name = "Penis",
                Image = bitmapImage
            });
            ServersList.Add(new Server
            {
                Name = "Penis",
                Image = bitmapImage
            });
            ServersList.Add(new Server
            {
                Name = "Penis",
                Image = bitmapImage
            });
            ServersList.Add(new Server
            {
                Name = "Penis",
                Image = bitmapImage
            });
        }

    }
}
