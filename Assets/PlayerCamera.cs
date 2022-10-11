using System.Collections;
using System.Collections.Generic;
using Fusion;
using Fusion.Sockets;
using System;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerCamera : NetworkBehaviour
{
/*     public GameObject player;
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
    } */

    public NetworkObject _player;

    // Start is called before the first frame update
    public void FollowPlayer(NetworkObject player)
    {
        
        _player = player;


        GameObject cameraObject = GameObject.FindGameObjectWithTag("MainCamera");
            if (cameraObject != null)
            {
                cameraObject.transform.parent = player.transform;
            }
            else
            {
                Debug.Log("Couldn't find MainCamera in scene");
            }
    
    }

}
