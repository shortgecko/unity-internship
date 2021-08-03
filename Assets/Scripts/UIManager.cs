using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    private Dictionary<string, GameObject> UIObjects = new Dictionary<string, GameObject>();

    void Start()
    {
        foreach(Transform child in gameObject.GetComponentInChildren<Transform>())
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
        return UIObjects[objectName];
    }

}
