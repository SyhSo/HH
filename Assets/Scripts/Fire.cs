using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using static Unity.VisualScripting.Member;

[RequireComponent(typeof(AudioSource))]

public class Fire : MonoBehaviour
{
    //�Ѿ� ������
    public GameObject bullet;
    //�Ѿ� �߻���ǥ
    public Transform FirePos;
    //�Ѿ� �߻� ����
    public AudioClip fireSfx;
    //AudioSource ������Ʈ ���� ����
    public AudioSource source = null;

    void Start()
    {
        //AudioSource ������Ʈ ����, ���� �Ҵ�
        source = GetComponent<AudioSource>();
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, FirePos.transform.position, FirePos.transform.rotation);

            source.PlayOneShot(fireSfx, 0.9f);
        }
    }
}
