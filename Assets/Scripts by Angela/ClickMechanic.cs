using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickMechanic : MonoBehaviour
{
    private string objectName;
    [SerializeField] private GameObject textOfObject;

    void OnMouseDown()
    {
        objectName = gameObject.name;
        Destroy(gameObject);
        Destroy(textOfObject);
    }
}
