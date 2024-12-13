using Domain.Models;
using Infrastracture.ApiResponse;
using Infrastracture.IRentService;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CarController(ICarService carService):ControllerBase
{
    [HttpGet]
    public Response<List<Cars>> GetAll()
    {
        var response = carService.GetAllCars();
        return response;
    }

    [HttpGet("{id:int}")]
    public Response<Cars> GetById(int id)
    {
        var response = carService.GetCarById(id);
        return response;
    }

    [HttpPost]
    public Response<bool> Create(Cars car)
    {
        var response = carService.AddCar(car);
        return response;
    }
    
    [HttpPut]
    public Response<bool> Update(Cars car)
    {
        var response = carService.UpdateCar(car);
        return response;
    }
    [HttpDelete]
    public Response<bool> Delete(int id)
    {
        var response = carService.DeleteCar(id);
        return response;
    }
}