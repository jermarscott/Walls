using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//public Text ScoreText();

public class Player : MonoBehaviour
{
    public float moveSpeed = 600f;
    float movement = 0f;
    private int Score = 0;
    double timeLeft = 5f;


    void Start()
    {
        SetScoreText ();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
          //  touchPosition.z = 0f;
            transform.position = touchPosition;
        }

        Debug.Log("recieve input");

        movement = Input.GetAxisRaw("Horizontal");

    
        


    }


    private void FixedUpdate()
    {
        Debug.Log("move object player");

        transform.RotateAround(Vector3.zero, Vector3.up, movement * Time.fixedDeltaTime * -moveSpeed);
    }


    void OnTriggerEnter (Collider collider)
    {
        if (collider.gameObject.CompareTag ("Enemy"))
        {
           // collider.gameObject.SetActive(false);
           Score++;
           // SetScoreText();
        }
    }

    void SetScoreText ()
    {
        //SetScoreText.text = "Score: " + Score.ToString ();
    }
}
