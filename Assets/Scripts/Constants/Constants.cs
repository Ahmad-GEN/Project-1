using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constants : MonoBehaviour
{
    public enum PlayerPrefsNames {player, scores, HighScore, CharacterSelected, Music, MusicVolume, 
                                  totalScoreValues, playerName, playerScore, fPlayerName, Sound};

    public enum BackgroundMusic { GamePlay, MainMenu };
    public enum SoundEffects { ButtonSound, FootSteps };
}
