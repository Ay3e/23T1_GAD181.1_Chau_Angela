using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace AngelaChau {
    public class SceneLoader : MonoBehaviour
    {
        private void Update()
        {
            //If CurrentTime is 0 then change to LOSE scene
            if (Countdown.currentTime == 0)
            {
                //Scene 1 is LoseScene
                SceneManager.LoadScene(1);
            }
            //If objectsRemaining is 0 then change to WIN scene
            if (ClickMechanic.objectsRemaining == 0)
            {
                //Scene 2 is WinScene
                SceneManager.LoadScene(2);
            }
        }
    }
}


