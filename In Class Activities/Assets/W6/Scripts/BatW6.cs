using UnityEditor.UI;
using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform player;

    public void ChaseEnabled()
    {
        enabled = true;
    }

    public void ChaseDisabled()
    {
        enabled = false;
    }

    public void Update()
    {
        Vector3 _updateVector = Vector3.zero;
        _updateVector.x = transform.position.x < player.position.x ? 1 : -1;
        _updateVector.y = transform.position.y < player.position.y ? 1 : -1;
        transform.Translate(_updateVector * Time.deltaTime * _speed);
    }
}
