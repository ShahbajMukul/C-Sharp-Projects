
using InterfaceDemo;

AudioPlayer sonyMp4 = new AudioPlayer();

(string name, double length) = sonyMp4.NowPlaying();

Console.WriteLine(name);