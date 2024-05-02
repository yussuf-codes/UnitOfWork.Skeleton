using Microsoft.AspNetCore.Mvc;

using Models;
using Services.IServices;
using Controllers.IControllers;

namespace Controllers;

[ApiController]
[Route("api/[controller]")]
public class Model1Controller : ControllerBase, IGenericController<Model1>
{
    protected readonly IUnitOfWork _unitOfWork;

    public Model1Controller(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    [HttpGet("custom_action")]
    public IActionResult CustomAction()
    {
        throw new System.NotImplementedException();
    }

    [HttpDelete("{id:int}")]
    public IActionResult Delete(int id)
    {
        throw new System.NotImplementedException();
    }

    [HttpGet]
    public IActionResult Get()
    {
        throw new System.NotImplementedException();
    }

    [HttpGet("{id:int}")]
    public IActionResult Get(int id)
    {
        throw new System.NotImplementedException();
    }

    [HttpPost]
    public IActionResult Post(Model1 obj)
    {
        throw new System.NotImplementedException();
    }

    [HttpPut("{id:int}")]
    public IActionResult Put(int id, Model1 obj)
    {
        throw new System.NotImplementedException();
    }
}
