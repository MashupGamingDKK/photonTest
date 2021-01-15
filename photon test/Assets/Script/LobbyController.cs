using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class LobbyController : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private ConnectionButton connectionButton;
    [SerializeField]
    private int RoomSize;
    // Start is called before the first frame update
    public override void OnConnectedToMaster()
    {
        PhotonNetwork.AutomaticallySyncScene = true;
        connectionButton.gameObject.SetActive(true);
    }
    public void StartConnection()
    {
        connectionButton.status = 2;
        PhotonNetwork.JoinRandomRoom();
        Debug.Log("Start Connection");
    }
    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        Debug.Log("Failed to join room! Creating new room...");
        CreateRoom();
    }
    void CreateRoom()
    {
        int RanRoomNum = Random.Range(0, 1000);
        Debug.Log("New Room ID " + RanRoomNum);
        RoomOptions roomOps = new RoomOptions() { IsVisible = true, IsOpen = true, MaxPlayers = (byte)RoomSize };
        PhotonNetwork.CreateRoom("Room" + RanRoomNum, roomOps);
        Debug.Log("New Room Created");
    }
    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        Debug.Log("Failed to create room, trying again");
        CreateRoom();
    }

    public void CancelConnection()
    {
        connectionButton.status = 0;
        PhotonNetwork.LeaveRoom();
    }
}
