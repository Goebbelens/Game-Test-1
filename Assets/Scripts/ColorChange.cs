using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    
public class ColorChange : MonoBehaviour
{
    [Header("Color range")]
    public Color currColor;
    public Color nextColor;

    [Header("Color change")]
    [SerializeField]
    private float ColorChangeSpeed = 1.0f;
    [SerializeField]
    private float ColorDiff = 1.0f;
    [SerializeField]
    private int XTimes = 1;
    private int X = 0;

    private Light spotlight;
    void Start()
    {
        spotlight = GetComponent<Light>();
        currColor = spotlight.color;
    }

    // Update is called once per frame
    void Update()
    {
        currColor = Color.Lerp(currColor, nextColor, Time.deltaTime/ColorChangeSpeed);
        spotlight.color = currColor;
        
        if(currColor == nextColor)
        {
            RandomizeColor(ref nextColor, ref X, XTimes);
        }
    }

    private void RandomizeColor(ref Color color, ref int x, int xtimes)
    {
        color.r = Random.Range(0.1f, 0.99f);
        color.g = Random.Range(0.1f, 0.99f);
        color.b = Random.Range(0.1f, 0.99f);
        if (Mathf.Abs(color.r - color.g) < ColorDiff || Mathf.Abs(color.r - color.b) < ColorDiff || Mathf.Abs(color.g - color.b) < ColorDiff)
        {
            x++;
            if (x > xtimes)
            {
                x = 0;
                return;
            }
            RandomizeColor(ref color, ref x, xtimes);
        }
    }

}
