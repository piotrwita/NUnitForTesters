using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace NUnitForTesters.Services
{
    public class CollectionService
    {
        public List<string> Names { get; set; }

        public CollectionService(List<string> names)
        {
            Names = names;
        }

        public CollectionService()
        {
            Names = new List<string> { "Clayton Richey", "Michael Brown", "Ireneusz Sobczak", "Marek Wieczorek" };
        }

        public List<string> GetInitialsFromNames()
        {
            return Names
                .Select(n => GetInitials(n))
                .ToList();
        }

        private string GetInitials(string name)
        {
            return Regex.Replace(name, @"(?i)(?:^|\s|-)+([^\s-])[^\s-]*(?:(?:\s+)(?:the\s+)?(?:jr|sr|II|2nd|III|3rd|IV|4th)\.?$)?", "$1").ToUpper();
        }
    }
}
