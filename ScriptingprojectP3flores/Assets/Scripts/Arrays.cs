using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    public GameObject[] players;
    // Start is called before the first frame update
    void Start()
    {
        players = GameObject.FindGameObjectsWithTag("Player");

        for(int i = 0; i < players.Length; i++)
        {
            Debug.Log("Player Nunber " + i + " is named " + players[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
