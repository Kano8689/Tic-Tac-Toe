using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class TicTac : MonoBehaviour
{
    public Text disp;
    public Text[] btn;
    public Button[] BtnAry;
    int i,cnt=0;
    public int temp = 0;

    // Start is called before the first frame update
    void Start()
    {
        for (i = 1; i <= 9; i++)
        {
            btn[i].text = "";
            BtnAry[i].GetComponent<Image>().color = Color.white;
            btn[i].color = Color.black;
            BtnAry[i].interactable = true;
        }
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}

    public void BtnClick(int pos)
    {
        if (pos == 1)
        {
            if (temp % 2 == 1)
            {
                btn[pos].text = "0";
            }
            else
            {
                btn[pos].text = "X";
            }
            BtnAry[pos].interactable = false;
        }
        else if (pos == 2)
        {
            if (temp % 2 == 1)
            {
                btn[pos].text = "0";
            }
            else
            {
                btn[pos].text = "X";
            }
            BtnAry[pos].interactable = false;
        }
        else if (pos == 3)
        {
            if (temp % 2 == 1)
            {
                btn[pos].text = "0";
            }
            else
            {
                btn[pos].text = "X";
            }
            BtnAry[pos].interactable = false;
        }
        else if (pos == 4)
        {
            if (temp % 2 == 1)
            {
                btn[pos].text = "0";
            }
            else
            {
                btn[pos].text = "X";
            }
            BtnAry[pos].interactable = false;
        }
        else if (pos == 5)
        {
            if (temp % 2 == 1)
            {
                btn[pos].text = "0";
            }
            else
            {
                btn[pos].text = "X";
            }
            BtnAry[pos].interactable = false;
        }
        else if (pos == 6)
        {
            if (temp % 2 == 1)
            {
                btn[pos].text = "0";
            }
            else
            {
                btn[pos].text = "X";
            }
            BtnAry[pos].interactable = false;
        }
        else if (pos == 7)
        {
            if (temp % 2 == 1)
            {
                btn[pos].text = "0";
            }
            else
            {
                btn[pos].text = "X";
            }
            BtnAry[pos].interactable = false;
        }
        else if (pos == 8)
        {
            if (temp % 2 == 1)
            {
                btn[pos].text = "0";
            }
            else
            {
                btn[pos].text = "X";
            }
            BtnAry[pos].interactable = false;
        }
        else if (pos == 9)
        {
            if (temp % 2 == 1)
            {
                btn[pos].text = "0";
            }
            else
            {
                btn[pos].text = "X";
            }
            BtnAry[pos].interactable = false;
        }
        temp++;
        Win();
    
    }
    public void Restart()
    {
        disp.text = "";
        cnt = 0;
        temp = 0;
        Start();
    }

    public void Win()
    {
        if (btn[1].text == "X" && btn[2].text == "X" && btn[3].text == "X")
        {
            disp.text = "X is Win";
            disp.color = Color.green;
            cnt = 1;

            BtnAry[1].GetComponent<Image>().color = Color.green;
            BtnAry[2].GetComponent<Image>().color = Color.green;
            BtnAry[3].GetComponent<Image>().color = Color.green;

            btn[1].color = Color.blue;
            btn[2].color = Color.blue;
            btn[3].color = Color.blue;
        }
        else if (btn[1].text == "X" && btn[4].text == "X" && btn[7].text == "X")
        {
            disp.text = "X is Win";
            disp.color = Color.green;
            cnt = 1;

            BtnAry[1].GetComponent<Image>().color = Color.green;
            BtnAry[4].GetComponent<Image>().color = Color.green;
            BtnAry[7].GetComponent<Image>().color = Color.green;

            btn[1].color = Color.blue;
            btn[4].color = Color.blue;
            btn[7].color = Color.blue;
        }
        else if (btn[1].text == "X" && btn[5].text == "X" && btn[9].text == "X")
        {
            disp.text = "X is Win";
            disp.color = Color.green;
            cnt = 1;

            BtnAry[1].GetComponent<Image>().color = Color.green;
            BtnAry[5].GetComponent<Image>().color = Color.green;
            BtnAry[9].GetComponent<Image>().color = Color.green;

            btn[1].color = Color.blue;
            btn[5].color = Color.blue;
            btn[7].color = Color.blue;
        }
        else if (btn[2].text == "X" && btn[5].text == "X" && btn[8].text == "X")
        {
            disp.text = "X is Win";
            disp.color = Color.green;
            cnt = 1;

            BtnAry[2].GetComponent<Image>().color = Color.green;
            BtnAry[5].GetComponent<Image>().color = Color.green;
            BtnAry[8].GetComponent<Image>().color = Color.green;

            btn[2].color = Color.blue;
            btn[5].color = Color.blue;
            btn[8].color = Color.blue;
        }
        else if (btn[3].text == "X" && btn[6].text == "X" && btn[9].text == "X")
        {
            disp.text = "X is Win";
            disp.color = Color.green;
            cnt = 1;

            BtnAry[3].GetComponent<Image>().color = Color.green;
            BtnAry[6].GetComponent<Image>().color = Color.green;
            BtnAry[9].GetComponent<Image>().color = Color.green;

            btn[3].color = Color.blue;
            btn[6].color = Color.blue;
            btn[9].color = Color.blue;
        }
        else if (btn[3].text == "X" && btn[5].text == "X" && btn[7].text == "X")
        {
            disp.text = "X is Win";
            disp.color = Color.green;
            cnt = 1;

            BtnAry[3].GetComponent<Image>().color = Color.green;
            BtnAry[5].GetComponent<Image>().color = Color.green;
            BtnAry[7].GetComponent<Image>().color = Color.green;

            btn[3].color = Color.blue;
            btn[5].color = Color.blue;
            btn[7].color = Color.blue;
        }
        else if (btn[4].text == "X" && btn[5].text == "X" && btn[6].text == "X")
        {
            disp.text = "X is Win";
            disp.color = Color.green;
            cnt = 1;

            BtnAry[4].GetComponent<Image>().color = Color.green;
            BtnAry[5].GetComponent<Image>().color = Color.green;
            BtnAry[6].GetComponent<Image>().color = Color.green;

            btn[4].color = Color.blue;
            btn[5].color = Color.blue;
            btn[6].color = Color.blue;
        }
        else if (btn[7].text == "X" && btn[8].text == "X" && btn[9].text == "X")
        {
            disp.text = "X is Win";
            disp.color = Color.green;
            cnt = 1;

            BtnAry[7].GetComponent<Image>().color = Color.green;
            BtnAry[8].GetComponent<Image>().color = Color.green;
            BtnAry[9].GetComponent<Image>().color = Color.green;

            btn[7].color = Color.blue;
            btn[8].color = Color.blue;
            btn[9].color = Color.blue;
        }

        else if (btn[1].text == "0" && btn[2].text == "0" && btn[3].text == "0")
        {
            disp.text = "0 is Win";
            disp.color = Color.green;
            cnt = 1;

            BtnAry[1].GetComponent<Image>().color = Color.green;
            BtnAry[2].GetComponent<Image>().color = Color.green;
            BtnAry[3].GetComponent<Image>().color = Color.green;

            btn[1].color = Color.blue;
            btn[2].color = Color.blue;
            btn[3].color = Color.blue;
        }
        else if (btn[1].text == "0" && btn[4].text == "0" && btn[7].text == "0")
        {
            disp.text = "0 is Win";
            disp.color = Color.green;
            cnt = 1;

            BtnAry[1].GetComponent<Image>().color = Color.green;
            BtnAry[4].GetComponent<Image>().color = Color.green;
            BtnAry[7].GetComponent<Image>().color = Color.green;

            btn[1].color = Color.blue;
            btn[4].color = Color.blue;
            btn[7].color = Color.blue;
        }
        else if (btn[1].text == "0" && btn[5].text == "0" && btn[9].text == "0")
        {
            disp.text = "0 is Win";
            disp.color = Color.green;
            cnt = 1;

            BtnAry[1].GetComponent<Image>().color = Color.green;
            BtnAry[5].GetComponent<Image>().color = Color.green;
            BtnAry[9].GetComponent<Image>().color = Color.green;

            btn[1].color = Color.blue;
            btn[5].color = Color.blue;
            btn[7].color = Color.blue;
        }
        else if (btn[2].text == "0" && btn[5].text == "0" && btn[8].text == "0")
        {
            disp.text = "0 is Win";
            disp.color = Color.green;
            cnt = 1;

            BtnAry[2].GetComponent<Image>().color = Color.green;
            BtnAry[5].GetComponent<Image>().color = Color.green;
            BtnAry[8].GetComponent<Image>().color = Color.green;

            btn[2].color = Color.blue;
            btn[5].color = Color.blue;
            btn[8].color = Color.blue;
        }
        else if (btn[3].text == "0" && btn[6].text == "0" && btn[9].text == "0")
        {
            disp.text = "0 is Win";
            disp.color = Color.green;
            cnt = 1;

            BtnAry[3].GetComponent<Image>().color = Color.green;
            BtnAry[6].GetComponent<Image>().color = Color.green;
            BtnAry[9].GetComponent<Image>().color = Color.green;

            btn[3].color = Color.blue;
            btn[6].color = Color.blue;
            btn[9].color = Color.blue;
        }
        else if (btn[3].text == "0" && btn[5].text == "0" && btn[7].text == "0")
        {
            disp.text = "0 is Win";
            disp.color = Color.green;
            cnt = 1;

            BtnAry[3].GetComponent<Image>().color = Color.green;
            BtnAry[5].GetComponent<Image>().color = Color.green;
            BtnAry[7].GetComponent<Image>().color = Color.green;

            btn[3].color = Color.blue;
            btn[5].color = Color.blue;
            btn[7].color = Color.blue;
        }
        else if (btn[4].text == "0" && btn[5].text == "0" && btn[6].text == "0")
        {
            disp.text = "0 is Win";
            disp.color = Color.green;
            cnt = 1;

            BtnAry[4].GetComponent<Image>().color = Color.green;
            BtnAry[5].GetComponent<Image>().color = Color.green;
            BtnAry[6].GetComponent<Image>().color = Color.green;

            btn[4].color = Color.blue;
            btn[5].color = Color.blue;
            btn[6].color = Color.blue;
        }
        else if (btn[7].text == "0" && btn[8].text == "0" && btn[9].text == "0")
        {
            disp.text = "0 is Win";
            disp.color = Color.green;
            cnt = 1;

            BtnAry[7].GetComponent<Image>().color = Color.green;
            BtnAry[8].GetComponent<Image>().color = Color.green;
            BtnAry[9].GetComponent<Image>().color = Color.green;

            btn[7].color = Color.blue;
            btn[8].color = Color.blue;
            btn[9].color = Color.blue;
        }
        else if (temp == 9)
        {
            disp.text = "Match Is Draw";
            disp.color = Color.red;
        }
        
        if(cnt==1)
        {
            for(i=1;i<=9;i++)
            {
                BtnAry[i].interactable = false;
            }
        }
    }
}
