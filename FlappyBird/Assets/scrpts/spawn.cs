using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    float max = 2f;
    float min = -1f;
    float rate = 1f;
    private void OnEnable()
    {
        InvokeRepeating(nameof(StartSpawn),rate,rate);
    }
    private void OnDisable()
    {
        CancelInvoke(nameof(StartSpawn));
    }
    void StartSpawn()
    {
        GameObject pipes=Instantiate(prefab, transform.position, Quaternion.identity);
        pipes.transform.position += Vector3.up *Random.Range(min, max);
    }
}
