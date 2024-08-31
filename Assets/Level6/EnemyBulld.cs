using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulld : MonoBehaviour
{
    Player _player = null;
    [SerializeField] Vector3 _power;

    private void Start()
    {
        _player = GameObject.FindObjectOfType<Player>();
       
    }

    void Update()
    {
        this.transform.position += _power * 5 * Time.deltaTime;

        if (Mathf.Abs(this.transform.position.x - _player.transform.transform.position.x) < (_player.transform.localScale.x + this.transform.localScale.x) / 2 &&
            Mathf.Abs(this.transform.position.y - _player.transform.transform.position.y) < (_player.transform.localScale.y + this.transform.localScale.y) / 2)
        {
            _player.Damage();
            Destroy(gameObject);
        }

    }
    public void SetVector(Vector3 vec)
    {
        _power = vec * _power.magnitude;
    }
}