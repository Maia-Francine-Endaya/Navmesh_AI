using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
  private bool hasLoadedGameOverScene = false;
  private void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.tag == "Player" && !hasLoadedGameOverScene)
    {
      hasLoadedGameOverScene = true;
      SceneManager.LoadScene("GameOver");
      StartCoroutine(WaitandResume());
    }
  }

  IEnumerator WaitandResume()
  {
    yield return new WaitForSeconds(5);
    SceneManager.LoadScene("SampleScene");
  }
}
