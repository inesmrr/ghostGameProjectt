using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup_text : MonoBehaviour
{
    public GameObject pickupText;

    public void Start()
    {
        pickupText.SetActive(false);
    }

    public void OnMouseOver()
    {
        pickupText.SetActive(true);
    }

    public void OnMouseExit()
    {
        pickupText.SetActive(false);
    }
}
