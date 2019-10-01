using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Television
    {
        public bool IsOn { get; private set; } = false;
        public int CurrentChannel { get; private set; } = 3;
        public int CurrentVolume { get; private set; } = 2;

        public void TurnOff()
        {
            IsOn = false;
        }
        public void TurnOn()
        {
            IsOn = true;
            CurrentVolume = 2;
            CurrentChannel = 3;
        }
        public void ChangeChannel(int newChannel)
        {
            if (IsOn == true && CurrentChannel >= 3 && CurrentChannel <= 18)
            {
                CurrentChannel = newChannel;
            }
        }
        public void ChannelUp()
        {
            if (IsOn == true && CurrentChannel >= 18)
            {
                 CurrentChannel = 3;
            }
            else if (IsOn == true)
            {
                CurrentChannel++;
            }

        }
        public void ChannelDown()
        {
             if (IsOn == true && CurrentChannel <= 3)
            {
                CurrentChannel = 18;
            }

            else if (IsOn == true)
            {
                CurrentChannel = CurrentChannel - 1;
            }
            
            
        }
        public void RaiseVolume()
        {
            if (IsOn == true && CurrentVolume < 10)
            {
                CurrentVolume++;
            }
        }
        public void LowerVolume()
        {
            if (IsOn == true && CurrentVolume > 0)
            {
                CurrentVolume = CurrentVolume - 1;
            }

        }





    }
}
