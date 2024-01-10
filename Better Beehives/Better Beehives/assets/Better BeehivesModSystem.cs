using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.Config;
using Vintagestory.API.Server;

namespace Better_Beehives.assets
{
    public class Better_BeehivesModSystem : ModSystem
    {
        ICoreAPI api;
        // Called on server and client
        // Useful for registering block/entity classes on both sides
        public override void Start(ICoreAPI api)
        {
            base.Start(api);
            this.api = api;
            this.api.RegisterBlockClass("BeehiveBlock", typeof(BeehiveBlock));
        }
    }
}
