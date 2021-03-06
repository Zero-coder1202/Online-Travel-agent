using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System;
using OTA.Classes;
using Microsoft.AspNetCore.Mvc;

namespace OTA.Pages
{
    public class LandingPagePageModel : PageModel
    {
        public string Background { get; private set; }
        // This property is accessed by "landingpage" page to get "Suggested flights" data.
        public IEnumerable<SuggestedFlight> SuggestedFlights { get; private set; }

        public void OnGet()
        {
            ViewData["Title"] = "Travel OTA Name";
            // Data of "SuggestedFlights" should come from the DB.
            SuggestedFlights = new SuggestedFlight[] {
                SuggestedFlight.Make("../misc/images/as_suggested_flights_thumbnails/japan.jpg", "Tokyo", "0"),
                SuggestedFlight.Make("../misc/images/as_suggested_flights_thumbnails/singapore.jpg", "Singapore", "0"),
                SuggestedFlight.Make("../misc/images/as_suggested_flights_thumbnails/malaysia.jpg", "Malaysia", "0"),
                SuggestedFlight.Make("../misc/images/as_suggested_flights_thumbnails/thailand.jpg", "Bangkok", "0"),
                SuggestedFlight.Make("../misc/images/as_suggested_flights_thumbnails/philippines.jpg", "Bohol", "0"),
                SuggestedFlight.Make("../misc/images/as_suggested_flights_thumbnails/south_korea.jpg", "Seoul", "0"),
                SuggestedFlight.Make("../misc/images/as_suggested_flights_thumbnails/china.jpg", "The Forbidden City", "0"),
                SuggestedFlight.Make("../misc/images/as_suggested_flights_thumbnails/hongkong.jpg", "Hongkong", "0")
            };

            Background = "../misc/images/as_backgrounds/japan.jpg";
        }
    }
}

