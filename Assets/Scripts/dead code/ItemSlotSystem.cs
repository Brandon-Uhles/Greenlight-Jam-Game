using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.Events;

[System.Serializable]
public class ItemSlotSystem
{
    [SerializeField] private List<ItemSlot> itemSlots;

    public List<ItemSlot> ItemSlots => itemSlots;
    public int InventorySize => itemSlots.Count;

    public UnityAction<ItemSlot> OnItemSlotChanged;

    public ItemSlotSystem(int size) {
        {
            itemSlots = new List<ItemSlot>(size);

            for (int i = 0; i < size; i++)
            {
                itemSlots.Add(new ItemSlot());
            }
        }
    }
}
