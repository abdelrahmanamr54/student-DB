using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Model
{
    public enum ResourceType
    {
        Video,
        Presentation,
        Document,
        Other
    }
    internal class Resource
    {
        public int ResourceId { get; set; }
        


        [Column(TypeName = "NVARCHAR(50)")]

        public string Name { get; set; }
        [Column(TypeName = "varchar(200)")]
        public string Url { get; set; }
      
        public ResourceType ResourceType { get; set; }
                public int CourseId { get; set; }

        public Course course { get; set; }

        //        o ResourceId
        //o Name(up to 50 characters, unicode)
        //o Url(not unicode)
        //o ResourceType(enum – can be Video, Presentation, Document or Other)
        //o CourseId
    }
}
