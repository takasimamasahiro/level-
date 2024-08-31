using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulld : Character
{
    Player _player = null;
    firing _Enemy = null;
    [SerializeField] Vector3 _power;

    private void Start()
    {
        _player = GameObject.FindObjectOfType<Player>();
        _Enemy = GameObject.FindObjectOfType<firing>();
    }

    void Update()
    {
        this.transform.position += _power * 5 * Time.deltaTime;
        if (_hp <= 0) 
        {
            if (Mathf.Abs(this.transform.position.x - _Enemy.transform.transform.position.x) < (_Enemy.transform.localScale.x + this.transform.localScale.x) / 2 &&
                Mathf.Abs(this.transform.position.y - _Enemy.transform.transform.position.y) < (_Enemy.transform.localScale.y + this.transform.localScale.y) / 2)
            {
                _Enemy.Damage();
                Destroy(gameObject);
            }
        }
        

    }
    public void SetVector(Vector3 vec)
    {
        _power = vec * _power.magnitude;
    }
}
