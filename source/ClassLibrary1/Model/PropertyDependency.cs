﻿using System.Collections.Generic;

namespace ClassLibrary1.Model
{
    public class PropertyDependency
    {
        public PropertyDependency(string propertySource, IEnumerable<string> propertyTarget)
        {
            PropertySource = propertySource;
            PropertyTarget = propertyTarget;
        }

        public string PropertySource { get; }
        public IEnumerable<string> PropertyTarget { get; }
    }
}