using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonOn : MonoBehaviour
{
    public Image _Message;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OnBtnUp()
    {
        _Message.gameObject.SetActive(false);

    }
    void Update()
    {
        
    }
}
