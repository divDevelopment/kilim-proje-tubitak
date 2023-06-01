using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UIElements;

public class NetworkPlayerSpawner : MonoBehaviourPunCallbacks
{
    private GameObject spawnedObjectPrefab;
    public override void OnJoinedRoom()
    {
        Vector3 spawnVec = new Vector3(-53f, 18.21f, 50.5f);
        base.OnJoinedRoom();
        spawnedObjectPrefab = PhotonNetwork.Instantiate("Network Player", spawnVec, transform.rotation);
    }

    public override void OnLeftRoom()
    {
        base.OnLeftRoom();
        PhotonNetwork.Destroy(spawnedObjectPrefab);
    }
}