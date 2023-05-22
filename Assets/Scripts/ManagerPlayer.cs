using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;
using Photon;
using PlayFab.ClientModels;
using PlayFab;
public class ManagerPlayer : MonoBehaviourPunCallbacks
{
    public static ManagerPlayer instance;
    [SerializeField] private Text namePlayer1;
    [SerializeField] private Text namePlayer2;
    [SerializeField] private Text timePlayer1;
    [SerializeField] private Text timePlayer2;
    public GameObject timeP1;
    public GameObject timeP2;
    public Text timePlayerCurrent;
    public ChessPieceType thisPlayer;
    public ChessPieceType otherPlayer;
    public GameObject popup_StartGame;
    public int countingTime = 30;

    public bool isMyTurn;
    public bool isStartGame;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }    
    }

    private void Start()
    {
        SetupName();
        StartCoroutine(CountingTime());
        if(PhotonNetwork.LocalPlayer.IsMasterClient)
        {
            RandomTurn();
        }
        
    }
    
    IEnumerator CountingTime()
    {
        while(true)
        {
            yield return new WaitForSeconds(0.01f);
            if(isStartGame)
            {
                if (countingTime >= 0)
                {
                    yield return new WaitForSeconds(1);
                    timePlayer1.text = "Time: " + countingTime;
                    timePlayer2.text = "Time: " + countingTime;
                    countingTime -= 1;
                }
                else
                {
                    if (isMyTurn)
                    {
                        isMyTurn = false;
                        SendData(-1, -1);
                        timeP1.SetActive(false);
                        timeP2.SetActive(true);
                        TimeDefauld();
                        Debug.Log("Mất lượt");

                    }
                }
            }    
            
        }    
    }    

    public void ShowPopupStartGame()
    {
        popup_StartGame.SetActive(true);
        Invoke(nameof(DelayOffPopup), 1.5f);
    }    

    void DelayOffPopup()
    {
        popup_StartGame.SetActive(false);
        isStartGame = true;
    }    

    public void TimeDefauld()
    {
        countingTime = 30;
        timePlayer1.text = "Time: " + countingTime;
        timePlayer2.text = "Time: " + countingTime;
    }    

    void RandomTurn()
    {
        int index = Random.Range(0, 100);
        int turnMaster;
        int turnclient;
        if(index%2==0)
        {
            turnMaster = 0;
            turnclient = 1;
            
        }    
        else
        {
            turnMaster = 1;
            turnclient = 0;
        }    
        Dictionary<int, Player> players = PhotonNetwork.CurrentRoom.Players;
        foreach (KeyValuePair<int, Player> entry in players)
        {
            if (entry.Value == PhotonNetwork.LocalPlayer)
            {
                ExitGames.Client.Photon.Hashtable newProperties = new ExitGames.Client.Photon.Hashtable();
                newProperties.Add("Turn", turnMaster);
                entry.Value.SetCustomProperties(newProperties);
            }
            else
            {
                ExitGames.Client.Photon.Hashtable newProperties = new ExitGames.Client.Photon.Hashtable();
                newProperties.Add("Turn", turnclient);
                entry.Value.SetCustomProperties(newProperties);
            }
        }

    }    


    public void SetupName()
    {
        Dictionary<int, Player> players = PhotonNetwork.CurrentRoom.Players;
        foreach (KeyValuePair<int, Player> entry in players)
        {
            if(entry.Value == PhotonNetwork.LocalPlayer)
            {
                namePlayer1.text = PlayerPrefs.GetString("PlayerName");
            }
            else
            {
                SetupUINamePlayer(entry.Value.NickName);
            }
        }
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
        namePlayer2.text = name;
    }

    [PunRPC]
    public void SendData(int x, int y)
    {
        this.photonView.RPC("ReceiveData", RpcTarget.Others, x, y);
        
        
    }

    [PunRPC]
    void ReceiveData(int x, int y)
    {
        Debug.Log("Receive ______");
        BoardManager.instance.PlaceChessPiece(otherPlayer, x, y);
        isMyTurn = true;
        TimeDefauld();
        timeP1.SetActive(true);
        timeP2.SetActive(false);
    }

}

[System.Serializable]
public class DataSend
{
    public int x;
    public int y;
}
