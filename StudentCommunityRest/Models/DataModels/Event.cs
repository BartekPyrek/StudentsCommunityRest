using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentCommunityRest.Models
{
    public enum EventType
    {
        kolokwium,
        spotkanie,
        egzamin,
        inne
    }

    public class Event
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Grupa ")]
        public int GroupID { get; set; }

        [ForeignKey("GroupID")]
        [Display(Name = "Grupa")]
        public virtual Group Group { get; set; }

        [Display(Name = "Stworzył")]
        public virtual ApplicationUser User { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}",
               ApplyFormatInEditMode = true)]
        [Display(Name = "Data")]
        public DateTime Datetime { get; set; }

        [Required]
        [Display(Name = "Rodzaj")]
        public EventType EventType { get; set; }

        [Required]
        [Display(Name = "Opis")]
        public String Description { get; set; }
    }
}
