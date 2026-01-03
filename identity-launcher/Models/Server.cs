using identity_launcher.Views.Pages;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;

namespace identity_launcher.Models
{
    public class Server : IServer
    {

        public string Name { get; set; }
        public ImageSource Image { get; set; }
    }
}
