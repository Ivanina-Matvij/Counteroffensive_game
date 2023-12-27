using UnityEngine;

public class Fire : MonoBehaviour
{
    void Update()
    {
        // ����������, �� ��������� ������ "Space"
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // ��������� ���, ��������� � ������� ����� ��'���� �� � �������� ������
            Ray ray = new Ray(transform.position, transform.forward);

            // ��������� �������� ���� (����� ���������� �� ��������)
            float rayDistance = 10f;

            // ���������� �� � �������� ���� � �����������
            if (Physics.Raycast(ray, out RaycastHit hit, rayDistance))
            {
                // �������� ����� ��'����, ��� ���� ������� �����
                GameObject hitObject = hit.collider.gameObject;

                // ������� ��� ��'���
                Destroy(hitObject);

                // ����� ������� ���������� ��� �������� � ������� (��� ������������)
                Debug.Log($"ǳ������� � {hitObject.name}!");
            }
        }
    }
}
