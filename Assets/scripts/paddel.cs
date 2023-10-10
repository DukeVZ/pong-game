using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddel : MonoBehaviour
{

    public float xPosition = 2f;
    public float yPosition = 2f;
   



    public float speed = 20f;
    public string leftOrRight;
    public float maxValue = 3.8f;

    void paddleControl(KeyCode up, KeyCode down)
    {
        if (Input.GetKey(up) && transform.position.y <maxValue)
        {
            Debug.Log("yo");
            transform.Translate(Vector3.up * speed * Time.deltaTime);

        }
        else if (Input.GetKey(down) && transform.position.y > -maxValue)
        {
            Debug.Log("kaas");
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (leftOrRight == "left")
        {

          paddleControl(KeyCode.W, KeyCode.S);
        }else if(leftOrRight == "right")
        {
            paddleControl(KeyCode.UpArrow, KeyCode.DownArrow);
        }

    }


    
}
