using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

using OhanaSupport.Enumerators;

namespace OhanaSupport.Models {
    [Table("Links")]
    public class Link {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Description { get; set; }
        
        public string Origin { get; set; }

        public DateTime? Published { get; set; }
        
        [Required]
        public LinkType Type { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        //Navigational Properties
        public List<LinkTag> LinkTags { get; set; }
    }
}