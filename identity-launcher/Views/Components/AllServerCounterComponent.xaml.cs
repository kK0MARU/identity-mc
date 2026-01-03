using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для AllServerCounterComponent.xaml
    /// </summary>
    public partial class AllServerCounterComponent : UserControl
    {



        public int PlayerCount
        {
            get { return (int)GetValue(PlayerCountProperty); }
            set { SetValue(PlayerCountProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PlayerCount.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PlayerCountProperty =
            DependencyProperty.Register(nameof(PlayerCount), typeof(int), typeof(AllServerCounterComponent), new PropertyMetadata(0));


        public AllServerCounterComponent()
        {
            InitializeComponent();
            DataContext = this;
        }
    }
}
