using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float Xangle = 1f;
    [SerializeField] float Yangle = 1f;
    [SerializeField] float Zangle = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Xangle, Yangle, Zangle);
    }
}
