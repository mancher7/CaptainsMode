using Coherence.Toolkit;
using TMPro;
using UnityEngine;

public class CoherenceSyncTest : MonoBehaviour
{
    public UnityEngine.UI.Button[] player;
    public Transform[] team1Position;
    public Transform[] team2Position;

    public GameObject redCapitan;
    public GameObject blueCapitan;

    void Start()
    {
        for (int i = 0; i < player.Length; i++)
        {
            int index = i;
            player[i].onClick.AddListener(() => OnButtonClick(index));
        }
        redCapitan.SetActive(true);
        blueCapitan.SetActive(false);       
    } 

    public int i = 0;
    public int j = 0;
    public int s = 0;

    public bool team1 = true;
    public bool team2 = false;

    private void OnButtonClick(int index)
    {
        for (i = 0; i < 12; i++)
        {
            if (team1)
            {
                player[index].transform.position = team1Position[j].position;
                player[index].interactable = false;
                team1 = false;
                team2 = true;
                j++;
               
                redCapitan.SetActive(false);
                blueCapitan.SetActive(true);

                break;
            }

            if (team2)
            {

                player[index].transform.position = team2Position[s].position;
                player[index].interactable = false;
                team2 = false;
                team1 = true;
                s++;

                blueCapitan.SetActive(false);
                redCapitan.SetActive(true);

                if (s == 6)
                {
                    blueCapitan.SetActive(false);

                    redCapitan.SetActive(false);
                    InteractOFFButtons();

                }
                break;
            }

        }
    }   

    public void InteractOnButtons()
    {
        foreach (var item in player)
        {
            item.interactable = true;
        }
    }

    public void InteractOFFButtons()
    {
        foreach (var item in player)
        {
            item.interactable = false;
        }
    }
}
