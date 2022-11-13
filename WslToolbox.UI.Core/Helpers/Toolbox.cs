﻿using System.Reflection;

namespace WslToolbox.UI.Core.Helpers;

public static class Toolbox
{
    public static readonly string AppDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
    public static readonly string AppData = @$"{AppDirectory}\data";

    public static readonly string UserConfiguration = @$"{AppData}\config.json";
    public static readonly string LogFile = @$"{AppData}\log.txt";
}