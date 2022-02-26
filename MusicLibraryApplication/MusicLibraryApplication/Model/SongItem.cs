﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace MusicLibraryApplication.Model
{
    public enum MusicGenre
    {
        Classical,
        Country,
        Electronic,
        Jazz,
        Pop,
        Rap,
        Rock
    }

    public enum Decades
    {
        Sixies,
        Seventies,
        Eighties,
        Ninties,
        Aughts,
        Teens,
        Twenties,
        Unknown
    }

    public class SongItem
    {
        public string SongTitle { get; set; }
        public string ArtistName { get; set; }
        public string AlbumName { get; set; }
        public string SongLength { get; set; }
        public MusicGenre Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Label { get; set; }
        public string ImageFile { get; set; }
        public string AudioFile { get; set; }

     /*   public SongItem(string songTitle, string artist, string albumName, string songLength, MusicGenre genre, DateTime releaseDate, string label)
        {
            SongTitle = songTitle;
            
            ArtistName = artist; 
            AlbumName = albumName;
            SongLength = songLength;
            Genre = genre;
            ReleaseDate = releaseDate;
            Label = label;
            ImageFile = $"/Assets/Image/MusicLibrary/{Genre}/{SongTitle}.png";
            AudioFile = $"/Assets/Audio/{Genre}/{SongTitle}.mp3";
        }
     */
        public SongItem (string name, string artist, string albumName, MusicGenre genre)
        {
            SongTitle = name;
            ArtistName = artist;
            AlbumName = albumName;
            Genre = genre;
            ImageFile = $"/Assets/Images/MusicNote.png";
            AudioFile = $"/Assets/Audio/{Genre}/{SongTitle}.mp3";

        }
    }
}