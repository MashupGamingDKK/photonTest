using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class NetworkController : MonoBehaviourPunCallbacks
{
    private void Start()
    {

    }
    public void ConnectServer()
    {
        PhotonNetwork.ConnectUsingSettings();

    }
    public override void OnConnectedToMaster()
    {
        Debug.Log("We are connected to " + PhotonNetwork.CloudRegion + " !");
        PhotonNetwork.LoadLevel(2);

    }
    
}
