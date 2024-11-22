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
        
    }

    void Update()
    {
        
        this.transform.position += _power * 5 * Time.deltaTime;
        var enList = GameObject.FindObjectsOfType<firing>();
        foreach (var enemy in enList)
        {
            if (Mathf.Abs(this.transform.position.x - enemy.transform.transform.position.x) < (enemy.transform.localScale.x + this.transform.localScale.x) / 2 &&
                Mathf.Abs(this.transform.position.y - enemy.transform.transform.position.y) < (enemy.transform.localScale.y + this.transform.localScale.y) / 2)
            {
                enemy.Damage();
                Destroy(gameObject);
            }
        }
        
        

    }
    public void SetVector(Vector3 vec)
    {
        _power = vec * _power.magnitude;
    }
}
