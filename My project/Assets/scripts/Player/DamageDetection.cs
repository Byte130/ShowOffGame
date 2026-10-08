using UnityEngine;
using UnityEngine.SceneManagement;

public class PLayerTakesHits : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("DeathPit"))
        {
            SceneManager.LoadScene(2);
            Cursor.visible = true;
        }

        if (collision.gameObject.CompareTag("StartBossFight"))
        {
            collision.gameObject.SetActive(false);
        }
    }
}
