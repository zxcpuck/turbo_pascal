using UnityEngine.SceneManagement;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private AudioSource jumpSound;
    public float jumpForce;
    public Rigidbody2D rb;

    private void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // встановлюєм кнопку на яку буде забінджений прижок
        {
            rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);// втановлюєм функцію на прижок персонажа та його корегування
            jumpSound.Play();// скрипт на встановлення звуку прижка
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("PipePart"))
        {
            GameManager.instance.Lose();
        }
    }// при зіткненні з gameObject під тегом PipePart персонаж програє   
}
