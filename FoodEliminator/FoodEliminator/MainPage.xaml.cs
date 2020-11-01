using FoodEliminator.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FoodEliminator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        int count = 0;

        void Button_Clicked(object sender, System.EventArgs e)
        {
            Food elementalFood = new ElementalFood(ingredientEntry.Text);

            using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {
                conn.CreateTable<ElementalFood>();
                int rowsAdded = conn.Insert(elementalFood);
            }
        }
    }
}
