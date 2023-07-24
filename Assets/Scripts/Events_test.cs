using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Events_test : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(DoSomething(WriteHello));
    }

    private IEnumerator DoSomething(Action callback)
    {
        yield return new WaitForSeconds(1);

        Debug.Log("Doing something...");

        yield return new WaitForSeconds(1);

        callback.Invoke();
    }



    private void WriteHello()
    {
        Debug.Log("Hello");
    }

    private void WriteBye()
    {
        Debug.Log("Bye");
    }
}
