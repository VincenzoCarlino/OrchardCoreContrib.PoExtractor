﻿using System.Collections.Generic;

namespace OrchardCoreContrib.PoExtractor
{
    /// <summary>
    /// Represents a localizable text with all it's occurrences in the project
    /// </summary>
    public class LocalizableString
    {
        /// <summary>
        /// Gets or sets context of the 
        /// </summary>
        public string Context { get; set; }

        /// <summary>
        /// Gets or sets the localizable text
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the localizable text for the plural
        /// </summary>
        public string TextPlural { get; set; }

        /// <summary>
        /// Gets collection of all locations of the text in the project
        /// </summary>
        public List<LocalizableStringLocation> Locations { get; }

        /// <summary>
        /// Creates a new instance of the <see cref="LocalizableString" class />
        /// </summary>
        public LocalizableString()
        {
            Locations = new List<LocalizableStringLocation>();
        }

        /// <summary>
        /// Creates a new instance of the <see cref="LocalizableString"/> and properties with data from the source
        /// </summary>
        /// <param name="source">the <see cref="LocalizableStringOccurence"/> with the data</param>
        public LocalizableString(LocalizableStringOccurence source)
        {
            Text = source.Text;
            TextPlural = source.TextPlural;
            Context = source.Context;

            Locations = new List<LocalizableStringLocation>();
            Locations.Add(source.Location);
        }
    }
}
