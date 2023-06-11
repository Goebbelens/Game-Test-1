using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTime : MonoBehaviour
{
    private TMPro.TextMeshProUGUI gameTime;
    void Awake()
    {
        gameTime = gameObject.GetComponent<TMPro.TextMeshProUGUI>();
    }

    void FixedUpdate()
    {
        gameTime.text = Time.time.ToString("00.0");
    }
}
