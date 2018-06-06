/*
  Test.cs (Unity)
*/

using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Test : MonoBehaviour {
  int cnt;

  // Use this for initialization
  void Start(){
    Debug.Log("Hello, world! 日本語UTF8");
    cnt = 0;
  }

  // Update is called once per frame
  void Update(){
    string s = "日本語";
    ++cnt;
    if(cnt % 60 == 0) Debug.Log(s + cnt);
  }
}
