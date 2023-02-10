using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    //public static to be used in SCENELOADER
    public static float currentTime = 10f;
    
    private int remainingItems = 4;
    [SerializeField] Text countDownText;
    private void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countDownText.text = currentTime.ToString("0");
        if (currentTime <= 0)
        {
            currentTime = 0;
        }
    }
}
