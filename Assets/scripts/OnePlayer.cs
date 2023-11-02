using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class OnePlayer : MonoBehaviour
{

    public float yPosition = 0f;
    public float ySpeed = 9f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(transform.position.x, yPosition, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        yPosition = yPosition + ySpeed * Time.deltaTime;
        transform.position = new Vector3(transform.position.x, yPosition, 0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Auw!");
        if (collision.gameObject.CompareTag("horizontalWall"))
        {
            Debug.Log("my head or my feet");
            ySpeed = ySpeed * -1f;
        }
    }
}
