using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : Interactable
{
    [SerializeField]
    GameObject door;
    protected override void Interact()
    {
       Debug.Log("Interacted With "+gameObject.name);
        door.GetComponent<Animator>().SetBool("IsOpen", true);
    }
}
