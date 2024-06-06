using UnityEngine;

public class MoveSphere : MonoBehaviour
{

    ////スタートと終わりの目印
    //[SerializeField] Transform startMarker;
    //[SerializeField] Transform endMarker;
    public int power;
    Rigidbody _rb;

    // スピード
    //public float speed = 1.0F;

    //二点間の距離を入れる
    //private float distance_two;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();

        _rb.AddForce(Vector3.right * power);
        ////二点間の距離を代入(スピード調整に使う)
        //distance_two = Vector3.Distance(startMarker.position, endMarker.position);
    }

    public void OnTriggerEnter(Collider collider)
    {
        _rb.Sleep();
    }

    void Update()
    {

        //// 現在の位置
        //float present_Location = (Time.time * speed) / distance_two;

        //// オブジェクトの移動
        //transform.position = Vector3.Lerp(startMarker.position, endMarker.position, present_Location);
    }
}
