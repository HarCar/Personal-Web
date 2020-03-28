using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Personal_Web.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Alias { get; set; }
        public string Password { get; set; }

    }
}