using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public Transform Destination;

    void OnMouseDown()
    {
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.position = Destination.position;
        this.transform.parent = GameObject.Find("destination").transform;
    }

    void OnMouseUp()
    {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
    }
}
