using UnityEngine.SceneManagement;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private AudioSource jumpSound;
    public float jumpForce;
    public Rigidbody2D rb;

    private void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // ����������� ������ �� ��� ���� ���������� ������
        {
            rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);// ���������� ������� �� ������ ��������� �� ���� �����������
            jumpSound.Play();// ������ �� ������������ ����� ������
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("PipePart"))
        {
            GameManager.instance.Lose();
        }
    }// ��� ������� � gameObject �� ����� PipePart �������� ������   
}
