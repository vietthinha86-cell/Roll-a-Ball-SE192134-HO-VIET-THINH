using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Reference to the player GameObject.
    public GameObject player;

    // The distance between the camera and the player.
    private Vector3 offset;

    // Start is called before the first frame update.
    void Start()
    {
        // 1. Vẫn phải tính toán khoảng cách ban đầu giữa Camera và Player ở đây!
        if (player != null)
        {
            offset = transform.position - player.transform.position;
        }
    }

    // LateUpdate is called once per frame after all Update functions have been completed.
    void LateUpdate()
    {
        // 2. Đặt đoạn kiểm tra if (player != null && player.activeInHierarchy) vào ĐÂY:
        if (player != null && player.activeInHierarchy)
        {
            transform.position = player.transform.position + offset;
        }
    }
}