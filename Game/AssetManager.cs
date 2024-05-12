using SFML.Graphics;
using SFML.System;
using SFML.Audio;

public class AssetManager
{
    private static AssetManager? instance;
    public readonly Dictionary<string, Texture> Textures = new Dictionary<string, Texture>();
    public readonly Dictionary<string, SoundBuffer> SoundBuffers = new Dictionary<string, SoundBuffer>();
    public readonly Dictionary<string, Music> Music = new Dictionary<string, Music>();
    public readonly Dictionary<string, Font> Fonts = new Dictionary<string, Font>();

    private AssetManager()
    {
    }

    public static AssetManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new AssetManager();
            }
            return instance;
        }
    }

    public void LoadTexture(string name, string filename)
    {
        
        Texture texture = new Texture(filename);
        Textures[name] = texture;
    }

    public Texture GetTexture(string name)
    {
        if (Textures.ContainsKey(name))
        {
            return Textures[name];
        }
        else
        {
            throw new KeyNotFoundException($"Texture '{name}' not found");
        }
    }

    public void LoadSoundBuffer(string name, string filename)
    {
        SoundBuffer soundBuffer = new SoundBuffer(filename);
        SoundBuffers[name] = soundBuffer;
    }

    public SoundBuffer GetSoundBuffer(string name)
    {
        if (SoundBuffers.ContainsKey(name))
        {
            return SoundBuffers[name];
        }
        else
        {
            throw new KeyNotFoundException($"SoundBuffer '{name}' not found");
        }
    }

    public void LoadMusic(string name, string filename)
    {
        Music music = new Music(filename);
        Music[name] = music;
    }

    public Music GetMusic(string name)
    {
        if (Music.ContainsKey(name))
        {
            return Music[name];
        }
        else
        {
            throw new KeyNotFoundException($"Music '{name}' not found");
        }
    }

    public void LoadFont(string name, string filename)
    {
        Font font = new Font(filename);
        Fonts[name] = font;
    }

    public Font GetFont(string name)
    {
        if (Fonts.ContainsKey(name))
        {
            return Fonts[name];
        }
        else
        {
            throw new KeyNotFoundException($"Font '{name}' not found");
        }
    }
}

