﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hurricane.Music
{
    class TrackComparer : IEqualityComparer<Track>
    {
        public bool Equals(Track x, Track y)
        {
            if (x == null || y == null || !x.TrackExists || !y.TrackExists) return false; //would crash if it needs to compute the hash
            return (x.TrackInformations.Length == y.TrackInformations.Length && Utilities.GeneralHelper.FileToMD5Hash(x.TrackInformations.FullName) == Utilities.GeneralHelper.FileToMD5Hash(y.TrackInformations.FullName));
        }

        public int GetHashCode(Track track)
        {
            //Check whether the object is null 
            if (Object.ReferenceEquals(track, null)) return 0;

            //Get hash code for the Title field if it is not null. 
            int hashProductName = track.Title == null ? 0 : track.Title.GetHashCode();

            //Get hash code for the Duration field. 
            int hashProductCode = track.Duration.GetHashCode();

            //Calculate the hash code for the product. 
            return hashProductName ^ hashProductCode;
        }
    }
}