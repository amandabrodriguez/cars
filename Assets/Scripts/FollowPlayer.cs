using Autodesk.Fbx;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject player;
    public Vector3 offset = new Vector3(0, 5, -6);
    public bool isPlaneOfChallenge = false;
    private Vector3 playerPreviousPos = Vector3.zero;
    public float distance = 30f;


    void Update()
    {
        if (!isPlaneOfChallenge)
        {
            Vector3 newOffset = (player.transform.position - offset) - (playerPreviousPos + offset);
            if (newOffset.magnitude < 0.5f) return; // Si se mueve poco el avión no hacer nada
            newOffset.Normalize();
            transform.position = player.transform.position - newOffset * distance;
            transform.LookAt(player.transform.position);
            playerPreviousPos = player.transform.position;
        }
        else
        {
            transform.position = player.transform.position + offset;
        }
    }
}
