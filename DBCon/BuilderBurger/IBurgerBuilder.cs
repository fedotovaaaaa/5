using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DBCon.BuilderBurger
{
    public interface IBurgerBuilder
    {
        IBurgerBuilder AddCheese();
        IBurgerBuilder AddBacon();
        IBurgerBuilder AddLetuce();
        IBurgerBuilder AddTomato();
        IBurgerBuilder AddPickles();
        Burgers GetBurgers();
    }
}
