using MelonLoader;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace DebugMod
{
    public class TestMod : MelonMod
    {
        /*public void LoadAssetBundle()
        {
            //Load the assetBundle
            string path = Path.Combine(Application.streamingAssetsPath, "models.xwing");
            AssetBundle bundle = AssetBundle.LoadFromFile(path);
            
            //Load the prefab from the asset bundle
            GameObject prefab = bundle.LoadAsset<GameObject>("xwing");

            //Instantiate the prefab
            GameObject instance = GameObject.Instantiate(prefab);

            //Set the position of the prefab
            instance.transform.position = new Vector3(0, 0, 0);
        }
        
        public override void OnApplicationStart()
        {
            MelonLogger.Msg("If you see this, that means the mod has successfully started");
            LoadAssetBundle();
        }*/

        /*public override void OnLateApplicationStart()
        {
            MelonLogger.Msg("If you see this, that means the mod has successfullt started, and the delayed start works");
        }*/

        public override void OnUpdate()
        {
            if (Input.GetKeyDown(KeyCode.F1))
            {
                int i = 0;
                while (i < 10)
                {
                    TeamManager.instance.GetTeam(1).TryProduceShip();
                    i++;
                }
                i = 0;
            }
        }
    }
}
