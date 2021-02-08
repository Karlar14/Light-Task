using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderBehavior : MonoBehaviour {
  GameObject found;
  AudioSource sold;
  bool warning = false;
  public static bool orderComplete = false;
  public GameObject order;
  public GameObject targetFixture;
  public Color colorIncrement;
  // FixtureBehavior fixture;

  void Start() {
    found = GameObject.Find(targetFixture.name);
    sold = GetComponent<AudioSource>();
  }

  void Update() {
    OrderWarning();
  }

  void OnMouseDown() {
    if (!orderComplete)
      if (found != null) {
        Money.money += found.GetComponent<FixtureBehavior>().sellFor;
        found.GetComponent<FixtureBehavior>().inInventory = false;
        // found.Play();
        orderComplete = true;
      }
      else {
        warning = true;
      }
  }

  void OrderWarning() {
    if (warning) {
      GetComponent<SpriteRenderer>().color -= colorIncrement;
      if (GetComponent<SpriteRenderer>().color == Color.red) {
        GetComponent<SpriteRenderer>().color = Color.white;
        warning = false;
      }
    }
  }
}
