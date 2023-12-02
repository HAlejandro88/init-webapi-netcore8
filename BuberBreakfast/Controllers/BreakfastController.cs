using Microsoft.AspNetCore.Mvc;
using BuberBreakfast.Contracts.Breakfast;

namespace BuberBreakfast.Controllers;

[ApiController]
public class BreakfastController: ControllerBase
    {
        [HttpPost("/breakfast")]
        public IActionResult CreateBreakfast(CreateBreakfastRequest request) {
            return Ok(request);
        }

        [HttpGet("/breakfast")]
        public IActionResult GetBreakfast() {
            return Ok("hellow");
        }

        [HttpGet("/breakfast/{id:guid}")]
        public IActionResult GetBreakfast(Guid id) {
            return Ok(id);
        }

        [HttpPut("/breakfast/{id:guid}")]
        public IActionResult UpsertBreakfast(Guid id, UpsertBreakfastRequest request) {
            return Ok(request);
        }

        [HttpDelete("/breakfast/{id:guid}")]
        public IActionResult DeleteBreakfast(Guid id) {
            return Ok(id);
        }
    }