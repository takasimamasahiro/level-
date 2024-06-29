using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pleyer : MonoBehaviour
{
    public float _JanpSpeed = 0.5f;
    public float _MoveSpeed = 1f;
    public float _time = 0;
    [SerializeField] GameObject _gameObject;
    [SerializeField] GameObject _gameObject2;
    public float _gravity = 1f;
    private float _ySpeed = 0;
    private float _Ground = 0;
    public int _JanpCount = 0;
    public int _MaxJanpCount = 2;

    // Start is called before the first frame update
    void Start()
    {
        _Ground = this.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Input.GetAxisRaw("Horizontal") * _MoveSpeed, 0, 0);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(_gameObject, _gameObject2.transform.position, Quaternion.identity);
        }


        if (this.transform.position.y < _Ground)
        {
            Vector3 tmp = this.transform.position;
            tmp.y = _Ground;
            this.transform.position = tmp;
            _ySpeed = 0;
            if (_JanpCount >= _MaxJanpCount)
            {
                _JanpCount = 0;
            }
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (_MaxJanpCount > _JanpCount)
            {
                Jump();
                _JanpCount++;
            }
        }
    }
    private void FixedUpdate()
    {
        TmpRigidBody();
    }
    void TmpRigidBody()
    {
        _ySpeed -= _gravity;
        Vector3 tmp = this.transform.position;
        tmp.y += _ySpeed;
        this.transform.position = tmp;
    }
    void Jump()
    {
        _ySpeed = _JanpSpeed;
    }
}
