using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _speed = 10f;

    // Update is called once per frame
    void Update()
    {
        var position = transform.position;
        var heading = _target.position - transform.position;
        heading.Normalize();
        position += (heading * _speed * Time.deltaTime);
        transform.position = position;
    }
}
