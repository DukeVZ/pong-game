using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

public class collision : MonoBehaviour
{

    //variabels
    public float xPosition = 2f;
    public float yPosition = 2f;
    public float xSpeed = 10f;
    public float ySpeed = 10f;
    public TMP_Text score;
    public int leftScore = 0;
    public int rightScore = 0;
    public int winScore = 10;
    void resetBall()
    {
        xPosition = 0f;
        yPosition = Random.Range(-4f,4f);
        xSpeed = xSpeed * -1f;

    }


    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(xPosition, yPosition, 0f);

    }

    // Update is called once per frame
    void Update()
    {
        xPosition = xPosition + xSpeed * Time.deltaTime;
        yPosition = yPosition + ySpeed * Time.deltaTime;
        transform.position = new Vector3(xPosition, yPosition, 0f);

        if(leftScore >= 10) 
        {
            score.text = "left player wins";
            xPosition = 0f;
            yPosition = 0f;
        }
        else if (rightScore >= 10)
        {
            score.text = "right player wins";
            xPosition = 0f;
            yPosition = 0f;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Auw!");
        if (collision.gameObject.CompareTag("horizontalWall"))
        {
            ySpeed = ySpeed * -1f;
          
        }
        else if (collision.gameObject.CompareTag("verticalWallL"))
        { 
            resetBall();
            rightScore++;
            score.text = leftScore + "-" + rightScore;
        }
        else if (collision.gameObject.CompareTag("verticalWallR"))
        {
            resetBall();
            leftScore++;
            score.text = leftScore + "-" + rightScore;
        }
        else if (collision.gameObject.CompareTag("middalWall"))
        {
            xSpeed = xSpeed * -1f;
        }


        {
            Debug.Log("Auw!");
            if (collision.gameObject.CompareTag("paddelLeft"))
            {
                Debug.Log("yes");
                xSpeed = xSpeed * -1.1f;
            }
            else if (collision.gameObject.CompareTag("paddelRight"))
            {
                Debug.Log("yeeey");
                xSpeed = xSpeed * -1.1f;
            }

        }
    }
}
