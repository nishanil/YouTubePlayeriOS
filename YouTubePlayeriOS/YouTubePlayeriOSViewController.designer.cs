// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using Foundation;
using UIKit;
using System.CodeDom.Compiler;

namespace YouTubePlayeriOS
{
	[Register ("YouTubePlayeriOSViewController")]
	partial class YouTubePlayeriOSViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIView MyPlayer { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton PauseButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton PlayButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel PlayerStatus { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton PlayListIdButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton SeekToButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField SeekToText { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton StopButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField TextPlayListId { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (MyPlayer != null) {
				MyPlayer.Dispose ();
				MyPlayer = null;
			}
			if (PauseButton != null) {
				PauseButton.Dispose ();
				PauseButton = null;
			}
			if (PlayButton != null) {
				PlayButton.Dispose ();
				PlayButton = null;
			}
			if (PlayerStatus != null) {
				PlayerStatus.Dispose ();
				PlayerStatus = null;
			}
			if (PlayListIdButton != null) {
				PlayListIdButton.Dispose ();
				PlayListIdButton = null;
			}
			if (SeekToButton != null) {
				SeekToButton.Dispose ();
				SeekToButton = null;
			}
			if (SeekToText != null) {
				SeekToText.Dispose ();
				SeekToText = null;
			}
			if (StopButton != null) {
				StopButton.Dispose ();
				StopButton = null;
			}
			if (TextPlayListId != null) {
				TextPlayListId.Dispose ();
				TextPlayListId = null;
			}
		}
	}
}
