using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pokedex
{
    public class RepairNames
    {
        private static RepairNames _service;

        public static RepairNames Instance()
        {
            if (_service == null)
                _service = new RepairNames();

            return _service;
        }

        public string Repair(string name)
        {
            var count = name.ToCharArray().ToList().FindAll(x => x == '-').Count();

            if (count >= 2)
            {
                var index = name.IndexOf('-');
                name = name.Substring(0, index);
            }
            else if (name.Contains("incarnate"))
            {
                name = name.Replace("-incarnate", "");
            }
            else if (name.Contains("standard"))
            {
                name = name.Replace("-standard", "");
            }
            else if (name.Contains("male"))
            {
                name = name.Replace("-male", "");
            }
            else if (name.Contains("amped"))
            {
                name = name.Replace("-amped", "");
            }
            else if (name.Contains("altered"))
            {
                name = name.Replace("-altered", "");
            }
            else if (name.Contains("ice"))
            {
                name = name.Replace("-ice", "");
            }
            else if (name.Contains("disguised"))
            {
                name = name.Replace("-disguised", "");
            }
            else if (name.Contains("solo"))
            {
                name = name.Replace("-solo", "");
            }
            else if (name.Contains("normal"))
            {
                name = name.Replace("-normal", "");
            }
            else if (name.Contains("plant"))
            {
                name = name.Replace("-plant", "");
            }
            else if (name.Contains("land"))
            {
                name = name.Replace("-land", "");
            }
            else if (name.Contains("ordinary"))
            {
                name = name.Replace("-ordinary", "");
            }
            else if (name.Contains("aria"))
            {
                name = name.Replace("-aria", "");
            }
            else if (name.Contains("shield"))
            {
                name = name.Replace("-shield", "");
            }
            else if (name.Contains("average"))
            {
                name = name.Replace("-average", "");
            }
            else if (name.Contains("50"))
            {
                name = name.Replace("-50", "");
            }
            else if (name.Contains("baile"))
            {
                name = name.Replace("-baile", "");
            }
            else if (name.Contains("midday"))
            {
                name = name.Replace("-midday", "");
            }

            return name;
        }
    }
}
