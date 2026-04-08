using System.Media;

public class Audio
{
    public static void PlayGreeting()
    {         ;
        SoundPlayer player = new SoundPlayer("Assets\\greeting.wav");
        player.SoundLocation = "Assets/greeting.wav";
        
        player.Load();
        player.PlaySync();
    }
}