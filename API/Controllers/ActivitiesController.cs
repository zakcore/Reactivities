using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Application.Activities;

namespace API.Controllers
{
    public class ActivitiesController:BaseApiController
    {
    

         [HttpGet]

         public async Task<ActionResult<List<Activity>>>Getactivities(){

            return await Mediator.Send(new List.Query());
         }
       [HttpGet ("{id}")]
        public async Task<ActionResult<Activity>> GetActivity(Guid id)
        {

            return await Mediator.Send(new Details.Query{Id=id});
       }

       [HttpPost]

       public async Task<IActionResult>CreateActivity(Activity activity){

        return  Ok(await Mediator.Send(new Create.Command{Activity=activity}));

       }

       [HttpPut("{id}")]

       public async Task<IActionResult>EditActivity(Guid id,Activity act){

        act.Id=id;
        return Ok(await Mediator.Send(new Edit.Command{Activity=act}));
        

       }

       [HttpDelete("{id}")]
       public async Task<IActionResult> DeleteActivity(Guid id){

        return Ok(await Mediator.Send(new Delete.Command{Id=id}));
       }

    }
}