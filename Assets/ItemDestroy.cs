using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroy : MonoBehaviour
{
    //Unityちゃんのゲームオブジェクト
    private GameObject unitychan;

    // Start is called before the first frame update
    void Start()
    {
        //Unityちゃんのゲームオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
    }

    // Update is called once per frame
    void Update()
    {
        //ItemがUnitytiちゃんより後ろに行ったら破棄する
        if ((unitychan.transform.position.z - this.transform.position.z) > 7f)
        {
            Destroy(gameObject);
           // Debug.Log(this.gameObject.tag + "を破棄しました");
        }
    }
}
