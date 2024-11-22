using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firing : Character
{
    [SerializeField] GameObject _player;
    [SerializeField] float _interval = 1.0f;
    [SerializeField] float _searchRadius = 200.0f;
    float _timer = 0.0f;
    [SerializeField] GameObject _prefab;
    EnemyBulld script;
    // Start is called before the first frame update
    void Start()
    {
        script = _prefab.GetComponent<EnemyBulld>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 sub = _player.transform.position - this.transform.position;
        float len = (sub.x * sub.x) + (sub.y * sub.y);
        if (len < _searchRadius * _searchRadius)
        {
            _timer += Time.deltaTime;
            if (_timer > _interval)
            {
                _timer -= _interval;

                script.SetVector(-this.transform.right);
                Instantiate(_prefab, this.transform.position + new Vector3(-0.5f, 0, 0), this.transform.rotation);
            }
        }
        if (_hp <= 0)
        {
            GameManager.Instance.Remove(this);
            Destroy(gameObject);
            return;
        }
    }
}
