using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoMangerEnum : MonoBehaviour
{
    Dictionary<Weapons, int> ammoTypes = new Dictionary<Weapons, int>();
    
    enum Weapons
    {
        GLOCK,
        AK47,
        AWP
    }
    void Start()
    {
        ammoTypes.Add(Weapons.GLOCK, 13);
        ammoTypes.Add(Weapons.AK47, 30);
        ammoTypes.Add(Weapons.AWP, 10);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            ammoTypes[Weapons.GLOCK] -= 1;
            Debug.Log(ammoTypes[Weapons.GLOCK]);
        }
    }
}
