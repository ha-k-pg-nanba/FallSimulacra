using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target_Black : MonoBehaviour
{
    private Vector3 targetpos;
    public Text ScoreText;
    public static int score = 0;
    public int scorepoint;

    void OnCollisionEnter(Collision collision)
    {
        score += scorepoint;
        ScoreText.text = string.Format("Score:{0}", score);

        GetComponent<ParticleSystem>().Play();
    }

    public static int getscore()
    {
        return score;
    }
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        targetpos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Sin(Time.time) * 10.0f + targetpos.x, targetpos.y, targetpos.z);
    }
}
