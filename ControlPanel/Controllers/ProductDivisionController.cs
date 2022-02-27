using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.ProductDivision;
using ControlPanel.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ControlPanel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductDivisionController : ControllerBase
    {
        private readonly IProductDivision _Context;
        public ProductDivisionController(IProductDivision context)
        {
            _Context = context;
        }

        [HttpGet]
        [Route("GetProductDivisionAll")]
        [SwaggerOperation(Description = "No Need Parameters")]
        public async Task<IActionResult> GetProductDivisionAll()
        {
            try
            {
                var dt = await _Context.GetProductDivisionAll();
                if (dt == null)
                {
                    return NotFound();
                }
                return Ok(dt);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        [Route("GetProductDivisionById")]
        [SwaggerOperation(Description = "Example { ProductDivisionid: 0 }")]
        public async Task<IActionResult> GetProductDivisionById(long Id)
        {
            try
            {
                var dt = await _Context.GetProductDivisionById(Id);
                if (dt == null)
                {
                    return NotFound();
                }

                return Ok(dt);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        [Route("GetProductDivisionByUnitId")]
        [SwaggerOperation(Description = "Example { ProductDivisionByUnitId: 0 }")]
        public async Task<IActionResult> GetProductDivisionByUnitId(long UId)
        {
            try
            {
                var dt = await _Context.GetProductDivisionByUnitId(UId);
                if (dt == null)
                {
                    return NotFound();
                }

                return Ok(dt);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        [Route("GetProductDivisionByClientId")]
        [SwaggerOperation(Description = "Example { ProductDivisionByClientId: 0 }")]
        public async Task<IActionResult> GetProductDivisionByClientId(long CId)
        {
            try
            {
                var dt = await _Context.GetProductDivisionByClientId(CId);
                if (dt == null)
                {
                    return NotFound();
                }

                return Ok(dt);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost]
        [Route("CreateProductDivision")]
        [SwaggerOperation(Description = "Example {clientid=0, ProductDivisioncode: string, ProductDivisionname: string, bussinessUnitId: 0, bussinessAreaId: 0, actionBy: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z }")]
        public async Task<IActionResult> CreateProductDivision(DTO.ProductDivision.CreateProductDivisionDTO postProductDivision)
        {
            try
            {
                var dt = await _Context.CreateProductDivision(postProductDivision);
                if (dt == null)
                {
                    return NotFound();
                }
                return Ok(dt);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut]
        [Route("EditProductDivision")]
        [SwaggerOperation(Description = "Example { ProductDivisionid: 0, ProductDivisionname: string, bussinessUnitId: 0, bussinessAreaId: 0, dteLastActionDateTime: 2020-02-09T11:42:09.172Z,  actionBy: 0 }")]
        public async Task<IActionResult> EditProductDivision([FromBody] EditProductDivisionDTO ProductDivision)
        {
            try
            {
                var dt = await _Context.EditProductDivision(ProductDivision);
                if (dt == null)
                {
                    return NotFound();
                }
                return Ok(dt);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut]
        [Route("CancelProductDivision")]
        [SwaggerOperation(Description = "Example { ProductDivisionid: 0, lastActionDateTime: 2020-02-09T11:42:09.172Z, ServerDateTime: 2020-02-09T11:42:09.172Z, actionBy: 0}")]
        public async Task<IActionResult> CancelProductDivision([FromBody] CancelProductDivisionDTO productDivision)
        {
            try
            {
                var dt = await _Context.CancelProductDivision(productDivision);
                if (dt == null)
                {
                    return NotFound();
                }
                return Ok(dt);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

    }
}