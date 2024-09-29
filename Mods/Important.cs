using Photon.Pun;
using StupidTemplate.Notifications;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using UnityEngine;

namespace StupidTemplate.Mods
{
    internal class Important
    {
        public static void GhostMonkey()
        {
            if (ControllerInputPoller.instance.rightControllerPrimaryButton)
            {
                GorillaTagger.Instance.offlineVRRig.enabled = false;

            }

            
            else
            {
                GorillaTagger.Instance.offlineVRRig.enabled = true;
            }

        }
        public static void RestartGame()
        {
            Process.Start("steam://rungameid/1533390");
            Application.Quit();
        }
    }
}
