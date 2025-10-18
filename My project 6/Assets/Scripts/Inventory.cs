using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{

    public enum PickupType
    {
        None,
        Sword,
        Pickaxe
    }

    public PickupType[] items = new PickupType[2];
    public TMP_Text[] slotTexts; // 👈 Assign Slot Texts in Inspector

    void Start()
    {
        ShowInventory();
        items = new PickupType[2];
    }

    public void AddItem(PickupType pickupType)
    {
        
      

        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == PickupType.None)
            {
                items[i] = pickupType;
                Debug.Log(pickupType + " added to slot " + i);
                ShowInventory(); // Update UI
                return; // ✅ stop here after adding one item
            }
        }

        Debug.Log("Inventory full!");
    
}

    public void RemoveItem(PickupType pickupType)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == pickupType)
            {
                items[i] = PickupType.None;
                Debug.Log(pickupType + " removed from slot " + i);
                ShowInventory();
                return;
            }
        }
        Debug.Log(pickupType + " not found!");
    }

    public void ShowInventory()
    {
        for (int i = 0; i < items.Length; i++)
        {
            string itemName = items[i].ToString();
            Debug.Log($"Slot {i}: {itemName}");

            // ✅ Update UI text if linked
            if (slotTexts != null && i < slotTexts.Length && slotTexts[i] != null)
            {
                if (items[i] == PickupType.None)
                    slotTexts[i].text = "";
                else
                    slotTexts[i].text = itemName;
            }
        }
    }
}
