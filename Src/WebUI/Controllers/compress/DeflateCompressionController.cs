using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Controllers;

using Application.Compress.Commands.Compress.CompressInsert.CompressInsertCommand;
using Microsoft.Extensions.Logging;

namespace XOKA.WebUI.Controllers
{
    [Route("api/compress/[controller]")]
    [ApiController]
    public class DeflateCompressionController : BaseController
    {
        private readonly ILogger logger;
        private byte[] zipBytes;

        public DeflateCompressionController(ILogger<DeflateCompressionController> logger)
        {
            this.logger = logger;
        }

        [HttpPost("Compresse")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Compresse([FromBody] CompressInsertCommand command)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                bool success;

                Chilkat.Compression compress = new Chilkat.Compression();
                compress.Algorithm = "deflate";

                Chilkat.BinData binDat = new Chilkat.BinData();
                binDat.AppendBinary(command.base64Data);

                compress.CompressBd(binDat);

                string compressedBase64 = binDat.GetEncoded("base64");

                return Ok(new { data = compressedBase64 });
            }
            catch (Exception ex)
            {
                this.logger.LogInformation("insert error: " + ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Decompres")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Decompres([FromBody] CompressInsertCommand command)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                bool success;

                Chilkat.Compression compress = new Chilkat.Compression();
                compress.Algorithm = "deflate";

                Chilkat.BinData binDat = new Chilkat.BinData();
                binDat.Clear();
                binDat.AppendBinary(command.base64Data);

                compress.DecompressBd(binDat);

                string decompressedBase64 = binDat.GetEncoded("base64");

                return Ok(new { data = decompressedBase64 });
            }
            catch (Exception ex)
            {
                this.logger.LogInformation("insert error: " + ex.Message);
                return BadRequest(ex.Message);
            }
        }


    }
}
