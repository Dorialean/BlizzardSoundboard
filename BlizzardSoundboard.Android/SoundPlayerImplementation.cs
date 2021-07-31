using Android.App;
using Android.Media;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using BlizzardSoundboard.Droid;

[assembly: Dependency(typeof(SoundPlayerImplementation))]
namespace BlizzardSoundboard.Droid
{
  public class SoundPlayerImplementation : ISoundPlayer
  {
    public SoundPlayerImplementation()
    {

    }

    public void PlaySoundFile(string fileName)
    {
      // Create a new Android MediaPlayer object
      // In android, it will remain in scope while it is playing, so we can create and instantiate it inside the method
      var player = new MediaPlayer();
      // Retrieve an asset file descriptor to the file name passed in out of the application assets
      var fd = global::Android.App.Application.Context.Assets.OpenFd(fileName);

      // Add a delegate handler that fires once the file is fully prepared in the media player
      // that will start the sound playback
      player.Prepared += (s, e) =>
      {
        player.Start();
      };

      // Wire up the datasource using the FileDescriptor, start offset of the file, and the length of the file
      player.SetDataSource(fd.FileDescriptor, fd.StartOffset, fd.Length);
      // Close out the file descriptor
      fd.Close();
      // instruct the MediaPlayer to prepare for playback
      player.Prepare();
    }
  }
}
