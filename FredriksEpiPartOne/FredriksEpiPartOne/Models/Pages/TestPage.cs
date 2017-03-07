using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.ChangeLog;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace FredriksEpiPartOne.Models.Pages
{
    [ContentType(DisplayName = "TestPage", GUID = "564163c4-1e07-4086-bb52-ef35bd7cdd1d", Description = "")]
    public class TestPage : PageData
    {
        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual XhtmlString MainBody { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Namnet i editorn",
            Description = "Lite hjälptext eller så.",
            GroupName = "Grupp 1",
            Order = 10
            )]
        public virtual string Header { get; set; }
    }
}