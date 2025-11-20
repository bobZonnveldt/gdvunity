using UnityEngine;

public class MediaPlayer : MonoBehaviour
{
    private string currentSong = "hupsakee";
    private bool isPlaying = false;
    private float volume = 1.0f;

    void Start()
    {
        PlaySong("gangnamstyle");
        SetVolume(0.8f);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            PlaySong("hallo wereld");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            StopSong();
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            SetVolume(Random.Range(0.0f, 1.0f));
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            Debug.Log("IsPlaying: " + IsPlaying());
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("Current song: " + GetCurrentSong());
        }
    }

    public void PlaySong(string songName)
    {
        currentSong = songName;
        isPlaying = true;
        Debug.Log("Playing song: " + songName);
    }

    public void StopSong()
    {
        Debug.Log("Stopping song: " + currentSong);
        currentSong = "";
        isPlaying = false;
    }

    public void SetVolume(float newVolume)
    {
    volume = Mathf.RoundToInt(Mathf.Clamp(newVolume * 100, 0, 100));
    Debug.Log("Volume set to: " + volume);
    }

    public string GetCurrentSong()
    {
        return currentSong;
    }

    public bool IsPlaying()
    {
        return isPlaying;
    }
}
