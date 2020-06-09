using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class OrbitArround : MonoBehaviour
{
    public Transform _transformEarth;
    public float minRadius = 30f;
    public float maxRadius = 50f;
    public float radius;
    public float rotation;
    [SerializeField]
    private float speed = 0.123f;





    private void Start()
    {

        radius = Random.Range(minRadius, maxRadius);



        transform.localPosition = new Vector3(radius, transform.localPosition.y, transform.localPosition.z);
    }
    private void Update()
    {
        transform.RotateAround(_transformEarth.position, -_transformEarth.up, Time.deltaTime * speed);
    }

    private void OnMouseDown()
    {



    }
}
