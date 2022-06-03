using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[System.Serializable]
public class ItemSlot : MonoBehaviour
{
    [SerializeField] private ItemData itemData;
    [SerializeField] private int stackSize;
    [SerializeField] private string identifier;
    [SerializeField] private Image image;

    private Button button;

    public ItemData ItemData => itemData;
    public int StackSize => stackSize;
    public string Identifier => identifier;
    public Image Image => image;



    public ItemSlot(ItemData source)
    {
        itemData = source;
        identifier = source.identifier;
//        image.sprite = source.image;
        stackSize = source.num;
    }

    public ItemSlot()
    {
        ClearSlot();
    }

    // private void Awake() 
    // {
    //     ClearSlot();
    //     button.GetComponent<Button>();
    //     button?.onClick.AddListener(OnUISlotClick);
    // }

    public void OnUISlotClick()
    {
        //Do some things
    }

    public void ClearSlot()
    {
        //itemData = null;
    }

    public void AddToStack(int amount)
    {
        stackSize += amount;

        if(stackSize < 0)
        {
            ClearSlot();
        }
    }

    public void RemoveFromStack(int amount)
    {
        stackSize -= amount;
        if(stackSize < 0)
        {
            ClearSlot();
        }
    }
}
