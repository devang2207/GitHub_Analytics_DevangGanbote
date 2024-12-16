using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    GameObject Ground;

    private void Start()
    {
        Ground = GetComponent<GameObject>();
    }
}
