using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{

   // public float thrust;
    public Rigidbody rb;
    public Transform target;
    public float flashTime;

    public Color origionalColor;
    public MeshRenderer renderer;
    public static int POINT=0;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("wait .2f");
       //new WaitForSeconds(0.2f);
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Debug.Log("move toward position");
        rb.AddForce(target.position - transform.position);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log("move toward position");
        rb.AddForce(target.position - transform.position);
       //  transform.rotation = Quaternion.RotateTowards(transform.rotation, target, 1 * Time.deltaTime);
    }
    
    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Destroyd");
              
         if (col.collider.tag == ("Player"))
        {
            POINT++;
           // WaitForSeconds(0.2f);

            MakeBlue();
            //ResetColor();
            Vector3 velocity = GetComponent<Rigidbody>().velocity;
            velocity.y = 20.0f;
            GetComponent<Rigidbody>().velocity = velocity;
            GetComponent<Rigidbody>().AddForce(Vector3.forward * 10f);
         
          
        }
        
    }

   void MakeBlue()
    {
     
        renderer.material.color = new Color(1.0f, 1, 1); 
       
    }


    void ResetColor()
    {
        renderer.material.color = new Color(5f, 1,5 ); 
    }
    
}
