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
    /// Логика взаимодействия для MiniProfileComponent.xaml
    /// </summary>
    public partial class MiniProfileComponent : UserControl
    {



        public string PlayerName
        {
            get { return (string)GetValue(PlayerNameProperty); }
            set { SetValue(PlayerNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PlayerName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PlayerNameProperty =
            DependencyProperty.Register(nameof(PlayerName), typeof(string), typeof(MiniProfileComponent), new PropertyMetadata(string.Empty));



        public int HourPlayTime
        {
            get { return (int)GetValue(HourPlayTimeProperty); }
            set { SetValue(HourPlayTimeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for HourPlayTime.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HourPlayTimeProperty =
            DependencyProperty.Register(nameof(HourPlayTime), typeof(int), typeof(MiniProfileComponent), new PropertyMetadata(0));



        public int MinutesPlayTime
        {
            get { return (int)GetValue(MinutesPlayTimeProperty); }
            set { SetValue(MinutesPlayTimeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MinutesPlayTime.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MinutesPlayTimeProperty =
            DependencyProperty.Register(nameof(MinutesPlayTime), typeof(int), typeof(MiniProfileComponent), new PropertyMetadata(0));


        public MiniProfileComponent()
        {
            InitializeComponent();
            DataContext = this;
        }
    }
}
