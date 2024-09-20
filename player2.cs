using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour
{
   
   public float moveSpeed;

    void Start()
    { 
    }

    void Update()
    {

        bool isPressingUp = Input.GetKey(KeyCode.UpArrow);
        bool isPressingDown = Input.GetKey(KeyCode.DownArrow);

        if(isPressingUp)
        {
           transform.Translate(Vector2.up * Time.deltaTime); 
        }

        if(isPressingDown)
        {
          transform.Translate(Vector2.down * Time.deltaTime); 
        }
            }
}
