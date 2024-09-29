using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Windows;

namespace StupidTemplate.Mods
{
    internal class TPTS
    {
        public static void TpToStump()
        {
            GameObject.Find("Player Objects/Player VR Controller/GorillaPlayer").GetComponent<ControllerInputPoller>();
            if (GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom").activeSelf == true)
            {
                if (ControllerInputPoller.instance.rightControllerPrimaryButton)
                {
                    foreach (MeshCollider mesh in Resources.FindObjectsOfTypeAll<MeshCollider>())
                    {
                        mesh.enabled = false;
                    }
                    GorillaLocomotion.Player.Instance.transform.position = new Vector3(-66.4848f, 11.8871f, -82.6619f);
                }
                else
                {
                    foreach (MeshCollider mesh in Resources.FindObjectsOfTypeAll<MeshCollider>())
                    {
                        mesh.enabled = true;
                    }
                }
            }
        }
    }
}
