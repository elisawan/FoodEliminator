using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodEliminator.Model
{
    class Ingredient
    {
        [PrimaryKey]
        public string Name { get; set; }

        public Ingredient()
        {

        }
    }
}
