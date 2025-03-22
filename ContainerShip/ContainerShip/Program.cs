using System;
using ContainerShip.Models;

using System;

class Program
{
    static void Main()
    {
        Ship ship = new Ship("Black Pearl", 30, 10, 50000);

        Container liquidSafe = new LiquidContainer(200, 500, 700, 2000, false);
        Container liquidDanger = new LiquidContainer(200, 500, 700, 2000, true);
        Container gasContainer = new GasContainer(200, 600, 700, 5000, 10);
        Container fridge = new RefrigeratedContainer(300, 500, 900, 4000, "Bananas");

        liquidSafe.Load(1800);
        liquidDanger.Load(900);
        gasContainer.Load(4000);
        fridge.Load(2500);

        ship.LoadContainer(liquidSafe);
        ship.LoadContainer(liquidDanger);
        ship.LoadContainer(gasContainer);
        ship.LoadContainer(fridge);

        ship.DisplayContainers();

        //---------------------------------------------------------------------------------------


        Ship ship1 = new Ship("White Pearl", 100, 10, 20000);

        Container liquidSafe1 = new LiquidContainer(200, 500, 700, 2000, false);
        Container liquidDanger1 = new LiquidContainer(200, 500, 700, 2000, true);
        Container gasContainer1 = new GasContainer(200, 600, 700, 5000, 10);
        Container fridge1 = new RefrigeratedContainer(300, 500, 900, 4000, "Fish");

        liquidSafe1.Load(1799);
        liquidDanger1.Load(999);
        gasContainer1.Load(4600);
        fridge1.Load(3800);

        ship1.LoadContainer(liquidSafe1);
        ship1.LoadContainer(liquidDanger1);
        ship1.LoadContainer(gasContainer1);
        ship1.LoadContainer(fridge1);

        ship1.DisplayContainers();
    }
}
