using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Text;

namespace StupidTemplate.Mods
{
    internal class Disconnect
    {
        public static void DisconnectPrimary()
        {
            if (ControllerInputPoller.instance.rightControllerPrimaryButton) 
            {
                PhotonNetwork.Disconnect();
            }
        }
        public static void DisconnectSecondary() 
        {
            if (ControllerInputPoller.instance.rightControllerSecondaryButton) 
            {
                PhotonNetwork.Disconnect();
            }
        }
        public static void RegularDisconnect() 
        {
            PhotonNetwork.Disconnect();
        }
        public static void Reconnect() 
        {
            PhotonNetwork.Reconnect();
        }
        public static void SpamRejoinandLeave() 
        {
            PhotonNetwork.Disconnect();
            PhotonNetwork.Reconnect();
        }
    }
}
