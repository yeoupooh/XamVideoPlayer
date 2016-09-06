﻿using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Xam.Plugins.VideoPlayer.Sample.ViewModels
{
	[PropertyChanged.ImplementPropertyChanged]
	public class VideoPlayerViewModel
	{
		public VideoPlayerViewModel()
		{
			Videos = new ObservableCollection<VideoItem>();

			Videos.Add(new VideoItem { Title = "Big Buck Bunny", PlaybackUrl = "http://download.openbricks.org/sample/H264/big_buck_bunny_1080p_H264_AAC_25fps_7200K.MP4" });
			Videos.Add(new VideoItem
			{
				Title = "Dash MSE Test - Car",
				PlaybackUrl = "http://yt-dash-mse-test.commondatastorage.googleapis.com/media/car-20120827-87.mp4"
			});
			Videos.Add(new VideoItem
			{
				Title = "Consult",
				PlaybackUrl = "http://192.168.0.34/static/decoded-x264.mp4"
			});
		}

		public ICollection<VideoItem> Videos { get; set; }
		public VideoItem SelectedVideo { get; set; }
	}

	[PropertyChanged.ImplementPropertyChanged]
	public class VideoItem
	{
		public string Title { get; set; }
		public string PlaybackUrl { get; set; }
	}
}
