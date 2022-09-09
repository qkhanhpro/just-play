namespace NetCoreAPIDocker.Model
{
    public class Recipe
    {
        public string Name { get; set; }
        public List<RecipeIngredient> RecipeIngredients { get; set; }
        public double EstimatedCalories { get;set; }
    }
}
