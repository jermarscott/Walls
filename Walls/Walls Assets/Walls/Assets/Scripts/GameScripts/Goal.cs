using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{

    // The Renderer that belongs to the object that the pointer is currently touching
    private Renderer touchCurrentRenderer;
    private Color touchOriginalColor;
    public Color touchHighlightColor;


    // Start is called before the first frame update
    void Start()
    {

    }


    void Update()
    {


    }

        // Has to be "Stay" instead of "Enter", if you have overlapping objects
        private void OnTriggerStay(Collider collider)
        {
        Debug.Log("item color change when contact");

        // If the pointer is not touching an object.
        // This if statement prevents the pointer from affecting multiple objects simultaneaously

        if (touchCurrentRenderer == null)
            {
                // Get Renderer component
                touchCurrentRenderer = collider.GetComponent<Renderer>();

                // If the touched object has a Renderer Component
                if (touchCurrentRenderer != null)
                {
                    // Save the Original Color
                    touchOriginalColor = touchCurrentRenderer.material.color;

                    // Highlight Object
                    touchCurrentRenderer.material.color = touchHighlightColor;
                }
            }
        }
        private void OnTriggerExit(Collider collider)
        {
        Debug.Log("item color change stop when  contact stops");

        if (touchCurrentRenderer != null)
            {
                // Restore the Original Color
                touchCurrentRenderer.material.color = touchOriginalColor;
                touchCurrentRenderer = null;
            }

        }

    }
