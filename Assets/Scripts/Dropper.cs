using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer r;
    Rigidbody rigid;
    [SerializeField] float timetowait = 5f;
    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<MeshRenderer>();
        rigid = GetComponent<Rigidbody>();

        r.enabled = false;
        rigid.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timetowait) 
        {  
            r.enabled = true;
            rigid.useGravity = true;
            Debug.Log("3 seconds have elapsed");
        }
    }
}
