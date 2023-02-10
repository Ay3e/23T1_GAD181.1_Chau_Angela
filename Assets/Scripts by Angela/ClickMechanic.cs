using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickMechanic : MonoBehaviour
{
    public static int objectsRemaining = 4;
    private string objectName;
    [SerializeField] private GameObject textOfObject;

    void OnMouseDown()
    {
        //If the player CLICKS on the game object make the object and name from the list disappear
        objectName = gameObject.name;
        Destroy(gameObject);
        Destroy(textOfObject);
        objectsRemaining--;
    }
}
