using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace AngelaChau {
    public class SceneLoader : MonoBehaviour
    {
        private int mainMenu = 0;
        private int levelOne = 1;
        private int loseScene = 2;
        private int winScene = 3;
        private int restartCurrentTime = 10;
        private int restartobjectsRemaining = 4;
        private void Update()
        {
            //If CurrentTime is 0 then change to LOSE scene
            if (Countdown.currentTime == 0)
            {
                //Scene 1 is LoseScene
                SceneManager.LoadScene(loseScene);
                ClickMechanic.objectsRemaining = 4;
                Countdown.currentTime = restartCurrentTime;
            }
            //If objectsRemaining is 0 then change to WIN scene
            if (ClickMechanic.objectsRemaining == 0)
            {
                //Scene 2 is WinScene
                SceneManager.LoadScene(winScene);
                ClickMechanic.objectsRemaining = 4;
                Countdown.currentTime = restartCurrentTime;
            }
        }
        //If button PLAY is pressed go to levelOne
        public void ButtonToPlay()
        {
            SceneManager.LoadScene(levelOne);
        }
        //If button MAIN MENU is pressed go to main menu scene
        public void ButtonToMainMenu()
        {
            SceneManager.LoadScene(mainMenu);
        }
        //If button RETRY is pressed go to levelOne
        public void ButtonToRetry()
        {
            SceneManager.LoadScene(levelOne);
        }
    }
}


