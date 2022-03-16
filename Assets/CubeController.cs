using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    // �L���[�u�̈ړ����x
    private float speed = -12;

    // ���ňʒu
    private float deadLine = -10;

    //���W�b�h�{�f�B������ꏊ
    private Rigidbody2D rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // �L���[�u���ړ�������
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        // ��ʊO�ɏo����j������
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }

    //��o�ۑ�

    void OnCollisionEnter2D(Collision2D other)
    {
        if ( (other.gameObject.CompareTag("Cube")) || (other.gameObject.CompareTag("Ground"))) 
        {
            Debug.Log("�ڐG����");
            
            // �I�[�f�B�I�Đ�
            GetComponent<AudioSource>().Play();
        }
    }
}
