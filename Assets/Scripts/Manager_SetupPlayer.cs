using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;
using Photon.Pun;
using Photon.Realtime;

public class Manager_SetupPlayer : MonoBehaviourPunCallbacks
{
    public static Manager_SetupPlayer instance;
    [SerializeField] private Text namePlayer1;
    [SerializeField] private Text goldPlayer1;

    [SerializeField] private Text namePlayer2;
    [SerializeField] private Text goldPlayer2;
    [SerializeField] private GameObject popup_RunStartGame;
    [SerializeField] private Text textCounting;
    [Header("Setup_Ready")]
    [SerializeField] Button btnReady;
    [SerializeField] Image imgReadyPlayer1;
    [SerializeField] Image imgReadyPlayer2;
    [SerializeField] Text textButtonReady;
    bool isReady;
    bool isPlayer2Ready;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        
    }
    private void Start()
    {
        UI_Loading.instance.FadeOff();
        Player localPlayer = PhotonNetwork.LocalPlayer;
        if (localPlayer.CustomProperties.ContainsKey("isReady"))
        {
            localPlayer.CustomProperties["isReady"] = 0;
        }
        else
        {
            localPlayer.SetCustomProperties(new ExitGames.Client.Photon.Hashtable() { { "isReady", 0 } });
        }

        Laucher.instance.SetupUIInRoom();

        btnReady.onClick.AddListener(() =>
        {
            OnClickReady();
        });
    }

    void OnClickReady()
    {
        
        if (!isReady)
        {
            textButtonReady.text = "UnReady";
            isReady = true;
            imgReadyPlayer1.enabled = true;
            PhotonNetwork.LocalPlayer.CustomProperties["isReady"] =1;
            SendReady(1);
            if(isPlayer2Ready)
            {
                RunStartGame();
            }

        }
        else
        {
            textButtonReady.text = "Ready";
            isReady = false;
            imgReadyPlayer1.enabled = false;
            PhotonNetwork.LocalPlayer.CustomProperties["isReady"] =0;
            SendReady(0);
        }
        
    }

    [PunRPC]
    public void SendReady(int value)
    {
        this.photonView.RPC("ReceiveReady", RpcTarget.Others, value);


    }

    [PunRPC]
    void ReceiveReady(int value)
    {
        if(value == 0)
        {
            isPlayer2Ready = false;
            imgReadyPlayer2.enabled = false;
        }
        else
        {
            isPlayer2Ready = true;
            imgReadyPlayer2.enabled = true;
            if(isReady)
            {
                RunStartGame();
            }
        }
    }

    public void SetupPlayer1(string name, string gold)
    {
        namePlayer1.text = name;
        goldPlayer1.text = gold;
    }    

    public void SetupPlayer2(string name, string gold)
    {
        namePlayer2.text = name;
        goldPlayer2.text = gold;
    }

    public void ResetUIPlayer()
    {
        namePlayer1.text = "";
        namePlayer2.text = "";
        goldPlayer1.text = "";
        goldPlayer2.text = "";
    }

    public void RunStartGame()
    {
        popup_RunStartGame.SetActive(true);
        StartCoroutine(CountingTime(3));
    }

    IEnumerator CountingTime(int amountTime)
    {
        for(int i = amountTime; i>=0;i--)
        {
            textCounting.text = i.ToString();
            yield return new WaitForSeconds(1);
        }
        textCounting.text = "GO";
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("GamePlay");
    }
}
