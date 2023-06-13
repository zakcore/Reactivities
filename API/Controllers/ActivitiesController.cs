using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class ActivitiesController:BaseApiController
    {
        private readonly DataContext _context;
        public ActivitiesController(DataContext context)
        {
            _context = context;
            
        }

         [HttpGet]

         public async Task<ActionResult<List<Activity>>>Getactivities(){

            return await _context.Activities.ToListAsync();
         }
       [HttpGet ("{id}")]
       public async Task<ActionResult<Activity>> GetActivity(Guid Id){

        return await _context.Activities.FindAsync(Id);
       }

    }
}