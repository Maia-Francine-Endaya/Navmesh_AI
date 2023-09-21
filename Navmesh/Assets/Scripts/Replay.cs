using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour
{
  private void Update()
  {
    StartCoroutine(WaitandResume());
  }

  IEnumerator WaitandResume()
  {
    yield return new WaitForSeconds(5);
    SceneManager.LoadScene("SampleScene");
  }
}
