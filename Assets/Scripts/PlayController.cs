using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayController : MonoBehaviour
{
    public float speed = 1;
    public float turnspeed = 10000000;
    public float horizontalInput;
    public float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        //transform.Translate(Vector3.right * Time.deltaTime * turnspeed * horizontalInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnspeed * horizontalInput);
        

    }
}
