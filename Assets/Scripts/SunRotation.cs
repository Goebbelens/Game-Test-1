using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunRotation : MonoBehaviour
{
    [SerializeField]
    private Transform Sun;
    public float rotationSpeed = 1.0f;

    void FixedUpdate()
    {
        Sun.Rotate(transform.position, rotationSpeed * Time.deltaTime);
    }
}
