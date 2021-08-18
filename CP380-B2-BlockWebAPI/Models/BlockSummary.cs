using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CP380_B2_BlockWebAPI.Models
{
    public class BlockSummary
    {
        // TODO
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
    }

    public class Block: BlockSummary
    {
        public string Description { get; set; }

        public List<Block> Blocks { get; set; }

    }
    public class BlockSummaryList 
    {

        public List<BlockSummary> blockSummaries { get; set; }
    }





}

