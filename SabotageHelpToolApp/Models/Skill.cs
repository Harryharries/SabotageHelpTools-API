﻿namespace SabotageHelpToolApp.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public Character? Character { get; set; }

    }
}
