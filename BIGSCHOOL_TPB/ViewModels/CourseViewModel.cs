﻿using BIGSCHOOL_TPB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BIGSCHOOL_TPB.ViewModels
{
    public class CourseViewModel
    {
        public string Place { get; set; }

        public string Date { get; set; }

        public string Time { get; set; }

        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }

        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }

    }
}