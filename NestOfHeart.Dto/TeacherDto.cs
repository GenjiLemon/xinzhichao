﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestOfHeart.Dto
{
    public class TeacherDto:UserDto
    {
        public Guid TeacherId { get; set; }
        public List<string> ClassNames { get; set; }

    }
}