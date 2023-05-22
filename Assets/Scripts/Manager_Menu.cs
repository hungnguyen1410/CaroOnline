using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;
using PlayFab;
using PlayFab.ClientModels;
using System;

public class Manager_Menu : MonoBehaviour
{
    public static Manager_Menu instance;
    public string playerNamePrefkey = "PlayerName";
    public string playerIDPrefKey = "PlayerID";
    public string playerGoldPrefKey = "PlayerGold";
    public string playerImagePrefKey = "PlayerImage";
    public string playerWonPrefKey = "PlayerWon";
    public GameObject setupAvatarAndName;
    public GameObject bgCover;
    public Text textID;
    public InputField inputField;
    public Button btn_Done;

    Player player;


    public Text textNameMain;
    public Text textGold;

    [Header("ID")]
    public Text idInSetting;

    [Header("Name")]
    public Text name_General;
    public Text name_InGame;

    [Header("Avatar")]
    public Image avatar_General;
    public Image avatar_Ingame;
    public Image avatar_change;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        UI_Loading.instance.FadeOff();
        PlayerPrefs.SetInt(playerWonPrefKey, 0);
        if(!PlayerPrefs.HasKey(playerGoldPrefKey))
        {
            PlayerPrefs.SetString(playerGoldPrefKey, "1000");
        }
        if (!PlayerPrefs.HasKey(playerNamePrefkey))
        {
            
            Debug.Log("Show setup name!!");
            bgCover.SetActive(true);
            setupAvatarAndName.SetActive(true);
            CreateNewPlayer();
            SetupName();
            
        }
        else
        {
            UpdateAllName(PlayerPrefs.GetString(playerNamePrefkey));
        }
        var request = new GetAccountInfoRequest();
        PlayFabClientAPI.GetAccountInfo(request, OnGetAccountInfoSuccess, OnGetAccountInfoFailure);
        textID.text = "#" + PlayerPrefs.GetString(playerIDPrefKey);
        idInSetting.text = "ID: #" + PlayerPrefs.GetString(playerIDPrefKey);
        UpdateLocalPlayer();
        GetInfoAccout(PlayerPrefs.GetString(playerIDPrefKey));
    }

    private void OnGetAccountInfoFailure(PlayFabError obj)
    {
        throw new System.NotImplementedException();
    }

    private void OnGetAccountInfoSuccess(GetAccountInfoResult obj)
    {
        PlayerPrefs.SetString(playerIDPrefKey, obj.AccountInfo.PlayFabId);
    }

    public void UpdateLocalPlayer()
    {
        PhotonNetwork.NickName = PlayerPrefs.GetString(playerIDPrefKey);
    }    

    public void UpdateAllName(string name)
    {
        name_General.text = name;
        name_InGame.text = name;
        PhotonNetwork.NickName = name;
        PlayerPrefs.SetString(playerNamePrefkey, name);
        UpDataPlayFab();
    }   

    public void UpdateAllAvatar(Sprite img)
    {

    }    
    

    public void SetupName()
    {
        btn_Done.onClick.AddListener(() =>
        {
            if(inputField.text =="")
            {
                Debug.Log("Text Input emtry!!");

            }   
            else
            {
                string name = inputField.text;
                PhotonNetwork.NickName = name;
                UpdateAllName(name);
                setupAvatarAndName.SetActive(false);
                bgCover.SetActive(false);

                UpDataPlayFab();
            }    
        });
    }     

    public void UpDataPlayFab()
    {
        UpdateUserDataRequest request = new UpdateUserDataRequest();
        request.Data = new Dictionary<string, string>();
        request.Data.Add("ID", PlayerPrefs.GetString(playerIDPrefKey));
        request.Data.Add("Name", PlayerPrefs.GetString(playerNamePrefkey));
        request.Data.Add("Gold", PlayerPrefs.GetString(playerGoldPrefKey));
        request.Data.Add("Won", PlayerPrefs.GetString(playerWonPrefKey));
        PlayFabClientAPI.UpdateUserData(request, OnUpdateSucess, OnUpdateError);
    }

    public void GetInfoAccout(string id)
    {
        var request = new GetUserDataRequest { PlayFabId = id,

        };
        PlayFabClientAPI.GetUserData(request, OnGetUserAccountInfoSuccess, OnGetUserAccountInfoError) ;
    }

    private void OnGetUserAccountInfoSuccess(GetUserDataResult obj)
    {
        string name = obj.Data["Name"].Value;
        string ID = obj.Data["ID"].Value;
        Debug.Log("Name: " + name + "  ID: " + ID);

    }


    private void OnGetUserAccountInfoError(PlayFabError obj)
    {
        Debug.LogError("Error getting user account info: " + obj.ErrorMessage);
    }

    private void OnUpdateSucess(UpdateUserDataResult obj)
    {
        Debug.Log("User data updated");
    }

    private void OnUpdateError(PlayFabError obj)
    {
        Debug.LogError("Error updating user data: " + obj.ErrorMessage);
    }

    private void CreateNewPlayer()
    {
        var request = new UpdatePlayerStatisticsRequest
        {
            Statistics = new List<StatisticUpdate>()
        };
        PlayFabClientAPI.UpdatePlayerStatistics(request, OnPlayerCreatedSuccess, OnPlayerCreatedFailure);
    }

    private void OnPlayerCreatedSuccess(UpdatePlayerStatisticsResult result)
    {
        Debug.Log("Player Created!");
    }

    private void OnPlayerCreatedFailure(PlayFabError error)
    {
        Debug.LogError(error.GenerateErrorReport());
    }
}
