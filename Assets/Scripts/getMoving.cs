using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getMoving : MonoBehaviour
{
    Vector3 joyInput;
    Vector3 playerPos;
    public float mspd = 10f;
    public float jumpPower = 5f;
    Rigidbody rb;

    // Update is called once per frame
    void Update()
        {
        //i'll add notes that describe what each thing does so that it's easier to build off of in the future
        //keep in mind, none of this has to do with physics yet, just moving.

        //first, we find the player's current position
        //so we call a vector3 and link it to where ever our player is
        playerPos = transform.position;

        //to actually move the character, we have to link it to our input
        //create a vector3 that looks for the axis of our joystick's input and set them correctly
        //then, grab the magnitude of the input to emulate joystick sensitivity
        joyInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        float joySensitivity = joyInput.magnitude;
        //finally, create a target position for rotation by combining the current position and the position of the input
        //basically, we add 1 to where ever the player is in the direction of the joystick
        Vector3 targetPos = joyInput + playerPos;

        //it's also best to normalize the length of the input, but this may make movement wonky so come back to it later
        //joyInput.Normalize();
        //joyInput = Vector2.ClampMagnitude(joyInput, 1f);

        //now it's time to start moving the player
        //we only want to move forward, since moving it around any direction would be too snappy or sluggish
        //but if they only move forward, then they can't turn or move in other directions
        //so what we want to do is make it so that player simply move forwards while rotating in the direction of the input
        
        //to start, we move the player along their z axis
        //adding in a rate determined by input magnitude creates slower movements with stick sensitivity
        float playerVelo = joySensitivity * mspd;
        //we want to make sure that the player stays in whatever position they move to
        //so add the displacement of the player's position to their current position so they stay where they are.
        transform.position += (transform.TransformDirection(Vector3.forward) * playerVelo) * Time.deltaTime;

        //these are all values that are supposed to clamp the players speed, ignore these for now.
        //playerVelo = Mathf.Clamp(playerVelo, -24, 24);
        //transform.postion += playerVelo * Time.deltaTime;
        //Vector3 place = velo * Time.deltaTime;

        //finally, it's time to start rotating the player's position
        //set the speed at which rotations to a new direction will happen
        float rotationSpeed = 8f * Time.deltaTime;
        //PAY ATTENTION TO THIS NEXT PART
        //what we do here is create the rotation target by subtracting the target from the player's position
        //we want the difference between where the player is and where they need to be
        //this is why we subtract the target from the current position
        //finally, we interpolate the player's rotation to the target at a rate of the rotationspeed
        Quaternion rotationTarget = Quaternion.LookRotation(targetPos - playerPos);
        transform.localRotation = Quaternion.Slerp(transform.localRotation, rotationTarget, rotationSpeed);

        //what we REALLY need is a way to give the player a new heading
        //that can probably be done by updating the player's roation with the new target rotation

        //Vector3 velo = new Vector3(joyInput.x, 0f, joyInput.y) * mspd;
        //Vector3 place = velo * Time.deltaTime;
        //transform.localPosition += place;

        rb = GetComponent<Rigidbody>();
        if (Input.GetButtonDown("Fire1"))
            {
                rb.AddForce(transform.up * jumpPower, ForceMode.Impulse);
            }

    }
}
