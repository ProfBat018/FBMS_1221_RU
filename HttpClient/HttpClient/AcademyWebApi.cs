using System.Net;
using System.Text.Json;

namespace HttpClient;

public class AcademyWebApi
{
    private HttpListenerContext _context;
    private AcademyContext _dbContext;
    
    public AcademyWebApi(HttpListenerContext httpContext, AcademyContext dbContext, WebApiService webapiService)
    {
        _context = httpContext;
        _dbContext = dbContext;
    }

    public void GetAllPeople()
    {
        WebApiService.ReturnJson(_context, JsonSerializer.Serialize(_dbContext.People.ToList()));
    }
    
    public void GetAllStudents()
    {
        WebApiService.ReturnJson(_context, JsonSerializer.Serialize(_dbContext.Students.ToList()));
        
    }
    
    public void GetAllTeachers()
    {
        WebApiService.ReturnJson(_context, JsonSerializer.Serialize(_dbContext.Teachers.ToList()));
    }
}