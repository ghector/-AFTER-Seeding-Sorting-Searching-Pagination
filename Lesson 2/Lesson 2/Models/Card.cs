using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Lesson_2.Models
{
    public class Card
    {
        [ForeignKey("Employee")]
        public int Id { get; set; }

        [StringLength(maximumLength: 30,ErrorMessage ="O titlos prepei na einai metaksi 2 eos 30 xaraktiron",MinimumLength =2)]
        public string Title { get; set; }

        public virtual Employee Employee { get; set; }

    }
}