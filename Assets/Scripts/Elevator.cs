using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    [SerializeField]
    private GameObject pressCanvas;

    private bool playerOnElevator = false;
    private bool onLowLvl = true;
    [SerializeField]
    private float lowLvl = 0.13f;
    [SerializeField]
    private float highLvl = 2.0f;

    Vector3 LowLevel;
    Vector3 HighLevel;

    public float MovementSpeed = 1f;
    private void Awake()
    {
        LowLevel = new Vector3(transform.position.x, lowLvl, transform.position.z);
        HighLevel = new Vector3(transform.position.x, highLvl, transform.position.z);

        if (onLowLvl)
        {
            transform.position = LowLevel;
        }
        if (!onLowLvl)
        {
            transform.position = HighLevel;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<CharacterController>(out CharacterController player))
        {
            playerOnElevator = true;
            pressCanvas.SetActive(true);
        }
    }

    /*private void OnTriggerStay(Collider other)
    {
       if(Input.GetKeyDown(KeyCode.E))
        {
            onLowLvl = !onLowLvl;
        }
    }*/

    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent<CharacterController>(out CharacterController player))
        {

            playerOnElevator = false;
            pressCanvas.SetActive(false);
            if(onLowLvl == false)
            {
                onLowLvl = true;
            }
        }
    }
    private void FixedUpdate()
    {
        if (!onLowLvl && transform.position.y != HighLevel.y)
        {
            transform.position = Vector3.MoveTowards(transform.position, HighLevel, MovementSpeed * Time.deltaTime);
        }
        if(onLowLvl && transform.position.y != LowLevel.y)
        {
            transform.position = Vector3.MoveTowards(transform.position, LowLevel, MovementSpeed * Time.deltaTime);
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerOnElevator)
        {
            onLowLvl = !onLowLvl;
        }
    }
}
