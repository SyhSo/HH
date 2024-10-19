using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using static Unity.VisualScripting.Member;

[RequireComponent(typeof(AudioSource))]

public class Fire : MonoBehaviour
{
    //총알 프리팹
    public GameObject bullet;
    //총알 발사좌표
    public Transform FirePos;
    //총알 발사 사운드
    public AudioClip fireSfx;
    //AudioSource 컴포넌트 저장 변수
    public AudioSource source = null;

    void Start()
    {
        //AudioSource 컴포넌트 추출, 변수 할당
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
