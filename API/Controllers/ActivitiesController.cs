using Application.Activities;
using Application.Activities.Commands;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class ActivitiesController : BaseApiController
    {
        
        [HttpGet] //api/activities
        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
            return await Mediator.Send(new GetAllActivities());
        }

        [HttpGet("{id}")] //api/acitivities/guid-12345
        public async Task<ActionResult<Activity>> GetActivity(Guid id)
        {
            return await Mediator.Send(new GetActivityById() {Id = id});            
        }
        [HttpPost] 
        public async Task<IActionResult> CreateActivity(Activity activity)
        {
            await Mediator.Send(new CreateActivity {Activity = activity});
            return Ok();
        }
        [HttpPut("{id}")] 
        public async Task<IActionResult> UpdateActivity(Guid id, Activity activity)
        {
            activity.Id = id;
            await Mediator.Send(new UpdateActivity {Activity = activity});
            return Ok();
        }
        [HttpDelete("{id}")] 
        public async Task<IActionResult> DeleteActivity(Guid id)
        {
            await Mediator.Send(new DeleteActivity {Id = id});
            return Ok();
        }

    }
}