using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text timeText;
    float TotalTime = 60;
    int retime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TotalTime -= Time.deltaTime;
        retime = (int)TotalTime;
        timeText.text = retime.ToString();

        if(retime == 0)
        {
            SceneManager.LoadScene("ResultScene");
        }
    }
}
