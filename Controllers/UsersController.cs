﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PRSNetWeb.Models;

namespace PRSNetWeb.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase {
        private static AppDbContext _context = null;
        public UsersController(AppDbContext context) { 
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<User>> GetAllUsers() {
            return await _context.Users.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUserByPK(int id) {
            var user = await _context.Users.FindAsync(id);
            if (user == null) return NotFound();
            return new OkObjectResult(user);
        }

        [HttpPost]
        public async Task<IActionResult> Insert(User user) {
            if (user == null) return new BadRequestResult();
            _context.Users.Add(user); //only adds to the collection, not the database
            await _context.SaveChangesAsync(); //saves changes to database by id
            return new OkResult(); //returns ok when the result was added successfully
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(User user, int id) {
            if (user == null || user.Id != id) return new BadRequestResult();
            _context.Entry(user).State = EntityState.Modified; //should modify what matches database
            await _context.SaveChangesAsync();
            return new OkResult();
        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteByPK(int id) {
            var user = await _context.Users.FindAsync(id);
            if (user == null) return NotFound();
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return new OkResult();
        }

        [HttpGet("{username}/{password}")]
        public async Task<ActionResult<User>> Login(string username, string password) {
            if (username == null || password == null) return new BadRequestResult();
            var user = await _context.Users
                .SingleOrDefaultAsync(x => x.Username.Equals(username)
                    && x.Password.Equals(password));
            if (user == null) return NotFound();
            return new OkObjectResult(user);
        }
    }
}