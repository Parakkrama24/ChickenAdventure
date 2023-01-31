using UnityEngine;

public class camaraFollwer : MonoBehaviour
{
    private GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }



    void Update()
    {
        playerflower();
    }

    private void playerflower()
    {
        if (player)//if player has ,fallow him
        {
            transform.position = new Vector3(transform.position.x, player.transform.position.y, transform.position.z);
        }
    }
}//class
