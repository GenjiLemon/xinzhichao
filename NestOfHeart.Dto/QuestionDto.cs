﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestOfHeart.Dto
{
    public class QuestionDto
    {
        public int Order { get; set; }
        public string Title { get; set; }
        public string Choice { get; set; }
        /// <summary>
        /// 类别 1选择题
        /// </summary>
        public int Type { get; set; }
    }
}
