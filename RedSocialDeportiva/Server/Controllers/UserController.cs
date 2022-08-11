﻿using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RedSocialDeportiva.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET: api/<UserController>
        [HttpGet]
        public async Task<LoginDataDTO> Get()
        {

            LoginDataDTO loginDataDTO = new LoginDataDTO
            {
                User = new User
                {
                    UserName = "Nomber completo",
                    Email = "AASDASD",
                    Id = "e21e12",
                    NameCompleted = "sacasc", 
                    LastName = "ADS"
                },
                Token = "aaaaaaaaadqwdqwdo12kwqndkas",
                MessageError = ""
            };


            return loginDataDTO;
        }
    

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
