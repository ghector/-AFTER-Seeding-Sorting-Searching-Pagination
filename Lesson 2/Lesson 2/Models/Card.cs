using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Lesson_2.Models
{
    public class Card
    {
        [ForeignKey("Employee")]
        public int Id { get; set; }
        public string Title { get; set; }

        public virtual Employee Employee { get; set; }

    }
}