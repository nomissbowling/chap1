/*
  Test.cs (Unity)
*/

using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Player {
  private int hp = 100;
  private int power = 50;

  public void Attack(){
    Debug.Log(power + " send damages.");
  }

  public void Damage(int damage){
    hp -= damage;
    Debug.Log(damage + " receive damages.");
  }
}

public class Test : MonoBehaviour {
  int cnt;

  // Use this for initialization
  void Start(){
    Debug.Log("Hello, world! 日本語UTF8");
    cnt = 0;

    Player p = new Player();
    p.Attack();
    p.Damage(30);

    Vector2 ppos = new Vector2(3.0f, 4.0f);
    ppos.x += 8.0f;
    ppos.y += 5.0f;
    Debug.Log(ppos);
  }

  // Update is called once per frame
  void Update(){
    string s = "日本語";
    ++cnt;
    if(cnt % 60 == 0) Debug.Log(s + cnt);
  }
}
