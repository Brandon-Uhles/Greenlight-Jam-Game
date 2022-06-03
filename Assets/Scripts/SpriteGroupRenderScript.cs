using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteGroupRenderScript : MonoBehaviour
{
    public Sprite greenTea;
    public Sprite senbei;
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = greenTea;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
