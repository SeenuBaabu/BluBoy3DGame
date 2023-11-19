using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class InventoryUI : MonoBehaviour
{
    TextMeshProUGUI collectableText;

    private void Start()
    {
        collectableText = GetComponent<TextMeshProUGUI>();
    }
    public void UpdateInventoryUI(PlayerInventory inventory)
    {
        collectableText.text = inventory.numberOfcollectables.ToString();
    }
}
