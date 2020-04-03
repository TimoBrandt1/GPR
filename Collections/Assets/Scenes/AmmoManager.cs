using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoManager : MonoBehaviour
{
    Dictionary<string, int> ammoTypes = new Dictionary<string, int>();
    // Start is called before the first frame update
    void Start()
    {
        ammoTypes.Add("glock", 13);
        ammoTypes.Add("ak47", 30);
        ammoTypes.Add("awp", 10);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            ammoTypes["glock"] -= 1;
            Debug.Log(ammoTypes["glock"]);
        }
    }
}
