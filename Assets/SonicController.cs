using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SonicController : MonoBehaviour
{
    Rigidbody rb;
    GameObject camera;
    GameObject ui;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        camera = GameObject.Find("Sonic/Main Camera");
        ui = GameObject.Find("Canvas/UILabels");
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

  private void OnCollisionEnter(Collision collision)
  {
    if(collision.gameObject.CompareTag("Goal")) {
      gameObject.transform.position = new Vector3(0,3,0);
    }

    if (collision.gameObject.tag.Contains("Ring"))
    {
      Destroy(collision.gameObject);
      ui.GetComponent<UIController>().IncRings();
    }

    if (collision.gameObject.tag.Contains("war_bug"))
    {
      Destroy(collision.gameObject);
      ui.GetComponent<UIController>().DropRings();
      rb.AddForce(-camera.transform.forward * 100.0f * Time.deltaTime * 100);
    }

    if (collision.gameObject.tag.Contains("Spring"))
    {
      rb.AddForce(camera.transform.up * 300.0f * Time.deltaTime * 100);
    }
  }
}
