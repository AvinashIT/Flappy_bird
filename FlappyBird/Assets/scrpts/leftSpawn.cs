using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftSpawn : MonoBehaviour
{
    float rateOfx=5f;
    float l_edge;
    private void Start()
    {
        l_edge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1;
    }
    private void Update()
    {
        transform.position+= Vector3.left * rateOfx*Time.deltaTime;
        if(transform.position.x<l_edge)
        {
            Destroy(gameObject);

        }
    }
}
