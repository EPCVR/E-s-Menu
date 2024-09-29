using System;
using System.Collections.Generic;
using System.Text;

namespace StupidTemplate.Mods
{
    internal class Slow_Speed
    {
        public static void SSpeed() 
        {
            GorillaLocomotion.Player.Instance.maxJumpSpeed = 3;
            GorillaLocomotion.Player.Instance.jumpMultiplier = 3;
        }
    }
}
