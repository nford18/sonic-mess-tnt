using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        foreach(Transform obj in gameObject.transform){
            obj.gameObject.AddComponent<MeshCollider>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
