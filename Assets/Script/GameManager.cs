using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int itemStats;

    public GameObject pasteObject;
    public GameObject brushObject;
    public GameObject waterObject;

    public Slider paste;
    public Slider brush;
    public Slider water;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance = this;
        brushObject.SetActive(false);
        waterObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(paste.value>0)
        {
            pasteObject.SetActive(true);
            brushObject.SetActive(false);
            waterObject.SetActive(false);
        }
       else if(brush.value >0)
        {
            pasteObject.SetActive(false );
            brushObject.SetActive(true );
            waterObject.SetActive(false);
        }
        else {
            pasteObject.SetActive(false );
            brushObject.SetActive(false);
            waterObject.SetActive(true );
        }
    }

   
}
