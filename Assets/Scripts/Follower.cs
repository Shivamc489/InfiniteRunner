using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class Follower : MonoBehaviour
{
    public PathCreator _pathCreator;
    public float _speed = 5;
    float _distanceTravelled;
    void Update()
    {
        _distanceTravelled += _speed * Time.deltaTime;
        transform.position = _pathCreator.path.GetPointAtDistance(_distanceTravelled);
        transform.LookAt(_pathCreator.path.GetPointAtDistance(_distanceTravelled+2f));
    }
}
