using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constructif : MonoBehaviour
{
    public int Money;
    public int Lvl;
    // && - ��� �������� "�" ���������� �������,��� ��� �������� ������ ���� �����
    // || - ��� �������� "���" ���������� �������, ��� ������ ���� ����� ������ ���� �������
    void Start()
    {
      if(Lvl >= 5)
        {
            Money = 5000;
        }
      else if(Lvl >= 3)
        {
            Money = 300;
        }
      else if(Lvl >= 2)
        {
            Money = -4000;
        }
      else
        {
            Money = 0;
        }

    }

    
    
    void Update()
    {
       if(Lvl < 5 && Lvl < 4)
        {
            
        }
            
    }
}
