using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour
{
    private static music backgroundmusic;

    void Awake()
    {
        if(backgroundmusic== null)
        {
            backgroundmusic = this;
            DontDestroyOnLoad(backgroundmusic);
        }

        else
        {
            Destroy(gameObject);
        }
    }
}
