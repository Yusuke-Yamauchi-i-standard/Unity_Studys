using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample5 : MonoBehaviour
{

    public GameObject prefab = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (prefab == null)
        {
            return;
        }

        Instantiate(prefab);
    }


}
