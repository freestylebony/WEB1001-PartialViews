using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using PartialViews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialViews.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public List<Films> Films;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            
            Films = new List<Films>();
            Films.Add(new Films {Title = "Slaughter in San Fransisco", Description = "A Chinese-American cop, skilled in martial arts, battles the most powerful criminal gang in San Francisco that is responsible for the death of his partner.", Duration = "1h 27m" });
            Films.Add(new Models.Films { Title = "Hard Target", Description = "A woman hires a drifter as her guide through New Orleans in search of her missing father. In the process, they discover a deadly game of cat and mouse behind his disappearance.", Duration = "1h 37m" });
            Films.Add(new Models.Films { Title = "Rush Hour", Description = "A loyal and dedicated Hong Kong Inspector teams up with a reckless and loudmouthed L.A.P.D. detective to rescue the Chinese Consul's kidnapped daughter, while trying to arrest a dangerous crime lord along the way.", Duration = "1h 38m" });
            Films.Add(new Models.Films { Title = "Kung Fu Panda", Description = "To everyone's surprise, including his own, Po, an overweight, clumsy panda, is chosen as protector of the Valley of Peace. His suitability will soon be tested as the valley's arch-enemy is on his way", Duration = "1h 32m" });
            Films.Add(new Models.Films { Title = "Street Fighter", Description = "Col. Guile and various other martial arts heroes fight against the tyranny of Dictator M. Bison and his cohorts.", Duration = "1h 42m" });
            Films.Add(new Models.Films { Title = "Rambo", Description = "Col. Guile and various other martial arts heroes fight against the tyranny of Dictator M. Bison and his cohorts.", Duration = "1h 29m" });
        }

        public void OnGet()
        {

        }
    }
}
