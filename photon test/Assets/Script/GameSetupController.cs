using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using System.IO;
using Unity.Mathematics;

public class GameSetupController : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        CreatePlayer();
    }
    void CreatePlayer()
    {
        Debug.Log("creating player");
        PhotonNetwork.Instantiate(Path.Combine("PlayerPrefab", "PhotonPlayer"), Vector3.zero, quaternion.identity);
    }
}
