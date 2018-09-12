using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Spotify.Sdk.Android.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Spotify']"
	[global::Android.Runtime.Register ("com/spotify/sdk/android/player/Spotify", DoNotGenerateAcw=true)]
	public sealed partial class Spotify : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/spotify/sdk/android/player/Spotify", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Spotify); }
		}

		internal Spotify (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getReferenceCount;
		public static unsafe int ReferenceCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Spotify']/method[@name='getReferenceCount' and count(parameter)=0]"
			[Register ("getReferenceCount", "()I", "GetGetReferenceCountHandler")]
			get {
				if (id_getReferenceCount == IntPtr.Zero)
					id_getReferenceCount = JNIEnv.GetStaticMethodID (class_ref, "getReferenceCount", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getReferenceCount);
				} finally {
				}
			}
		}

		static IntPtr id_awaitDestroyPlayer_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Spotify']/method[@name='awaitDestroyPlayer' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='long'] and parameter[3][@type='java.util.concurrent.TimeUnit']]"
		[Register ("awaitDestroyPlayer", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z", "")]
		public static unsafe bool AwaitDestroyPlayer (global::Java.Lang.Object p0, long p1, global::Java.Util.Concurrent.TimeUnit p2)
		{
			if (id_awaitDestroyPlayer_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_awaitDestroyPlayer_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetStaticMethodID (class_ref, "awaitDestroyPlayer", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_awaitDestroyPlayer_Ljava_lang_Object_JLjava_util_concurrent_TimeUnit_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_destroyPlayer_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Spotify']/method[@name='destroyPlayer' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("destroyPlayer", "(Ljava/lang/Object;)V", "")]
		public static unsafe void DestroyPlayer (global::Java.Lang.Object p0)
		{
			if (id_destroyPlayer_Ljava_lang_Object_ == IntPtr.Zero)
				id_destroyPlayer_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "destroyPlayer", "(Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_destroyPlayer_Ljava_lang_Object_, __args);
			} finally {
			}
		}

		static IntPtr id_getPlayer_Lcom_spotify_sdk_android_player_Config_Ljava_lang_Object_Lcom_spotify_sdk_android_player_SpotifyPlayer_InitializationObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Spotify']/method[@name='getPlayer' and count(parameter)=3 and parameter[1][@type='com.spotify.sdk.android.player.Config'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='com.spotify.sdk.android.player.SpotifyPlayer.InitializationObserver']]"
		[Register ("getPlayer", "(Lcom/spotify/sdk/android/player/Config;Ljava/lang/Object;Lcom/spotify/sdk/android/player/SpotifyPlayer$InitializationObserver;)Lcom/spotify/sdk/android/player/SpotifyPlayer;", "")]
		public static unsafe global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer GetPlayer (global::Com.Spotify.Sdk.Android.Player.Config p0, global::Java.Lang.Object p1, global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer.IInitializationObserver p2)
		{
			if (id_getPlayer_Lcom_spotify_sdk_android_player_Config_Ljava_lang_Object_Lcom_spotify_sdk_android_player_SpotifyPlayer_InitializationObserver_ == IntPtr.Zero)
				id_getPlayer_Lcom_spotify_sdk_android_player_Config_Ljava_lang_Object_Lcom_spotify_sdk_android_player_SpotifyPlayer_InitializationObserver_ = JNIEnv.GetStaticMethodID (class_ref, "getPlayer", "(Lcom/spotify/sdk/android/player/Config;Ljava/lang/Object;Lcom/spotify/sdk/android/player/SpotifyPlayer$InitializationObserver;)Lcom/spotify/sdk/android/player/SpotifyPlayer;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer __ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPlayer_Lcom_spotify_sdk_android_player_Config_Ljava_lang_Object_Lcom_spotify_sdk_android_player_SpotifyPlayer_InitializationObserver_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getPlayer_Lcom_spotify_sdk_android_player_SpotifyPlayer_Builder_Ljava_lang_Object_Lcom_spotify_sdk_android_player_SpotifyPlayer_InitializationObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Spotify']/method[@name='getPlayer' and count(parameter)=3 and parameter[1][@type='com.spotify.sdk.android.player.SpotifyPlayer.Builder'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='com.spotify.sdk.android.player.SpotifyPlayer.InitializationObserver']]"
		[Register ("getPlayer", "(Lcom/spotify/sdk/android/player/SpotifyPlayer$Builder;Ljava/lang/Object;Lcom/spotify/sdk/android/player/SpotifyPlayer$InitializationObserver;)Lcom/spotify/sdk/android/player/SpotifyPlayer;", "")]
		public static unsafe global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer GetPlayer (global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer.Builder p0, global::Java.Lang.Object p1, global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer.IInitializationObserver p2)
		{
			if (id_getPlayer_Lcom_spotify_sdk_android_player_SpotifyPlayer_Builder_Ljava_lang_Object_Lcom_spotify_sdk_android_player_SpotifyPlayer_InitializationObserver_ == IntPtr.Zero)
				id_getPlayer_Lcom_spotify_sdk_android_player_SpotifyPlayer_Builder_Ljava_lang_Object_Lcom_spotify_sdk_android_player_SpotifyPlayer_InitializationObserver_ = JNIEnv.GetStaticMethodID (class_ref, "getPlayer", "(Lcom/spotify/sdk/android/player/SpotifyPlayer$Builder;Ljava/lang/Object;Lcom/spotify/sdk/android/player/SpotifyPlayer$InitializationObserver;)Lcom/spotify/sdk/android/player/SpotifyPlayer;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer __ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPlayer_Lcom_spotify_sdk_android_player_SpotifyPlayer_Builder_Ljava_lang_Object_Lcom_spotify_sdk_android_player_SpotifyPlayer_InitializationObserver_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
