using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public GameObject PlatNormalPrefab;
    public GameObject PlatHighPrefab;
    public GameObject GameOverPanel;

    private void Start()
    {
        GameOverPanel.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Platform" || collision.gameObject.tag == "Platform_High")
        {
            Vector3 newPos = new Vector3(Random.Range(-3.35f, 3.35f), Camera.main.transform.position.y + (6 * Random.Range(0.75f, 1f)), 0f);
            GameObject Plat = ChoosePlatform();
            Destroy(collision.gameObject);
            Instantiate(Plat, newPos, Quaternion.identity);
        }
        if(collision.gameObject.tag == "Player")
        {
            GameOverPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }

    private GameObject ChoosePlatform()
    {
        float rand = Random.Range(1, 11);
        return rand < 4 ? PlatHighPrefab : PlatNormalPrefab;
    }
}
