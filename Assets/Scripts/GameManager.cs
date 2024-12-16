using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    GameObject GroundNew; 

    private void Start()
    {
        GroundNew = GetComponent<GameObject>();
    }
}
