using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlTogglePrivate : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject popupPassWord;
    [SerializeField]private Toggle toggle;
    void Start()
    {
        toggle = GetComponent<Toggle>();
        //toggle.onValueChanged.AddListener((isSelect) =>
        //{
        //    if(isSelect)
        //    {
        //        popupPassWord.SetActive(true);
        //    }
        //    else
        //    {
        //        popupPassWord.SetActive(false);
        //    }
        //});
            
    }

}
