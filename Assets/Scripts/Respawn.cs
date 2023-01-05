using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject[]         characterPrefabs;
    public GameObject           player;

    void Start(){
        player = Instantiate(characterPrefabs[(int)GameController.instance.currentCharacter]);
        player.transform.position = transform.position;

    }
}
