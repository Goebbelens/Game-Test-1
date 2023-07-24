using Newtonsoft.Json.Bson;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class BodyText : MonoBehaviour
{
    private int bodyBumped = 0;

    private void Awake()
    {
        GlobalEventManager.OnBodyBumped.AddListener(BodyHasBeenBumped);
    }


    private void BodyHasBeenBumped(int bodies)
    {
        bodyBumped++;
        
        GetComponent<TextMeshProUGUI>().text = "Bodies: " + bodyBumped;
    }
}
