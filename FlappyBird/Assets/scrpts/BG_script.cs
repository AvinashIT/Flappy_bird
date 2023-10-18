using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG_script : MonoBehaviour
{
    private MeshRenderer mr;
    public float anispeed = 1f;
    private void Start()
    {
        mr = GetComponent<MeshRenderer>();
    }

    private  void Update()
    {
        mr.material.mainTextureOffset += new Vector2(anispeed*Time.deltaTime,0);
    }
}
