﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillrGame_GabeCampbell
{
    class SpaceShip : Mover
    {
        //public Vector2 location;//supposed to be private I think
        //private Shape shape;
        private Vector2[] array;
        //Vector2 velocity;
        //public SpaceShip(Vector2 location) : base(shapePoints, location)
        //{
        //    velocity = new Vector2(1, 1)
        //}

        public SpaceShip(Vector2[] pointsArray, Vector2 location) : base(pointsArray, location)
        {
            array = pointsArray;
            this.location = location;
            velocity = new Vector2(1, 1);
        }

        //public void Draw(Graphics g, Vector2 location)
        //{
        //    for (int i = 0; i < array.Length; i += 2)
        //    {
        //        Vector2 start = location + array[i];
        //        Vector2 end = location + array[i + 1];

        //        g.DrawLine(Pens.Red, start.GetX(), start.GetY(), end.GetX(), end.GetY());
        //    }


        //}

        //public void Update()
        //{
        //    Console.WriteLine("location: " + location.GetX() + " " + location.GetY());
        //    location = location + velocity;
        //}
    }
}
