using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseChange : MonoBehaviour
{
    // Start is called before the first frame update
    public Texture2D Paste;
    public Texture2D Brush;
    public Texture2D Water;
    public int wichCusor;


    public void Gettoothpaste()
    {
        Cursor.SetCursor(Paste,new Vector2(1,0),CursorMode.Auto);
        GameManager.instance.itemStats = 1;
    }

    public void Gettoothbrush()
    {
        Cursor.SetCursor(Brush, new Vector2(1, 0), CursorMode.Auto);
        GameManager.instance.itemStats = 2;
    }

    public void Getwater()
    {
        Cursor.SetCursor(Water, new Vector2(1, 0), CursorMode.Auto);
        GameManager.instance.itemStats = 3;
    }
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        

        
    }
}
