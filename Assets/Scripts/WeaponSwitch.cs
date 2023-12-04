using System;
using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Transform[] weapons;
    
    [Header("Keys")] 
    [SerializeField] private KeyCode[] keys;

    [Header("Settings")]
    [SerializeField] private float switchTime;
    [HideInInspector]
    public int selectedWeapon;
    private float timeSinceLastSwitch;
    private GunData gunData;
    
    private void Start()
    {
        SetWeapons();
        Select(selectedWeapon);
        timeSinceLastSwitch += 0f;
        gunData = GameObject.Find("PlayerCapsule").GetComponent<FirstPersonController>().gunData;
    }
    private void SetWeapons()
    {
        weapons = new Transform[transform.childCount];

        for (int i = 0; i < transform.childCount; i++)
        {
            weapons[i] = transform.GetChild(i);
        }
        if(keys == null) keys = new KeyCode[weapons.Length];
    }
    private void Update()
    {
        if (!gunData.reloading)
        {
        int previousSelectedWeapon = selectedWeapon;
        for (int i = 0; i < keys.Length; i++)
        {
            if (Input.GetKeyDown(keys[i]) && timeSinceLastSwitch >= switchTime)
            {
                selectedWeapon = i;
            }
            
        }
        if (previousSelectedWeapon != selectedWeapon) Select(selectedWeapon);
        timeSinceLastSwitch += Time.deltaTime;
        }
    }
    private void Select(int weaponIndex)
    {
        for (int i = 0; i < weapons.Length; i++)
        {
            weapons[i].gameObject.SetActive(i==weaponIndex);
        }
        timeSinceLastSwitch = 0f;
        OnWeaponSelected();
    }

    private void OnWeaponSelected()
    {

    }
}
