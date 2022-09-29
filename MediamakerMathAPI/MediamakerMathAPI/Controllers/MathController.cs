using MediamakerMathAPI.Domain.Enumerations;
using MediamakerMathAPI.Domain.Requests.v1;
using MediamakerMathAPI.Domain.Responses.v1;
using MediamakerMathAPI.Settings;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediamakerMathAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MathController : ControllerBase
    {
        private ILogger<MathController> _logger;

        public MathController(ILogger<MathController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Adds the values in the request (ItemA, ItemB)
        /// </summary>
        /// <param name="request"></param>
        /// <returns>The result of the addition sum</returns>
        [HttpPost]
        [Route("add"), Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<MathResponse> Addition([FromBody]MathRequest request)
        {
            _logger.LogInformation(LogEvents.AdditionId, $"Addition request called. ItemA = {request.ItemA.Value} + ItemB = {request.ItemB.Value}");

            MathResponse response = new MathResponse
            {
                SumValue = request.ItemA.Value + request.ItemB.Value
            };

            return Ok(response);
        }

        /// <summary>
        /// Subtracts the values in the request (ItemA, ItemB)
        /// </summary>
        /// <param name="request"></param>
        /// <returns>The result of the subtraction sum</returns>
        [HttpPost]
        [Route("subtract"), Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<MathResponse> Subtraction([FromBody] MathRequest request)
        {
            _logger.LogInformation(LogEvents.SubtractionId, $"Subtraction request called. ItemA = {request.ItemA.Value} - ItemB = {request.ItemB.Value}");

            MathResponse response = new MathResponse
            {
                SumValue = request.ItemA.Value - request.ItemB.Value
            };

            return Ok(response);
        }

        /// <summary>
        /// Multiplies the values in the request (ItemA, ItemB)
        /// </summary>
        /// <param name="request"></param>
        /// <returns>The result of the multiplication sum</returns>
        [HttpPost]
        [Route("multiply"), Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<MathResponse> Multiplication([FromBody] MathRequest request)
        {
            _logger.LogInformation(LogEvents.MultiplicationId, $"Multiplication request called. ItemA = {request.ItemA.Value} * ItemB = {request.ItemB.Value}");

            MathResponse response = new MathResponse
            {
                SumValue = request.ItemA.Value * request.ItemB.Value
            };

            return Ok(response);
        }

        /// <summary>
        /// Divides the values in the request (ItemA, ItemB)
        /// </summary>
        /// <param name="request"></param>
        /// <returns>The result of the division sum</returns>
        [HttpPost]
        [Route("divide"), Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<MathResponse> Division([FromBody] MathRequest request)
        {
            _logger.LogInformation(LogEvents.DivisionId, $"Division request called. ItemA = {request.ItemA.Value} / ItemB = {request.ItemB.Value}");

            MathResponse response = new MathResponse
            {
                SumValue = request.ItemA.Value / request.ItemB.Value
            };

            return Ok(response);
        }

    }
}
