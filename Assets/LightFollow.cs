using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFollow : MonoBehaviour
{
    public GameObject Player;

    private void Update()
    {
        transform.LookAt(Player.transform);
    }
}
