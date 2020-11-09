using System;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

namespace OhanaSupport.Models {
    [Table("LinkTags")]
    public class LinkTag {
        public Guid LinkId { get; set; }

        public Guid TagId { get; set; }

        //Navigational Properties
        [ForeignKey("LinkId")]
        public Link Link { get; set; }
        [ForeignKey("TagId")]
        public Tag Tag { get; set; }
    }
}