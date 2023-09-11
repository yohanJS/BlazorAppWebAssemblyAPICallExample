﻿namespace BlazorAppWebAssembly.Models
{
    public class Rover
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? landing_date { get; set; }
        public string? launch_date { get; set; }
        public string? status { get; set; }
        public int max_sol { get; set; }
        public string? max_date { get; set; }
        public int total_photos { get; set; }
        public List<Cameras>? cameras { get; set; }
    }
}
