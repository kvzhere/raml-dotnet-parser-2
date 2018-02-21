﻿using System.Collections.Generic;

namespace ClassLibrary1.Model
{
    public class Shape
    {
        /// <summary>
        /// Shape
        /// </summary>
        public Shape(string name, string displayName, string description, string @default, IEnumerable<string> values, IEnumerable<Shape> inherits)
        {
            Name = name;
            DisplayName = displayName;
            Description = description;
            Default = @default;
            Values = values;
            Inherits = inherits;
        }

        // shape
        public string Name { get; }
        public string DisplayName { get; }
        public string Description { get; }
        public string Default { get; }
        public IEnumerable<string> Values { get; }
        public IEnumerable<Shape> Inherits { get; }
    }
}