/// <summary>
/// Auto generated offsets for PUBG 
/// Extracted from https://github.com/TJ888/PUBG-SDK
/// </summary>

namespace Offsets
{
	public class UMediaPlayer
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnEndReached = 0x0030;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnMediaClosed = 0x0040;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnMediaOpened = 0x0050;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnMediaOpenFailed = 0x0060;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnPlaybackResumed = 0x0070;

		///<summary>FScriptMulticastDelegate</summary>
		public const int OnPlaybackSuspended = 0x0080;

		///<summary>FName</summary>
		public const int DesiredPlayerName = 0x0090;

		///<summary>bool</summary>
		public const int PlayOnOpen = 0x0098;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData01 = 0x0099;

		///<summary>unsigned char:1</summary>
		public const int Shuffle = 0x009C;

		///<summary>unsigned char:1</summary>
		public const int Loop = 0x009C;

		///<summary>unsigned char[0x3]</summary>
		public const int UnknownData02 = 0x009D;

		///<summary>UMediaPlaylist *</summary>
		public const int Playlist = 0x00A0;

		///<summary>int</summary>
		public const int PlaylistIndex = 0x00A8;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData03 = 0x00AC;

		///<summary>UMediaSoundWave *</summary>
		public const int SoundWave = 0x00B0;

		///<summary>UMediaTexture *</summary>
		public const int VideoTexture = 0x00B8;

		///<summary>unsigned char[0xA0]</summary>
		public const int UnknownData04 = 0x00C0;

	}

	public class UMediaPlaylist
	{
		///<summary>TArray<UMediaSource * ></summary>
		public const int Items = 0x0028;

	}

	public class UMediaSoundWave
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0260;

		///<summary>int</summary>
		public const int AudioTrackIndex = 0x0268;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData01 = 0x026C;

		///<summary>UMediaPlayer *</summary>
		public const int MediaPlayer = 0x0270;

		///<summary>unsigned char[0xC8]</summary>
		public const int UnknownData02 = 0x0278;

	}

	public class UMediaSource
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x0028;

		///<summary>FName</summary>
		public const int PlayerName = 0x0030;

	}

	public class UFileMediaSource
	{
		///<summary>FString</summary>
		public const int FilePath = 0x0038;

		///<summary>bool</summary>
		public const int PrecacheFile = 0x0048;

		///<summary>unsigned char[0x7]</summary>
		public const int UnknownData00 = 0x0049;

	}

	public class UPlatformMediaSource
	{
		///<summary>UMediaSource *</summary>
		public const int MediaSource = 0x0038;

	}

	public class UStreamMediaSource
	{
		///<summary>FString</summary>
		public const int StreamUrl = 0x0038;

	}

	public class UMediaSubtitles
	{
		///<summary>TArray<FMediaSubtitle></summary>
		public const int Subtitles = 0x0028;

	}

	public class UMediaTexture
	{
		///<summary>unsigned char[0x8]</summary>
		public const int UnknownData00 = 0x00C8;

		///<summary>TEnumAsByte<ETextureAddress></summary>
		public const int AddressX = 0x00D0;

		///<summary>TEnumAsByte<ETextureAddress></summary>
		public const int AddressY = 0x00D1;

		///<summary>unsigned char[0x2]</summary>
		public const int UnknownData01 = 0x00D2;

		///<summary>FLinearColor</summary>
		public const int ClearColor = 0x00D4;

		///<summary>unsigned char[0x4]</summary>
		public const int UnknownData02 = 0x00E4;

		///<summary>UMediaPlayer *</summary>
		public const int MediaPlayer = 0x00E8;

		///<summary>int</summary>
		public const int VideoTrackIndex = 0x00F0;

		///<summary>unsigned char[0xBC]</summary>
		public const int UnknownData03 = 0x00F4;

	}

}
