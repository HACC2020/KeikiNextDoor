using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

namespace OhanaSupport.Models {
    [Table("Tags")]
    public class Tag {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }

        [Required]
        public string Text { get; set; }

        //Navigational Properties
        public List<LinkTag> LinkTags { get; set; }
    }
}