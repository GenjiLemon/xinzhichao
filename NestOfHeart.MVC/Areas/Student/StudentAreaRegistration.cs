﻿using System.Web.Mvc;

namespace NestOfHeart.MVC.Areas.Student
{
    public class StudentAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Student";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Student_default",
                "Student/{controller}/{action}/{id}",
                new { Controller="Home",action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}