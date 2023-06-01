using DG.Tweening;
using System.Collections;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{
    public float Velocity;
    private Vector3 direction = Vector3.forward;
    public bool isStacked = false;
    private RaycastHit hit;
    public PlayerMoverRunner playerMoverRunner;
    public PlayerBehaviour playerBehaviour;
    public GameObject WinUI;


    void FixedUpdate()
    {
        if (!isStacked)
            return;

        float coeff = 0.02f;
        Debug.DrawRay(transform.position, direction * coeff, Color.red);

        if (Physics.Raycast(transform.position, direction, out hit, 1f * coeff))
        {

            if (hit.transform.gameObject.CompareTag("Obstacle"))
            {
                PlayerCubeManager.Instance.DropCube(this);
            }

            else if (hit.transform.gameObject.CompareTag("FinishLine"))
            {
                Debug.Log("HIT");
                AccessEndPoint();
            }
        }


    }

    public void AccessEndPoint()
    {
        //playerMoverRunner.Velocity = 0F;
        Debug.Log("win!");
        
        DOTween.To(() => playerMoverRunner.Velocity, x => playerMoverRunner.Velocity = x, 0, 1.5f).OnUpdate(() => {
            Debug.Log("DOTween Update");
        }).OnComplete(() => {
            Debug.Log("On Complete");
        });
        //playerBehaviour.VictoryAnimation();
        WinUI.SetActive(true);

    }



}
