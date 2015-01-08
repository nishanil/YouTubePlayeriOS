using System;
using System.Drawing;

using Foundation;
using UIKit;
using System.Collections.Generic;
using System.Diagnostics;
using YouTube;
namespace YouTubePlayeriOS
{
	public partial class YouTubePlayeriOSViewController : UIViewController
	{
		YouTubePlayer player;
		public YouTubePlayeriOSViewController (IntPtr handle) : base (handle)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		#region View lifecycle

	

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Add the player to our UIView's Sub View
			player = new YouTubePlayer (MyPlayer.Bounds);
			MyPlayer.AddSubview (player.PlayerView);

			Dictionary<string, object> playerVars = new Dictionary<string, object>{
			
				{"controls" , 1},
				{"playsinline" , 1},
				{"autohide" , 0},
				{"showinfo" , 1},
				{"modestbranding" , 0}
			};

			player.LoadWithPlaylistId ("PLM75ZaNQS_Fa-rPUZPdK9EejObe-AkkGz", playerVars);
			player.PlayerStateChanged += (object sender, PlayerState e) => {
				PlayerStatus.Text = e.ToString();
			};	

//			player.PlayerReceivedError += (object sender, PlayerError e) => new UIAlertView ("Error", e.ToString (), null, "Ok").Show ();

			PlayButton.TouchUpInside += (sender, e) => player.PlayVideo ();

			SeekToButton.TouchUpInside += (sender, e) => player.SeekTo(double.Parse(SeekToText.Text), true);

			StopButton.TouchUpInside += (sender, e) => player.StopVideo();
			PauseButton.TouchUpInside += (sender, e) => player.PauseVideo();

			PlayListIdButton.TouchUpInside += (sender, e) => {
				playerVars = new Dictionary<string, object>{

					{"controls" , 1},
					{"playsinline" , 1},
					{"autohide" , 0},
					{"showinfo" , 1},
					{"modestbranding" , 0}
				};
				player.LoadWithPlaylistId (TextPlayListId.Text, playerVars);
			};


			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}



		#endregion
	}
}

