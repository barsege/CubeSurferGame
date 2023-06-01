
using DG.Tweening;
using UnityEngine;

public class PlayerMoverRunner : MonoBehaviour
{
    [SerializeField]
    public float Velocity;

    private bool canMotion = true;

    public bool CanMotion { get => canMotion; set => canMotion = value; }
    private void FixedUpdate()
    {
        if (!canMotion)
        {
            return;
        }
        transform.position += new Vector3(0F, 0F, 1F) * Time.deltaTime * Velocity;

        if (transform.position.x > 0.14F)
        {
            transform.position = new Vector3(0.14f, transform.position.y, transform.position.z);
        }

        if (transform.position.x < -0.14F)
        {
            transform.position = new Vector3(-0.14f, transform.position.y, transform.position.z);
        }
    }


   


}
