﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProSwap.Models.Game
{
    public class GameCreate
    {
        [Required]
        public string Name { get; set; }
    }
}
