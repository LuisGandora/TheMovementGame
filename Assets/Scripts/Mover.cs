using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{ 
    [SerializeField] float MoveSpeed = 10f;
    // Start is called before the first frame update
    //Adams bad at every game and botw is bad(he said that) -signed by adam
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the Games");
        Debug.Log("The Controls are WASD or Arrow Keys to move your character");
        Debug.Log("Dont hit the walls!");
    }

    void Movement()
    {
        float XValue = Input.GetAxis("Horizontal")* Time.deltaTime * MoveSpeed;
        float ZValue = Input.GetAxis("Vertical")* Time.deltaTime * MoveSpeed;
        transform.Translate(XValue,0,ZValue); 
    }
}
