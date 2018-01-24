﻿using Umbraco.Core.PropertyEditors;

namespace Umbraco.Web.PropertyEditors
{
    /// <summary>
    /// Represents the configuration for the nested content value editor.
    /// </summary>
    public class NestedContentConfiguration : ConfigurationEditor
    {
        [ConfigurationField("contentTypes", "Doc Types", "views/propertyeditors/nestedcontent/nestedcontent.doctypepicker.html", Description = "Select the doc types to use as the data blueprint.")]
        public string[] ContentTypes { get; set; }

        [ConfigurationField("minItems", "Min Items", "number", Description = "Set the minimum number of items allowed.")]
        public int MinItems { get; set; }

        [ConfigurationField("maxItems", "Max Items", "number", Description = "Set the maximum number of items allowed.")]
        public int MaxItems { get; set; }

        [ConfigurationField("confirmDeletes", "Confirm Deletes", "boolean", Description = "Set whether item deletions should require confirming.")]
        public string ConfirmDeletes { get; set; } // fixme bool

        [ConfigurationField("showIcons", "Show Icons", "boolean", Description = "Set whether to show the items doc type icon in the list.")]
        public string ShowIcons { get; set; } // fixme bool

        [ConfigurationField("hideLabel", "Hide Label", "boolean", Description = "Set whether to hide the editor label and have the list take up the full width of the editor window.")]
        public string HideLabel { get; set; } // fixme bool
    }
}