using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    // キューブの移動速度
    private float speed = -12;

    // 消滅位置
    private float deadLine = -10;

    //リジッドボディを入れる場所
    private Rigidbody2D rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // キューブを移動させる
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        // 画面外に出たら破棄する
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }

    //提出課題

    void OnCollisionEnter2D(Collision2D other)
    {
        if ( (other.gameObject.CompareTag("Cube")) || (other.gameObject.CompareTag("Ground"))) 
        {
            Debug.Log("接触判定");
            
            // オーディオ再生
            GetComponent<AudioSource>().Play();
        }
    }
}
