using StupidTemplate.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace StupidTemplate.Mods
{
    internal class Platforms
    {
        public static Color PlatColorA = new Color32(0, 255, 246, 255);
        public static Color PlatColorB = new Color32(0, 255, 144, 255);

        public static GameObject platl;
        public static GameObject platr;

        public static void PlatformsMod()
        {
            if (ControllerInputPoller.instance.leftGrab)
            {
                if (platl == null)
                {
                    platl = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    platl.transform.localScale = new Vector3(0.025f, 0.3f, 0.4f);
                    platl.transform.position = GorillaTagger.Instance.leftHandTransform.position;
                    platl.transform.rotation = GorillaTagger.Instance.leftHandTransform.rotation;

                    ColorChanger colorChanger = platl.AddComponent<ColorChanger>();
                    colorChanger.colorInfo = new ExtGradient
                    {
                        colors = new GradientColorKey[]
                    {
                new GradientColorKey(PlatColorA, 1f),
                new GradientColorKey(PlatColorB, 1f),
                new GradientColorKey(PlatColorA, 1f)
                    }
                    };
                    colorChanger.Start();
                }
                else
                {
                    if (platl != null)
                    {
                        UnityEngine.Object.Destroy(platl);
                        platl = null;
                    }
                }
            }

            if (ControllerInputPoller.instance.rightGrab)
            {
                if (platr == null)
                {
                    platr = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    platr.transform.localScale = new Vector3(0.025f, 0.3f, 0.4f);
                    platr.transform.position = GorillaTagger.Instance.rightHandTransform.position;
                    platr.transform.rotation = GorillaTagger.Instance.rightHandTransform.rotation;

                    ColorChanger colorChanger = platr.AddComponent<ColorChanger>();
                    colorChanger.colorInfo = new ExtGradient
                    {
                        colors = new GradientColorKey[]
                    {
                new GradientColorKey(PlatColorA, 0f),
                new GradientColorKey(PlatColorB, 0.5f),
                new GradientColorKey(PlatColorA, 1f)
                    }
                    };
                    colorChanger.Start();
                }
                else
                {
                    if (platr != null)
                    {
                        UnityEngine.Object.Destroy(platr);
                        platr = null;
                    }
                }
            }
        }
    }
}
