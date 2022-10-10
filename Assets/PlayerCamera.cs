/* using UnityEngine;
using UnityEngine.Networking;

public class PlayerCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (isLocalPlayer)
        {
            GameObject cameraObject = GameObject.FindGameObjectWithTag("MainCamera");
            if (cameraObject != null)
            {
                cameraObject.transform.parent = gameObject.transform;
            }
            else
            {
                Debug.Log("Couldn't find MainCamera in scene");
            }
        }
    
    }
} */
