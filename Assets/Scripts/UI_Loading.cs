using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_Loading : MonoBehaviour
{
    public static UI_Loading instance;
    [SerializeField] Image imgAll;
    [SerializeField] GameObject imgLoading;
    [SerializeField] GameObject textLoading;
    bool isLoading;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
    private void Start()
    {
        imgLoading.SetActive(false);
        textLoading.SetActive(false);
    }

    public void LoadScene(string nameScene = "")
    {
        imgAll.gameObject.SetActive(true);
        imgAll.DOFade(1, 0.4f).SetEase(Ease.Linear).OnComplete(() => {
            isLoading = true;
            textLoading.SetActive(true);
            imgLoading.SetActive(true);
            if (nameScene != "")
                StartCoroutine(LoadingScene(nameScene));
        });
    }    

    IEnumerator LoadingScene(string nameScene)
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(nameScene);
    }


    public void FadeOff()
    {
        isLoading = false;
        imgAll.DOFade(0, 0.4f).SetEase(Ease.Linear).OnComplete(() =>
        {
            imgAll.gameObject.SetActive(false);
        });
        imgLoading.SetActive(false);
        textLoading.SetActive(false);
    }
    private void Update()
    {
        if(isLoading)
        {
            imgLoading.transform.localEulerAngles += new Vector3(0, 0, 1);
        }
    }
}
