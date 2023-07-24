using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Legacy_AngleCheck_Test : MonoBehaviour
{
    /*[SerializeField]
    private Collider playerCollider;*/
    [SerializeField]
    private int RoofDetected = 0;

    
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("XYU");
        Vector3 colCon = collision.GetContact(0).normal;
        
        RoofDetected++;
        Debug.Log("Contact" + colCon.ToString() + "\nRoof Detection " + RoofDetected);
    }

    private void OnCollisionStay(Collision collision)
    {
        Vector3 colStayConnect = collision.GetContact(0).normal;
        Debug.Log("Contact: " + colStayConnect.ToString() + "\nRoof Detection " + RoofDetected);
    }
}
