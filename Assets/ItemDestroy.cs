using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroy : MonoBehaviour
{
    //Unity�����̃Q�[���I�u�W�F�N�g
    private GameObject unitychan;

    // Start is called before the first frame update
    void Start()
    {
        //Unity�����̃Q�[���I�u�W�F�N�g���擾
        this.unitychan = GameObject.Find("unitychan");
    }

    // Update is called once per frame
    void Update()
    {
        //Item��Unityti���������ɍs������j������
        if ((unitychan.transform.position.z - this.transform.position.z) > 7f)
        {
            Destroy(gameObject);
           // Debug.Log(this.gameObject.tag + "��j�����܂���");
        }
    }
}
