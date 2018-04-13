using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elemoving : MonoBehaviour
{
    public Transform PointB;
    private int _direction = 1;
    private float _pointA;
    public bool enable { get; set; }

    // Use this for initialization
    void Start()
    {
        enable = false;
        _pointA = transform.position.y;
    }

    private void Update()
    {
        if (!enable) return;

        if (transform.position.y < _pointA)
        {
            _direction = 1;
        }
        if (transform.position.y > PointB.position.y)
        {
            _direction = -1;
        }
        transform.Translate(0, _direction * 2 * Time.deltaTime, 0);
    }
}