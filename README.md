# SoundCoreEngine
# 🎵 SoundCoreEngine

Aplicación de escritorio desarrollada en **C# con Windows Forms** para gestionar y reproducir una playlist utilizando estructuras de datos personalizadas y estructuras proporcionadas por .NET.

El proyecto también incorpora herramientas de **Benchmark y Telemetría** para medir el rendimiento de diferentes estructuras de datos.

---

## 🚀 Características

### 🎶 Gestión de Playlist

- Registrar canciones con:
  - Título
  - Artista
  - BPM
  - Duración
- Agregar canciones al final de la playlist.
- Reproducir la siguiente canción.
- Avanzar dentro de la playlist.
- Invertir la lista.
- Ordenar canciones por BPM.
- Eliminar canciones duplicadas.
- Visualizar las canciones en un `DataGridView`.

### 🔊 Reproducción de Audio

La aplicación permite seleccionar archivos de audio `.mp3` y `.wav` y reproducirlos utilizando **NAudio**.

Actualmente se utiliza:

- `Play Next`
- `Pause`
- `Resume`

### 📊 Benchmark

El programa realiza una prueba de **25,000 inserciones** y mide el tiempo de ejecución con `Stopwatch`.

Se comparan:

```text
SinglyLinkedList<Track>
LinkedList<Track>
List<Track>
