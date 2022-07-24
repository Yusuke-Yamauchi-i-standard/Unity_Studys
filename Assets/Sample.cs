using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
         * GameObjectの位置・回転・拡縮はtransformを操作します。
         * 位置情報はtransformのpositionで、positionはVector3型になっています。
         * 中の要素は(x,y,z)でそれぞれの要素ごとに操作することも可能です。
         * その場合は以下の手順をふみます。
         * 
         * Vector3 pos = transform.position
         * pos.z += 2.0f;
         * transform.position = pos;
         * 
         * 現在のままでは3D空間の前方にしか移動することは出来ません。
        */
        transform.position += Vector3.forward * 2.0f;
    }
}
