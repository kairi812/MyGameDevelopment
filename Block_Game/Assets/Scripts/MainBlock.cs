using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainBlock : MonoBehaviour
{
    public Text GameOverText;

    // Start is called before the first frame update
    void Start()
    {
        for (int i=1; i<=19; i++){
            GameObject prefab = GameObject.Find("BlockPrefab(" + i + ")");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)){
            transform.position = new Vector3(0,0,0);
        }
        else if (Input.GetKey(KeyCode.DownArrow)){
            transform.position = new Vector3(0,0,0);
        }
        else if (Input.GetKey(KeyCode.RightArrow)){
            transform.position = new Vector3(0,0,0);
        }
        else if (Input.GetKey(KeyCode.LeftArrow)){
            transform.position = new Vector3(0,0,0);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // ゲームオブジェクトを削除するメソッド
        Destroy(gameObject);
        GameOverText.text = "GameOver";
    }
}
