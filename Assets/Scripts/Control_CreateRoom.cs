using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Control_CreateRoom : MonoBehaviour
{
    public Button btn_Create;
    public Button btn_reset;
    public InputField inputFieldNameRoom;
    public InputField inputFieldGoldBet;
    public Toggle togglePublic;
    public Toggle togglePrivate;
    public InputField inputPassword;

    public Transform contentAvailableRoom;

    void Start()
    {
        
    }

}
