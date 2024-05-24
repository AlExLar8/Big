using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsHeigh : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Heigh"))
        {
            if (transform.localScale != new Vector3(5f, 5f, 5f))
            {
                transform.localScale = transform.localScale + new Vector3(0.2f, 0.2f, 0.2f);

                Destroy(collision.gameObject);
            }

        }
        if (collision.gameObject.CompareTag("Obstacles")) 
        {
            if (transform.localScale != new Vector3(0.4f, 0.4f, 0.4f))
            {
                 transform.localScale = transform.localScale - new Vector3(0.2f, 0.2f, 0.2f);
            }
           
            
        }
    }
}
