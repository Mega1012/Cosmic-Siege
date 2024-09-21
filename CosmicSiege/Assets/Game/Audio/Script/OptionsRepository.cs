using UnityEngine;
public static class OptionsRepository
{
    private struct Keys
    {
        public const string Language = "Language";
        public const string VolumeMaster = "VolumeMaster";
    }
    public static void SaveLanguageValue(int language)
    {
        PlayerPrefs.SetInt(Keys.Language, language);
        PlayerPrefs.Save();
    }
    public static int GetLanguage => PlayerPrefs.GetInt(Keys.Language, -1);

    public static void SaveVolumeMaster(float volumeMaster)
    {
        PlayerPrefs.SetFloat(Keys.VolumeMaster, volumeMaster);
        PlayerPrefs.Save();
    }
    public static float GetVolumeMaster => PlayerPrefs.GetFloat(Keys.VolumeMaster, -1);
}
