﻿using Decore.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Decore.ClientApp.ViewModels
{
    public class EventViewModel
    {

        public int Id { get; set; }
        public ICollection<Event> Events { get; set; }
        public int EventId { get; set; }
        public Dictionary<int, string> EventTypes { get; set; }

        [Required(ErrorMessage = "Title måste anges")]
        [StringLength(40, ErrorMessage = "Får ej vara över 40 bokstäver")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Postnummer måste anges")]
        [StringLength(40, ErrorMessage = "Får ej vara över 40 bokstäver")]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Adress måste anges")]
        [StringLength(40, ErrorMessage = "Får ej vara över 40 bokstäver")]
        public string Adress { get; set; }


        [Required(ErrorMessage = "Image Url måste anges")]
        [StringLength(140, ErrorMessage = "Får ej vara över 140 bokstäver")]
        public string ImageURL { get; set; }



        [Required(ErrorMessage = "Event Owner måste anges")]
        [StringLength(40, ErrorMessage = "Får ej vara över 40 bokstäver")]
        public string EventOwner { get; set; }


     

        [Required(ErrorMessage = "Beskrivning måste anges")]
        [StringLength(40, ErrorMessage = "Får ej vara över 40 bokstäver")]
        public string Description { get; set; }


        [Required(ErrorMessage = "Beskrivning måste anges")]
        public float BasePrice { get; set; }


      

    }
}