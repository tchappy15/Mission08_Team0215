using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mission08_Team0215.Models
{
    public partial class Quadrant
    {
        [Key]
        public int QuadantId { get; set; }
        public string? TaskName { get; set; }

        public string? DueDate { get; set; }

        public string? QuadrantNum { get; set; }

        public int? CategoryId { get; set; }

        public int? Completed { get; set; }

    }

}




