using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    public Text coinText;
    public int coinAmount;
    private void Start()
    {
        coinText = GetComponent<Text>();
    }
    void Update()
    {
        coinText.text = coinAmount.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            coinAmount -= 1;
            Destroy(gameObject);
        }
    }
}
