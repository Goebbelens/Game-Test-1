using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Legacy_PlayerMovement : MonoBehaviour
{
    private Rigidbody playerRigid;
    void Start()
    {
        playerRigid = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        /*if (Input.GetKey(KeyCode.W))
        {
            playerRigid.AddForce(transform.forward * 20, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.S))
        {
            playerRigid.AddForce(transform.forward * -17, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.D))
        {
            playerRigid.AddForce(transform.right * 18, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.A))
        {
            playerRigid.AddForce(transform.right * -18, ForceMode.Force);
        }*/
        if (Input.GetKey(KeyCode.W))
        {
            playerRigid.AddForce(Vector3.forward * 20, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.S))
        {
            playerRigid.AddForce(Vector3.forward * -17, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.D))
        {
            playerRigid.AddForce(Vector3.right * 18, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.A))
        {
            playerRigid.AddForce(Vector3.right * -18, ForceMode.Force);
        }
    }
}
