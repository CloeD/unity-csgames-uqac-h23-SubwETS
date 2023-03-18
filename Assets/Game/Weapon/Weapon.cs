using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] GameObject _BallSpwanPoint;
    [SerializeField] GameObject _Ball;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(_Ball, _BallSpwanPoint.transform.position, _BallSpwanPoint.transform.rotation);
        }
    }
}
