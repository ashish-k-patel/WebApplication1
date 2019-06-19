using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppication1.Models;

namespace WebApplication1.Models
{
    public static class Helper
    {
        public static string RecursiveTree(List<Location> categories)
        {
            string htmlOutput = string.Empty;

            if (categories.Count() > 0)
            {
                htmlOutput += "<ul>";
                foreach (Location category in categories)
                {
                    htmlOutput += "<li>";
                    htmlOutput += category.Name;
                    htmlOutput += RecursiveTree(category.ChildrenLocations);
                    htmlOutput += "</li>";
                }
                htmlOutput += "</ul>";
            }

            return htmlOutput;
        }
    }
}
