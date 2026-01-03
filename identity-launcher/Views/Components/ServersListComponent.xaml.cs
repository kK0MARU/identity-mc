using Accessibility;
using identity_launcher.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace identity_launcher.Views.Components
{
    /// <summary>
    /// Логика взаимодействия для ServersListComponent.xaml
    /// </summary>
    public partial class ServersListComponent : UserControl
    {


        public ObservableCollection<IServer> ServersList
        {
            get { return (ObservableCollection<IServer>)GetValue(ServersListProperty); }
            set { SetValue(ServersListProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ServersList.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ServersListProperty =
            DependencyProperty.Register(nameof(ServersList), typeof(ObservableCollection<IServer>), typeof(ServersListComponent), new PropertyMetadata(null));



        public IServer SelectedServer
        {
            get { return (IServer)GetValue(SelectedServerProperty); }
            set { SetValue(SelectedServerProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelectedServer.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedServerProperty =
            DependencyProperty.Register(nameof(SelectedServer), typeof(IServer), typeof(ServersListComponent), new PropertyMetadata(null));




        public ServersListComponent()
        {
            InitializeComponent();
        }
    }
}
