using System;
using System.Collections.Generic;

public class Dish : Food
{
	private List<Food> ingredients;
	public Dish(string name)
	{
		Name = name;
		ingredients = new List<Food>();
	}

	public void AddIngredient(Food ingredient)
	{
		foreach(Food i in ingredients)
        {
			if (i.Name == ingredient.Name)
            {
				throw new IngredientAlreadyPresentException("the food \""+ ingredient+ "\" was added as ingredient in a food that already contains it as an ingredient ");
            }
        }
		ingredients.Add(ingredient);
	}
	public List<Food> GetIngredients()
	{
		return ingredients;
	}

	class IngredientAlreadyPresentException : ArgumentException
    {
		public IngredientAlreadyPresentException(string message) : base(message)
		{
		}
	}
}
