using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerPhysics : MonoBehaviour
{

    public float grav;
    public float drag;
    public float frct;
    public float rcoil;

    // Start is called before the first frame update
    void Start()
    {
        RaycastHit hit;
        Ray point_ray = new Ray(transform.position, transform.forward);

    }

    // Update is called once per frame
    void Update()
    {
        //here we'll establish basic player physics
        //the player needs to respond to changes in gravity
        //the player needs to react to hitting walls
        //the player needs to know when to collide with a surface
        //the player needs to know what is and isn't the floor
        //the player should respond to drag on foot and in the air


        //For Ground Collisions

        //Send out a raycast along the z and y vectors
        //When raycast "y" is triggered start physics event
        //Check the objectID of the surface
        //Grab the normal and compare it to a vector "UP"
        //If the dot fits within the threshold set it as ground
        //Send instructions to collider to stop when it hits the object
        //Allow collider to slide along objects markes as ground
        //Get the contact point and set it as the "AXIS"
        //Set the player's state to "OnGround"


        //For Wall Collisions

        //Send out a raycast along the z and y vectors
        //When raycast "z" is triggered start physics event
        //Check the objectID of the surface
        //Grab the normal and compare it to a vector "FORWARD"
        //If the dot fits within the threshold set it as wall
        //Send instructions to collider to stop when it hits the object


        //For Gravity

        //If player is "OnGroud" set "yspd" to 0
        //Otherwise
        //Get the playerID
        //Collect the "weight" value
        //Add a value "grav" to the player's y vector multiplied by weight

    }
}
