using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockVillage : MonoBehaviour
{
    [SerializeField] GameObject villageburier;

    public void UnlockVillageSave()
    {
        PlayerPrefs.SetInt("villageone", 1);
        villageburier.SetActive(false);
    }
}
