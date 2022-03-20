using _2022Hackathon.DA.Repositories.Bases;
using _2022HackatonAroundTheWal.Bases;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2022HackathonAroundTheWal.Controllers
{
    public class SitesTouristiquesController : ControllerBase
    {
        private readonly ILieuxRepository lieuxRepo;
        public SitesTouristiquesController(ILieuxRepository lieux) 
        {
            this.lieuxRepo = lieux;
        }

        // GET: SitesTouristiquesController/Liste
        [HttpGet("Liste")]
        public ActionResult<IEnumerable<ILieu>> Get()
        {
            try
            {
                return Ok(lieuxRepo.Read());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    new
                    {
                        Method = "Get",
                        Message = ex.Message
                    });
            }
        }

        // GET: SitesTouristiquesController/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                return Ok(lieuxRepo.Read(id));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    new
                    {
                        Method = "Get",
                        Message = ex.Message
                    });
            }
        }

        //GET: SitesTouristiquesController/Details/Balade
        public ActionResult Search(string critere)
        {
            try
            {
                return Ok(lieuxRepo.Search());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    new
                    {
                        Method = "Get",
                        Message = ex.Message
                    });
            }
        }
    }
}
