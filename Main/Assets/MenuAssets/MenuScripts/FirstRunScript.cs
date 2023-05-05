using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class FirstRunScript : MonoBehaviour
{
   public static class Globals {

         public const int MenuScene = 0;
         public const int AsteroidScene = 1;
         public const int NewArrowScene = 2;
   }
   private VideoPlayer LoadingScreenPlayer;

   private void start() {
      LoadingScreenPlayer = GetComponent<VideoPlayer>();

      LoadingScreenPlayer.clip = Resources.Load<VideoClip>("Assets/MenuAssets/Video/TrimLoadingVid.mp4");
      Debug.Log("loaded video in runtime");
   }
}
