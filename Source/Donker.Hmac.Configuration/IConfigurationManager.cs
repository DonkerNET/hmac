﻿using System.Collections.Generic;
using System.IO;

namespace Donker.Hmac.Configuration
{
    /// <summary>
    /// Interface for a configuration manager class used for loading configuration objects from a file.
    /// </summary>
    /// <typeparam name="TConfiguration">The type of configurations that are managed.</typeparam>
    /// <typeparam name="TKey">The key used to retrieve a configuration.</typeparam>
    public interface IConfigurationManager<TConfiguration, TKey>
    {
        /// <summary>
        /// Gets the default configuration.
        /// </summary>
        /// <returns>A new configuration instance.</returns>
        TConfiguration GetDefault();
        /// <summary>
        /// Gets a key collection of all the configurations that are available.
        /// </summary>
        /// <returns>A collection of keys.</returns>
        ICollection<TKey> GetAllKeys();
        /// <summary>
        /// Tries to get the configuration for the specified key.
        /// </summary>
        /// <param name="key">The key to retrieve the configuration for.</param>
        /// <param name="configuration">The retrieved configuration instance.</param>
        /// <returns><c>true</c> if found; otherwise, <c>false</c>.</returns>
        bool TryGet(TKey key, out TConfiguration configuration);
        /// <summary>
        /// Gets the configuration for the specified key.
        /// </summary>
        /// <param name="key">The key to retrieve the configuration for.</param>
        /// <returns>A new configuration instance.</returns>
        TConfiguration Get(TKey key);
        /// <summary>
        /// Checks if a configuration exists for the specified key.
        /// </summary>
        /// <param name="key">The key of the configuration to find.</param>
        /// <returns><c>true</c> if found; otherwise, <c>false</c>.</returns>
        bool Contains(TKey key);
        /// <summary>
        /// Loads all configurations from the specified string.
        /// </summary>
        /// <param name="config">The string to load the configurations from.</param>
        /// <param name="format">Specified in which format the config is written (XML, JSON, etc.).</param>
        void ConfigureFromString(string config, string format);
        /// <summary>
        /// Loads all configurations from an XML application configuration file.
        /// </summary>
        void ConfigureFromXmlAppConfig();
        /// <summary>
        /// Loads all configurations from the specified file.
        /// </summary>
        /// <param name="file">The file to load the configurations from.</param>
        void ConfigureFromFile(FileInfo file);
        /// <summary>
        /// Loads all configurations from the specified file.
        /// </summary>
        /// <param name="filePath">The path to the file to load the configurations from.</param>
        void ConfigureFromFile(string filePath);
        /// <summary>
        /// Loads all configurations from the specified file and watches this file for any changes.
        /// </summary>
        /// <param name="file">The file to load the configurations from.</param>
        void ConfigureFromFileAndWatch(FileInfo file);
        /// <summary>
        /// Loads all configurations from the specified file and watches this file for any changes.
        /// </summary>
        /// <param name="filePath">The path to the file to load the configurations from.</param>
        void ConfigureFromFileAndWatch(string filePath);
    }
}