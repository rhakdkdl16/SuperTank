using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    GameObject PlayerTankMaker;
    private void Start()
    {
        Destroy(PlayerTankMaker,5f);
    }
}
