using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CP380_B2_BlockWebAPI.Models;

namespace CP380_B2_BlockWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class BlocksController : ControllerBase
    {
        // TODO
        private readonly PendingPayloads _db;
        private readonly BlockSummaryList _today;

        public BlocksController(PendingPayloads dbContext, BlockSummaryList blockSummaryList)
        {
            _db = dbContext;
            _today = blockSummaryList;
        }

        [HttpGet]

        public ActionResult<List<BlockSummary>> Get() =>
            _db.blockSummaries.Select(a => new BlockSummary() { DateTime = a.DateTime, Id = a.Id})
            .ToList();

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesErrorResponseType(typeof(NotFoundResult))]

        public ActionResult<BlockSummary> GetBlockSummary(int id)
        {
            var blocksummary = _db.blockSummaries.Where(a => a.Id == id).FirstOrDefault();
            if (blocksummary == null)
            {
                return NotFound();
            }
            return blocksummary;

        }

        [HttpPost]
        public ActionResult<BlockSummary> Post(BlockSummary value)
        {
            _db.blockSummaries.Add(value);
            return CreatedAtAction(nameof(BlockSummary), value);
        }
            

    }
}
