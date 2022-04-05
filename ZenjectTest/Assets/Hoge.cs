using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Hoge : MonoBehaviour, IOnButton
{
    [SerializeField] Text text;
    public void ButtonPushed(string key)
    {
        text.text += " " + key;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
