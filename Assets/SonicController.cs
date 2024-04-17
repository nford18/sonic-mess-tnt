using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonicController : MonoBehaviour
{
    Rigidbody rb;
    GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        camera = GameObject.Find("Sonic the Hedgehog/Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        float time = Time.deltaTime * 100;
        float multiplier = 100.0f;
        Vector3 move = new Vector3(0, 0, 0);
        if(Input.GetKey("w")){
            move += camera.transform.forward * multiplier * time;
        }
        if(Input.GetKey("a")){
            move -= camera.transform.right * multiplier * time;
        }
        if(Input.GetKey("s")){
            move -= camera.transform.forward * multiplier * time;
        }
        if(Input.GetKey("d")){
            move += camera.transform.right * multiplier * time;
        }
        if(Input.GetKey("space")){
            move += camera.transform.up * multiplier * time;
        }
        if(rb.velocity.magnitude < 10.0f){
            rb.AddForce(move);
        }
    }
}
