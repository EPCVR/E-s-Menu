using GorillaNetworking;
using PlayFab.ClientModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace StupidTemplate.Mods
{
    internal class Plats_Fix
    {
        public static void InfShinyRocks()
        {
            CosmeticsController.instance.numShinyRocksToBuy = 999999999;
            CosmeticsController.instance.numShinyRocksToBuy = 999999999;
            CosmeticsController.instance.currencyBalance = 999999999;
        }
    }
}
