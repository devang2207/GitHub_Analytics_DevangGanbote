using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    GameObject GroundBranchToMergeIn;

    private void Start()
    {
        GroundBranchToMergeIn = GetComponent<GameObject>();
    }
}
