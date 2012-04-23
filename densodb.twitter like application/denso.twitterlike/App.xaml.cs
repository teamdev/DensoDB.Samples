using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using DeNSo.Core;
using System.IO;

namespace denso.twitterlike
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
  {
    protected override void OnStartup(StartupEventArgs e)
    {
      base.OnStartup(e);

      Session.DefaultDataBase = "twitterlike";
      DeNSo.Core.Configuration.BasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "densosamples");

      if (!Directory.Exists(DeNSo.Core.Configuration.BasePath))
        Directory.CreateDirectory(DeNSo.Core.Configuration.BasePath);

    }

    protected override void OnExit(ExitEventArgs e)
    {
      base.OnExit(e);
      Session.ShutDown();
    }

  }
}
