using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace FoodEliminator
{
    class DataFacade
    {
        static DataFacade instance = null;
        private List<Dish> dishes;
        private List<ElementalFood> elementalFoods;

        public DataFacade()
        {
            if (instance != null)
            {
                throw new Exception("DataFacade was already instantiated");
            }
        }

        private void AddNewElementalFood(string name)
        {
            foreach(ElementalFood e in elementalFoods)
            {
                if(e.Name == name)
                {
                    throw new ElementAlreadyExistException("elemental food with name \"" + name + "\" already exist");
                }
            }
            ElementalFood food = new ElementalFood(name);
            elementalFoods.Add(food);
        }

        private void AddNewDish(string name, List<Food> ingredients)
        {
            foreach (Dish d in dishes)
            {
                if (d.Name == name)
                {
                    throw new ElementAlreadyExistException("dish with name \"" + name + "\" already exist");
                }
            }
            Dish dish = new Dish(name);

            foreach(Food f in ingredients)
            {
                try
                {
                    dish.AddIngredient(f);
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            dishes.Add(dish);
        }

        class ElementAlreadyExistException : Exception
        {
            public ElementAlreadyExistException(string message) : base(message)
            { }
        }
    }
}
