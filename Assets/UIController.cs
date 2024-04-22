using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class UIController : MonoBehaviour
{
  TextMeshProUGUI text;
  float time;
  int rings;
  int lives;
  // Start is called before the first frame update
  void Start()
  {
    text = gameObject.GetComponent<TextMeshProUGUI>();
    time = 0.0f;
    rings = 0;
    lives = 3;
    text.text = "Time: " + time.ToString() + "\n" +
                "Rings: " + rings.ToString() + "\n" +
                "Lives: " + lives.ToString();
  }

  // Update is called once per frame
  void Update()
  {
    time += Time.deltaTime;
    text.text = "Time: " + time.ToString() + "\n" +
                "Rings: " + rings.ToString() + "\n" +
                "Lives: " + lives.ToString();
  }

  public void IncRings()
  {
    rings += 1;
  }
  public void DropRings()
  {
    if (rings == 0)
    {
      DecLives();
    }
    rings = 0;
  }
  public void ResetLives()
  {
    lives += 1;
  }
  void DecLives()
  {
    lives -= 1;
    GameObject.Find("Sonic").transform.position = new Vector3(0, 3, 0);
  }
}