﻿using System.ComponentModel.DataAnnotations;
using System.Globalization;
namespace Fyp.Models
{
    public class Patient
    {
        
        public int PatientId { get; set; }
        
        public string Name { get; set; }
        
        public string Address { get; set; }
        
        public string City { get; set; }
        
        public string State { get; set; }
        
        public string Zip { get; set; }
        
        public string Doctor { get; set; }
        
        public string Diagnosis { get; set; }
        
        public string Medication { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}