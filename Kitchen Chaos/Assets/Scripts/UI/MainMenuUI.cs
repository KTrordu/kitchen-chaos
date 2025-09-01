using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    private const string GAME_SCENE = "GameScene";

    [SerializeField] private Button playButton;
    [SerializeField] private Button quitButton;

    private void Awake()
    {
        playButton.onClick.AddListener(PlayClick);
        quitButton.onClick.AddListener(QuitClick);
    }

    private void PlayClick()
    {
        Loader.Load(Loader.Scene.GameScene);
    }

    private void QuitClick()
    {
        Application.Quit();
    }
}
