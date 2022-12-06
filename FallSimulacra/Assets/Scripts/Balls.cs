using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balls : MonoBehaviour
{
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit))
            {
                //Destroy(hit.collider.gameObject);
                Rigidbody rb = hit.collider.gameObject.GetComponent<Rigidbody>();
                Vector3 force = new Vector3(0.0f, 5.0f, 20.0f);
                rb.AddForce(force, ForceMode.Impulse);
            }
        }
    }
}
