using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace DragonSkies.Items.Weapons
{
    public class Sword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sword"); // Needs to be changed
            Tooltip.SetDefault("This is a sword"); // Needs to be changed
            DisplayName.AddTranslation(GameCulture.German, "..."); // Add trans
            Tooltip.AddTranslation(GameCulture.German, "..."); // Add trans
        }

        public override void SetDefaults()
        {
            item.damage = 10;
            item.width = 40;
            item.height = 40;
            item.melee = true;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.autoReuse = true;
            item.value = Item.buyPrice(0, 0, 0, 25);
            item.value = Item.sellPrice(0, 0, 0, 20);
            item.knockBack = 4.5f;
            item.rare = 0;
            item.UseSound = SoundID.Item1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WoodenSword);
            recipe.AddIngredient(ItemID.Gel, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}