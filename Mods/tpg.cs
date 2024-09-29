using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace StupidTemplate.Mods
{
    internal class tpg
    {
        public static void TPGun() 
        {
            if (ControllerInputPoller.instance.rightGrab) 
            {
                if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.1f) 
                {
                    GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.headCollider.transform.forward * Time.deltaTime * 999999999f;
                    GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
                }
            }
        }
    }
}
