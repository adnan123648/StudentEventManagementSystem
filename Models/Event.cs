using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace StudentEventAPI.Models
{
    public class Event
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Venue { get; set; }

        [Required]
        [JsonPropertyName("eventDate")] // 👈 Fixes mapping
        public DateTime Date { get; set; }

        public string Description { get; set; }

        public ICollection<EventParticipant> EventParticipants { get; set; } = new List<EventParticipant>();
    }
}
