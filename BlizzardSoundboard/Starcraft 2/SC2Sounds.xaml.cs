using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BlizzardSoundboard.Starcraft_2
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class SC2Sounds : ContentPage
  {
    public SC2Sounds()
    {
      InitializeComponent();
    }

    private void ZealotQuote1_Clicked(object sender, EventArgs e)
    {
      DependencyService.Get<ISoundPlayer>().PlaySoundFile("Zealot1.mp3");
    }

    private void ZealotQuote2_Clicked(object sender, EventArgs e)
    {
      DependencyService.Get<ISoundPlayer>().PlaySoundFile("Zealot2.mp3");
    }
    private void ZealotQuote3_Clicked(object sender, EventArgs e)
    {
      DependencyService.Get<ISoundPlayer>().PlaySoundFile("Zealot3.mp3");
    }
    private void ZealotQuote4_Clicked(object sender, EventArgs e)
    {
      DependencyService.Get<ISoundPlayer>().PlaySoundFile("Zealot4.mp3");
    }
    private void ZealotQuote5_Clicked(object sender, EventArgs e)
    {
      DependencyService.Get<ISoundPlayer>().PlaySoundFile("Zealot5.mp3");
    }
    private void ZealotQuote6_Clicked(object sender, EventArgs e)
    {
      DependencyService.Get<ISoundPlayer>().PlaySoundFile("Zealot6.mp3");
    }
    private void ZealotQuote7_Clicked(object sender, EventArgs e)
    {
      DependencyService.Get<ISoundPlayer>().PlaySoundFile("Zealot7.mp3");
    }
    private void ZealotQuote8_Clicked(object sender, EventArgs e)
    {
      DependencyService.Get<ISoundPlayer>().PlaySoundFile("Zealot8.mp3");
    }
    private void ZealotQuote9_Clicked(object sender, EventArgs e)
    {
      DependencyService.Get<ISoundPlayer>().PlaySoundFile("Zealot9.mp3");
    }
    private void ZealotQuote10_Clicked(object sender, EventArgs e)
    {
      DependencyService.Get<ISoundPlayer>().PlaySoundFile("Zealot10.mp3");
    }
    private void ZealotQuote11_Clicked(object sender, EventArgs e)
    {
      DependencyService.Get<ISoundPlayer>().PlaySoundFile("Zealot11.mp3");
    }
    private void ZealotQuote12_Clicked(object sender, EventArgs e)
    {
      DependencyService.Get<ISoundPlayer>().PlaySoundFile("Zealot12.mp3");
    }
    private void ZealotQuote13_Clicked(object sender, EventArgs e)
    {
      DependencyService.Get<ISoundPlayer>().PlaySoundFile("Zealot13.mp3");
    }
    private void ZealotQuote14_Clicked(object sender, EventArgs e)
    {
      DependencyService.Get<ISoundPlayer>().PlaySoundFile("Zealot14.mp3");
    }
    private void ZealotQuote15_Clicked(object sender, EventArgs e)
    {
      DependencyService.Get<ISoundPlayer>().PlaySoundFile("Zealot15.mp3");
    }
    private void ZealotQuote16_Clicked(object sender, EventArgs e)
    {
      DependencyService.Get<ISoundPlayer>().PlaySoundFile("Zealot16.mp3");
    }
    private void ZealotQuote17_Clicked(object sender, EventArgs e)
    {
      DependencyService.Get<ISoundPlayer>().PlaySoundFile("Zealot17.mp3");
    }
    private void ZealotQuote18_Clicked(object sender, EventArgs e)
    {
      DependencyService.Get<ISoundPlayer>().PlaySoundFile("Zealot18.mp3");
    }
    private void ZealotQuote19_Clicked(object sender, EventArgs e)
    {
      DependencyService.Get<ISoundPlayer>().PlaySoundFile("Zealot19.mp3");
    }
    private void ZealotQuote20_Clicked(object sender, EventArgs e)
    {
      DependencyService.Get<ISoundPlayer>().PlaySoundFile("Zealot20.mp3");
    }
  }
}