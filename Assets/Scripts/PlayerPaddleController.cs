using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddleController : MonoBehaviour
{
    public float speed = 5f;
    public string movementAxisName = "Vertical";

    public bool isPlayer = true;
    public SpriteRenderer spriteRenderer;

    private void Start()
    {
        if (isPlayer)
            spriteRenderer.color = SaveController.Instance.colorPlayer;
        else
            spriteRenderer.color = SaveController.Instance.colorEnemy;
    }

    // Update is called once per frame
    void Update()
    {
        float moveInput = Input.GetAxis(movementAxisName);
        Vector3 newPostion = transform.position + Vector3.up* moveInput * speed * Time.deltaTime;
        newPostion.y = Mathf.Clamp(newPostion.y, -4.5f, 4.5f);
        transform.position = newPostion;
    }
}
