using GorillaNetworking;
using System;
using System.Collections.Generic;
using System.Text;

namespace StupidTemplate.Mods
{
    internal class JoinCodeEMenu
    {
        public static void JoinCodeModsHelp()
        {
            PhotonNetworkController.Instance.AttemptToJoinSpecificRoom("EDisco", (JoinType)4);
        }
    }
}
