using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPointer : MonoBehaviour
{
    [SerializeField] Player _player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //個々のやり方は仕組みによって変化します
        Vector3 point = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        point.z = 0;
        this.transform.position = point;

        //差分ベクトル
        Vector3 sub = this.transform.position - _player.transform.position;
        float rad = Mathf.Atan2(sub.y, sub.x);
        _player.SetTargetRadian(rad);
    }
}
