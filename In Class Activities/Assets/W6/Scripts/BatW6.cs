using UnityEditor.UI;
using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _speed;
    private bool _willChase;
    private Transform player;

    public void ChaseEnabled(Transform playerTrans)
    {
        player = playerTrans;
        _willChase = true;
    }

    public void ChaseDisabled()
    {
        _willChase = false;
    }

    public void Update()
    {
        if (_willChase)
        {
            Vector3 _updateVector = Vector3.zero;
            _updateVector.x = transform.position.x < player.position.x ? 1 : -1;
            _updateVector.y = transform.position.y < player.position.y ? 1 : -1;
            transform.Translate(_updateVector * Time.deltaTime * _speed);
        }
    }
}
