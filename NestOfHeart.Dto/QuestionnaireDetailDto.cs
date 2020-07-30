﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestOfHeart.Dto
{
    public class QuestionnaireDetailDto
    {
        public Guid StudentId { get; set; }
        public string StudentName { get; set; }
        public QuestionnaireDto Questionnaire { get; set; }
        public DateTime FinishTime { get; set; }
        public float Score { get; set; }

    }
}
