using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private PlatformManager _manager;

    void Start()    {
        _manager = FindObjectOfType<PlatformManager>();
    }
    void OnTriggerEnter(Collider other)
    {
        _manager.CollectCoin();
        Destroy(this.gameObject);
    }
}
