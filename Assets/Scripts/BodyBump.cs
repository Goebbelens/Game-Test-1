using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyBump : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent<CharacterController>(out CharacterController player))
        {
            GlobalEventManager.SendBodyBumped(1);
        }
    }
}
