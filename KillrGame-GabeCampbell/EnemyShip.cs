using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillrGame_GabeCampbell
{
    public class EnemyShip : Mover
    {
        private Vector2[] array;
        Random rand = new Random();
        public EnemyShip(Vector2[] pointsArray, Vector2 location) : base(pointsArray, location)
        {
            array = pointsArray;
            this.location = location;//is this supposed to be randomized?
            velocity = new Vector2(rand.Next(1,4), rand.Next(1,4));
        }
    }
}
