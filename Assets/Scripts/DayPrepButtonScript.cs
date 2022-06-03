using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
using UnityEngine.UI;
using TMPro;

public class DayPrepButtonScript: MonoBehaviour {  
    public GameObject Panel;
    public GameObject Canvas;


    private void Start() 
    {
        StartupOfNewGame();
    }


    public void DayPrepButton() {  
        if (Panel != null) {  
            bool isActive = Canvas.activeSelf;  
            Canvas.SetActive(!isActive);  
        }  
    }  


    private void StartupOfNewGame()
    {
        List<ItemData> startingGoods = ItemData.StartingGoodsList();
        GameObject buttonTemplate = Panel.transform.GetChild(0).gameObject;
        //Debug.Log(buttonTemplate);
        GameObject g;
        foreach(var item in startingGoods)
        {
            g = Instantiate(buttonTemplate, Panel.transform);
            g.transform.GetChild(0).GetComponent<TMPro.TextMeshProUGUI>().text = item.identifier +" "+ item.num;
            g.transform.GetComponent<Image>().sprite = item.image;
            g.transform.GetComponent<Image>().preserveAspect = true;
            //Sprite tester = item.image;
        }
        Destroy(buttonTemplate);
        
    }
} 
