﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProSwap.Data
{
    public class Offer
    {
        [Key]
        public int OfferId { get; set; }
        [Required]
        public Guid OwnerId { get; set; }
        [Required]
        [MinLength(10, ErrorMessage ="You must enter at least 10 characters for the title.")]
        public string Title { get; set; }
        [Required]
        [MaxLength(3000, ErrorMessage = "Please shorten your message below 3000 characters and resubmit.")]
        public string Content { get; set; }
        [Required]
        public DateTimeOffset CreatedUTC { get; set; }
        public DateTimeOffset? ModifiedUTC { get; set; }
        [ForeignKey("Game")]
        public int GameId { get; set; }
        public virtual Game Game { get; set; }
    }
}
