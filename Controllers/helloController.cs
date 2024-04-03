using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MC1_Controller_redo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SayHielloController : ControllerBase
    {
       [HttpGet]
        public string SayHi(string firstName){
            return "Hi " + firstName;
        } 
    }
}