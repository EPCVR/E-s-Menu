using BepInEx;
using GorillaLocomotion;
using GorillaNetworking;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace StupidTemplate.Mods
{
    internal class Advanteges
    {
        public static void TagAura()
        {
            float num = 4f;
            VRRig vrrig = null;
            foreach (VRRig vrrig2 in GorillaParent.instance.vrrigs)
            {
                bool flag = GorillaTagger.Instance.offlineVRRig.mainSkin.material.name.Contains("fected") && vrrig2 != GorillaTagger.Instance.offlineVRRig && Vector3.Distance(GorillaTagger.Instance.bodyCollider.transform.position, vrrig2.transform.position) < num && !vrrig2.mainSkin.material.name.Contains("fected");
                bool flag2 = flag;
                if (flag2)
                {
                    num = Vector3.Distance(GorillaTagger.Instance.bodyCollider.transform.position, vrrig2.transform.position) * 4f;
                    vrrig = vrrig2;
                }
            }
            GorillaTagger.Instance.leftHandTransform.position = vrrig.transform.position;
            GorillaTagger.Instance.rightHandTransform.position = vrrig.transform.position;
        }
        public static void ESPMod()
        {
            foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
            {
                bool flag = vrrig != GorillaTagger.Instance.offlineVRRig;
                if (flag)
                {
                    Color playerColor = vrrig.playerColor;
                    GameObject gameObject = GameObject.CreatePrimitive(0);
                    gameObject.transform.position = vrrig.transform.position;
                    gameObject.transform.localScale = new Vector3(0.5f, 0.5f, 0f);
                    gameObject.transform.LookAt(GorillaTagger.Instance.headCollider.transform.position);
                    gameObject.GetComponent<Renderer>().material.shader = Shader.Find("GUI/Text Shader");
                    gameObject.GetComponent<Renderer>().material.color = playerColor;
                    UnityEngine.Object.Destroy(gameObject, Time.deltaTime);
                }
            }
        }
        public static void COMPSTUFF()
        {
            foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
            {
                bool flag = vrrig != GorillaTagger.Instance.offlineVRRig;
                if (flag)
                {
                    Color playerColor = vrrig.playerColor;
                    GameObject gameObject = GameObject.CreatePrimitive(0);
                    gameObject.transform.position = vrrig.transform.position;
                    gameObject.transform.localScale = new Vector3(0.5f, 0.5f, 0f);
                    gameObject.transform.LookAt(GorillaTagger.Instance.headCollider.transform.position);
                    gameObject.GetComponent<Renderer>().material.shader = Shader.Find("GUI/Text Shader");
                    gameObject.GetComponent<Renderer>().material.color = playerColor;
                    UnityEngine.Object.Destroy(gameObject, Time.deltaTime);
                }
            }
            {
                float num = 4f;
                VRRig vrrig = null;
                foreach (VRRig vrrig2 in GorillaParent.instance.vrrigs)
                {
                    bool flag = GorillaTagger.Instance.offlineVRRig.mainSkin.material.name.Contains("fected") && vrrig2 != GorillaTagger.Instance.offlineVRRig && Vector3.Distance(GorillaTagger.Instance.bodyCollider.transform.position, vrrig2.transform.position) < num && !vrrig2.mainSkin.material.name.Contains("fected");
                    bool flag2 = flag;
                    if (flag2)
                    {
                        num = Vector3.Distance(GorillaTagger.Instance.bodyCollider.transform.position, vrrig2.transform.position) * 4f;
                        vrrig = vrrig2;
                    }
                }
                GorillaTagger.Instance.leftHandTransform.position = vrrig.transform.position;
                GorillaTagger.Instance.rightHandTransform.position = vrrig.transform.position;
            }
            {
                GorillaLocomotion.Player.Instance.maxJumpSpeed = 7f;
                GorillaLocomotion.Player.Instance.jumpMultiplier = 5f;
            }
        }
        public static void InvisMonke()
        {
            if (ControllerInputPoller.instance.rightControllerPrimaryButton)
            {
                GorillaTagger.Instance.offlineVRRig.enabled = false;
                GorillaTagger.Instance.offlineVRRig.transform.position = new Vector3(0f, 0f, 0f);
            }
            else
            {
                GorillaTagger.Instance.offlineVRRig.enabled = true;
            }
        }

        internal static void TagGunMod()
        {
            throw new NotImplementedException();
        }

        public class TagGun : BaseUnityPlugin
        {
            public GameObject tagEffectPrefab; // Prefab for tagging effect
            public float tagDistance = 9999999f; // Maximum distance for tagging

            void Update()
            {
                // Check for input to shoot the tag gun
                if (ControllerInputPoller.instance.rightGrabMomentary) // Change this to your desired input
                {
                    if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.1f)
                    {
                        ShootTag();
                    }
;
                }
            }

            void ShootTag()
            {
                RaycastHit hit;

                // Raycast to see if we hit another player
                if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, tagDistance))
                {
                    // Check if the hit object has a player component
                    var player = hit.collider.GetComponent<Player>(); // Adjust according to actual player component

                    if (player != null)
                    {
                        // Apply tagging logic
                        TagPlayer(player);

                        // Optionally, instantiate a visual effect
                        if (tagEffectPrefab != null)
                        {
                            Instantiate(tagEffectPrefab, hit.point, Quaternion.identity);
                        }
                    }
                }
            }

            void TagPlayer(Player player)
            {
                // Logic to tag the player (e.g., change their state)
                player.Tagged = true; // Example, adjust according to your player class
                Debug.Log($"{player.name} has been tagged!");
            }
        }
        public class Player : MonoBehaviour
        {
            public bool Tagged { get; set; } = false; // Default to not tagged

            // Other player-related code...
        }
    }
}
