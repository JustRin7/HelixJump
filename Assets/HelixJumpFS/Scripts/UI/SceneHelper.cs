using UnityEngine;
using UnityEngine.SceneManagement;//������ �� ������


public class SceneHelper : MonoBehaviour
{
    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void RestartLevel()//����� ������������ ���
    {
        SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex );//��������� ������� �����
    }

    public void LoadLevel(int buildIndex)//�������� ��� �� ������
    {
        SceneManager.LoadScene(buildIndex);
    }

    public void Quit()//����� �� ����
    {
        Application.Quit();
    }

}
