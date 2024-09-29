using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.UIElements;

namespace StupidTemplate.Mods
{
    internal class Fun
    {
        public static void GrabIDCard()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                GameObject.Find("Environment Objects/05Maze_PersistentObjects/HiddenIDCard/ID Card Anchor/ID Card Holdable").GetComponent<ScannableIDCard>().enabled = true;
                GameObject.Find("Environment Objects/05Maze_PersistentObjects/HiddenIDCard/ID Card Anchor/ID Card Holdable").transform.position = GorillaTagger.Instance.rightHandTransform.position; ;
            }
        }
        public static void GrabBatMod()
        {
            GameObject.Find("Cave Bat Holdable").transform.position = GorillaTagger.Instance.rightHandTransform.position;
        }
        public static void GrabRig()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                GorillaTagger.Instance.offlineVRRig.enabled = false;
                GorillaTagger.Instance.offlineVRRig.transform.position = GorillaTagger.Instance.rightHandTransform.position;
            }
            else
            {
                GorillaTagger.Instance.offlineVRRig.enabled = true;
            }
        }
    }
}
