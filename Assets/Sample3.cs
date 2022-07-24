using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
         * 
         * GameObjectを拡大縮小させるにはlocalScaleを操作します。
         * localScaleはVector3型です。
         * Vector3.oneはx,y,zの値が全て1になります。
         * 
        */
        transform.localScale += Vector3.one;
    }
}
