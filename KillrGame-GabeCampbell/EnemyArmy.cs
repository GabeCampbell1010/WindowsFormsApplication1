using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillrGame_GabeCampbell
{
    public class EnemyArmy
    {
        List<EnemyShip> enemyShips = new List<EnemyShip>();
        public const int numShips = 10;

        //not sure where else to get shapepoints?
        private Vector2[] shapePoints =
        {
            new Vector2(-10,-10), new Vector2(-10,20),
            new Vector2(-10,5), new Vector2(5,21),
            new Vector2(5,10), new Vector2(12,-10),
            new Vector2(10,-10), new Vector2(0,-10)
        };


        public EnemyArmy(int width, int height)
        {
            for (int i = 0; i < numShips; i++)
            {
                enemyShips.Add(new EnemyShip(shapePoints, new Vector2(width, height)));
            }
        }

        public void Draw(Graphics g, Vector2 location)
        {
            foreach (var ship in enemyShips)
            {
                ship.Draw(g, ship.location);//this is wrong, where am I supposed to get g and location from?
            }
        }

        public void Update()
        {
            foreach (var ship in enemyShips)
            {
                ship.Update();
            }
            
        }
    }
}
