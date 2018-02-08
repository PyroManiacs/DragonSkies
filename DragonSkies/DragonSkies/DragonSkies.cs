using Terraria.ModLoader;

namespace DragonSkies
{
	class DragonSkies : Mod
	{
		public DragonSkies()
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
