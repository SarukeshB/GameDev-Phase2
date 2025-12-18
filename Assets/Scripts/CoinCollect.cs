using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    // The AudioSource variable is removed since you don't want audio

    void OnTriggerEnter(Collider other)
    {
        // Removed: coinFX.Play();
        MasterInfo.coinCount += 1;
        this.gameObject.SetActive(false);
    }
}