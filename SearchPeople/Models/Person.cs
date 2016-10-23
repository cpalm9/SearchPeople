using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;

namespace SearchPeople.Models
{
    public class Person
    {
        public int ID { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public int age { get; set; }
        public string address { get; set; }
        public string interests { get; set; }
        public string profilePicture { get; set; }
    }
}