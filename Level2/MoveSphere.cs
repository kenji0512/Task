using UnityEngine;

public class MoveSphere : MonoBehaviour
{

    //�X�^�[�g�ƏI���̖ڈ�
    [SerializeField] Transform startMarker;
    [SerializeField] Transform endMarker;

    // �X�s�[�h
    public float speed = 1.0F;

    //��_�Ԃ̋���������
    private float distance_two;

    void Start()
    {
        //��_�Ԃ̋�������(�X�s�[�h�����Ɏg��)
        distance_two = Vector3.Distance(startMarker.position, endMarker.position);
    }

    void Update()
    {

        // ���݂̈ʒu
        float present_Location = (Time.time * speed) / distance_two;

        // �I�u�W�F�N�g�̈ړ�
        transform.position = Vector3.Lerp(startMarker.position, endMarker.position, present_Location);
    }
}
