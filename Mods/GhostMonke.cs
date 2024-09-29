using System;
using System.Collections.Generic;
using System.Text;

namespace StupidTemplate.Mods
{
    internal class GhostMonke
    {
        public static void freezerig()
        {
            bool gorillaenabled = GorillaTagger.Instance.offlineVRRig.enabled;
            bool rg = ControllerInputPoller.instance.rightControllerPrimaryButton;
            if (rg && gorillaenabled)
            {
                gorillaenabled = false;
            }
            if (!rg && !gorillaenabled)
            {
                gorillaenabled = false;
            }
        }
    }
}
