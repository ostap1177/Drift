using System;
using UnityEngine;

[RequireComponent(typeof(Player))]
public class PlayerCollision : MonoBehaviour
{
    private Player _player;

    private void Awake()
    {
        _player = GetComponent<Player>();
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.TryGetComponent(out Barrier barrier))
        {
            _player.ResetPosition();
        }
        
        if (collider.TryGetComponent(out Item item))
        {
            _player.SetScore(item.Score);
            item.ResetPool();
        }
    }
}
