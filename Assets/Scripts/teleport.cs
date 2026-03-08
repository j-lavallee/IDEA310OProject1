using UnityEngine;

public class teleport : MonoBehaviour
{
    public GameObject player;
    public GameObject target;

    public void OnTriggerEnter(Collider other)
    {
        CharacterController cc = player.GetComponent<CharacterController>();
        cc.enabled = false;
        player.transform.position = target.transform.position;
        player.transform.rotation = target.transform.rotation;
        cc.enabled = true;
    }
}
