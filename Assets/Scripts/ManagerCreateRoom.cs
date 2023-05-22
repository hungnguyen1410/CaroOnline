using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerCreateRoom : MonoBehaviour
{
    [SerializeField] private InputField inputName;
    [SerializeField] private InputField inputGold;
    [SerializeField] private InputField inputPassword;
    [SerializeField] private Toggle isPrivate;
    [SerializeField] private Button btnCreate;
    [SerializeField] private Button btnResetInput;

    private void Start()
    {
        btnCreate.onClick.AddListener(() =>
        {
            CheckCreateRoom();
        });
        btnResetInput.onClick.AddListener(() =>
        {
            ResetInput();
        });
    }

    void CheckCreateRoom()
    {
        if(inputName.text == "" )
        {
            var colors = inputName.colors;
            colors.normalColor = Color.red;
            inputName.colors = colors;
        }
        else if(inputGold.text == "")
        {
            var colors = inputGold.colors;
            colors.normalColor = Color.red;
            inputGold.colors = colors;
        }    
        else if((isPrivate.isOn && inputPassword.text == ""))
        {
            var colors = inputPassword.colors;
            colors.normalColor = Color.red;
            inputPassword.colors = colors;
        }
        else
        {
            CreateRoom();
        }

    }

    public void CreateRoom()
    {
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 2;
        int requiredGold = int.Parse(inputGold.text);
        roomOptions.CustomRoomProperties = new ExitGames.Client.Photon.Hashtable();
        roomOptions.CustomRoomProperties.Add("RequiredGold", requiredGold);
        roomOptions.CustomRoomPropertiesForLobby = new string[] { "RequiredGold" };
        roomOptions.IsVisible = true; // Loại phòng public

        //if (isPrivate)
        //{
        //    roomOptions.IsVisible = false; // Loại phòng private
        //    roomOptions.CustomRoomProperties.Add("IsPrivate", true);
        //    roomOptions.CustomRoomPropertiesForLobby = new string[] { "RequiredGold", "IsPrivate" };
        //    roomOptions.PublishUserId = true;
        //    roomOptions.CustomRoomProperties.Add("Password", inputPassword.text.ToString());
        //}

        PhotonNetwork.CreateRoom(inputName.text, roomOptions);
    }


    void ResetInput()
    {
        inputName.text = "";
        inputGold.text = "";
        isPrivate.isOn = false;
        inputPassword.text = "";
        inputPassword.transform.parent.gameObject.SetActive(false);
    }
}
