using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    
    public GameObject player;
    public float z_offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update () 
    {

        // Temporary vector
        Vector3 temp = player.transform.position;
        temp.x = temp.x - 0;
        temp.y = 4;
        temp.z = temp.z - 12;
        // Assign value to Camera position
        transform.position = temp;
    }
}
