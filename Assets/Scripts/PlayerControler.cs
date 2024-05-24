using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private int speed = 20;
    public bool gameOverl;
    private float horizontalInput;
    private float forwardInput;
    private int rotationSpeed = 70;
    public Rigidbody rb;
    private int force = 9;
    private bool onfloor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed*forwardInput);
        transform.Rotate(Vector3.up * horizontalInput * Time.deltaTime * rotationSpeed);
        if (Input.GetKeyDown(KeyCode.Space)&& onfloor==true)
        {
            rb.AddForce(Vector3.up * force, ForceMode.Impulse);
            onfloor = false;
        }
        

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            onfloor = true;
        }
    }




}
