using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<CharacterController>(out CharacterController player))
        {
            GlobalEventManager.SendCoinTaken();

            Destroy(gameObject);
            
        }
    }
}
