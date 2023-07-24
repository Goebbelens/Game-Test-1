using Newtonsoft.Json.Bson;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GlobalEventManager : MonoBehaviour
{
    public static Action OnCoinTaken;

    public static UnityEvent<int> OnBodyBumped = new UnityEvent<int>();



    public static void SendCoinTaken()
    {
        if (OnCoinTaken != null) OnCoinTaken.Invoke();
    }

    public static void SendBodyBumped(int amountBumped)
    {
        OnBodyBumped.Invoke(amountBumped);
    }
}
