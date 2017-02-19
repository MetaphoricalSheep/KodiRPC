# KodiRPC - A .NET/C# wrapper for the Kodi Api (v6)

The KodiRPC documentation can be viewed on (http://kodi.wiki/view/JSON-RPC_API/v6)

## Getting Started

### Installation
You can clone the KodiRPC repository in any path.
```bash
git clone https://github.com/MetaphoricalSheep/KodiRPC.git
```

### Configuration
Specify your kodi connection settings in your *.config file
   ```xml
   <appSettings>
     <add key="Debug" value="false"/>
     <add key="KodiUsername" value="kodi"/>
     <add key="KodiPassword" value="kodi"/>
     <add key="KodiHost" value="http://localhost"/>
     <add key="KodiPort" value="80"/>
   </appSettings>
   ```
Setting the debug key to true will output the request info on every request that you make. Useful for debugging, terrible in production.

## Usage
All the KodiRPC methods are exposed through the KodiService class. Instantiate an instance of the class to get started.
```c#
using KodiRPC.Services;
var service = new KodiService();
```

You can use the ```Ping()``` method to ping Kodi:
```c#
var ping = Service.Ping();
Console.WriteLine(ping.Result);
```

You can use the ```GetTvShows()``` method to get all tv shows:
```c#
var parameters = new GetTvShowsParams()
{
    Properties = TvShowProperties.All()
};

var shows = Service.GetTvShows(parameters);

Console.WriteLine("First Show Title: {0}", shows.Result.TvShows.First().Title)
```

The ```parameters``` variable is used to specify the payload for the method you are calling. You can set Filter, Limit, Properties and Sort depending on the method. Some methods, like the Details methods, require an id as well.

You can use the ```GetTvShowDetails()``` method to get detailed data about a specific show:
```c#
var parameters = new GetTvShowDetailsParams()
{
    TvShowId = 54,
    Properties = TvShowProperties.All()
};

var details = Service.GetTvShowDetails(parameters);

Console.WriteLine("Show Title: {0}", details.Result.TvShow.Title)
```


## Methods

### Implemented Methods
1. [JSONRPC](http://kodi.wiki/view/JSON-RPC_API/v6#JSONRPC)
    1. [JSONRPC.Ping](http://kodi.wiki/view/JSON-RPC_API/v6#JSONRPC.Ping)
2. [VideoLibrary](http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary)
    1. [VideoLibrary.Clean](http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.Clean)
    2. [VideoLibrary.Scan](http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.Scan)
    3. [VideoLibrary.GetEpisodeDetails](http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.GetEpisodeDetails)
    4. [VideoLibrary.GetEpisodes](http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.GetEpisodes)
    5. [VideoLibrary.GetMovieDetails](http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.GetMovieDetails)
    6. [VideoLibrary.GetMovies](http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.GetMovies)
    7. [VideoLibrary.GetRecentlyAddedEpisodes](http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.GetRecentlyAddedEpisodes)
    8. [VideoLibrary.GetRecentlyAddedMovies](http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.GetRecentlyAddedMovies)
    9. [VideoLibrary.GetSeasons](http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.GetSeasons)
    10. [VideoLibrary.GetTvShowDetails](http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.GetTvShowDetails)
    11. [VideoLibrary.GetTvShows](http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.GetTvShows)
3. [Files](http://kodi.wiki/view/JSON-RPC_API/v6#Files)
    1. [Files.GetDirectory](http://kodi.wiki/view/JSON-RPC_API/v6#Files.GetDirectory)
    2. [Files.PrepareDownload](http://kodi.wiki/view/JSON-RPC_API/v6#Files.PrepareDownload)


### Planned Methods (v1.1)
1. [Input](http://kodi.wiki/view/JSON-RPC_API/v6#Input)
    1. [Input.Back](http://kodi.wiki/view/JSON-RPC_API/v6#Input.Back)
    2. [Input.ContextMenu](http://kodi.wiki/view/JSON-RPC_API/v6#Input.ContextMenu)
    3. [Input.Down](http://kodi.wiki/view/JSON-RPC_API/v6#Input.Down)
    4. [Input.ExecuteAction](http://kodi.wiki/view/JSON-RPC_API/v6#Input.ExecuteAction)
    5. [Input.Home](http://kodi.wiki/view/JSON-RPC_API/v6#Input.Home)
    6. [Input.Info](http://kodi.wiki/view/JSON-RPC_API/v6#Input.Info)
    7. [Input.Left](http://kodi.wiki/view/JSON-RPC_API/v6#Input.Left)
    8. [Input.Right](http://kodi.wiki/view/JSON-RPC_API/v6#Input.Right)
    9. [Input.Select](http://kodi.wiki/view/JSON-RPC_API/v6#Input.Select)
    10. [Input.SendText](http://kodi.wiki/view/JSON-RPC_API/v6#Input.SendText)
    11. [Input.ShowCodec](http://kodi.wiki/view/JSON-RPC_API/v6#Input.ShowCodec)
    12. [Input.ShowOSD](http://kodi.wiki/view/JSON-RPC_API/v6#Input.ShowOSD)
    13. [Input.Up](http://kodi.wiki/view/JSON-RPC_API/v6#Input.Up)
2. [JSONRPC](http://kodi.wiki/view/JSON-RPC_API/v6#JSONRPC)
    1. [JSONRPC.GetConfiguration](http://kodi.wiki/view/JSON-RPC_API/v6#JSONRPC.GetConfiguration)
    2. [JSONRPC.Introspect](http://kodi.wiki/view/JSON-RPC_API/v6#JSONRPC.Introspect)
    3. [JSONRPC.NotifyAll](http://kodi.wiki/view/JSON-RPC_API/v6#JSONRPC.NotifyAll)
    4. [JSONRPC.Permission](http://kodi.wiki/view/JSON-RPC_API/v6#JSONRPC.Permission)
    5. [JSONRPC.SetConfiguration](http://kodi.wiki/view/JSON-RPC_API/v6#JSONRPC.SetConfiguration)
    6. [JSONRPC.Version](http://kodi.wiki/view/JSON-RPC_API/v6#JSONRPC.Version)
3. [VideoLibrary](http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary)
    1. [VideoLibrary.Export](http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.Export)
    2. [VideoLibrary.GetGenres](http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.GetGenres)
    3. [VideoLibrary.GetMusicVideoDetails](http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.GetMusicVideoDetails)
    4. [VideoLibrary.GetMusicVideos](http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.GetMusicVideos)
    5. [VideoLibrary.GetRecentlyAddedMusicVideos](http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.GetRecentlyAddedMusicVideos)
    6. [VideoLibrary.RemoveEpisode](http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.RemoveEpisode)
    7. [VideoLibrary.RemoveMovie](http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.RemoveMovie)
    8. [VideoLibrary.RemoveMusicVideo](http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.RemoveMusicVideo)
    9. [VideoLibrary.RemoveTVShow](http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.RemoveTVShow)


### Unplanned Methods
1. [Addons](http://kodi.wiki/view/JSON-RPC_API/v6#Addons)
    1. [Addons.ExecuteAddon](http://kodi.wiki/view/JSON-RPC_API/v6#Addons.ExecuteAddon)
    2. [Addons.GetAddonDetails](http://kodi.wiki/view/JSON-RPC_API/v6#Addons.GetAddondDetails)
    3. [Addons.GetAddons](http://kodi.wiki/view/JSON-RPC_API/v6#Addons.GetAddons)
    4. [Addons.SetAddonEnabled](http://kodi.wiki/view/JSON-RPC_API/v6#Addons.SetAddonEnabled)
2. [Application](http://kodi.wiki/view/JSON-RPC_API/v6#Application)
    1. [Application.GetProperties](http://kodi.wiki/view/JSON-RPC_API/v6#Application.GetProperties)
    2. [Application.Quit](http://kodi.wiki/view/JSON-RPC_API/v6#Application.Quit)
    3. [Application.SetMute](http://kodi.wiki/view/JSON-RPC_API/v6#Application.SetMute)
    4. [Application.SetVolume](http://kodi.wiki/view/JSON-RPC_API/v6#Application.SetVolume)
3. [AudioLibrary](http://kodi.wiki/view/JSON-RPC_API/v6#AudioLibrary)
    1. [AudioLibrary.Clean](http://kodi.wiki/view/JSON-RPC_API/v6#AudioLibrary.Clean)
    2. [AudioLibrary.Export](http://kodi.wiki/view/JSON-RPC_API/v6#AudioLibrary.Export)
    3. [AudioLibrary.GetAlbumDetails](http://kodi.wiki/view/JSON-RPC_API/v6#AudioLibrary.GetAlbumDetails)
    4. [AudioLibrary.GetAlbums](http://kodi.wiki/view/JSON-RPC_API/v6#AudioLibrary.GetAlbums)
    5. [AudioLibrary.GetArtistDetails](http://kodi.wiki/view/JSON-RPC_API/v6#AudioLibrary.GetArtistDetails)
    6. [AudioLibrary.GetArtists](http://kodi.wiki/view/JSON-RPC_API/v6#AudioLibrary.GetArtists)
    7. [AudioLibrary.GetGenres](http://kodi.wiki/view/JSON-RPC_API/v6#AudioLibrary.GetGenres)
    8. [AudioLibrary.GetRecentlyAddedAlbums](http://kodi.wiki/view/JSON-RPC_API/v6#AudioLibrary.GetRecentlyAddedAlbums)
    9. [AudioLibrary.GetRecentlyAddedSongs](http://kodi.wiki/view/JSON-RPC_API/v6#AudioLibrary.GetRecetlyAddedSongs)
    10. [AudioLibrary.GetRecentlyPlayedAlbums](http://kodi.wiki/view/JSON-RPC_API/v6#AudioLibrary.GetRecentlyPlayedAlbums)
    11. [AudioLibrary.GetRecentlyPlayedSongs](http://kodi.wiki/view/JSON-RPC_API/v6#AudioLibrary.GetRecentlyPlayedSongs)
    12. [AudioLibrary.GetSongDetails](http://kodi.wiki/view/JSON-RPC_API/v6#AudioLibrary.GetSongDetails)
    13. [AudioLibrary.GetSongs](http://kodi.wiki/view/JSON-RPC_API/v6#AudioLibrary.GetSongs)
    14. [AudioLibrary.Scan](http://kodi.wiki/view/JSON-RPC_API/v6#AudioLibrary.Scan)
    15. [AudioLibrary.SetAlbumDetails](http://kodi.wiki/view/JSON-RPC_API/v6#AudioLibrary.SetAlbumDetails)
    16. [AudioLibrary.SetArtistDetails](http://kodi.wiki/view/JSON-RPC_API/v6#AudioLibrary.SetArtistDetails)
    17. [AudioLibrary.SetSongDetails](http://kodi.wiki/view/JSON-RPC_API/v6#AudioLibrary.SetSongDetails)
4. [Files](http://kodi.wiki/view/JSON-RPC_API/v6#Files)
    1. [Files.GetFileDetails](http://kodi.wiki/view/JSON-RPC_API/v6#Files.GetFileDetails)
    2. [Files.GetSources](http://kodi.wiki/view/JSON-RPC_API/v6#Files.GetSources)
    3. [Files.Download](http://kodi.wiki/view/JSON-RPC_API/v6#Files.Download)
5. [GUI](http://kodi.wiki/view/JSON-RPC_API/v6#GUI)
    1. [GUI.ActivateWindow](http://kodi.wiki/view/JSON-RPC_API/v6#GUI.ActivateWindows)
    2. [GUI.GetProperties](http://kodi.wiki/view/JSON-RPC_API/v6#GUI.GetProperties)
    3. [GUI.SetFullscreen](http://kodi.wiki/view/JSON-RPC_API/v6#GUI.SetFullscreen)
    4. [GUI.ShowNotification](http://kodi.wiki/view/JSON-RPC_API/v6#GUI.ShowNotification)
6. [PVR](http://kodi.wiki/view/JSON-RPC_API/v6#PVR)
    1. [PVR.GetChannelDetails](http://kodi.wiki/view/JSON-RPC_API/v6#PVR.GetChannelDetails)
    2. [PVR.GetChannelGroupDetails](http://kodi.wiki/view/JSON-RPC_API/v6#PVR.GetChannelGroupDetails)
    3. [PVR.GetChannelGroups](http://kodi.wiki/view/JSON-RPC_API/v6#PVR.GetChannelGroups)
    4. [PVR.GetChannels](http://kodi.wiki/view/JSON-RPC_API/v6#PVR.GetChannels)
    5. [PVR.GetProperties](http://kodi.wiki/view/JSON-RPC_API/v6#PVR.GetProperties)
    6. [PVR.Record](http://kodi.wiki/view/JSON-RPC_API/v6#PVR.Record)
    7. [PVR.Scan](http://kodi.wiki/view/JSON-RPC_API/v6#PVR.Scan)
7. [Player](http://kodi.wiki/view/JSON-RPC_API/v6#Player)
    1. [Player.GetActivePlayers](http://kodi.wiki/view/JSON-RPC_API/v6#Player.GetActivePlayers)
    2. [Player.GetItem](http://kodi.wiki/view/JSON-RPC_API/v6#Player.GetItem)
    3. [Player.GetProperties](http://kodi.wiki/view/JSON-RPC_API/v6#Player.GetProperties)
    4. [Player.GoTo](http://kodi.wiki/view/JSON-RPC_API/v6#Player.GoTo)
    5. [Player.Move](http://kodi.wiki/view/JSON-RPC_API/v6#Player.Move)
    6. [Player.Open](http://kodi.wiki/view/JSON-RPC_API/v6#Player.Open)
    7. [Player.PlayPause](http://kodi.wiki/view/JSON-RPC_API/v6#Player.PlayPause)
    8. [Player.Rotate](http://kodi.wiki/view/JSON-RPC_API/v6#Player.Rotate)
    9. [Player.Seek](http://kodi.wiki/view/JSON-RPC_API/v6#Player.Seek)
    10. [Player.SetAudioStream](http://kodi.wiki/view/JSON-RPC_API/v6#Player.SetAudioStream)
    11. [Player.SetPartymode](http://kodi.wiki/view/JSON-RPC_API/v6#Player.SetPartymode)
    12. [Player.SetRepeat](http://kodi.wiki/view/JSON-RPC_API/v6#Player.SetRepeat)
    13. [Player.SetShuffle](http://kodi.wiki/view/JSON-RPC_API/v6#Player.SetShuffle)
    14. [Player.SetSpeed](http://kodi.wiki/view/JSON-RPC_API/v6#Player.SetSpeed)
    15. [Player.SetSubtitle](http://kodi.wiki/view/JSON-RPC_API/v6#Player.SetSubtitle)
    16. [Player.Stop](http://kodi.wiki/view/JSON-RPC_API/v6#Player.Stop)
    17. [Player.Zoom](http://kodi.wiki/view/JSON-RPC_API/v6#Player.Zoom)
8. [Playlist](http://kodi.wiki/view/JSON-RPC_API/v6#Playlist)
    1. [Playlist.Add](http://kodi.wiki/view/JSON-RPC_API/v6#Playlist.Add)
    2. [Playlist.Clear](http://kodi.wiki/view/JSON-RPC_API/v6#Playlist.Clear)
    3. [Playlist.GetItems](http://kodi.wiki/view/JSON-RPC_API/v6#Playlist.GetItems)
    4. [Playlist.GetPlaylists](http://kodi.wiki/view/JSON-RPC_API/v6#Playlist.GetPlaylists)
    5. [Playlist.GetProperties](http://kodi.wiki/view/JSON-RPC_API/v6#Playlist.GetProperties)
    6. [Playlist.Insert](http://kodi.wiki/view/JSON-RPC_API/v6#Playlist.Insert)
    7. [Playlist.Remove](http://kodi.wiki/view/JSON-RPC_API/v6#Playlist.Remove)
    8. [Playlist.Swap](http://kodi.wiki/view/JSON-RPC_API/v6#Playlist.Swap)
9. [System](http://kodi.wiki/view/JSON-RPC_API/v6#System)
    1. [System.EjectOpticalDrive](http://kodi.wiki/view/JSON-RPC_API/v6#System.EjectOpticalDrive)
    2. [System.GetProperties](http://kodi.wiki/view/JSON-RPC_API/v6#System.GetProperties)
    3. [System.Hibernate](http://kodi.wiki/view/JSON-RPC_API/v6#System.Hibernate)
    4. [System.Reboot](http://kodi.wiki/view/JSON-RPC_API/v6#System.Reboot)
    5. [System.Shutdown](http://kodi.wiki/view/JSON-RPC_API/v6#System.Shutdown)
    6. [System.Suspend](http://kodi.wiki/view/JSON-RPC_API/v6#System.Suspend)
10. [VideoLibrary](http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary)
    1. [VideoLibrary.GetMovieSetDetails](http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.GetMovieSetDetails)
    2. [VideoLibrary.GetMovieSets](http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.GetMovieSets)
    3. [VideoLibrary.SetEpisodeDetails](http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.SetEpisodeDetails)
    4. [VideoLibrary.SetMovieDetails](http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.SetMovieDetails)
    5. [VideoLibrary.SetMusicVideoDetails](http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.SetMusicVideoDetails)
    6. [VideoLibrary.SetTVShowDetails](http://kodi.wiki/view/JSON-RPC_API/v6#VideoLibrary.SetTVShowDetails)
11. [Kodi](http://kodi.wiki/view/JSON-RPC_API/v6#Kodi)
    1. [XBMC.GetInfoBooleans](http://kodi.wiki/view/JSON-RPC_API/v6#XBMC.GetInfoBooleans)
    2. [XBMC.GetInfoLabels](http://kodi.wiki/view/JSON-RPC_API/v6#XBMC.GetInfoLabels)


## License
Copyright (C) 2016  Pieter-Uys Fourie

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.

