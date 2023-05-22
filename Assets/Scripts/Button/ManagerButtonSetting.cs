using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerButtonSetting : MonoBehaviour
{
    public Button btn_Setting;
    public Button btn_Avatar;
    public Button btn_Rename;
    public Button btn_Music;
    public Button btn_Sound;
    public Button btn_Close;
    public GameObject bgCover;
    public List<GameObject> popups;
    public GameObject popupSetting;

    [Header("Avatar")]
    public Button btn_Gallery;
    public Button btn_Camera;
    

    [Header("Rename")]
    public Button btn_Done;
    public InputField input_Name;
    

    void Start()
    {
        btn_Setting.onClick.AddListener(OnClickBtn_Setting);
        btn_Avatar.onClick.AddListener(OnclickBtn_Avatar);
        btn_Rename.onClick.AddListener(OnclickBtn_Rename);
        btn_Close.onClick.AddListener(OnclickBtn_Close);
    }

    public void OnClickBtn_Setting()
    {
        popupSetting.SetActive(true);
        bgCover.SetActive(true);
        ShopPopup(0);
    }    
    public void OnclickBtn_Avatar()
    {
        ShopPopup(1);
    }    
    public void OnclickBtn_Rename()
    {
        ShopPopup(2);
        btn_Done.onClick.AddListener(OnClickBtn_DoneReName);
    }    

    void ShopPopup(int index)
    {
        for(int i=0;i<popups.Count;i++)
        {
            if(i == index)
            {
                popups[i].SetActive(true);
            }    
            else
            {
                popups[i].SetActive(false);
            }    
        }    
    }

    void OnClickBtn_DoneReName()
    {
        string nameInput = input_Name.text;
        if (nameInput != "")
        {
            Manager_Menu.instance.UpdateAllName(nameInput);
            ShopPopup(0);
            Manager_Menu.instance.UpdateLocalPlayer();
        }    
    }    

    void OnclickBtn_Close()
    {
        popupSetting.SetActive(false);
        bgCover.SetActive(false);
    }    
}
