using Sleep_Tracker_WebApi.Models;

namespace Sleep_Tracker_WebApi.Services;

public class SleepService
{
    private readonly SleepDbContext _context;
    
    public SleepService(SleepDbContext context)
    {
        _context = context;
    }
    
    public List<SleepData> GetAllSleepData()
    {
        return _context.SleepDatas.ToList();
    }
    
    public SleepData GetSleepDataById(int id)
    {
        return _context.SleepDatas.FirstOrDefault(s => s.Id == id);
    }
    
    public SleepData AddSleepData(SleepData sleepData)
    {
        _context.SleepDatas.Add(sleepData);
        _context.SaveChanges();
        return sleepData;
    }
    
    public SleepData UpdateSleepData(SleepData sleepData)
    {
        var existingSleepData = _context.SleepDatas.FirstOrDefault(s => s.Id == sleepData.Id);
        if (existingSleepData != null)
        {
            existingSleepData.Date = sleepData.Date;
            existingSleepData.Hours = sleepData.Hours;
            existingSleepData.Minutes = sleepData.Minutes;
            existingSleepData.Notes = sleepData.Notes;
            _context.SaveChanges();
        }
        return sleepData;
    }
    
    public void DeleteSleepData(int id)
    {
        var sleepData = _context.SleepDatas.FirstOrDefault(s => s.Id == id);
        if (sleepData != null)
        {
            _context.SleepDatas.Remove(sleepData);
            _context.SaveChanges();
        }
    }
}