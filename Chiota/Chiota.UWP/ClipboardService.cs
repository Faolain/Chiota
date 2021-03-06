﻿using Xamarin.Forms;

[assembly: Dependency(typeof(Chiota.UWP.ClipboardService))]

namespace Chiota.UWP
{
  using Chiota.Services;

  using Windows.ApplicationModel.DataTransfer;

  public class ClipboardService : IClipboardService
  {
    public string GetTextFromClipboard()
    {
      var dataPackage = Clipboard.GetContent();
      var text = dataPackage.GetTextAsync();
      return text.GetResults();
    }

    public void SendTextToClipboard(string text)
    {
      DataPackage dataPackage = new DataPackage();
      dataPackage.SetText(text);
      Clipboard.SetContent(dataPackage);
    }
  }
}
