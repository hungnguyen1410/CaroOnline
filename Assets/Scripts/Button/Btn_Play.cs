using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Btn_Play : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(() =>
        {
            transform.DOKill();
            GetComponent<Button>().interactable = false;
            Laucher.instance.Connect();
            UI_Loading.instance.LoadScene();
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
