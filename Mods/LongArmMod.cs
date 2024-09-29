using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace StupidTemplate.Mods
{
    internal class LongArmMod
    {
        public static void resetarms()
        {
            {
                GorillaLocomotion.Player.Instance.transform.localScale = new Vector3(1f, 1f, 1f);
            }
        }
        public static void LongArms()
        {
            {
                GorillaLocomotion.Player.Instance.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
            }
        }
        public static void RllyLongArms()
        {
            {
                GorillaLocomotion.Player.Instance.transform.localScale = new Vector3(2f, 2f, 2f);
            }
        }
        public static void ShortArms()
        {
            {
                GorillaLocomotion.Player.Instance.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            }
        }
    }
}
