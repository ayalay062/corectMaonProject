﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
  public  class TeacherAndPerson
    {
        public long TeacherId { get; set; }
        public long TeacherTz { get; set; }

        public string PersonName { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string PhoneNamber1 { get; set; }
        public string PhoneNamber2 { get; set; }
        
        public string Password { get; set; }



    }
}
