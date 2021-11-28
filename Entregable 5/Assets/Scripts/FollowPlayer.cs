using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(25, 4, 2);

    private void LateUpdate()
    {
        //Esto hace que la camara siga al objeto con las cordenadas que le hemos dado antes
        transform.position = player.transform.position + offset;
    }
}
