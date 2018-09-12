using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Spotify.Sdk.Android.Player {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.spotify.sdk.android.player']/interface[@name='Player.AudioDeliveredCallback']"
	[Register ("com/spotify/sdk/android/player/Player$AudioDeliveredCallback", "", "Com.Spotify.Sdk.Android.Player.IPlayerAudioDeliveredCallbackInvoker")]
	public partial interface IPlayerAudioDeliveredCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/interface[@name='Player.AudioDeliveredCallback']/method[@name='onAudioDelivered' and count(parameter)=4 and parameter[1][@type='short[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onAudioDelivered", "([SIII)I", "GetOnAudioDelivered_arraySIIIHandler:Com.Spotify.Sdk.Android.Player.IPlayerAudioDeliveredCallbackInvoker, SpotifyLibraryBinding")]
		int OnAudioDelivered (short[] p0, int p1, int p2, int p3);

	}

	[global::Android.Runtime.Register ("com/spotify/sdk/android/player/Player$AudioDeliveredCallback", DoNotGenerateAcw=true)]
	internal class IPlayerAudioDeliveredCallbackInvoker : global::Java.Lang.Object, IPlayerAudioDeliveredCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/spotify/sdk/android/player/Player$AudioDeliveredCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IPlayerAudioDeliveredCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IPlayerAudioDeliveredCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPlayerAudioDeliveredCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.spotify.sdk.android.player.Player.AudioDeliveredCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPlayerAudioDeliveredCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAudioDelivered_arraySIII;
#pragma warning disable 0169
		static Delegate GetOnAudioDelivered_arraySIIIHandler ()
		{
			if (cb_onAudioDelivered_arraySIII == null)
				cb_onAudioDelivered_arraySIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, int, int>) n_OnAudioDelivered_arraySIII);
			return cb_onAudioDelivered_arraySIII;
		}

		static int n_OnAudioDelivered_arraySIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3)
		{
			global::Com.Spotify.Sdk.Android.Player.IPlayerAudioDeliveredCallback __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IPlayerAudioDeliveredCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			short[] p0 = (short[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (short));
			int __ret = __this.OnAudioDelivered (p0, p1, p2, p3);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_onAudioDelivered_arraySIII;
		public unsafe int OnAudioDelivered (short[] p0, int p1, int p2, int p3)
		{
			if (id_onAudioDelivered_arraySIII == IntPtr.Zero)
				id_onAudioDelivered_arraySIII = JNIEnv.GetMethodID (class_ref, "onAudioDelivered", "([SIII)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_onAudioDelivered_arraySIII, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.spotify.sdk.android.player']/interface[@name='Player.AudioFlushCallback']"
	[Register ("com/spotify/sdk/android/player/Player$AudioFlushCallback", "", "Com.Spotify.Sdk.Android.Player.IPlayerAudioFlushCallbackInvoker")]
	public partial interface IPlayerAudioFlushCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/interface[@name='Player.AudioFlushCallback']/method[@name='onAudioFlush' and count(parameter)=0]"
		[Register ("onAudioFlush", "()V", "GetOnAudioFlushHandler:Com.Spotify.Sdk.Android.Player.IPlayerAudioFlushCallbackInvoker, SpotifyLibraryBinding")]
		void OnAudioFlush ();

	}

	[global::Android.Runtime.Register ("com/spotify/sdk/android/player/Player$AudioFlushCallback", DoNotGenerateAcw=true)]
	internal class IPlayerAudioFlushCallbackInvoker : global::Java.Lang.Object, IPlayerAudioFlushCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/spotify/sdk/android/player/Player$AudioFlushCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IPlayerAudioFlushCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IPlayerAudioFlushCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPlayerAudioFlushCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.spotify.sdk.android.player.Player.AudioFlushCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPlayerAudioFlushCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAudioFlush;
#pragma warning disable 0169
		static Delegate GetOnAudioFlushHandler ()
		{
			if (cb_onAudioFlush == null)
				cb_onAudioFlush = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnAudioFlush);
			return cb_onAudioFlush;
		}

		static void n_OnAudioFlush (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Sdk.Android.Player.IPlayerAudioFlushCallback __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IPlayerAudioFlushCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAudioFlush ();
		}
#pragma warning restore 0169

		IntPtr id_onAudioFlush;
		public unsafe void OnAudioFlush ()
		{
			if (id_onAudioFlush == IntPtr.Zero)
				id_onAudioFlush = JNIEnv.GetMethodID (class_ref, "onAudioFlush", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAudioFlush);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.spotify.sdk.android.player']/interface[@name='Player.NotificationCallback']"
	[Register ("com/spotify/sdk/android/player/Player$NotificationCallback", "", "Com.Spotify.Sdk.Android.Player.IPlayerNotificationCallbackInvoker")]
	public partial interface IPlayerNotificationCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/interface[@name='Player.NotificationCallback']/method[@name='onPlaybackError' and count(parameter)=1 and parameter[1][@type='com.spotify.sdk.android.player.Error']]"
		[Register ("onPlaybackError", "(Lcom/spotify/sdk/android/player/Error;)V", "GetOnPlaybackError_Lcom_spotify_sdk_android_player_Error_Handler:Com.Spotify.Sdk.Android.Player.IPlayerNotificationCallbackInvoker, SpotifyLibraryBinding")]
		void OnPlaybackError (global::Com.Spotify.Sdk.Android.Player.Error p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/interface[@name='Player.NotificationCallback']/method[@name='onPlaybackEvent' and count(parameter)=1 and parameter[1][@type='com.spotify.sdk.android.player.PlayerEvent']]"
		[Register ("onPlaybackEvent", "(Lcom/spotify/sdk/android/player/PlayerEvent;)V", "GetOnPlaybackEvent_Lcom_spotify_sdk_android_player_PlayerEvent_Handler:Com.Spotify.Sdk.Android.Player.IPlayerNotificationCallbackInvoker, SpotifyLibraryBinding")]
		void OnPlaybackEvent (global::Com.Spotify.Sdk.Android.Player.PlayerEvent p0);

	}

	[global::Android.Runtime.Register ("com/spotify/sdk/android/player/Player$NotificationCallback", DoNotGenerateAcw=true)]
	internal class IPlayerNotificationCallbackInvoker : global::Java.Lang.Object, IPlayerNotificationCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/spotify/sdk/android/player/Player$NotificationCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IPlayerNotificationCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IPlayerNotificationCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPlayerNotificationCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.spotify.sdk.android.player.Player.NotificationCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPlayerNotificationCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onPlaybackError_Lcom_spotify_sdk_android_player_Error_;
#pragma warning disable 0169
		static Delegate GetOnPlaybackError_Lcom_spotify_sdk_android_player_Error_Handler ()
		{
			if (cb_onPlaybackError_Lcom_spotify_sdk_android_player_Error_ == null)
				cb_onPlaybackError_Lcom_spotify_sdk_android_player_Error_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPlaybackError_Lcom_spotify_sdk_android_player_Error_);
			return cb_onPlaybackError_Lcom_spotify_sdk_android_player_Error_;
		}

		static void n_OnPlaybackError_Lcom_spotify_sdk_android_player_Error_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Spotify.Sdk.Android.Player.IPlayerNotificationCallback __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IPlayerNotificationCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Sdk.Android.Player.Error p0 = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Error> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPlaybackError (p0);
		}
#pragma warning restore 0169

		IntPtr id_onPlaybackError_Lcom_spotify_sdk_android_player_Error_;
		public unsafe void OnPlaybackError (global::Com.Spotify.Sdk.Android.Player.Error p0)
		{
			if (id_onPlaybackError_Lcom_spotify_sdk_android_player_Error_ == IntPtr.Zero)
				id_onPlaybackError_Lcom_spotify_sdk_android_player_Error_ = JNIEnv.GetMethodID (class_ref, "onPlaybackError", "(Lcom/spotify/sdk/android/player/Error;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPlaybackError_Lcom_spotify_sdk_android_player_Error_, __args);
		}

		static Delegate cb_onPlaybackEvent_Lcom_spotify_sdk_android_player_PlayerEvent_;
#pragma warning disable 0169
		static Delegate GetOnPlaybackEvent_Lcom_spotify_sdk_android_player_PlayerEvent_Handler ()
		{
			if (cb_onPlaybackEvent_Lcom_spotify_sdk_android_player_PlayerEvent_ == null)
				cb_onPlaybackEvent_Lcom_spotify_sdk_android_player_PlayerEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPlaybackEvent_Lcom_spotify_sdk_android_player_PlayerEvent_);
			return cb_onPlaybackEvent_Lcom_spotify_sdk_android_player_PlayerEvent_;
		}

		static void n_OnPlaybackEvent_Lcom_spotify_sdk_android_player_PlayerEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Spotify.Sdk.Android.Player.IPlayerNotificationCallback __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IPlayerNotificationCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Sdk.Android.Player.PlayerEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.PlayerEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPlaybackEvent (p0);
		}
#pragma warning restore 0169

		IntPtr id_onPlaybackEvent_Lcom_spotify_sdk_android_player_PlayerEvent_;
		public unsafe void OnPlaybackEvent (global::Com.Spotify.Sdk.Android.Player.PlayerEvent p0)
		{
			if (id_onPlaybackEvent_Lcom_spotify_sdk_android_player_PlayerEvent_ == IntPtr.Zero)
				id_onPlaybackEvent_Lcom_spotify_sdk_android_player_PlayerEvent_ = JNIEnv.GetMethodID (class_ref, "onPlaybackEvent", "(Lcom/spotify/sdk/android/player/PlayerEvent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPlaybackEvent_Lcom_spotify_sdk_android_player_PlayerEvent_, __args);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.spotify.sdk.android.player']/interface[@name='Player.OperationCallback']"
	[Register ("com/spotify/sdk/android/player/Player$OperationCallback", "", "Com.Spotify.Sdk.Android.Player.IPlayerOperationCallbackInvoker")]
	public partial interface IPlayerOperationCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/interface[@name='Player.OperationCallback']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.spotify.sdk.android.player.Error']]"
		[Register ("onError", "(Lcom/spotify/sdk/android/player/Error;)V", "GetOnError_Lcom_spotify_sdk_android_player_Error_Handler:Com.Spotify.Sdk.Android.Player.IPlayerOperationCallbackInvoker, SpotifyLibraryBinding")]
		void OnError (global::Com.Spotify.Sdk.Android.Player.Error p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/interface[@name='Player.OperationCallback']/method[@name='onSuccess' and count(parameter)=0]"
		[Register ("onSuccess", "()V", "GetOnSuccessHandler:Com.Spotify.Sdk.Android.Player.IPlayerOperationCallbackInvoker, SpotifyLibraryBinding")]
		void OnSuccess ();

	}

	[global::Android.Runtime.Register ("com/spotify/sdk/android/player/Player$OperationCallback", DoNotGenerateAcw=true)]
	internal class IPlayerOperationCallbackInvoker : global::Java.Lang.Object, IPlayerOperationCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/spotify/sdk/android/player/Player$OperationCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IPlayerOperationCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IPlayerOperationCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPlayerOperationCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.spotify.sdk.android.player.Player.OperationCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPlayerOperationCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onError_Lcom_spotify_sdk_android_player_Error_;
#pragma warning disable 0169
		static Delegate GetOnError_Lcom_spotify_sdk_android_player_Error_Handler ()
		{
			if (cb_onError_Lcom_spotify_sdk_android_player_Error_ == null)
				cb_onError_Lcom_spotify_sdk_android_player_Error_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnError_Lcom_spotify_sdk_android_player_Error_);
			return cb_onError_Lcom_spotify_sdk_android_player_Error_;
		}

		static void n_OnError_Lcom_spotify_sdk_android_player_Error_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Sdk.Android.Player.Error p0 = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Error> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		IntPtr id_onError_Lcom_spotify_sdk_android_player_Error_;
		public unsafe void OnError (global::Com.Spotify.Sdk.Android.Player.Error p0)
		{
			if (id_onError_Lcom_spotify_sdk_android_player_Error_ == IntPtr.Zero)
				id_onError_Lcom_spotify_sdk_android_player_Error_ = JNIEnv.GetMethodID (class_ref, "onError", "(Lcom/spotify/sdk/android/player/Error;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Lcom_spotify_sdk_android_player_Error_, __args);
		}

		static Delegate cb_onSuccess;
#pragma warning disable 0169
		static Delegate GetOnSuccessHandler ()
		{
			if (cb_onSuccess == null)
				cb_onSuccess = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnSuccess);
			return cb_onSuccess;
		}

		static void n_OnSuccess (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess ();
		}
#pragma warning restore 0169

		IntPtr id_onSuccess;
		public unsafe void OnSuccess ()
		{
			if (id_onSuccess == IntPtr.Zero)
				id_onSuccess = JNIEnv.GetMethodID (class_ref, "onSuccess", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.spotify.sdk.android.player']/interface[@name='Player']"
	[Register ("com/spotify/sdk/android/player/Player", "", "Com.Spotify.Sdk.Android.Player.IPlayerInvoker")]
	public partial interface IPlayer : IJavaObject {

		global::Com.Spotify.Sdk.Android.Player.Metadata Metadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/interface[@name='Player']/method[@name='getMetadata' and count(parameter)=0]"
			[Register ("getMetadata", "()Lcom/spotify/sdk/android/player/Metadata;", "GetGetMetadataHandler:Com.Spotify.Sdk.Android.Player.IPlayerInvoker, SpotifyLibraryBinding")] get;
		}

		global::Com.Spotify.Sdk.Android.Player.PlaybackState PlaybackState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/interface[@name='Player']/method[@name='getPlaybackState' and count(parameter)=0]"
			[Register ("getPlaybackState", "()Lcom/spotify/sdk/android/player/PlaybackState;", "GetGetPlaybackStateHandler:Com.Spotify.Sdk.Android.Player.IPlayerInvoker, SpotifyLibraryBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/interface[@name='Player']/method[@name='addConnectionStateCallback' and count(parameter)=1 and parameter[1][@type='com.spotify.sdk.android.player.ConnectionStateCallback']]"
		[Register ("addConnectionStateCallback", "(Lcom/spotify/sdk/android/player/ConnectionStateCallback;)Z", "GetAddConnectionStateCallback_Lcom_spotify_sdk_android_player_ConnectionStateCallback_Handler:Com.Spotify.Sdk.Android.Player.IPlayerInvoker, SpotifyLibraryBinding")]
		bool AddConnectionStateCallback (global::Com.Spotify.Sdk.Android.Player.IConnectionStateCallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/interface[@name='Player']/method[@name='addNotificationCallback' and count(parameter)=1 and parameter[1][@type='com.spotify.sdk.android.player.Player.NotificationCallback']]"
		[Register ("addNotificationCallback", "(Lcom/spotify/sdk/android/player/Player$NotificationCallback;)Z", "GetAddNotificationCallback_Lcom_spotify_sdk_android_player_Player_NotificationCallback_Handler:Com.Spotify.Sdk.Android.Player.IPlayerInvoker, SpotifyLibraryBinding")]
		bool AddNotificationCallback (global::Com.Spotify.Sdk.Android.Player.IPlayerNotificationCallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/interface[@name='Player']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler:Com.Spotify.Sdk.Android.Player.IPlayerInvoker, SpotifyLibraryBinding")]
		void Destroy ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/interface[@name='Player']/method[@name='initialize' and count(parameter)=1 and parameter[1][@type='com.spotify.sdk.android.player.Config']]"
		[Register ("initialize", "(Lcom/spotify/sdk/android/player/Config;)V", "GetInitialize_Lcom_spotify_sdk_android_player_Config_Handler:Com.Spotify.Sdk.Android.Player.IPlayerInvoker, SpotifyLibraryBinding")]
		void Initialize (global::Com.Spotify.Sdk.Android.Player.Config p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/interface[@name='Player']/method[@name='login' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("login", "(Ljava/lang/String;)Z", "GetLogin_Ljava_lang_String_Handler:Com.Spotify.Sdk.Android.Player.IPlayerInvoker, SpotifyLibraryBinding")]
		bool Login (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/interface[@name='Player']/method[@name='logout' and count(parameter)=0]"
		[Register ("logout", "()Z", "GetLogoutHandler:Com.Spotify.Sdk.Android.Player.IPlayerInvoker, SpotifyLibraryBinding")]
		bool Logout ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/interface[@name='Player']/method[@name='pause' and count(parameter)=1 and parameter[1][@type='com.spotify.sdk.android.player.Player.OperationCallback']]"
		[Register ("pause", "(Lcom/spotify/sdk/android/player/Player$OperationCallback;)V", "GetPause_Lcom_spotify_sdk_android_player_Player_OperationCallback_Handler:Com.Spotify.Sdk.Android.Player.IPlayerInvoker, SpotifyLibraryBinding")]
		void Pause (global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/interface[@name='Player']/method[@name='playUri' and count(parameter)=4 and parameter[1][@type='com.spotify.sdk.android.player.Player.OperationCallback'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("playUri", "(Lcom/spotify/sdk/android/player/Player$OperationCallback;Ljava/lang/String;II)V", "GetPlayUri_Lcom_spotify_sdk_android_player_Player_OperationCallback_Ljava_lang_String_IIHandler:Com.Spotify.Sdk.Android.Player.IPlayerInvoker, SpotifyLibraryBinding")]
		void PlayUri (global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback p0, string p1, int p2, int p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/interface[@name='Player']/method[@name='queue' and count(parameter)=2 and parameter[1][@type='com.spotify.sdk.android.player.Player.OperationCallback'] and parameter[2][@type='java.lang.String']]"
		[Register ("queue", "(Lcom/spotify/sdk/android/player/Player$OperationCallback;Ljava/lang/String;)V", "GetQueue_Lcom_spotify_sdk_android_player_Player_OperationCallback_Ljava_lang_String_Handler:Com.Spotify.Sdk.Android.Player.IPlayerInvoker, SpotifyLibraryBinding")]
		void Queue (global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/interface[@name='Player']/method[@name='refreshCache' and count(parameter)=0]"
		[Register ("refreshCache", "()V", "GetRefreshCacheHandler:Com.Spotify.Sdk.Android.Player.IPlayerInvoker, SpotifyLibraryBinding")]
		void RefreshCache ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/interface[@name='Player']/method[@name='removeConnectionStateCallback' and count(parameter)=1 and parameter[1][@type='com.spotify.sdk.android.player.ConnectionStateCallback']]"
		[Register ("removeConnectionStateCallback", "(Lcom/spotify/sdk/android/player/ConnectionStateCallback;)Z", "GetRemoveConnectionStateCallback_Lcom_spotify_sdk_android_player_ConnectionStateCallback_Handler:Com.Spotify.Sdk.Android.Player.IPlayerInvoker, SpotifyLibraryBinding")]
		bool RemoveConnectionStateCallback (global::Com.Spotify.Sdk.Android.Player.IConnectionStateCallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/interface[@name='Player']/method[@name='removeNotificationCallback' and count(parameter)=1 and parameter[1][@type='com.spotify.sdk.android.player.Player.NotificationCallback']]"
		[Register ("removeNotificationCallback", "(Lcom/spotify/sdk/android/player/Player$NotificationCallback;)Z", "GetRemoveNotificationCallback_Lcom_spotify_sdk_android_player_Player_NotificationCallback_Handler:Com.Spotify.Sdk.Android.Player.IPlayerInvoker, SpotifyLibraryBinding")]
		bool RemoveNotificationCallback (global::Com.Spotify.Sdk.Android.Player.IPlayerNotificationCallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/interface[@name='Player']/method[@name='resume' and count(parameter)=1 and parameter[1][@type='com.spotify.sdk.android.player.Player.OperationCallback']]"
		[Register ("resume", "(Lcom/spotify/sdk/android/player/Player$OperationCallback;)V", "GetResume_Lcom_spotify_sdk_android_player_Player_OperationCallback_Handler:Com.Spotify.Sdk.Android.Player.IPlayerInvoker, SpotifyLibraryBinding")]
		void Resume (global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/interface[@name='Player']/method[@name='seekToPosition' and count(parameter)=2 and parameter[1][@type='com.spotify.sdk.android.player.Player.OperationCallback'] and parameter[2][@type='int']]"
		[Register ("seekToPosition", "(Lcom/spotify/sdk/android/player/Player$OperationCallback;I)V", "GetSeekToPosition_Lcom_spotify_sdk_android_player_Player_OperationCallback_IHandler:Com.Spotify.Sdk.Android.Player.IPlayerInvoker, SpotifyLibraryBinding")]
		void SeekToPosition (global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/interface[@name='Player']/method[@name='setConnectivityStatus' and count(parameter)=2 and parameter[1][@type='com.spotify.sdk.android.player.Player.OperationCallback'] and parameter[2][@type='com.spotify.sdk.android.player.Connectivity']]"
		[Register ("setConnectivityStatus", "(Lcom/spotify/sdk/android/player/Player$OperationCallback;Lcom/spotify/sdk/android/player/Connectivity;)V", "GetSetConnectivityStatus_Lcom_spotify_sdk_android_player_Player_OperationCallback_Lcom_spotify_sdk_android_player_Connectivity_Handler:Com.Spotify.Sdk.Android.Player.IPlayerInvoker, SpotifyLibraryBinding")]
		void SetConnectivityStatus (global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback p0, global::Com.Spotify.Sdk.Android.Player.Connectivity p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/interface[@name='Player']/method[@name='setPlaybackBitrate' and count(parameter)=2 and parameter[1][@type='com.spotify.sdk.android.player.Player.OperationCallback'] and parameter[2][@type='com.spotify.sdk.android.player.PlaybackBitrate']]"
		[Register ("setPlaybackBitrate", "(Lcom/spotify/sdk/android/player/Player$OperationCallback;Lcom/spotify/sdk/android/player/PlaybackBitrate;)V", "GetSetPlaybackBitrate_Lcom_spotify_sdk_android_player_Player_OperationCallback_Lcom_spotify_sdk_android_player_PlaybackBitrate_Handler:Com.Spotify.Sdk.Android.Player.IPlayerInvoker, SpotifyLibraryBinding")]
		void SetPlaybackBitrate (global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback p0, global::Com.Spotify.Sdk.Android.Player.PlaybackBitrate p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/interface[@name='Player']/method[@name='setRepeat' and count(parameter)=2 and parameter[1][@type='com.spotify.sdk.android.player.Player.OperationCallback'] and parameter[2][@type='boolean']]"
		[Register ("setRepeat", "(Lcom/spotify/sdk/android/player/Player$OperationCallback;Z)V", "GetSetRepeat_Lcom_spotify_sdk_android_player_Player_OperationCallback_ZHandler:Com.Spotify.Sdk.Android.Player.IPlayerInvoker, SpotifyLibraryBinding")]
		void SetRepeat (global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback p0, bool p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/interface[@name='Player']/method[@name='setShuffle' and count(parameter)=2 and parameter[1][@type='com.spotify.sdk.android.player.Player.OperationCallback'] and parameter[2][@type='boolean']]"
		[Register ("setShuffle", "(Lcom/spotify/sdk/android/player/Player$OperationCallback;Z)V", "GetSetShuffle_Lcom_spotify_sdk_android_player_Player_OperationCallback_ZHandler:Com.Spotify.Sdk.Android.Player.IPlayerInvoker, SpotifyLibraryBinding")]
		void SetShuffle (global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback p0, bool p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/interface[@name='Player']/method[@name='skipToNext' and count(parameter)=1 and parameter[1][@type='com.spotify.sdk.android.player.Player.OperationCallback']]"
		[Register ("skipToNext", "(Lcom/spotify/sdk/android/player/Player$OperationCallback;)V", "GetSkipToNext_Lcom_spotify_sdk_android_player_Player_OperationCallback_Handler:Com.Spotify.Sdk.Android.Player.IPlayerInvoker, SpotifyLibraryBinding")]
		void SkipToNext (global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/interface[@name='Player']/method[@name='skipToPrevious' and count(parameter)=1 and parameter[1][@type='com.spotify.sdk.android.player.Player.OperationCallback']]"
		[Register ("skipToPrevious", "(Lcom/spotify/sdk/android/player/Player$OperationCallback;)V", "GetSkipToPrevious_Lcom_spotify_sdk_android_player_Player_OperationCallback_Handler:Com.Spotify.Sdk.Android.Player.IPlayerInvoker, SpotifyLibraryBinding")]
		void SkipToPrevious (global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback p0);

	}

	[global::Android.Runtime.Register ("com/spotify/sdk/android/player/Player", DoNotGenerateAcw=true)]
	internal class IPlayerInvoker : global::Java.Lang.Object, IPlayer {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/spotify/sdk/android/player/Player");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IPlayerInvoker); }
		}

		IntPtr class_ref;

		public static IPlayer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPlayer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.spotify.sdk.android.player.Player"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPlayerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getMetadata;
#pragma warning disable 0169
		static Delegate GetGetMetadataHandler ()
		{
			if (cb_getMetadata == null)
				cb_getMetadata = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMetadata);
			return cb_getMetadata;
		}

		static IntPtr n_GetMetadata (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Sdk.Android.Player.IPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Metadata);
		}
#pragma warning restore 0169

		IntPtr id_getMetadata;
		public unsafe global::Com.Spotify.Sdk.Android.Player.Metadata Metadata {
			get {
				if (id_getMetadata == IntPtr.Zero)
					id_getMetadata = JNIEnv.GetMethodID (class_ref, "getMetadata", "()Lcom/spotify/sdk/android/player/Metadata;");
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Metadata> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMetadata), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPlaybackState;
#pragma warning disable 0169
		static Delegate GetGetPlaybackStateHandler ()
		{
			if (cb_getPlaybackState == null)
				cb_getPlaybackState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPlaybackState);
			return cb_getPlaybackState;
		}

		static IntPtr n_GetPlaybackState (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Sdk.Android.Player.IPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PlaybackState);
		}
#pragma warning restore 0169

		IntPtr id_getPlaybackState;
		public unsafe global::Com.Spotify.Sdk.Android.Player.PlaybackState PlaybackState {
			get {
				if (id_getPlaybackState == IntPtr.Zero)
					id_getPlaybackState = JNIEnv.GetMethodID (class_ref, "getPlaybackState", "()Lcom/spotify/sdk/android/player/PlaybackState;");
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.PlaybackState> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPlaybackState), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_addConnectionStateCallback_Lcom_spotify_sdk_android_player_ConnectionStateCallback_;
#pragma warning disable 0169
		static Delegate GetAddConnectionStateCallback_Lcom_spotify_sdk_android_player_ConnectionStateCallback_Handler ()
		{
			if (cb_addConnectionStateCallback_Lcom_spotify_sdk_android_player_ConnectionStateCallback_ == null)
				cb_addConnectionStateCallback_Lcom_spotify_sdk_android_player_ConnectionStateCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_AddConnectionStateCallback_Lcom_spotify_sdk_android_player_ConnectionStateCallback_);
			return cb_addConnectionStateCallback_Lcom_spotify_sdk_android_player_ConnectionStateCallback_;
		}

		static bool n_AddConnectionStateCallback_Lcom_spotify_sdk_android_player_ConnectionStateCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Spotify.Sdk.Android.Player.IPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Sdk.Android.Player.IConnectionStateCallback p0 = (global::Com.Spotify.Sdk.Android.Player.IConnectionStateCallback)global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IConnectionStateCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddConnectionStateCallback (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_addConnectionStateCallback_Lcom_spotify_sdk_android_player_ConnectionStateCallback_;
		public unsafe bool AddConnectionStateCallback (global::Com.Spotify.Sdk.Android.Player.IConnectionStateCallback p0)
		{
			if (id_addConnectionStateCallback_Lcom_spotify_sdk_android_player_ConnectionStateCallback_ == IntPtr.Zero)
				id_addConnectionStateCallback_Lcom_spotify_sdk_android_player_ConnectionStateCallback_ = JNIEnv.GetMethodID (class_ref, "addConnectionStateCallback", "(Lcom/spotify/sdk/android/player/ConnectionStateCallback;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_addConnectionStateCallback_Lcom_spotify_sdk_android_player_ConnectionStateCallback_, __args);
			return __ret;
		}

		static Delegate cb_addNotificationCallback_Lcom_spotify_sdk_android_player_Player_NotificationCallback_;
#pragma warning disable 0169
		static Delegate GetAddNotificationCallback_Lcom_spotify_sdk_android_player_Player_NotificationCallback_Handler ()
		{
			if (cb_addNotificationCallback_Lcom_spotify_sdk_android_player_Player_NotificationCallback_ == null)
				cb_addNotificationCallback_Lcom_spotify_sdk_android_player_Player_NotificationCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_AddNotificationCallback_Lcom_spotify_sdk_android_player_Player_NotificationCallback_);
			return cb_addNotificationCallback_Lcom_spotify_sdk_android_player_Player_NotificationCallback_;
		}

		static bool n_AddNotificationCallback_Lcom_spotify_sdk_android_player_Player_NotificationCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Spotify.Sdk.Android.Player.IPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Sdk.Android.Player.IPlayerNotificationCallback p0 = (global::Com.Spotify.Sdk.Android.Player.IPlayerNotificationCallback)global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IPlayerNotificationCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddNotificationCallback (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_addNotificationCallback_Lcom_spotify_sdk_android_player_Player_NotificationCallback_;
		public unsafe bool AddNotificationCallback (global::Com.Spotify.Sdk.Android.Player.IPlayerNotificationCallback p0)
		{
			if (id_addNotificationCallback_Lcom_spotify_sdk_android_player_Player_NotificationCallback_ == IntPtr.Zero)
				id_addNotificationCallback_Lcom_spotify_sdk_android_player_Player_NotificationCallback_ = JNIEnv.GetMethodID (class_ref, "addNotificationCallback", "(Lcom/spotify/sdk/android/player/Player$NotificationCallback;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_addNotificationCallback_Lcom_spotify_sdk_android_player_Player_NotificationCallback_, __args);
			return __ret;
		}

		static Delegate cb_destroy;
#pragma warning disable 0169
		static Delegate GetDestroyHandler ()
		{
			if (cb_destroy == null)
				cb_destroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Destroy);
			return cb_destroy;
		}

		static void n_Destroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Sdk.Android.Player.IPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		IntPtr id_destroy;
		public unsafe void Destroy ()
		{
			if (id_destroy == IntPtr.Zero)
				id_destroy = JNIEnv.GetMethodID (class_ref, "destroy", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_destroy);
		}

		static Delegate cb_initialize_Lcom_spotify_sdk_android_player_Config_;
#pragma warning disable 0169
		static Delegate GetInitialize_Lcom_spotify_sdk_android_player_Config_Handler ()
		{
			if (cb_initialize_Lcom_spotify_sdk_android_player_Config_ == null)
				cb_initialize_Lcom_spotify_sdk_android_player_Config_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Initialize_Lcom_spotify_sdk_android_player_Config_);
			return cb_initialize_Lcom_spotify_sdk_android_player_Config_;
		}

		static void n_Initialize_Lcom_spotify_sdk_android_player_Config_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Spotify.Sdk.Android.Player.IPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Sdk.Android.Player.Config p0 = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Config> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Initialize (p0);
		}
#pragma warning restore 0169

		IntPtr id_initialize_Lcom_spotify_sdk_android_player_Config_;
		public unsafe void Initialize (global::Com.Spotify.Sdk.Android.Player.Config p0)
		{
			if (id_initialize_Lcom_spotify_sdk_android_player_Config_ == IntPtr.Zero)
				id_initialize_Lcom_spotify_sdk_android_player_Config_ = JNIEnv.GetMethodID (class_ref, "initialize", "(Lcom/spotify/sdk/android/player/Config;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initialize_Lcom_spotify_sdk_android_player_Config_, __args);
		}

		static Delegate cb_login_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLogin_Ljava_lang_String_Handler ()
		{
			if (cb_login_Ljava_lang_String_ == null)
				cb_login_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Login_Ljava_lang_String_);
			return cb_login_Ljava_lang_String_;
		}

		static bool n_Login_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Spotify.Sdk.Android.Player.IPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Login (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_login_Ljava_lang_String_;
		public unsafe bool Login (string p0)
		{
			if (id_login_Ljava_lang_String_ == IntPtr.Zero)
				id_login_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "login", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_login_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_logout;
#pragma warning disable 0169
		static Delegate GetLogoutHandler ()
		{
			if (cb_logout == null)
				cb_logout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Logout);
			return cb_logout;
		}

		static bool n_Logout (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Sdk.Android.Player.IPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Logout ();
		}
#pragma warning restore 0169

		IntPtr id_logout;
		public unsafe bool Logout ()
		{
			if (id_logout == IntPtr.Zero)
				id_logout = JNIEnv.GetMethodID (class_ref, "logout", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_logout);
		}

		static Delegate cb_pause_Lcom_spotify_sdk_android_player_Player_OperationCallback_;
#pragma warning disable 0169
		static Delegate GetPause_Lcom_spotify_sdk_android_player_Player_OperationCallback_Handler ()
		{
			if (cb_pause_Lcom_spotify_sdk_android_player_Player_OperationCallback_ == null)
				cb_pause_Lcom_spotify_sdk_android_player_Player_OperationCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Pause_Lcom_spotify_sdk_android_player_Player_OperationCallback_);
			return cb_pause_Lcom_spotify_sdk_android_player_Player_OperationCallback_;
		}

		static void n_Pause_Lcom_spotify_sdk_android_player_Player_OperationCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Spotify.Sdk.Android.Player.IPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback p0 = (global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback)global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Pause (p0);
		}
#pragma warning restore 0169

		IntPtr id_pause_Lcom_spotify_sdk_android_player_Player_OperationCallback_;
		public unsafe void Pause (global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback p0)
		{
			if (id_pause_Lcom_spotify_sdk_android_player_Player_OperationCallback_ == IntPtr.Zero)
				id_pause_Lcom_spotify_sdk_android_player_Player_OperationCallback_ = JNIEnv.GetMethodID (class_ref, "pause", "(Lcom/spotify/sdk/android/player/Player$OperationCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pause_Lcom_spotify_sdk_android_player_Player_OperationCallback_, __args);
		}

		static Delegate cb_playUri_Lcom_spotify_sdk_android_player_Player_OperationCallback_Ljava_lang_String_II;
#pragma warning disable 0169
		static Delegate GetPlayUri_Lcom_spotify_sdk_android_player_Player_OperationCallback_Ljava_lang_String_IIHandler ()
		{
			if (cb_playUri_Lcom_spotify_sdk_android_player_Player_OperationCallback_Ljava_lang_String_II == null)
				cb_playUri_Lcom_spotify_sdk_android_player_Player_OperationCallback_Ljava_lang_String_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, int>) n_PlayUri_Lcom_spotify_sdk_android_player_Player_OperationCallback_Ljava_lang_String_II);
			return cb_playUri_Lcom_spotify_sdk_android_player_Player_OperationCallback_Ljava_lang_String_II;
		}

		static void n_PlayUri_Lcom_spotify_sdk_android_player_Player_OperationCallback_Ljava_lang_String_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3)
		{
			global::Com.Spotify.Sdk.Android.Player.IPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback p0 = (global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback)global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PlayUri (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_playUri_Lcom_spotify_sdk_android_player_Player_OperationCallback_Ljava_lang_String_II;
		public unsafe void PlayUri (global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback p0, string p1, int p2, int p3)
		{
			if (id_playUri_Lcom_spotify_sdk_android_player_Player_OperationCallback_Ljava_lang_String_II == IntPtr.Zero)
				id_playUri_Lcom_spotify_sdk_android_player_Player_OperationCallback_Ljava_lang_String_II = JNIEnv.GetMethodID (class_ref, "playUri", "(Lcom/spotify/sdk/android/player/Player$OperationCallback;Ljava/lang/String;II)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_playUri_Lcom_spotify_sdk_android_player_Player_OperationCallback_Ljava_lang_String_II, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_queue_Lcom_spotify_sdk_android_player_Player_OperationCallback_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetQueue_Lcom_spotify_sdk_android_player_Player_OperationCallback_Ljava_lang_String_Handler ()
		{
			if (cb_queue_Lcom_spotify_sdk_android_player_Player_OperationCallback_Ljava_lang_String_ == null)
				cb_queue_Lcom_spotify_sdk_android_player_Player_OperationCallback_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Queue_Lcom_spotify_sdk_android_player_Player_OperationCallback_Ljava_lang_String_);
			return cb_queue_Lcom_spotify_sdk_android_player_Player_OperationCallback_Ljava_lang_String_;
		}

		static void n_Queue_Lcom_spotify_sdk_android_player_Player_OperationCallback_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Spotify.Sdk.Android.Player.IPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback p0 = (global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback)global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Queue (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_queue_Lcom_spotify_sdk_android_player_Player_OperationCallback_Ljava_lang_String_;
		public unsafe void Queue (global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback p0, string p1)
		{
			if (id_queue_Lcom_spotify_sdk_android_player_Player_OperationCallback_Ljava_lang_String_ == IntPtr.Zero)
				id_queue_Lcom_spotify_sdk_android_player_Player_OperationCallback_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "queue", "(Lcom/spotify/sdk/android/player/Player$OperationCallback;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_queue_Lcom_spotify_sdk_android_player_Player_OperationCallback_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_refreshCache;
#pragma warning disable 0169
		static Delegate GetRefreshCacheHandler ()
		{
			if (cb_refreshCache == null)
				cb_refreshCache = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RefreshCache);
			return cb_refreshCache;
		}

		static void n_RefreshCache (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Sdk.Android.Player.IPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RefreshCache ();
		}
#pragma warning restore 0169

		IntPtr id_refreshCache;
		public unsafe void RefreshCache ()
		{
			if (id_refreshCache == IntPtr.Zero)
				id_refreshCache = JNIEnv.GetMethodID (class_ref, "refreshCache", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_refreshCache);
		}

		static Delegate cb_removeConnectionStateCallback_Lcom_spotify_sdk_android_player_ConnectionStateCallback_;
#pragma warning disable 0169
		static Delegate GetRemoveConnectionStateCallback_Lcom_spotify_sdk_android_player_ConnectionStateCallback_Handler ()
		{
			if (cb_removeConnectionStateCallback_Lcom_spotify_sdk_android_player_ConnectionStateCallback_ == null)
				cb_removeConnectionStateCallback_Lcom_spotify_sdk_android_player_ConnectionStateCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RemoveConnectionStateCallback_Lcom_spotify_sdk_android_player_ConnectionStateCallback_);
			return cb_removeConnectionStateCallback_Lcom_spotify_sdk_android_player_ConnectionStateCallback_;
		}

		static bool n_RemoveConnectionStateCallback_Lcom_spotify_sdk_android_player_ConnectionStateCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Spotify.Sdk.Android.Player.IPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Sdk.Android.Player.IConnectionStateCallback p0 = (global::Com.Spotify.Sdk.Android.Player.IConnectionStateCallback)global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IConnectionStateCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveConnectionStateCallback (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_removeConnectionStateCallback_Lcom_spotify_sdk_android_player_ConnectionStateCallback_;
		public unsafe bool RemoveConnectionStateCallback (global::Com.Spotify.Sdk.Android.Player.IConnectionStateCallback p0)
		{
			if (id_removeConnectionStateCallback_Lcom_spotify_sdk_android_player_ConnectionStateCallback_ == IntPtr.Zero)
				id_removeConnectionStateCallback_Lcom_spotify_sdk_android_player_ConnectionStateCallback_ = JNIEnv.GetMethodID (class_ref, "removeConnectionStateCallback", "(Lcom/spotify/sdk/android/player/ConnectionStateCallback;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_removeConnectionStateCallback_Lcom_spotify_sdk_android_player_ConnectionStateCallback_, __args);
			return __ret;
		}

		static Delegate cb_removeNotificationCallback_Lcom_spotify_sdk_android_player_Player_NotificationCallback_;
#pragma warning disable 0169
		static Delegate GetRemoveNotificationCallback_Lcom_spotify_sdk_android_player_Player_NotificationCallback_Handler ()
		{
			if (cb_removeNotificationCallback_Lcom_spotify_sdk_android_player_Player_NotificationCallback_ == null)
				cb_removeNotificationCallback_Lcom_spotify_sdk_android_player_Player_NotificationCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RemoveNotificationCallback_Lcom_spotify_sdk_android_player_Player_NotificationCallback_);
			return cb_removeNotificationCallback_Lcom_spotify_sdk_android_player_Player_NotificationCallback_;
		}

		static bool n_RemoveNotificationCallback_Lcom_spotify_sdk_android_player_Player_NotificationCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Spotify.Sdk.Android.Player.IPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Sdk.Android.Player.IPlayerNotificationCallback p0 = (global::Com.Spotify.Sdk.Android.Player.IPlayerNotificationCallback)global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IPlayerNotificationCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveNotificationCallback (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_removeNotificationCallback_Lcom_spotify_sdk_android_player_Player_NotificationCallback_;
		public unsafe bool RemoveNotificationCallback (global::Com.Spotify.Sdk.Android.Player.IPlayerNotificationCallback p0)
		{
			if (id_removeNotificationCallback_Lcom_spotify_sdk_android_player_Player_NotificationCallback_ == IntPtr.Zero)
				id_removeNotificationCallback_Lcom_spotify_sdk_android_player_Player_NotificationCallback_ = JNIEnv.GetMethodID (class_ref, "removeNotificationCallback", "(Lcom/spotify/sdk/android/player/Player$NotificationCallback;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_removeNotificationCallback_Lcom_spotify_sdk_android_player_Player_NotificationCallback_, __args);
			return __ret;
		}

		static Delegate cb_resume_Lcom_spotify_sdk_android_player_Player_OperationCallback_;
#pragma warning disable 0169
		static Delegate GetResume_Lcom_spotify_sdk_android_player_Player_OperationCallback_Handler ()
		{
			if (cb_resume_Lcom_spotify_sdk_android_player_Player_OperationCallback_ == null)
				cb_resume_Lcom_spotify_sdk_android_player_Player_OperationCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Resume_Lcom_spotify_sdk_android_player_Player_OperationCallback_);
			return cb_resume_Lcom_spotify_sdk_android_player_Player_OperationCallback_;
		}

		static void n_Resume_Lcom_spotify_sdk_android_player_Player_OperationCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Spotify.Sdk.Android.Player.IPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback p0 = (global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback)global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Resume (p0);
		}
#pragma warning restore 0169

		IntPtr id_resume_Lcom_spotify_sdk_android_player_Player_OperationCallback_;
		public unsafe void Resume (global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback p0)
		{
			if (id_resume_Lcom_spotify_sdk_android_player_Player_OperationCallback_ == IntPtr.Zero)
				id_resume_Lcom_spotify_sdk_android_player_Player_OperationCallback_ = JNIEnv.GetMethodID (class_ref, "resume", "(Lcom/spotify/sdk/android/player/Player$OperationCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resume_Lcom_spotify_sdk_android_player_Player_OperationCallback_, __args);
		}

		static Delegate cb_seekToPosition_Lcom_spotify_sdk_android_player_Player_OperationCallback_I;
#pragma warning disable 0169
		static Delegate GetSeekToPosition_Lcom_spotify_sdk_android_player_Player_OperationCallback_IHandler ()
		{
			if (cb_seekToPosition_Lcom_spotify_sdk_android_player_Player_OperationCallback_I == null)
				cb_seekToPosition_Lcom_spotify_sdk_android_player_Player_OperationCallback_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_SeekToPosition_Lcom_spotify_sdk_android_player_Player_OperationCallback_I);
			return cb_seekToPosition_Lcom_spotify_sdk_android_player_Player_OperationCallback_I;
		}

		static void n_SeekToPosition_Lcom_spotify_sdk_android_player_Player_OperationCallback_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Spotify.Sdk.Android.Player.IPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback p0 = (global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback)global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SeekToPosition (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_seekToPosition_Lcom_spotify_sdk_android_player_Player_OperationCallback_I;
		public unsafe void SeekToPosition (global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback p0, int p1)
		{
			if (id_seekToPosition_Lcom_spotify_sdk_android_player_Player_OperationCallback_I == IntPtr.Zero)
				id_seekToPosition_Lcom_spotify_sdk_android_player_Player_OperationCallback_I = JNIEnv.GetMethodID (class_ref, "seekToPosition", "(Lcom/spotify/sdk/android/player/Player$OperationCallback;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_seekToPosition_Lcom_spotify_sdk_android_player_Player_OperationCallback_I, __args);
		}

		static Delegate cb_setConnectivityStatus_Lcom_spotify_sdk_android_player_Player_OperationCallback_Lcom_spotify_sdk_android_player_Connectivity_;
#pragma warning disable 0169
		static Delegate GetSetConnectivityStatus_Lcom_spotify_sdk_android_player_Player_OperationCallback_Lcom_spotify_sdk_android_player_Connectivity_Handler ()
		{
			if (cb_setConnectivityStatus_Lcom_spotify_sdk_android_player_Player_OperationCallback_Lcom_spotify_sdk_android_player_Connectivity_ == null)
				cb_setConnectivityStatus_Lcom_spotify_sdk_android_player_Player_OperationCallback_Lcom_spotify_sdk_android_player_Connectivity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetConnectivityStatus_Lcom_spotify_sdk_android_player_Player_OperationCallback_Lcom_spotify_sdk_android_player_Connectivity_);
			return cb_setConnectivityStatus_Lcom_spotify_sdk_android_player_Player_OperationCallback_Lcom_spotify_sdk_android_player_Connectivity_;
		}

		static void n_SetConnectivityStatus_Lcom_spotify_sdk_android_player_Player_OperationCallback_Lcom_spotify_sdk_android_player_Connectivity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Spotify.Sdk.Android.Player.IPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback p0 = (global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback)global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Sdk.Android.Player.Connectivity p1 = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Connectivity> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetConnectivityStatus (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setConnectivityStatus_Lcom_spotify_sdk_android_player_Player_OperationCallback_Lcom_spotify_sdk_android_player_Connectivity_;
		public unsafe void SetConnectivityStatus (global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback p0, global::Com.Spotify.Sdk.Android.Player.Connectivity p1)
		{
			if (id_setConnectivityStatus_Lcom_spotify_sdk_android_player_Player_OperationCallback_Lcom_spotify_sdk_android_player_Connectivity_ == IntPtr.Zero)
				id_setConnectivityStatus_Lcom_spotify_sdk_android_player_Player_OperationCallback_Lcom_spotify_sdk_android_player_Connectivity_ = JNIEnv.GetMethodID (class_ref, "setConnectivityStatus", "(Lcom/spotify/sdk/android/player/Player$OperationCallback;Lcom/spotify/sdk/android/player/Connectivity;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setConnectivityStatus_Lcom_spotify_sdk_android_player_Player_OperationCallback_Lcom_spotify_sdk_android_player_Connectivity_, __args);
		}

		static Delegate cb_setPlaybackBitrate_Lcom_spotify_sdk_android_player_Player_OperationCallback_Lcom_spotify_sdk_android_player_PlaybackBitrate_;
#pragma warning disable 0169
		static Delegate GetSetPlaybackBitrate_Lcom_spotify_sdk_android_player_Player_OperationCallback_Lcom_spotify_sdk_android_player_PlaybackBitrate_Handler ()
		{
			if (cb_setPlaybackBitrate_Lcom_spotify_sdk_android_player_Player_OperationCallback_Lcom_spotify_sdk_android_player_PlaybackBitrate_ == null)
				cb_setPlaybackBitrate_Lcom_spotify_sdk_android_player_Player_OperationCallback_Lcom_spotify_sdk_android_player_PlaybackBitrate_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPlaybackBitrate_Lcom_spotify_sdk_android_player_Player_OperationCallback_Lcom_spotify_sdk_android_player_PlaybackBitrate_);
			return cb_setPlaybackBitrate_Lcom_spotify_sdk_android_player_Player_OperationCallback_Lcom_spotify_sdk_android_player_PlaybackBitrate_;
		}

		static void n_SetPlaybackBitrate_Lcom_spotify_sdk_android_player_Player_OperationCallback_Lcom_spotify_sdk_android_player_PlaybackBitrate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Spotify.Sdk.Android.Player.IPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback p0 = (global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback)global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Sdk.Android.Player.PlaybackBitrate p1 = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.PlaybackBitrate> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetPlaybackBitrate (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setPlaybackBitrate_Lcom_spotify_sdk_android_player_Player_OperationCallback_Lcom_spotify_sdk_android_player_PlaybackBitrate_;
		public unsafe void SetPlaybackBitrate (global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback p0, global::Com.Spotify.Sdk.Android.Player.PlaybackBitrate p1)
		{
			if (id_setPlaybackBitrate_Lcom_spotify_sdk_android_player_Player_OperationCallback_Lcom_spotify_sdk_android_player_PlaybackBitrate_ == IntPtr.Zero)
				id_setPlaybackBitrate_Lcom_spotify_sdk_android_player_Player_OperationCallback_Lcom_spotify_sdk_android_player_PlaybackBitrate_ = JNIEnv.GetMethodID (class_ref, "setPlaybackBitrate", "(Lcom/spotify/sdk/android/player/Player$OperationCallback;Lcom/spotify/sdk/android/player/PlaybackBitrate;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPlaybackBitrate_Lcom_spotify_sdk_android_player_Player_OperationCallback_Lcom_spotify_sdk_android_player_PlaybackBitrate_, __args);
		}

		static Delegate cb_setRepeat_Lcom_spotify_sdk_android_player_Player_OperationCallback_Z;
#pragma warning disable 0169
		static Delegate GetSetRepeat_Lcom_spotify_sdk_android_player_Player_OperationCallback_ZHandler ()
		{
			if (cb_setRepeat_Lcom_spotify_sdk_android_player_Player_OperationCallback_Z == null)
				cb_setRepeat_Lcom_spotify_sdk_android_player_Player_OperationCallback_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_SetRepeat_Lcom_spotify_sdk_android_player_Player_OperationCallback_Z);
			return cb_setRepeat_Lcom_spotify_sdk_android_player_Player_OperationCallback_Z;
		}

		static void n_SetRepeat_Lcom_spotify_sdk_android_player_Player_OperationCallback_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Spotify.Sdk.Android.Player.IPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback p0 = (global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback)global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetRepeat (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setRepeat_Lcom_spotify_sdk_android_player_Player_OperationCallback_Z;
		public unsafe void SetRepeat (global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback p0, bool p1)
		{
			if (id_setRepeat_Lcom_spotify_sdk_android_player_Player_OperationCallback_Z == IntPtr.Zero)
				id_setRepeat_Lcom_spotify_sdk_android_player_Player_OperationCallback_Z = JNIEnv.GetMethodID (class_ref, "setRepeat", "(Lcom/spotify/sdk/android/player/Player$OperationCallback;Z)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRepeat_Lcom_spotify_sdk_android_player_Player_OperationCallback_Z, __args);
		}

		static Delegate cb_setShuffle_Lcom_spotify_sdk_android_player_Player_OperationCallback_Z;
#pragma warning disable 0169
		static Delegate GetSetShuffle_Lcom_spotify_sdk_android_player_Player_OperationCallback_ZHandler ()
		{
			if (cb_setShuffle_Lcom_spotify_sdk_android_player_Player_OperationCallback_Z == null)
				cb_setShuffle_Lcom_spotify_sdk_android_player_Player_OperationCallback_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_SetShuffle_Lcom_spotify_sdk_android_player_Player_OperationCallback_Z);
			return cb_setShuffle_Lcom_spotify_sdk_android_player_Player_OperationCallback_Z;
		}

		static void n_SetShuffle_Lcom_spotify_sdk_android_player_Player_OperationCallback_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Spotify.Sdk.Android.Player.IPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback p0 = (global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback)global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetShuffle (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setShuffle_Lcom_spotify_sdk_android_player_Player_OperationCallback_Z;
		public unsafe void SetShuffle (global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback p0, bool p1)
		{
			if (id_setShuffle_Lcom_spotify_sdk_android_player_Player_OperationCallback_Z == IntPtr.Zero)
				id_setShuffle_Lcom_spotify_sdk_android_player_Player_OperationCallback_Z = JNIEnv.GetMethodID (class_ref, "setShuffle", "(Lcom/spotify/sdk/android/player/Player$OperationCallback;Z)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setShuffle_Lcom_spotify_sdk_android_player_Player_OperationCallback_Z, __args);
		}

		static Delegate cb_skipToNext_Lcom_spotify_sdk_android_player_Player_OperationCallback_;
#pragma warning disable 0169
		static Delegate GetSkipToNext_Lcom_spotify_sdk_android_player_Player_OperationCallback_Handler ()
		{
			if (cb_skipToNext_Lcom_spotify_sdk_android_player_Player_OperationCallback_ == null)
				cb_skipToNext_Lcom_spotify_sdk_android_player_Player_OperationCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SkipToNext_Lcom_spotify_sdk_android_player_Player_OperationCallback_);
			return cb_skipToNext_Lcom_spotify_sdk_android_player_Player_OperationCallback_;
		}

		static void n_SkipToNext_Lcom_spotify_sdk_android_player_Player_OperationCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Spotify.Sdk.Android.Player.IPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback p0 = (global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback)global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SkipToNext (p0);
		}
#pragma warning restore 0169

		IntPtr id_skipToNext_Lcom_spotify_sdk_android_player_Player_OperationCallback_;
		public unsafe void SkipToNext (global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback p0)
		{
			if (id_skipToNext_Lcom_spotify_sdk_android_player_Player_OperationCallback_ == IntPtr.Zero)
				id_skipToNext_Lcom_spotify_sdk_android_player_Player_OperationCallback_ = JNIEnv.GetMethodID (class_ref, "skipToNext", "(Lcom/spotify/sdk/android/player/Player$OperationCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_skipToNext_Lcom_spotify_sdk_android_player_Player_OperationCallback_, __args);
		}

		static Delegate cb_skipToPrevious_Lcom_spotify_sdk_android_player_Player_OperationCallback_;
#pragma warning disable 0169
		static Delegate GetSkipToPrevious_Lcom_spotify_sdk_android_player_Player_OperationCallback_Handler ()
		{
			if (cb_skipToPrevious_Lcom_spotify_sdk_android_player_Player_OperationCallback_ == null)
				cb_skipToPrevious_Lcom_spotify_sdk_android_player_Player_OperationCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SkipToPrevious_Lcom_spotify_sdk_android_player_Player_OperationCallback_);
			return cb_skipToPrevious_Lcom_spotify_sdk_android_player_Player_OperationCallback_;
		}

		static void n_SkipToPrevious_Lcom_spotify_sdk_android_player_Player_OperationCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Spotify.Sdk.Android.Player.IPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback p0 = (global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback)global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SkipToPrevious (p0);
		}
#pragma warning restore 0169

		IntPtr id_skipToPrevious_Lcom_spotify_sdk_android_player_Player_OperationCallback_;
		public unsafe void SkipToPrevious (global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback p0)
		{
			if (id_skipToPrevious_Lcom_spotify_sdk_android_player_Player_OperationCallback_ == IntPtr.Zero)
				id_skipToPrevious_Lcom_spotify_sdk_android_player_Player_OperationCallback_ = JNIEnv.GetMethodID (class_ref, "skipToPrevious", "(Lcom/spotify/sdk/android/player/Player$OperationCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_skipToPrevious_Lcom_spotify_sdk_android_player_Player_OperationCallback_, __args);
		}

	}

}
