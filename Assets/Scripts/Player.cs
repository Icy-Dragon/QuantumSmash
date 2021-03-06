﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour {
    public Slider hpSlider;

    // Properties
    public float Health
    {
        get { return hpSlider.value; }
        set { hpSlider.value = value; }
    }

    // Use this for initialization
    void Start () {
        //var healthUI = GameObject.Find("HealthUI");
        //hpSlider = healthUI.GetComponent<Slider>() as Slider;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void GiveCoins( int value )
    {
        var coin = GameObject.Find("Coin");
        var gold = coin.GetComponent<GoldScript>();
        gold.Gold += value;

    }

    void ApplyDamage( float damage )
    {
        FloatingTextController.CreateFloatingText(damage.ToString(), transform);
        DialogueController.GetInstance().ShowText("test\n1\n2\n3\n4\n5\n6\n7\n" + damage.ToString());
        Health -= damage;
        if (Health <= 0)
        {
            Death();
        }
    }

    void Death()
    {
        Destroy(gameObject);
    }
}
