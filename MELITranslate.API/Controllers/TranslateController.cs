using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MELITranslate.API.Controllers.DTOs;
using MELITranslate.Business.Exceptions;
using MELITranslate.Business.Interfaces;
using MELITranslate.Business.TranslateStrategies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace MELITranslate.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TranslateController : ControllerBase
    {
        private readonly IServiceProvider _serviceProvider;

        public TranslateController(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        [HttpPost("decodeBits2Morse")]
        public IActionResult Bits2Morse([FromBody] TranslateDTO bits)
        {
            try
            {
                using (var scope = _serviceProvider.CreateScope())
                {
                    var bits2Morse = (ITranslateStrategy)scope.ServiceProvider.GetRequiredService<Bits2MorseStrategy>();
                    return Ok(bits2Morse.Translate(bits.Text));
                }
            }            
            catch (BadInputException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("2text")]
        public IActionResult Morse2Text([FromBody] TranslateDTO morse)
        {
            try
            {
                using (var scope = _serviceProvider.CreateScope())
                {
                    var morse2Text = (ITranslateStrategy)scope.ServiceProvider.GetRequiredService<Morse2TextStrategy>();
                    return Ok(morse2Text.Translate(morse.Text));
                }
            }
            catch(BadInputException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("2morse")]
        public IActionResult Text2Morse([FromBody] TranslateDTO text)
        {
            try
            {
                using (var scope = _serviceProvider.CreateScope())
                {
                    var text2Morse = (ITranslateStrategy)scope.ServiceProvider.GetRequiredService<Text2MorseStragety>();
                    return Ok(text2Morse.Translate(text.Text));
                }
            }
            catch (BadInputException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}