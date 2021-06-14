using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countscore : MonoBehaviour
{
    public Text scoretext;
    private float score;
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectsWithTag("Player") != null)
        {
            score += 1 * Time.deltaTime;
            scoretext.text = ((int)score).ToString();
        }
    }
}
