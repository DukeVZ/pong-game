using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class ball : MonoBehaviour
{
    // Variabels 
    public float xPosition = 2f;
    public float yPosition = 2f;
    public float xSpeed = 3f;
    public float ySpeed = 3f;
    public TMP_Text score; 

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

    }
}
