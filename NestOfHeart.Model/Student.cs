using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NestOfHeart.Model
{
    public class Student:BaseEntity
    {
        [StringLength(20)]
        public string Name { get; set; }
        [ForeignKey(nameof(Class))]
        public Guid ClassId { get; set; }
        public Class Class { get; set; }
    }
}