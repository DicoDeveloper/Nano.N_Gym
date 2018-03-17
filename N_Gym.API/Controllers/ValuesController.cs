﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using N_Base.Entity.Objects;
using N_Gym.Application.Interfaces;

namespace N_Gym.API.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private IAuditoriaServiceApp _service { get; }

        public ValuesController(IAuditoriaServiceApp service) => _service = service;

        // GET api/values
        [HttpGet]
        public async Task<IEnumerable<Auditoria>> Get()
        {
            var a = await _service.GetAll();
            return a;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
