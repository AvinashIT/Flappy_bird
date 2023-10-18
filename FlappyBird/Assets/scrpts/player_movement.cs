using UnityEngine;
public class player_movement : MonoBehaviour
{
    [SerializeField] float gravity = -9.5f;
    private Vector3 direction;
    private float strength = 5f;
    public Sprite[] spirtes;
    private int spInd=0;
    private SpriteRenderer spren;
    private void Start()
    {
        spren = GetComponent<SpriteRenderer>();
        InvokeRepeating(nameof(animate),0.15f,0.15f);
        
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)||Input.GetMouseButton(0))
        {
            direction= Vector3.up * strength;
        }
        if (Input.touchCount > 0)
        {
            Touch to = Input.GetTouch(0);
            if (to.phase == TouchPhase.Began)
            {
                direction = Vector3.up * strength;
            }
        }
        direction.y += gravity * Time.deltaTime;
        transform.position+= direction * Time.deltaTime;

    }
    void animate()
    {
        spInd++;
        if(spInd>=spirtes.Length)
        {
            spInd = 0;
        }
        spren.sprite = spirtes[spInd];
    }


}
