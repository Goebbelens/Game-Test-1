using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscoBallRotation : MonoBehaviour
{
    private Transform DiscoBall;
    [Header("Movement")]
    public float RotationSpeed = 1.0f;
    void Awake()
    {
       DiscoBall = gameObject.GetComponent<Transform>();
    }

    void FixedUpdate()
    {
        DiscoBall.Rotate(DiscoBall.position, RotationSpeed * Time.deltaTime);
    }
}
