using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionDet : MonoBehaviour
{
    public int inventoryCapNow { get; set; }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "wood")
        {
            Debug.Log("it is wood and added to inventory");

            // +1 on inventory - !!!!! Envanter Sýnýrýna Sonra Tekrar Bak, düzgün ayarla - Þu an 7 olarak düþündüm
            if (inventoryCapNow <= 7)
            {
                inventoryCapNow++;
                Debug.Log(inventoryCapNow);
                
                // green point with wood
                ScoreScript.greenPoint++;

                // destroy the gameObject.tag == wood
                Destroy(collision.gameObject, 0.1f);
                ScoreScript.greenScore.text = "Green Score: " + ScoreScript.greenPoint;
            }
            else
            {
                Debug.Log("Inventory Limit has Reached");
            }

        }
        else if (collision.gameObject.tag == "plastic")
        {
            Debug.Log("it is plastic and added to inventory");

            // +1 on inventory
            if (inventoryCapNow <= 7)
            {
                inventoryCapNow++;
                Debug.Log(inventoryCapNow);
                
                // green point with plastic
                ScoreScript.greenPoint += 20;
                ScoreScript.greenScore.text = "Green Score: " + ScoreScript.greenPoint;

                // destroy the gameObject.tag == wood
                Destroy(collision.gameObject, 0.1f);
            }
            else
            {
                Debug.Log("Inventory Limit has Reached");
            }

            // destroy the gameObject.tag == wood
            Destroy(collision.gameObject, 0.1f);
        }
        else if (collision.gameObject.tag == "metal")
        {
            Debug.Log("it is metal and added to inventory");

            // +1 on inventory
            if (inventoryCapNow <= 7)
            {
                inventoryCapNow++;
                Debug.Log(inventoryCapNow);
                
                // green point with metal
                ScoreScript.greenPoint += 5;
                ScoreScript.greenScore.text = "Green Score: " + ScoreScript.greenPoint;

                // destroy the gameObject.tag == wood
                Destroy(collision.gameObject, 0.1f);
            }
            else
            {
                Debug.Log("Inventory Limit has Reached");
            }


        }
        else if (collision.gameObject.tag == "glass")
        {
            Debug.Log("it is glass and added to inventory");

            // +1 on inventory
            if (inventoryCapNow <= 7)
            {
                inventoryCapNow++;
                Debug.Log(inventoryCapNow);
                
                // green point with glass
                ScoreScript.greenPoint += 10;
                ScoreScript.greenScore.text = "Green Score: " + ScoreScript.greenPoint;

                // destroy the gameObject.tag == wood
                Destroy(collision.gameObject, 0.1f);
            }
            else
            {
                Debug.Log("Inventory Limit has Reached");
            }
        }
    }
}
