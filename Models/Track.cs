namespace SoundCoreEngine.Models;

public record Track(
    int Id,
    string Title,
    string Artist,
    int Bpm,
    int DurationSeconds
)
{
    public override string ToString() =>
        $"[{Id:D3}] {Title} - {Artist} | {Bpm} BPM";
}