# Net40VolumeSample
Volume issue repro for .NET 40

This small sample will:
- Read the volume after creating a media player
- Set the volume to 20 percent
- Read the volume again after the video has started playing
- Subscribe to the VolumeChanged event, which should print the new volume as well

(and set the volume to 100 again because for some reason the last known volume persist after a reboot of the program)
