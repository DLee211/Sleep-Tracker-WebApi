using Microsoft.AspNetCore.Mvc;
using Sleep_Tracker_WebApi.Models;
using Sleep_Tracker_WebApi.Services;

namespace Sleep_Tracker_WebApi.Controllers;
[ApiController]
[Route("[controller]")]
public class SleepController:ControllerBase
{
    private readonly SleepService _sleepService;

    public SleepController(SleepService sleepService)
    {
        _sleepService = sleepService;
    }

    [HttpGet]
    public ActionResult<List<SleepData>> GetAllSleepData()
    {
        return _sleepService.GetAllSleepData();
    }

    [HttpGet("{id}")]
    public ActionResult<SleepData> GetSleepDataById(int id)
    {
        var sleepData = _sleepService.GetSleepDataById(id);
        if (sleepData == null)
        {
            return NotFound();
        }
        return sleepData;
    }
    
    [HttpPost]
    public ActionResult<SleepData> AddSleepData(SleepData sleepData)
    {
        var createdSleepData = _sleepService.AddSleepData(sleepData);
        return CreatedAtAction(nameof(GetSleepDataById), new { id = createdSleepData.Id }, createdSleepData);
    }
    
    [HttpPut("{id}")]
    public ActionResult UpdateCoffee(int id, SleepData sleepData)
    {
        sleepData.Id = id;
        var existingSleepData = _sleepService.GetSleepDataById(id);
        if (existingSleepData == null)
        {
            return BadRequest();
        }
        _sleepService.UpdateSleepData(sleepData);
        return NoContent();
    }
    
    [HttpDelete("{id}")]
    public ActionResult DeleteCoffee(int id)
    {
        _sleepService.DeleteSleepData(id);
        return NoContent();
    }
}