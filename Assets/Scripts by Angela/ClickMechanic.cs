using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClickMechanic : MonoBehaviour
{
    //Variables to make objects and list name disappear
    private string objectName;
    [SerializeField] private GameObject textOfObject;
    //Variables to have a counter
    private float currentTime = 10f;
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
        if (remainingItems == 0)
        {
            //CHANGE TO WIN SCENE
            remainingItems = -1; //to get out of a loop
        }
    }

    void OnMouseDown()
    {
        //If player clicks on the game object make the object and name from list disappear
        objectName = gameObject.name;
        Destroy(gameObject);
        Destroy(textOfObject);
        //Everytime the Hidden item is pressed remaining items is reduced
        remainingItems -= 1;
    }
}
