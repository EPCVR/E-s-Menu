using System;
using System.Collections.Generic;
using System.Text;

namespace StupidTemplate.Mods
{
    internal class GSB
    {
        public static void GSpB() 
        {
            if (ControllerInputPoller.instance.rightGrab) 
            {
                GorillaLocomotion.Player.Instance.maxJumpSpeed = 9f;
                GorillaLocomotion.Player.Instance.jumpMultiplier = 9f;
            }
        }
    }
}
