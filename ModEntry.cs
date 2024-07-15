using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;
using SpaceCore;
using SpaceShared;
using SpaceCore.Events;
using SpaceShared.APIs;
using HarmonyLib;
using Netcode;

namespace Reputation
{
    internal class ModEntry : Mod
    {
        internal static IMonitor ModMonitor { get; set; }

        internal static IModHelper ModHelper { get; set; }

        public static ModEntry instance;


        public override void Entry(IModHelper helper)
        {
            instance = this;

            ModMonitor = Monitor;
            ModHelper = helper;

            Helper.Events.GameLoop.GameLaunched += OnGameLaunched;
















        }




        private void OnGameLaunched(object sender, GameLaunchedEventArgs e)
        {
            ModEntry.ModHelper = Helper;
            ModEntry.ModMonitor = Monitor;

            var sc = Helper.ModRegistry.GetApi<ISpaceCoreApi>("spacechase0.SpaceCore");






           // sc.RegisterCustomProperty(typeof(Farmer), "isShunned", typeof(NetBool), AccessTools.Method(typeof(FarmerTeam_Enlightenment), nameof(FarmerTeam_Enlightenment.hasEnlightenment)), AccessTools.Method(typeof(FarmerTeam_Enlightenment), nameof(FarmerTeam_Enlightenment.set_hasEnlightenment)));



        }






    }
}
