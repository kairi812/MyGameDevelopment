using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabCreate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = (GameObject)Resources.Load ("Block");
        for (int i=-2; i<=2; i++){
            for (int j=0; j<=3; j++){
                Instantiate (obj, new Vector3(0.9f*i,4.5f-0.6f*j,0.0f), Quaternion.identity);
            }   
        }
    }

    // 何かとぶつかった時に呼ばれるビルトインメソッド
    void OnCollisionEnter(Collision collision)
    {
        // GameObject obj = GameObject.Find("Block(Clone)");
        // // ゲームオブジェクトを削除するメソッド
        // Destroy(obj);
    }
}
