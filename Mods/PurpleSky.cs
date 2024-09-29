using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace StupidTemplate.Mods
{
    internal class PurpleSky
    {
        public static void PurpleSkyMod()
        {
            Renderer SkyObject = GameObject.Find("Environment Objects/LocalObjects_Prefab/Standard Sky").GetComponent<Renderer>();
            SkyObject.material.shader = Shader.Find("GorillaTag/UberShader");
            SkyObject.material.color = Color.magenta;
        }
        public static void PurpleSkyDisable()
        {
            GameObject.Find("Environment Objects/LocalObjects_Prefab/Standard Sky").GetComponent<Renderer>().material.shader = Shader.Find("Gorilla/DayNightLerpSkyMaterial");
        }

    }
}
