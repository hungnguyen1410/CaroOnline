using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class CreatePlayerID : MonoBehaviourPunCallbacks
{
    private string playerId;

    private void Start()
    {
        Connect();
    }

    void Connect()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    // Khi đã kết nối đến Photon Server
    public override void OnConnectedToMaster()
    {
        PhotonView photonView = GetComponent<PhotonView>();
        int actorNumber = photonView.Owner.ActorNumber;
        Debug.Log(actorNumber);
    }

    // Khi không thể tìm thấy phòng chơi phù hợp để tham gia
    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        // Tạo ra một phòng chơi mới
        Debug.Log("Tạo zoom thành công!!");
        OnJoinedRoom();
    }

    // Khi tham gia vào một phòng chơi
    public override void OnJoinedRoom()
    {
        // Khởi tạo bàn cờ và gửi thông tin lên server
        Debug.Log("tham gia zoom thành công!!");
    }
}