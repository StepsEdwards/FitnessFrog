using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitnessFrog.Models
{
    public class Activity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public enum ActivityType
        {
            Basketball = 1,
            Biking = 2,
            Hiking = 3,
            Kayaking = 4,
            PokemonGo = 5,
            Running = 6,
            Skiing = 7,
            Swimming = 8,
            Walking = 9,
            Weightlifting = 10
        }

        public Activity(ActivityType activityType, string name = null)
        {
            Id = (int)activityType;
            Name = name ?? activityType.ToString();
        }
    }
}