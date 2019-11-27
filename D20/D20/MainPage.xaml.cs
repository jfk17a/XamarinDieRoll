using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace D20
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public Random rnd = new Random();
        public MainPage()
        {
            InitializeComponent();
        }
        private void DieRoll(object sender, EventArgs e)
        {
            DieValue.Text = rnd.Next(1,20).ToString();
        }
    }
}
