using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class Player : MonoBehaviour
{
    public int coin = 0;
    public float health = 100;
    public Slider HealthBar;
    public TextMeshProUGUI Number;

    private void Start()
    {
        HealthBar.maxValue = health;
        HealthBar.value = health;
        Number.text = coin+"";
    }

    private void Update()
    {
        health += 0.05f;
        HealthBar.value = health;
    }
    public void collectCoins()
    {
        coin += 5;
        Number.text = coin+"";
    }
    public void collecSpecialCoins()
    {
        coin += 100;
        Number.text = coin + "";
    }
    public AudioSource oof;
    public void attacked()
    {
        health -= 10;
        HealthBar.value = health;
        oof.Play();
        if (health < 1)
        {
            SceneManager.LoadScene(0);
        }
    }
    public void bossAttacked()
    {
        health -= 30;
    }
}
