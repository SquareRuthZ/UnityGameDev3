using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Samarnggoon.GameDev3.Chapter1
{ public class SpinMovement : MonoBehaviour {
[SerializeField]
private float _angularSpeed = 5.0f;
[SerializeField]
private Vector3 _axisOfRotation = new Vector3(1.0f,0,0);

private Transform _objTransformComponent;

// Use this for initialization
void Start () {
    _objTransformComponent = this.gameObject.GetComponent <Transform >();
    }

 // Update is called once per frame
 void Update () {
     _objTransformComponent.Rotate(_axisOfRotation , _angularSpeed);
     }
 } 
}