using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory inventory = other.GetComponent<PlayerInventory>();
        if(inventory != null )
        {
            inventory.CollectedCollectables();
            gameObject.SetActive(false);    
        }
    }
}
