using System;
using System;
using System.Collections.Generic;
using System.Text;

namespace StupidTemplate.Mods
{
    internal class SpeedBoostSmall
    {
        public static void SmallSpeedBoost()
        {
            GorillaLocomotion.Player.Instance.maxJumpSpeed = 4.5f;
            GorillaLocomotion.Player.Instance.jumpMultiplier = 4.5f;
        }
    }
}
