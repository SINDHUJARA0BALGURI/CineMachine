using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour
{
    public float bridgedestroytime;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "Player")
        {
            StartCoroutine("BridgeDestroy");
        }

    }
    IEnumerator BridgeDestroy()
    {
        yield return new WaitForSeconds(bridgedestroytime);
        Destroy(this.gameObject);
    }
}
