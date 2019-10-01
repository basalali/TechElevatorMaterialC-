﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Elevator
    {
       public Elevator(int numberOfLevels)
        {
            NumberOfLevels = numberOfLevels;
        }

        public int CurrentLevel { get; private set; } = 1;
        public int NumberOfLevels { get; }
        public bool DoorIsOpen { get; private set; }

        public void OpenDoor()
        {
            DoorIsOpen = true;
        }

        public void CloseDoor()
        {
            DoorIsOpen = false;
        }

        public void GoUp(int desiredFloor)
        {
            if (DoorIsOpen == false && CurrentLevel < NumberOfLevels)
            {
                CurrentLevel += (desiredFloor - CurrentLevel);
            }
        }

        public void GoDown(int desiredFloor)
        {
            if (DoorIsOpen == false && desiredFloor > 0 && (NumberOfLevels - desiredFloor) >= 1)
            {
                CurrentLevel -= (CurrentLevel - desiredFloor);
            }
        }







    }

}