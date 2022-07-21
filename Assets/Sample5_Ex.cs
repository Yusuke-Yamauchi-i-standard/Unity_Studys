using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample5_Ex : MonoBehaviour
{
    public GameObject prefab = null;

    public KeyCode key = KeyCode.Space;

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

        if(!Input.GetKeyDown(key))
        {
            return;
        }

        Instantiate(prefab);
    }

}
