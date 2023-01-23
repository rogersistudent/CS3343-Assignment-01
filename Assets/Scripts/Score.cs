using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{

    public Transform player;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI playerName;
    public TextMeshProUGUI playerSpeed;

    private void Start()
    {
        playerName.text = PlayerPrefs.GetString("Username");
        playerSpeed.text = "Current Speed: " + PlayerPrefs.GetFloat("PlayerSpeed").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
    }
}
