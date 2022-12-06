using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private Vector3 targetpos;
    public Text Scoretext;
    private int score = 0;

    void OnCollisionEnter(Collision collision)
    {
        score += 10;
        Scoretext.text = string.Format("Score:{0}", score);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
