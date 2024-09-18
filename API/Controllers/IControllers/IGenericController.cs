using Microsoft.AspNetCore.Mvc;
using Models.Abstractions;

namespace Controllers.IControllers;

public interface IGenericController<T> where T : BaseModel
{
    [HttpDelete("{id:int}")]
    IActionResult Delete(int id);

    [HttpGet]
    IActionResult Get();

    [HttpGet("{id:int}")]
    IActionResult Get(int id);

    [HttpPost]
    IActionResult Post(T obj);

    [HttpPut("{id:int}")]
    IActionResult Put(int id, T obj);
}
