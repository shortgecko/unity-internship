using System;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private Dictionary<string, GameObject> UIObjects;

    void Start()
    {
        UIObjects = new Dictionary<string, GameObject>();

        foreach (Transform child in gameObject.GetComponentInChildren<Transform>())
        {
           GameObject childObject = child.gameObject;
           UIObjects.Add(childObject.name, childObject);
           if(childObject.tag == "StartUnactive")
           {
               childObject.SetActive(false);
           }
        }
    }


    public GameObject Get(string objectName)
    {
        if(UIObjects.ContainsKey(objectName))
        {
            return UIObjects[objectName];
        }

        throw new Exception($"Game Object {objectName} does not exist.");

    }

}
