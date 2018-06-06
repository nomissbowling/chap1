/*
  RouletteController.cs (Unity)
*/

using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class RouletteController : MonoBehaviour {
  float rotSpeed = .0f;

  void Start(){
  }

  void Update(){
    if(Input.GetMouseButtonDown(0)){
      rotSpeed = 10.0f;
    }
    transform.Rotate(0, 0, rotSpeed);
    rotSpeed *= .98f;
  }
}
