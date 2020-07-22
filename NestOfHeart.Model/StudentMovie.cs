using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace NestOfHeart.Model
{
    /// <summary>
    /// 学生看电影的详情表
    /// </summary>
    public class StudentMovie:BaseEntity
    {
        [ForeignKey(nameof(Student))]
        public Guid StudentId { get; set; }
        public Student Student { get; set; }

        [ForeignKey(nameof(Movie))]
        public Guid MovieId { get; set; }
        public Movie Movie { get; set; }

    }
}