﻿using Hurricane.ViewModelBase;

namespace Hurricane.Music.Download
{
    public class DownloadEntry : PropertyChangedBase
    {
        private bool _isWaiting;
        public bool IsWaiting
        {
            get { return _isWaiting; }
            set
            {
                SetProperty(value, ref _isWaiting);
            }
        }
        
        private double _progress;
        public double Progress
        {
            get { return _progress; }
            set
            {
                SetProperty(value, ref _progress);
            }
        }

        public bool IsDownloaded { get; set; }
        public string DownloadUrl { get; set; }
        public string Filename { get; set; }
        public string Trackname { get; set; }
    }
}
