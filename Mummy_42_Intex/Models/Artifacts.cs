using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mummy_42_Intex.Models
{
    public class Artifacts
    {
        //THIS IS A TEMPORARY FILE TO USE DUMMY DATA!!!
        [Key]
        [Required]
        public int ArtifactId { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public string Material { get; set; }
        public string Dimensions { get; set; }
        public string CurrentLocation { get; set; }
        public string StorageLocation { get; set; }
    }
}

//ArtifactId
//Description
//Date
//Material
//Dimensions
//CurrentLocation
//StorageLocation