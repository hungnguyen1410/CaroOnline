using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Realtime;
using Photon.Pun;

public class UI_ElementAvailableRoom : MonoBehaviour
{
    public string nameRoom;
    public Text textNameRoom;
    public List<Image> imagePeoples;
    public Text textValueGame;
    public Image imagePrivate;
    public bool isPrivate;
    public string password;
    public Sprite spritePeople;
    public Sprite spriteNoPeople;

    private Button btn;

    private void Start()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(() =>
        {
            if (ManagerAvailableRoom.instance.preChoose != gameObject)
            {
                ManagerAvailableRoom.instance.ChangeColorChoose(this.gameObject.GetComponent<RawImage>());
                ManagerAvailableRoom.instance.preChoose = this.gameObject;
            }
            else
            {
                ManagerAvailableRoom.instance.preChoose = null;
                ManagerAvailableRoom.instance.SetColorDefault(this.gameObject.GetComponent<RawImage>());
                JoinRoom();

            }
            
        });
    }

    void JoinRoom()
    {
        PhotonNetwork.JoinRoom(nameRoom);
    }    

    public void CheckUpdateRoom(string nameRoom, int amountPeople, int gold)
    {
        this.nameRoom = nameRoom;
        textNameRoom.text = nameRoom;
        if(amountPeople == 1)
        {
            imagePeoples[0].sprite = spritePeople;
            imagePeoples[1].sprite = spriteNoPeople;
        }
        else if (amountPeople == 2)
        {
            imagePeoples[0].sprite = spritePeople;
            imagePeoples[1].sprite = spritePeople;
        }
        //if (isPrivate)
        //{
        //    imagePrivate.gameObject.SetActive(true);
        //}
        //else
        //{
        //    imagePrivate.gameObject.SetActive(false);
        //}
        textValueGame.text = gold.ToString();
        
    }

}
