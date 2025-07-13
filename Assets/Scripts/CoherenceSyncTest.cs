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

    public GameObject screepts;

    public GameObject buttonCachAutority;

    public TMP_Text timer;
    public float time = 100f;

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

    public void Update()
    {
        if (time >= 0)
        {
            time -= Time.deltaTime * 1;
            timer.text = time.ToString("F0");
        }
        else
        {
            time = 100;
            timer.text = time.ToString("F0");
        }
    }

    private void OnButtonClick(int index)
    {
        for (i = 0; i < 12; i++)
        {
            if (team1)
            {
                AutorityCach();

                player[index].transform.position = team1Position[j].position;
                player[index].interactable = false;
                team1 = false;
                team2 = true;
                j++;

                AutorityLose();
                redCapitan.SetActive(false);
                blueCapitan.SetActive(true);

                break;
            }

            if (team2)
            {
                AutorityCach();

                player[index].transform.position = team2Position[s].position;
                player[index].interactable = false;
                team2 = false;
                team1 = true;
                s++;

                AutorityLose();
                blueCapitan.SetActive(false);
                redCapitan.SetActive(true);

                if (s == 6)
                {
                    blueCapitan.SetActive(false);

                    redCapitan.SetActive(false);
                    timer.alignment = TextAlignmentOptions.Center;
                    InteractOFFButtons();

                }
                break;
            }

        }
    }


    public void AutorityLose()
    {
        InteractOFFButtons();
        foreach (var item in player)
        {
            item.transform.GetComponent<CoherenceSync>().AbandonAuthority();

        }
        screepts.GetComponent<CoherenceSync>().AbandonAuthority();
        //  buttonCachAutority.SetActive(false);


    }

    public void AutorityCach()
    {
        foreach (var item in player)
        {
            item.transform.GetComponent<CoherenceSync>().Adopt();
        }
        screepts.GetComponent<CoherenceSync>().Adopt();
        //   buttonCachAutority.SetActive(true);
        Invoke("InteractButtons", 0.1f);
        Invoke("InteractButtons", 0.1f);
    }

    public void InteractButtons()
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
