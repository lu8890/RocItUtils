using System;
using System.Collections.Generic;
using System.Configuration;

namespace lu8890.UtilityLibraries
{
    public class WebconfigObj
    {
        private readonly Dictionary<string, string> _appSettings;
        public WebconfigObj()
        {
            _appSettings = new Dictionary<string, string>();

            foreach (var appset in ConfigurationManager.AppSettings.Keys)
            {
                if (!_appSettings.ContainsKey(appset.ToString().Trim()))
                {
                    _appSettings.Add(appset.ToString().Trim(), ConfigurationManager.AppSettings[appset.ToString()].Trim());
                }
                else
                    throw new Exception("[Web.Config Error] Duplicate Key Error: " + appset);
            }

            for (var i = 0; i < ConfigurationManager.ConnectionStrings.Count; i++)
            {
                if (!_appSettings.ContainsKey(ConfigurationManager.ConnectionStrings[i].Name.Trim()))
                {
                    _appSettings.Add(ConfigurationManager.ConnectionStrings[i].Name.Trim(), ConfigurationManager.ConnectionStrings[i].ConnectionString.Trim());
                }
                else
                    throw new Exception("[Web.Config Error] Duplicate Connstring Key Error: " + ConfigurationManager.ConnectionStrings[i].Name.Trim());
            }
        }

        public bool HasKey(string keyName)
        {
            return (_appSettings.ContainsKey(keyName) && !string.IsNullOrWhiteSpace(_appSettings[keyName]));
        }

        public string GetValue(string keyName)
        {
            if (_appSettings != null)
                return HasKey(keyName) ? _appSettings[keyName] : string.Empty;
            return string.Empty;
        }

        public int? GetValueAsInt(string keyName)
        {
            if (!HasKey(keyName)) return null;

            int intOut;
            if (_appSettings != null && int.TryParse(_appSettings[keyName], out intOut))
                return intOut;

            return null;
        }
    }
}