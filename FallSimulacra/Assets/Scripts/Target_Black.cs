using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target_Black : MonoBehaviour
{
    private Vector3 targetpos;

    void OnCollisionEnter(Collision collision)
    {
        GetComponent<ParticleSystem>().Play();
    }
    // Start is called before the first frame update
    void Start()
    {
        targetpos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Sin(Time.time) * 10.0f + targetpos.x, targetpos.y, targetpos.z);
    }
}
