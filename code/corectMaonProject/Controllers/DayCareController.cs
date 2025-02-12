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
    public class DayCareController : ControllerBase
    {
        DayCareBL _DayCareBL = new DayCareBL();

        [HttpGet]
        [Route("getAll")]
        //שליפה
        public IActionResult GetAll()
        {
            return Ok(_DayCareBL.GetAll());

        }

        [HttpGet]
        [Route("getDayCareByKids/{kidsId}")]
        public IActionResult GetDayCareByKids(int kidsId)
        {
            return Ok(_DayCareBL.GetDayCareByKids(kidsId));
        }


        [HttpPut]
        //עדכון
        public IActionResult uppdata(DayCareDTO DayCare)
        {
            return Ok(_DayCareBL.update(DayCare));

        }
        [HttpPost]
        //הוספה
        public IActionResult AddDayCare(DayCareDTO DayCare)
        {
            return Ok(_DayCareBL.AddDayCare(DayCare));

        }
        [HttpPost]
        [Route("AddUpdateKidCare")]
        //הוספה
        public IActionResult AddUpdateKidCare(DayCareDTO DayCare)
        {
            return Ok(_DayCareBL.AddUpdateKidCare(DayCare));

        }
        
        [HttpDelete]
        public IActionResult Delete(int IdDayCare)
        {
            return Ok(_DayCareBL.Delete(IdDayCare));

        }

    }


}

