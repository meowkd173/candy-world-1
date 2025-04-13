using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneLocker : MonoBehaviour
{
    [SerializeField] string ZoneName;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(PlayerPrefs.GetInt(ZoneName, 0) == 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
