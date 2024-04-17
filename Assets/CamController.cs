using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Sonic the Hedgehog");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("left")){
            gameObject.transform.RotateAround(player.transform.position, Vector3.up, 1);
        }
        if(Input.GetKey("right")){
            gameObject.transform.RotateAround(player.transform.position, Vector3.up, -1);
        }
        
    }
}
