using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BlizzardSoundboard
{
  public partial class MainPage : ContentPage
  {
    public MainPage()
    {
      InitializeComponent();
    }

    private async void ButtonClickedSC(object sender, EventArgs e)
    {
      await Navigation.PushAsync(new Starcraft_2.SC2Sounds());
    }

    private async void ButtonClickedWC(object sender, EventArgs e)
    {
      await Navigation.PushAsync(new Warcraft_3.WC3Sounds());
    }

    private async void ButtonClickedOW(object sender, EventArgs e)
    {
      await Navigation.PushAsync(new Overwatch.OverwatchSounds());
    }

    private async void ButtonClickedHO(object sender, EventArgs e)
    {
      await Navigation.PushAsync(new Hots.HotsSounds());
    }
  }
}
