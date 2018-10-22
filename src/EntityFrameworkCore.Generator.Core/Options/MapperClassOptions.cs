﻿using System;

namespace EntityFrameworkCore.Generator.Options
{
    /// <summary>
    /// View model mapper class options
    /// </summary>
    /// <seealso cref="EntityFrameworkCore.Generator.Options.ClassOptionsBase" />
    public class MapperClassOptions : ClassOptionsBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MapperClassOptions"/> class.
        /// </summary>
        public MapperClassOptions(VariableDictionary variables, string prefix)
            : base(variables, AppendPrefix(prefix, "Mapper"))
        {
            Namespace = "{Project.Namespace}.Domain.Mapping";
            Directory = @"{Project.Directory}\Domain\Mapping";

            BaseClass = "Profile";
            Name = "{Model.Name}Profile";
        }

        /// <summary>
        /// Gets or sets the mapper class name template.
        /// </summary>
        /// <value>
        /// The mapper class name template.
        /// </value>
        public string Name
        {
            get => GetProperty();
            set => SetProperty(value);
        }

        /// <summary>
        /// Gets or sets the base class to inherit from.
        /// </summary>
        /// <value>
        /// The base class.
        /// </value>
        public string BaseClass
        {
            get => GetProperty();
            set => SetProperty(value);
        }
    }
}