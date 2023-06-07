using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransformersController : ControllerBase
    {
        private readonly ITransformerService _transformerService;

        public TransformersController(ITransformerService transformerService)
        {
            _transformerService = transformerService;
        }

        [HttpGet("getTransformerById")]
        public IActionResult gettransformerById(Guid id)
        {
            var result = _transformerService.GetById(id);
            if (result.Success)
                return Ok(result.Data);
            return BadRequest();
        }

        [HttpGet("getAllTransformers")]
        public IActionResult getAlltransformers()
        {
            var result = _transformerService.GetAll();
            if (result.Success)
                return Ok(result.Data);
            return BadRequest();
        }
        [HttpDelete("deleteTransformer")]
        public IActionResult deletetransformer(Transformer transformer)
        {
            var result = _transformerService.Delete(transformer);
            if (result.Success)
                return Ok(result);
            return BadRequest();
        }

        [HttpPatch("updateTransformer")]
        public IActionResult updatetransformer(Transformer transformer)
        {
            var result = _transformerService.Update(transformer);
            if (result.Success)
                return Ok(result);
            return BadRequest();
        }

        [HttpPost("addTransformer")]
        public IActionResult addtransformer(Transformer transformer)
        {
            var result = _transformerService.Update(transformer);
            if (result.Success)
                return Ok(result);
            return BadRequest();
        }
    }
}
