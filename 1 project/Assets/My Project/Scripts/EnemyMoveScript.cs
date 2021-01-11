using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveScript : MonoBehaviour
{
    [SerializeField] private Transform _endPoint;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _endPoint.position, Time.deltaTime);// Идет за конечной точкой, игнорируя физику и здраы
    }
}
