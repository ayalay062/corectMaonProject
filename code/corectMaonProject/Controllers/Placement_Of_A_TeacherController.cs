﻿using BL;
using DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace corectMaonProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Placement_Of_A_TeacherController : ControllerBase
    {
        Placement_Of_A_TeacherBL _Placement_Of_A_TeacherBL = new Placement_Of_A_TeacherBL();

        [HttpGet]
        //שליפה
        public IActionResult getAll()
        {
            return Ok(_Placement_Of_A_TeacherBL.getAll());

        }

        [HttpPut]
        //עדכון
        public IActionResult uppdate(Placement_Of_A_TeacherDTO Placement_Of_A_Teacher)
        {
            return Ok(_Placement_Of_A_TeacherBL.uppdate(Placement_Of_A_Teacher));

        }
        [HttpPost]
        //הוספה
        public IActionResult AddPlacementOfATeacher(Placement_Of_A_TeacherDTO Placement_Of_A_Teacher)
        {
            return Ok(_Placement_Of_A_TeacherBL.AddPlacementOfATeacher(Placement_Of_A_Teacher));

        }
        [HttpDelete]
        public IActionResult Delete(int IdPlacementOfATeacher)
        {
            return Ok(_Placement_Of_A_TeacherBL.Delete(IdPlacementOfATeacher));

        }

    }
}
