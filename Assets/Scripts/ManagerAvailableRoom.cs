using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using UnityEngine.UI;

public class ManagerAvailableRoom : MonoBehaviour
{
    public static ManagerAvailableRoom instance;
    public UI_ElementAvailableRoom newUIRoom;
    public Transform content;
    public List<UI_ElementAvailableRoom> listRoom = new List<UI_ElementAvailableRoom>();
    public GameObject preChoose;
    [SerializeField] Color colorDefault;
    [SerializeField] Color colorSelect;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void ChangeColorChoose(RawImage current)
    {
        if(preChoose != null)
        {
            preChoose.GetComponent<RawImage>().color = colorDefault;
            current.color = colorSelect;
        }
        else
        {
            current.color = colorSelect;
        }
    }

    public void SetColorDefault(RawImage current)
    {
        current.color = default;
    }

    public void CreateAndUpdateUIRoom(string nameRoom, RoomInfo roomInfo)
    {
        bool isHad = false;
        foreach(Transform tf in content)
        {
            UI_ElementAvailableRoom uiRoom = tf.GetComponent<UI_ElementAvailableRoom>();
            if(uiRoom)
            {
                if(uiRoom.nameRoom == nameRoom)
                {
                    isHad = true;
                    // update 
                    uiRoom.CheckUpdateRoom(roomInfo.Name, roomInfo.PlayerCount, (int)roomInfo.CustomProperties["RequiredGold"]);
                }
            }
        }
        if(!isHad)
        {
            // create ui
            UI_ElementAvailableRoom roomNew = Instantiate(newUIRoom, content);
            roomNew.CheckUpdateRoom(roomInfo.Name, roomInfo.PlayerCount, (int)roomInfo.CustomProperties["RequiredGold"]);
            listRoom.Add(roomNew);
        }
    }      
}
