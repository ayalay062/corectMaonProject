﻿using BL;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace corectMaonProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassesController : ControllerBase
    {
        ClassesBL _classesBL = new ClassesBL();

        [HttpGet]
        //שליפה
        public IActionResult getAll()
        {
            return Ok(_classesBL.getAll());

        }

        [HttpPut]
        //עדכון
        public IActionResult uppdate(ClassesDTO classes)
        {
            return Ok(_classesBL.uppdate(classes));

        }
        [HttpPost]
        //הוספה
        public IActionResult AddClasses(ClassesDTO classes)
        {
            return Ok(_classesBL.AddClasses(classes));

        }
        [HttpDelete]
        public IActionResult Delete(int ClassId)
        {
            return Ok(_classesBL.Delete(ClassId));

        }

    }


}
