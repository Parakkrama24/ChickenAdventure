using UnityEngine;

public class GroundSpawner : MonoBehaviour
{public static GroundSpawner Instance;


    public GameObject GroundFrefab;
    private float _grounddistance = 3.5f;
    private float _currentGroundpos=0f ;
    void Awake()
    {
        makeinstance();
    }

    private void makeinstance()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private void Start()
    {
        intialspwnGround();
    }

    private void intialspwnGround()
    {
        for (int i = 0; i < 5; i++)
        {
            spowennewGround();
        }
    }

    void Update()
    {
        
    }
    
    public void spowennewGround()
    {
        _currentGroundpos += _grounddistance;
        Instantiate(GroundFrefab,new Vector3(0,_currentGroundpos,0f),Quaternion.identity);
    }
}//class
