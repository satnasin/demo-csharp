﻿using System.Collections.Generic;

namespace Common
{
    public class SauceLabsCapabilities
    {
        private List<string> _tags;

        public SauceLabsCapabilities()
        {
            _tags = new List<string>();
        }

        public bool IsDebuggingEnabled { get; set; }

        public List<string> Tags
        {
            get => _tags;
            set => _tags = value;
        }

        public static string BuildName { get; set; }
        public static string TunnelIdentifier => "tunnelIdentifier";
    }
}