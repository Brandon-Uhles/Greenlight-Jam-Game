using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class InventoryHolder : MonoBehaviour
{
    [SerializeField] private int inventorySize;
    [SerializeField] protected ItemSlotSystem itemSlotSystem;

    public ItemSlotSystem ItemSlotSystem => itemSlotSystem;
    public int InventorySize => inventorySize;

    public static UnityAction<ItemSlotSystem> OnDynamicInventoryDisplayRequested;

    private void Awake() {
        itemSlotSystem = new ItemSlotSystem(inventorySize);
    }
}
