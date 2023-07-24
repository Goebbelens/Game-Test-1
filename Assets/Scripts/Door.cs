using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private bool isOpen;

    public void _TryOpen(float mass )
    {
        Debug.Log(mass);
        if(mass > 10f) isOpen = true;
    }

    private void Update()
    {
        if (isOpen)
        {
            Transform cube = transform.GetChild(0);
            cube.localPosition =  Vector3.MoveTowards(cube.localPosition, Vector3.up * 7, Time.deltaTime * 4);
        }
    }
}
