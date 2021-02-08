using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour {
  public GameObject txt;
  public static int money = 100;

  void Update() {
     txt.GetComponent<UnityEngine.UI.Text>().text = money.ToString();
  }
}
