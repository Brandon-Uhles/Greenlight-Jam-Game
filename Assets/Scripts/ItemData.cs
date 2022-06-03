using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Greenlight Jam Project/ItemData")]
public class ItemData : ScriptableObject {
    public Sprite image;
    public string identifier;
    [TextArea(4,4)]
    public string description;
    public int price;
    public int num;


    public static List<ItemData> StartingGoodsList()
    {
        ItemData greenTea = new ItemData();
        greenTea.identifier = "Green Tea";
        greenTea.num = 5;
        greenTea.image = Resources.Load <Sprite> ("Sprites/greenTeaSprite");
        ItemData senbei = new ItemData();
        senbei.identifier = "Senbei";
        senbei.image = Resources.Load <Sprite> ("Sprites/badSenbei");
        senbei.num = 1;

        List<ItemData> startingGoods = new List<ItemData>();
        
        startingGoods.Add(greenTea);
        startingGoods.Add(senbei);

        return startingGoods;
    }
}
