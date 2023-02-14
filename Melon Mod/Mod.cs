using MelonLoader;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace DebugMod
{
    public class TestMod : MelonMod
    {
        bool hasUpdateStarted = true;
        bool hasFixedUpdateStarted = true;
        bool hasLateUpdateStarted = true;
        
        public override void OnApplicationStart()
        {
            MelonLogger.Msg("If you see this, that means the mod has successfully started");
        }
        
        /*public override void OnLateApplicationStart()
        {
            MelonLogger.Msg("If you see this, that means the mod has successfullt started, and the delayed start works");
        }*/

        public override void OnUpdate()
        {
            if(hasUpdateStarted == true)
            {
                MelonLogger.Msg("If you see this, that means the update function is working");
                hasUpdateStarted = false;
            }
        }
        
        public override void OnFixedUpdate()
        {
            if(hasFixedUpdateStarted == true)
            {
                MelonLogger.Msg("If you see this, that means OnFixedUpdate works");
                hasFixedUpdateStarted = false;
            }
        
            /*bool triggerValue;
            if (device.TryGetFeatureValue(UnityEngine.XR.CommonUsages.triggerButton, out triggerValue) && triggerValue)
            {
                MelonLogger.Msg("Trigger button is pressed.");
            }*/
        }        
        public override void OnLateUpdate()
        {
            if(hasLateUpdateStarted == true)
            {
                MelonLogger.Msg("If you see this, that means OnLateUpdate works, this message should appear after all the others, with the except being possibly OnFixedUpdate");
                hasLateUpdateStarted = false;
            }
        }
    }
}
