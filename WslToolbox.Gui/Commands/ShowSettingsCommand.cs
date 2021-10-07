﻿using WslToolbox.Gui.Handlers;
using WslToolbox.Gui.Views;

namespace WslToolbox.Gui.Commands
{
    public class ShowSettingsCommand : GenericCommand
    {
        private readonly ConfigurationHandler _config;

        public ShowSettingsCommand(ConfigurationHandler config)
        {
            _config = config;
        }

        public override void Execute(object parameter)
        {
            SettingsView settingsWindow = new(_config.Configuration, _config);
            settingsWindow.ShowDialog();

            // SaveConfiguration:
            // if (settingsWindow.DialogResult != null && (bool) settingsWindow.DialogResult &&
            //     IsExecutable(null)) Execute(null);

            settingsWindow.Close();
        }
    }
}