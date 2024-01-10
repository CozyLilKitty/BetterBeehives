using System;
using Vintagestory.API.Common;
using Vintagestory.API.MathTools;

namespace Better_Beehives.assets
{
    internal class BeehiveBlock : Block
    {
        public override bool DoParticalSelection(IWorldAccessor world, BlockPos pos)
        {
            return true;
        }

        public override bool OnBlockInteractStart(IWorldAccessor world, IPlayer byPlayer, BlockSelection blockSel)
        {
            BEBeehive beshelf = world.BlockAccessor.GetBlockEntity(blockSel.Position) as BEBeehive;
            if (beshelf != null) return beshelf.OnInteract(byPlayer, blockSel);

            return base.OnBlockInteractStart(world, byPlayer, blockSel);
        }
    }
}
