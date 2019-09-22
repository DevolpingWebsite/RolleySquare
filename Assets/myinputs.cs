using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class myinputs : MonoBehaviour
{
    Squareinputs controls;

    Vector2 move;
    Vector3 jumps;
    
    
    void Awake()
    {
         controls = new Squareinputs();
         controls.Gameplay.Move.performed += context => move = context.ReadValue<Vector2>();
         controls.Gameplay.Move.canceled += context => move = Vector2.zero; 
         controls.Gameplay.Grow.performed += context => Grow();
         controls.Gameplay.Shrink.performed += context => Shrink();
         controls.Gameplay.Jump.performed += context => Jump();
         
    }

 void Shrink()
    {
        transform.localScale *= 0.9f;
    }
 
    void Grow()
    {
        transform.localScale *= 1.1f;
    }
         
     void Update()
     {
         Vector2 m = new Vector2(move.x, 0) * 10f * Time.deltaTime;
         transform.Translate(m, Space.World);
     }

     void Jump()
     {
        gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 500f);
     }

    void OnEnable()
    {
        controls.Gameplay.Enable();
    }

     void OnDisable()
    {
        controls.Gameplay.Disable();
    }
}
