using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ToDoListApi.Data;
using ToDoListApi.Dtos;
using ToDoListApi.Models;
using ToDoListApi.Repositories;
using ToDoListApi.Services;

namespace ToDoListApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ActivitiesController : ControllerBase
    {
        private readonly  IActivityRepository _repository;
        private readonly IMapper _mapper;
        public ActivitiesController(IActivityRepository repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
      
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> GetActivity(int id)
        {
            var activity=await _repository.Get(id);
            if (activity==null)
            {
                return NotFound();
            }
            
            return Ok(activity);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Activity>>> GetActivities()
        {
            var activities = await _repository.GetAll();
            return Ok(activities);
        }
        [HttpPost]
        public async Task<ActionResult> CreateActivity(ActivityDto activityDto)
        {

            Activity activity = _mapper.Map<Activity>(activityDto);
            await _repository.Add(activity);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteActivity(int id)
        {
            await _repository.Delete(id);
            return Ok();
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateProduct(int id,ActivityDto activityDto)
        {

            Activity activity = _mapper.Map<Activity>(activityDto);
            activity.Id = id;
            await _repository.Update(activity);
            return Ok();
        }


       
    }
}
