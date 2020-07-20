﻿// This file is part of the TA.NexDome.AscomServer project
//
// Copyright © 2015-2020 Tigra Astronomy, all rights reserved.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated
// documentation files (the "Software"), to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so. The Software comes with no warranty of any kind.
// You make use of the Software entirely at your own risk and assume all liability arising from your use thereof.
//
// File: Settings.cs  Last modified: 2020-07-20@17:59 by Tim Long

// ReSharper disable once CheckNamespace

using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using ASCOM;
using Ninject;
using NLog;
using TA.Utils.Core.Diagnostics;
using SettingsProvider = ASCOM.SettingsProvider;

namespace TA.NexDome.Server.Properties
    {
    // This class allows you to handle specific events on the settings class:
    // The SettingChanging event is raised before a setting's value is changed.
    // The PropertyChanged event is raised after a setting's value is changed.
    // The SettingsLoaded event is raised after the setting values are loaded.
    // The SettingsSaving event is raised before the setting values are saved.
    [SettingsProvider(typeof(SettingsProvider))]
    [DeviceId(SharedResources.DomeDriverId, DeviceName = SharedResources.DomeDriverName)]
    public sealed partial class Settings
        {
        private readonly ILogger log = LogManager.GetCurrentClassLogger();

        public Settings()
            {
            SettingChanging += SettingChangingEventHandler;
            SettingsSaving += SettingsSavingEventHandler;
            SettingsLoaded += SettingsLoadedEventHandler;
            PropertyChanged += SettingChangedEventHandler;
            }

        private ILog Log => CompositionRoot.Kernel.Get<ILog>();

        private void SettingChangedEventHandler(object sender, PropertyChangedEventArgs args)
            {
            Log.Debug().Message("Setting changed: {property}",args.PropertyName).Write();
            }

        private void SettingsLoadedEventHandler(object sender, SettingsLoadedEventArgs e)
            {
            Log.Debug().Message("Settings loaded").WithSettings(this.Context).Write();
            }

        private void SettingChangingEventHandler(object sender, SettingChangingEventArgs e)
            {
            var log = CompositionRoot.Kernel.Get<ILog>();
            log.Debug()
                .Message("Setting changing {settingName}[{settingKey}] -> {newValue}", e.SettingKey, e.SettingName,
                    e.NewValue)
                .Write();
            }

        private void SettingsSavingEventHandler(object sender, CancelEventArgs e)
            {
            var log = CompositionRoot.Kernel.Get<ILog>();
            log.Debug()
                .Message("Saving settings");
            }
        }
    }