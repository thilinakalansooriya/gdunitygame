using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loopingbackground : MonoBehaviour
{
    // Start is called before the first frame update
    public float backgroundspeed;
    public Renderer backgroundRender;


    // Update is called once per frame
    void Update()
    {
        backgroundRender.material.mainTextureOffset += new Vector2(backgroundspeed * Time.deltaTime, 0f);
    }
}
