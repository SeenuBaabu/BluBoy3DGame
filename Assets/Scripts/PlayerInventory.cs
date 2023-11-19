using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class PlayerInventory : MonoBehaviour
{
    public int numberOfcollectables {  get; private set; }
    public UnityEvent<PlayerInventory> onItemCollected;
    public void CollectedCollectables()
    {
        numberOfcollectables++;
        onItemCollected.Invoke(this);
    }
}
