using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DiscoBallRotation : MonoBehaviour
{
    private Transform DiscoBall;
    [Header("On/Off")]
    [SerializeField]
    private bool IsRotating = true;
    [SerializeField]
    private bool RandomIsOn = false;

    [Header("Positions")]
    [SerializeField]
    private Vector3 currRotation;
    [SerializeField]
    private Vector3 nextRotation;

    [Header("Rotation parameters")]
    [SerializeField]
    private float RotationSpeed = 1.0f;
    [SerializeField]
    private float DefaultRotationCoef = 50.0f;
    public float RotationCoef;
    public float CoefReduction = 1.0f;
    void Awake()
    {
        DiscoBall = gameObject.GetComponent<Transform>();
        currRotation = DiscoBall.rotation.eulerAngles;
        RotationCoef = DefaultRotationCoef;
    }

    void FixedUpdate()
    {
        
        if(IsRotating == true)
        {
            currRotation = Vector3.Lerp(currRotation, nextRotation, RotationSpeed/RotationCoef);
            
            DiscoBall.rotation = Quaternion.Euler(currRotation);

            if(RotationCoef > 1.0f)
            {
                RotationCoef -= CoefReduction;
            }
            
            if(Vector3.Distance(currRotation, nextRotation) < 0.085f)
            {
                currRotation = nextRotation;
                RotationCoef = DefaultRotationCoef;
                IsRotating = false;
            }
            
        }
        if(RandomIsOn == true && IsRotating == false)
        {
            RandomizeDisco(currRotation, ref nextRotation);
            IsRotating = true;
        }
    }

    private void RandomizeDisco(Vector3 disco, ref Vector3 next)
    {
        if (disco.x == 0)
        {
            next = new Vector3(Random.Range(0.0f, 361.0f), Random.Range(0.0f, 361.0f), 0);
            return;
        }
        if (disco.y == 0)
        {
            next = new Vector3(0, Random.Range(0.0f, 361.0f), Random.Range(0.0f, 361.0f));
            return;
        }
        if (disco.z == 0)
        {
            next = new Vector3(Random.Range(0.0f, 361.0f), 0, Random.Range(0.0f, 361.0f));
            return;
        }
        return;
    }
}