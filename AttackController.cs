using UnityEngine;

public class AttackController : MonoBehaviour
{
    [SerializeField] private GameObject _damageTextObj; //�_�[���[�W�e�L�X�g���i�[

    //Enemy���_���[�W���󂯂�Ƃ���ł�т���
    public void Attack()
    {
        //�_���[�W�e�L�X�g(3DText)������
        Instantiate(_damageTextObj, transform.position, transform.rotation) ;
    }
}
