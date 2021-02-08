using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixtureBehavior : MonoBehaviour {
//   float maxIntensity = 2;
//   bool warning = false;
  public bool inInventory = true;
//   public int upkeep;
//   public int buyFor;
  public int sellFor;
//   public float timer;
//   public Color colorIncrement;
//   public GameObject fixture;
//   public GameObject txt;
//   public Material lit;
//   public Material unlit;
//   // public UnityEngine.Experimental.Rendering.Universal.Light2D luminosity;
//
//   void Update() {
//     Dimming();
//     MoneyWarning();
//     checkInventory();
//   }
//
//   void OnMouseDown() {
//     if (inInventory) {
//       if (luminosity.intensity <= 0) {
//         if (Money.money >= upkeep) {
//           luminosity.intensity = maxIntensity;
//           Money.money -= upkeep;
//         }
//         else {
//           warning = true;
//         }
//       }
//     }
//     else {
//       if (Money.money >= buyFor) {
//         Money.money -= buyFor;
//         Bought();
//       }
//     }
//   }
//
//   void Dimming() {
//     if (luminosity.intensity > 0) {
//       luminosity.intensity -= (maxIntensity/timer);
//     }
//     else {
//       luminosity.intensity = 0;
//     }
//   }
//
//   void MoneyWarning() {
//     if (warning) {
//       txt.GetComponent<UnityEngine.UI.Text>().color -= colorIncrement;
//       if (txt.GetComponent<UnityEngine.UI.Text>().color == Color.red) {
//         txt.GetComponent<UnityEngine.UI.Text>().color = Color.white;
//         warning = false;
//       }
//     }
//   }
//
//   void Bought() {
//     luminosity.intensity = maxIntensity;
//     inInventory = true;
//   }
//
//   // void Sold() {
//   //
//   // }
//
//   void checkInventory() {
//     if (inInventory) {
//       GetComponent<SpriteRenderer>().material = lit;
//     }
//     else {
//       GetComponent<SpriteRenderer>().material = unlit;
//       luminosity.intensity = 0;
//     }
//   }
//
}
