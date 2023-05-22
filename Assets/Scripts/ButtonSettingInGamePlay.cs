using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class ButtonSettingInGamePlay : MonoBehaviour
{
    [SerializeField] Button btnResume;
    [SerializeField] Button btnBackToLobby;
    private Button btnSetting;
    [SerializeField] GameObject popup_setting;
    void Start()
    {
        btnSetting = GetComponent<Button>();
        btnSetting.onClick.AddListener(() =>
        {
            transform.DORotate(new Vector3(0, 0, 45), 0.3f).SetEase(Ease.Linear).OnComplete(() =>
            {
                popup_setting.SetActive(true);
            });
        });
        btnResume.onClick.AddListener(() =>
        {
            popup_setting.SetActive(false);
            transform.DORotate(new Vector3(0, 0, -45), 0.3f).SetEase(Ease.Linear).OnComplete(() =>
            {
                
            });
        });

        btnBackToLobby.onClick.AddListener(() =>
        {
            PhotonNetwork.LeaveRoom();
            SceneManager.LoadScene("Lobby");
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
