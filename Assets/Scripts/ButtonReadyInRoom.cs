using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class ButtonReadyInRoom : MonoBehaviourPunCallbacks
{


    [PunRPC]
    public void SendData(int x, int y)
    {
        this.photonView.RPC("ReceiveData", RpcTarget.Others, x, y);
    }

    [PunRPC]
    void ReceiveData(int x, int y)
    {
        Debug.Log("Receive ______");
    }
}
