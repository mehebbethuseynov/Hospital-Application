﻿using System.ComponentModel.DataAnnotations;

namespace HospitalApp.Models
{
    public  class Doctor:Entity
    {

        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        [Required]
        [StringLength(30)]
        public string Surname { get; set; }
        [Required]
        [StringLength(30)]
        public string PIN { get; set; }
        [Required]
        [StringLength(30)]
        public string Password { get; set; }
       
        public DoctorSpecialty Specialty { get; set; }
        [Required]
        public int SpecialtyId { get; set; }
        
        
    }
}
