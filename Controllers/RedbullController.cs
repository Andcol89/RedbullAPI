using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RedbullAPI.Contexts;
using RedbullAPI.Models;

namespace RedbullAPI.Controllers;

[ApiController]
[Route("[controller]")]

// Dette er dependency injection
public class RedbullController(APIContext _apiContext) : ControllerBase
{
    [HttpGet]
    public async Task<List<Redbull>> Get()
    {
        List<Redbull> redbulls = await _apiContext.Redbulls.ToListAsync();

        return redbulls;
    }
}


// Standard microsoft for HTTP get er å gjøre dem async