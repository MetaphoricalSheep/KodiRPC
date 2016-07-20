# KodiRPC - A .NET/C# wrapper for the Kodi Api (v6)

The KodiRPC documentation can be viewed on [http://kodi.wiki/view/JSON-RPC_API/v6]

## Getting Started

### Installation
You can clone the KodiRPC repository in any path.
```bash
git clone git@github.com:PieterUysFourie/KodiRPC.git
```

### Configuration
The App.config file is created by transforming the Base.config file with the settings in the selected Configuration. Never edit the App.config file directly as all changes will be lost when you build. To customize your settings you can either change the Base.config file directly or you can set up a new configuration by following the steps below:

1. Open the ```Configuration Manager``` and create a new configuration.
2. Create a copy the Base.config file in KodiRPC/demo and name it to the same name you used for the new configuration.
3. Open up the config file in an editor. Add ```xmlns:xdt="http://schemas.microsoft.com/XML-Document-Transform"``` to the configuration     element and ``` xdt:Transform="SetAttributes" xdt:Locator="Match(key)"``` to all the appSettings children:

   ```xml
   <?xml version="1.0" encoding="utf-8" ?>
   <configuration xmlns:xdt="http://schemas.microsoft.com/XML-Document-Transform">
     ...
     <appSettings>
       <add key="KodiUsername" value="kodi" xdt:Transform="SetAttributes" xdt:Locator="Match(key)"/>
       ...
       <add key="KodiPort" value="80" xdt:Transform="SetAttributes" xdt:Locator="Match(key)"/>
     </appSettings>
   </configuration>
   ```
   
4. Change all the values to what you need it to be for the new configuration. You can remove anything that does not have to change.
5. Select the new configuration from the Configuration Manager and click build. App.config should now transform with the values in the new config file.
6. Add the new config file to .gitignore

## Usage


## Implemented Methods
1. (JSONRPC)[http://kodi.wiki/view/JSON-RPC_API/v6#JSONRPC]
    1. (JSONRPC.Ping)[http://kodi.wiki/view/JSON-RPC_API/v6#JSONRPC.Ping]
2. (VideoLibrary)[http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary]
    1. (VideoLibrary.GetEpisodeDetails)[http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.GetEpisodeDetails]
    2. (VideoLibrary.GetEpisodes)[http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.GetEpisodes]
    3. (VideoLibrary.GetMovieDetails)[http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.GetMovieDetails]
    4. (VideoLibrary.GetMovies)[http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.GetMovies]
    5. (VideoLibrary.GetRecentlyAddedEpisodes)[http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.GetRecentlyAddedEpisodes]
    6. (VideoLibrary.GetRecentlyAddedMovies)[http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.GetRecentlyAddedMovies]
    7. (VideoLibrary.GetSeasons)[http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.GetSeasons]
    8. (VideoLibrary.GetTvShowDetails)[http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.GetTvShowDetails]
    9. (VideoLibrary.GetTvShows)[http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.GetTvShows]


## Outstanding Methods
1. (Addons)[http://kodi.wiki/view/JSON-RPC_API/v6#Addons]
    1. (Addons.ExecuteAddon)[http://kodi.wiki/view/JSON-RPC_API/v6#Addons.ExecuteAddon]
    2. (Addons.GetAddonDetails)[http://kodi.wiki/view/JSON-RPC_API/v6#Addons.GetAddondDetails]
    3. (Addons.GetAddons)[http://kodi.wiki/view/JSON-RPC_API/v6#Addons.GetAddons]
    4. (Addons.SetAddonEnabled)[http://kodi.wiki/view/JSON-RPC_API/v6#Addons.SetAddonEnabled]
2. (Application)[http://kodi.wiki/view/JSON-RPC_API/v6#Application]
    1. (Application.GetProperties)[http://kodi.wiki/view/JSON-RPC_API/v6#Application.GetProperties]
    2. (Application.Quit)[http://kodi.wiki/view/JSON-RPC_API/v6#Application.Quit]
    3. (Application.SetMute)[http://kodi.wiki/view/JSON-RPC_API/v6#Application.SetMute]
    4. (Application.SetVolume)[http://kodi.wiki/view/JSON-RPC_API/v6#Application.SetVolume]
3. (AudioLibrary)[http://kodi.wiki/view/JSON-RPC_API/v6#AudioLibrary]
    1. (AudioLibrary.Clean)[http://kodi.wiki/view/JSON-RPC_API/v6#AudioLibrary.Clean]
    2. (AudioLibrary.Export)[http://kodi.wiki/view/JSON-RPC_API/v6#AudioLibrary.Export]
    3. (AudioLibrary.GetAlbumDetails)[http://kodi.wiki/view/JSON-RPC_API/v6#AudioLibrary.GetAlbumDetails]
    4. (AudioLibrary.GetAlbums)[http://kodi.wiki/view/JSON-RPC_API/v6#AudioLibrary.GetAlbums]
    5. (AudioLibrary.GetArtistDetails)[http://kodi.wiki/view/JSON-RPC_API/v6#AudioLibrary.GetArtistDetails]
    6. (AudioLibrary.GetArtists)[http://kodi.wiki/view/JSON-RPC_API/v6#AudioLibrary.GetArtists]
    7. (AudioLibrary.GetGenres)[http://kodi.wiki/view/JSON-RPC_API/v6#AudioLibrary.GetGenres]
    8. (AudioLibrary.GetRecentlyAddedAlbums)[http://kodi.wiki/view/JSON-RPC_API/v6#AudioLibrary.GetRecentlyAddedAlbums]
    9. (AudioLibrary.GetRecentlyAddedSongs)[http://kodi.wiki/view/JSON-RPC_API/v6#AudioLibrary.GetRecetlyAddedSongs]
    10. (AudioLibrary.GetRecentlyPlayedAlbums)[http://kodi.wiki/view/JSON-RPC_API/v6#AudioLibrary.GetRecentlyPlayedAlbums]
    11. (AudioLibrary.GetRecentlyPlayedSongs)[http://kodi.wiki/view/JSON-RPC_API/v6#AudioLibrary.GetRecentlyPlayedSongs]
    12. (AudioLibrary.GetSongDetails)[http://kodi.wiki/view/JSON-RPC_API/v6#AudioLibrary.GetSongDetails]
    13. (AudioLibrary.GetSongs)[http://kodi.wiki/view/JSON-RPC_API/v6#AudioLibrary.GetSongs]
    14. (AudioLibrary.Scan)[http://kodi.wiki/view/JSON-RPC_API/v6#AudioLibrary.Scan]
    15. (AudioLibrary.SetAlbumDetails)[http://kodi.wiki/view/JSON-RPC_API/v6#AudioLibrary.SetAlbumDetails]
    16. (AudioLibrary.SetArtistDetails)[http://kodi.wiki/view/JSON-RPC_API/v6#AudioLibrary.SetArtistDetails]
    17. (AudioLibrary.SetSongDetails)[http://kodi.wiki/view/JSON-RPC_API/v6#AudioLibrary.SetSongDetails]
4. (Files)[http://kodi.wiki/view/JSON-RPC_API/v6#Files]
    1. (Files.Download)[http://kodi.wiki/view/JSON-RPC_API/v6#Files.Download]
    2. (Files.GetDirectory)[http://kodi.wiki/view/JSON-RPC_API/v6#Files.GetDirectory]
    3. (Files.GetFileDetails)[http://kodi.wiki/view/JSON-RPC_API/v6#Files.GetFileDetails]
    4. (Files.GetSources)[http://kodi.wiki/view/JSON-RPC_API/v6#Files.GetSources]
    5. (Files.PrepareDownload)[http://kodi.wiki/view/JSON-RPC_API/v6#Files.PrepareDownload]
5. (GUI)[http://kodi.wiki/view/JSON-RPC_API/v6#GUI]
    1. (GUI.ActivateWindow)[http://kodi.wiki/view/JSON-RPC_API/v6#GUI.ActivateWindows]
    2. (GUI.GetProperties)[http://kodi.wiki/view/JSON-RPC_API/v6#GUI.GetProperties]
    3. (GUI.SetFullscreen)[http://kodi.wiki/view/JSON-RPC_API/v6#GUI.SetFullscreen]
    4. (GUI.ShowNotification)[http://kodi.wiki/view/JSON-RPC_API/v6#GUI.ShowNotification]
6. (Input)[http://kodi.wiki/view/JSON-RPC_API/v6#Input]
    1. (Input.Back)[http://kodi.wiki/view/JSON-RPC_API/v6#Input.Back]
    2. (Input.ContextMenu)[http://kodi.wiki/view/JSON-RPC_API/v6#Input.ContextMenu]
    3. (Input.Down)[http://kodi.wiki/view/JSON-RPC_API/v6#Input.Down]
    4. (Input.ExecuteAction)[http://kodi.wiki/view/JSON-RPC_API/v6#Input.ExecuteAction]
    5. (Input.Home)[http://kodi.wiki/view/JSON-RPC_API/v6#Input.Home]
    6. (Input.Info)[http://kodi.wiki/view/JSON-RPC_API/v6#Input.Info]
    7. (Input.Left)[http://kodi.wiki/view/JSON-RPC_API/v6#Input.Left]
    8. (Input.Right)[http://kodi.wiki/view/JSON-RPC_API/v6#Input.Right]
    9. (Input.Select)[http://kodi.wiki/view/JSON-RPC_API/v6#Input.Select]
    10. (Input.SendText)[http://kodi.wiki/view/JSON-RPC_API/v6#Input.SendText]
    11. (Input.ShowCodec)[http://kodi.wiki/view/JSON-RPC_API/v6#Input.ShowCodec]
    12. (Input.ShowOSD)[http://kodi.wiki/view/JSON-RPC_API/v6#Input.ShowOSD]
    13. (Input.Up)[http://kodi.wiki/view/JSON-RPC_API/v6#Input.Up]
7. (JSONRPC)[http://kodi.wiki/view/JSON-RPC_API/v6#JSONRPC]
    1. (JSONRPC.GetConfiguration)[http://kodi.wiki/view/JSON-RPC_API/v6#JSONRPC.GetConfiguration]
    2. (JSONRPC.Introspect)[http://kodi.wiki/view/JSON-RPC_API/v6#JSONRPC.Introspect]
    3. (JSONRPC.NotifyAll)[http://kodi.wiki/view/JSON-RPC_API/v6#JSONRPC.NotifyAll]
    4. (JSONRPC.Permission)[http://kodi.wiki/view/JSON-RPC_API/v6#JSONRPC.Permission]
    5. (JSONRPC.SetConfiguration)[http://kodi.wiki/view/JSON-RPC_API/v6#JSONRPC.SetConfiguration]
    6. (JSONRPC.Version)[http://kodi.wiki/view/JSON-RPC_API/v6#JSONRPC.Version]
8. (PVR)[http://kodi.wiki/view/JSON-RPC_API/v6#PVR]
    1. (PVR.GetChannelDetails)[http://kodi.wiki/view/JSON-RPC_API/v6#PVR.GetChannelDetails]
    2. (PVR.GetChannelGroupDetails)[http://kodi.wiki/view/JSON-RPC_API/v6#PVR.GetChannelGroupDetails]
    3. (PVR.GetChannelGroups)[http://kodi.wiki/view/JSON-RPC_API/v6#PVR.GetChannelGroups]
    4. (PVR.GetChannels)[http://kodi.wiki/view/JSON-RPC_API/v6#PVR.GetChannels]
    5. (PVR.GetProperties)[http://kodi.wiki/view/JSON-RPC_API/v6#PVR.GetProperties]
    6. (PVR.Record)[http://kodi.wiki/view/JSON-RPC_API/v6#PVR.Record]
    7. (PVR.Scan)[http://kodi.wiki/view/JSON-RPC_API/v6#PVR.Scan]
9. (Player)[http://kodi.wiki/view/JSON-RPC_API/v6#Player]
    1. (Player.GetActivePlayers)[http://kodi.wiki/view/JSON-RPC_API/v6#Player.GetActivePlayers]
    2. (Player.GetItem)[http://kodi.wiki/view/JSON-RPC_API/v6#Player.GetItem]
    3. (Player.GetProperties)[http://kodi.wiki/view/JSON-RPC_API/v6#Player.GetProperties]
    4. (Player.GoTo)[http://kodi.wiki/view/JSON-RPC_API/v6#Player.GoTo]
    5. (Player.Move)[http://kodi.wiki/view/JSON-RPC_API/v6#Player.Move]
    6. (Player.Open)[http://kodi.wiki/view/JSON-RPC_API/v6#Player.Open]
    7. (Player.PlayPause)[http://kodi.wiki/view/JSON-RPC_API/v6#Player.PlayPause]
    8. (Player.Rotate)[http://kodi.wiki/view/JSON-RPC_API/v6#Player.Rotate]
    9. (Player.Seek)[http://kodi.wiki/view/JSON-RPC_API/v6#Player.Seek]
    10. (Player.SetAudioStream)[http://kodi.wiki/view/JSON-RPC_API/v6#Player.SetAudioStream]
    11. (Player.SetPartymode)[http://kodi.wiki/view/JSON-RPC_API/v6#Player.SetPartymode]
    12. (Player.SetRepeat)[http://kodi.wiki/view/JSON-RPC_API/v6#Player.SetRepeat]
    13. (Player.SetShuffle)[http://kodi.wiki/view/JSON-RPC_API/v6#Player.SetShuffle]
    14. (Player.SetSpeed)[http://kodi.wiki/view/JSON-RPC_API/v6#Player.SetSpeed]
    15. (Player.SetSubtitle)[http://kodi.wiki/view/JSON-RPC_API/v6#Player.SetSubtitle]
    16. (Player.Stop)[http://kodi.wiki/view/JSON-RPC_API/v6#Player.Stop]
    17. (Player.Zoom)[http://kodi.wiki/view/JSON-RPC_API/v6#Player.Zoom]
10. (Playlist)[http://kodi.wiki/view/JSON-RPC_API/v6#
    1. (Playlist.Add)[http://kodi.wiki/view/JSON-RPC_API/v6#Playlist.Add]
    2. (Playlist.Clear)[http://kodi.wiki/view/JSON-RPC_API/v6#Playlist.Clear]
    3. (Playlist.GetItems)[http://kodi.wiki/view/JSON-RPC_API/v6#Playlist.GetItems]
    4. (Playlist.GetPlaylists)[http://kodi.wiki/view/JSON-RPC_API/v6#Playlist.GetPlaylists]
    5. (Playlist.GetProperties)[http://kodi.wiki/view/JSON-RPC_API/v6#Playlist.GetProperties]
    6. (Playlist.Insert)[http://kodi.wiki/view/JSON-RPC_API/v6#Playlist.Insert]
    7. (Playlist.Remove)[http://kodi.wiki/view/JSON-RPC_API/v6#Playlist.Remove]
    8. (Playlist.Swap)[http://kodi.wiki/view/JSON-RPC_API/v6#Playlist.Swap]
11. (System)[http://kodi.wiki/view/JSON-RPC_API/v6#
    1. (System.EjectOpticalDrive)[http://kodi.wiki/view/JSON-RPC_API/v6#System.EjectOpticalDrive]
    2. (System.GetProperties)[http://kodi.wiki/view/JSON-RPC_API/v6#System.GetProperties]
    3. (System.Hibernate)[http://kodi.wiki/view/JSON-RPC_API/v6#System.Hibernate]
    4. (System.Reboot)[http://kodi.wiki/view/JSON-RPC_API/v6#System.Reboot]
    5. (System.Shutdown)[http://kodi.wiki/view/JSON-RPC_API/v6#System.Shutdown]
    6. (System.Suspend)[http://kodi.wiki/view/JSON-RPC_API/v6#System.Suspend]
12. (VideoLibrary)[http://kodi.wiki/view/JSON-RPC_API/v6#
    1. (VideoLibrary.Clean)[http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.Clean]
    2. (VideoLibrary.Export)[http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.Export]
    3. (VideoLibrary.GetGenres)[http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.GetGenres]
    4. (VideoLibrary.GetMovieSetDetails)[http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.GetMovieSetDetails]
    5. (VideoLibrary.GetMovieSets)[http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.GetMovieSets]
    6. (VideoLibrary.GetMusicVideoDetails)[http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.GetMusicVideoDetails]
    7. (VideoLibrary.GetMusicVideos)[http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.GetMusicVideos]
    8. (VideoLibrary.GetRecentlyAddedMusicVideos)[http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.GetRecentlyAddedMusicVideos]
    9. (VideoLibrary.RemoveEpisode)[http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.RemoveEpisode]
    10. (VideoLibrary.RemoveMovie)[http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.RemoveMovie]
    11. (VideoLibrary.RemoveMusicVideo)[http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.RemoveMusicVideo]
    12. (VideoLibrary.RemoveTVShow)[http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.RemoveTVShow]
    12. (VideoLibrary.Scan)[http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.Scan]
    13. (VideoLibrary.SetEpisodeDetails)[http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.SetEpisodeDetails]
    14. (VideoLibrary.SetMovieDetails)[http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.SetMovieDetails]
    15. (VideoLibrary.SetMusicVideoDetails)[http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.SetMusicVideoDetails]
    16. (VideoLibrary.SetTVShowDetails)[http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.SetTVShowDetails]
13. (Kodi)[http://kodi.wiki/view/JSON-RPC_API/v6#
    1. (XBMC.GetInfoBooleans)[http://kodi.wiki/view/JSON-RPC_API/v6#XBMC.GetInfoBooleans]
    2. (XBMC.GetInfoLabels)[http://kodi.wiki/view/JSON-RPC_API/v6#XBMC.GetInfoLabels]


## License
