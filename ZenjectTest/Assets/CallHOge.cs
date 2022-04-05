using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
public class CallHOge : MonoBehaviour
{
    [Inject] IOnButton onButton;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(onButton==null)
        {
            Debug.Log("‰½‚à“ü‚Á‚Ä‚È‚¢");
        }
        if (Input.anyKeyDown)
        {
            onButton.ButtonPushed(Input.inputString);
        }
    }
}
