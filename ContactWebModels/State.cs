﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactWebModels
{
    public class State
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "State")]
        [Required(ErrorMessage = "Name of State is required")]
        [StringLength(ContactManagerConstants.MAX_STATE_NAME_LENGTH)]
        public string Name { get; set; }

        [Required(ErrorMessage = "State Abbreviation is required")]
        [StringLength(ContactManagerConstants.MAX_STATE_ABBR_LENGTH)]
\
        public string Abbreviation { get; set; }
    }
}
