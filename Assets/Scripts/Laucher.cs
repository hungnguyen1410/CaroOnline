using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using ExitGames.Client.Photon;
using PlayFab;
using PlayFab.ClientModels;
using System;

public class Laucher : MonoBehaviourPunCallbacks
{
    public static Laucher instance;
    [SerializeField] private byte maxPlayersPerRoom = 3;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }    
        //PhotonNetwork.AutomaticallySyncScene = true;
    }

    private void Start()
    {
    }
    public void Connect()
    {
        // we check if we are connected or not, we join if we are , else we initiate the connection to the server.
        if (PhotonNetwork.IsConnected)
        {
            // #Critical we need at this point to attempt joining a Random Room. If it fails, we'll get notified in OnJoinRandomFailed() and we'll create one.
            PhotonNetwork.JoinRandomRoom();
        }
        else
        {
            // #Critical, we must first and foremost connect to Photon Online Server.
            PhotonNetwork.ConnectUsingSettings();
        }
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("PUN Basics Tutorial/Launcher: OnConnectedToMaster() was called by PUN");
        PhotonNetwork.JoinLobby();
        SceneManager.LoadScene("Lobby");
    }

    public override void OnJoinedLobby()
    {
        base.OnJoinedLobby();
        Debug.Log("ON join lobby");

        

    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        Debug.LogWarningFormat("PUN Basics Tutorial/Launcher: OnDisconnected() was called by PUN with reason {0}", cause);
    }
    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        Debug.Log("PUN Basics Tutorial/Launcher:OnJoinRandomFailed() was called by PUN. No random room available, so we create one.\nCalling: PhotonNetwork.CreateRoom");
    }

    public void SetupUIInRoom()
    {
        Dictionary<int, Player> players = PhotonNetwork.CurrentRoom.Players;
        foreach (KeyValuePair<int, Player> entry in players)
        {
            if (entry.Value == PhotonNetwork.LocalPlayer)
            {
                if(Manager_SetupPlayer.instance == null)
                    Invoke(nameof(DelaySetupName), 0.5f);
                else
                    Manager_SetupPlayer.instance.SetupPlayer1(PlayerPrefs.GetString("PlayerName"), PlayerPrefs.GetString("PlayerGold"));
            }
            else
            {
                SetupUINamePlayer(entry.Value.NickName);
            }

        }
    }

    public override void OnJoinedRoom()
    {
        UI_Loading.instance.LoadScene("InRoom");
        Debug.Log("OnJoinedRoom() called by PUN. Now this client is in a room.");
        Dictionary<int, Player> players = PhotonNetwork.CurrentRoom.Players;
        //foreach (KeyValuePair<int, Player> entry in players)
        //{
        //    if (entry.Value == PhotonNetwork.LocalPlayer)
        //    {
        //        if (Manager_SetupPlayer.instance == null)
        //        {
        //            Debug.Log("@@@@@@@@@@@");
        //            while(Manager_SetupPlayer.instance == null)
        //            {
                        
        //                Manager_SetupPlayer.instance.SetupPlayer1(PlayerPrefs.GetString("PlayerName"), PlayerPrefs.GetString("PlayerGold"));
        //            }    
        //        }    
        //        else
        //            Manager_SetupPlayer.instance.SetupPlayer1(PlayerPrefs.GetString("PlayerName"), PlayerPrefs.GetString("PlayerGold"));
        //    }
        //    else
        //    {
        //        SetupUINamePlayer(entry.Value.NickName);
        //    }

        //}

    }

    void DelaySetupName()
    {
        Manager_SetupPlayer.instance.SetupPlayer1(PlayerPrefs.GetString("PlayerName"), PlayerPrefs.GetString("PlayerGold"));
    }
    public void SetupUINamePlayer(string id)
    {
        var request = new GetUserDataRequest
        {
            PlayFabId = id,

        };
        PlayFabClientAPI.GetUserData(request, OnGetUserAccountInfoSuccess, OnGetUserAccountInfoError);
    }

    private void OnGetUserAccountInfoError(PlayFabError obj)
    {
    }

    private void OnGetUserAccountInfoSuccess(GetUserDataResult obj)
    {
        string name = obj.Data["Name"].Value;
        string gold = obj.Data["Gold"].Value;
        Manager_SetupPlayer.instance.SetupPlayer2(name, gold);
    }


    public override void OnRoomListUpdate(List<RoomInfo> roomList)
    {
        foreach(RoomInfo room in roomList)
        {
            string nameRoom = room.Name;
            if(room.RemovedFromList)
            {
                foreach(UI_ElementAvailableRoom UI_room in ManagerAvailableRoom.instance.listRoom)
                {
                    if(UI_room.nameRoom == nameRoom)
                    {
                        Destroy(UI_room.gameObject);
                        ManagerAvailableRoom.instance.listRoom.Remove(UI_room);
                    }
                }
            }
            else
            {
                ManagerAvailableRoom.instance.CreateAndUpdateUIRoom(nameRoom, room);
            }
            
        }
        
    }


    public override void OnCreatedRoom()
    {
        base.OnCreatedRoom();
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        base.OnCreateRoomFailed(returnCode, message);
        Debug.Log("Create Room fail :" + message);
    }

    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        base.OnJoinRoomFailed(returnCode, message);
        Debug.Log("Join Room fail");
    }

    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        SetupUINamePlayer(newPlayer.NickName);
        //Invoke(nameof(DelayCheckRunStartGame), 1.5f);
    }

    public override void OnPlayerLeftRoom(Player otherPlayer)
    {
        //Manager_SetupPlayer.instance.ResetUIPlayer();
        Dictionary<int, Player> players = PhotonNetwork.CurrentRoom.Players;
        foreach (KeyValuePair<int, Player> entry in players)
        {
            SetupUINamePlayer(entry.Value.NickName);
        }
    }
    public override void OnPlayerPropertiesUpdate(Player targetPlayer, Hashtable changedProps)
    {
        if(ManagerPlayer.instance != null)
        {
            if (!ManagerPlayer.instance.isStartGame)
            {
                if (int.Parse(PhotonNetwork.LocalPlayer.CustomProperties["Turn"].ToString()) == 0)
                {
                    ManagerPlayer.instance.thisPlayer = ChessPieceType.X;
                    ManagerPlayer.instance.otherPlayer = ChessPieceType.O;
                    ManagerPlayer.instance.isMyTurn = true;
                    ManagerPlayer.instance.timeP1.SetActive(true);
                    ManagerPlayer.instance.timeP2.SetActive(false);
                    ManagerPlayer.instance.ShowPopupStartGame();
                }
                else
                {
                    ManagerPlayer.instance.thisPlayer = ChessPieceType.O;
                    ManagerPlayer.instance.otherPlayer = ChessPieceType.X;
                    ManagerPlayer.instance.timeP1.SetActive(false);
                    ManagerPlayer.instance.timeP2.SetActive(true);
                    ManagerPlayer.instance.isMyTurn = false;
                    ManagerPlayer.instance.isStartGame = true;
                }
            }
        }
           
    }

}
