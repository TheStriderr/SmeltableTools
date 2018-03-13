using Terraria.ModLoader;

namespace SmeltableTools
{
	class SmeltableTools : Mod
	{
		public SmeltableTools()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
