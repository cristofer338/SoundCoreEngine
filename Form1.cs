using SoundCoreEngine.CustomStructures;
using SoundCoreEngine.Models;
using NAudio.Wave;
using System.Collections.Generic;
using System.Diagnostics;
namespace SoundCoreEngine
{
    public partial class Form1 : Form
    {
        private readonly SinglyLinkedList<Track> playlist = new();
        private readonly List<string> telemetry = new();
        private readonly Dictionary<int, string> audioPaths = new();

        private WaveOutEvent? outputDevice;
        private AudioFileReader? audioFile;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddToEnd_Click(object sender, EventArgs e)
        {

            using OpenFileDialog dialog = new();

            dialog.Title = "Seleccionar archivo de audio";
            dialog.Filter = "Archivos de audio|*.mp3;*.wav|MP3|*.mp3|WAV|*.wav";

            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            int id = playlist.Count + 1;

            Track track = new(
                id,
                txtTitle.Text,
                txtArtist.Text,
                (int)numBpm.Value,
                (int)numDuration.Value
            );

            long elapsed = MeasureTime(() =>
            {
                playlist.AddToEnd(track);
            });

            RegisterTelemetry("Add To End", elapsed);

            audioPaths[track.Id] = dialog.FileName;

            dgvPlaylist.Rows.Add(
                track.Id,
                track.Title,
                track.Artist,
                track.Bpm,
                track.DurationSeconds
            );
        }


        private void btnPlayNext_Click(object sender, EventArgs e)
        {
            Track? track = playlist.PlayNext();

            if (track == null)
            {
                MessageBox.Show(
                    "No hay canciones en la playlist.",
                    "Play Next"
                );

                return;
            }

            if (!audioPaths.TryGetValue(track.Id, out string? path))
            {
                MessageBox.Show(
                    "No se encontró el archivo de audio.",
                    "Play Next"
                );

                return;
            }

            try
            {
                outputDevice?.Stop();
                outputDevice?.Dispose();
                outputDevice = null;

                audioFile?.Dispose();
                audioFile = null;

                audioFile = new AudioFileReader(path);

                outputDevice = new WaveOutEvent();
                outputDevice.Init(audioFile);
                outputDevice.Play();

                MessageBox.Show(
                    $"Playing: {track.Title} - {track.Artist}",
                    "Play Next"
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"No se pudo reproducir el audio.\n\n{ex.Message}",
                    "Error de reproducción"
                );
            }
        }


        private void btnAdvanceTrack_Click(object sender, EventArgs e)
        {
            long elapsed = MeasureTime(() =>
            {
                playlist.AdvanceTrack(1);
            });

            RegisterTelemetry("Advance Track", elapsed);

            Track? track = playlist.AdvanceTrack(0);

            if (track != null)
            {
                MessageBox.Show(
                    $"Playing: {track.Title} - {track.Artist}",
                    "Advance Track"
                );
            }

        }

        private void btnReverseList_Click(object sender, EventArgs e)
        {
            long elapsed = MeasureTime(() =>
            {
                playlist.Reverse();
            });

            RegisterTelemetry("Reverse List", elapsed);

            RefreshPlaylistGrid();
        }

        private void btnSortByBpm_Click(object sender, EventArgs e)
        {
            long elapsed = MeasureTime(() =>
            {
                playlist.Sort((a, b) => a.Bpm.CompareTo(b.Bpm));
            });

            RegisterTelemetry("Sort By BPM", elapsed);

            RefreshPlaylistGrid();
        }

        private void btnRemoveDuplicates_Click(object sender, EventArgs e)
        {
            long elapsed = MeasureTime(() =>
            {
                playlist.RemoveDuplicates();
            });

            RegisterTelemetry("Remove Duplicates", elapsed);

            RefreshPlaylistGrid();
        }

        private void RefreshPlaylistGrid()
        {
            dgvPlaylist.Rows.Clear();

            foreach (Track track in playlist.ToList())
            {
                dgvPlaylist.Rows.Add(
                    track.Id,
                    track.Title,
                    track.Artist,
                    track.Bpm,
                    track.DurationSeconds
                );
            }
        }
        private long MeasureTime(Action action)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            action();

            stopwatch.Stop();

            return stopwatch.ElapsedMilliseconds;
        }
        private void RegisterTelemetry(string operation, long milliseconds)
        {
            telemetry.Add(
     $"{DateTime.Now:HH:mm:ss} - {operation}: {milliseconds} ms"
 );

            lblBenchmarkResults.Text =
                "TELEMETRY\n" +
                string.Join(Environment.NewLine, telemetry);
        }

        private void btnBenchmark_Click(object sender, EventArgs e)
        {
            var customList = new SinglyLinkedList<Track>();
            var linkedList = new LinkedList<Track>();
            var list = new List<Track>();

            long customTime, linkedTime, listTime;

            var stopwatch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < 25000; i++)
            {
                customList.AddToEnd(
                    new Track(i, $"Track {i}", "Artist", 120, 180)
                );
            }

            stopwatch.Stop();
            customTime = stopwatch.ElapsedMilliseconds;

            stopwatch.Restart();

            for (int i = 0; i < 25000; i++)
            {
                linkedList.AddLast(
                    new Track(i, $"Track {i}", "Artist", 120, 180)
                );
            }

            stopwatch.Stop();
            linkedTime = stopwatch.ElapsedMilliseconds;

            stopwatch.Restart();

            for (int i = 0; i < 25000; i++)
            {
                list.Add(
                    new Track(i, $"Track {i}", "Artist", 120, 180)
                );
            }

            stopwatch.Stop();
            listTime = stopwatch.ElapsedMilliseconds;

            lblBenchmarkResults.Text =
                $"Custom Linked List: {customTime} ms\n" +
                $"LinkedList<T>: {linkedTime} ms\n" +
                $"List<T>: {listTime} ms";
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            outputDevice?.Stop();
            outputDevice?.Dispose();

            audioFile?.Dispose();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (outputDevice == null)
            {
                MessageBox.Show(
                    "No hay ninguna canción reproduciéndose.",
                    "Pause"
                );

                return;
            }

            outputDevice.Pause();
        }
    }
}