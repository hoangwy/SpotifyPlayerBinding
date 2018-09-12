using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Spotify.Sdk.Android.Player {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.spotify.sdk.android.player']/interface[@name='ConnectionStateCallback']"
	[Register ("com/spotify/sdk/android/player/ConnectionStateCallback", "", "Com.Spotify.Sdk.Android.Player.IConnectionStateCallbackInvoker")]
	public partial interface IConnectionStateCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/interface[@name='ConnectionStateCallback']/method[@name='onConnectionMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onConnectionMessage", "(Ljava/lang/String;)V", "GetOnConnectionMessage_Ljava_lang_String_Handler:Com.Spotify.Sdk.Android.Player.IConnectionStateCallbackInvoker, SpotifyLibraryBinding")]
		void OnConnectionMessage (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/interface[@name='ConnectionStateCallback']/method[@name='onLoggedIn' and count(parameter)=0]"
		[Register ("onLoggedIn", "()V", "GetOnLoggedInHandler:Com.Spotify.Sdk.Android.Player.IConnectionStateCallbackInvoker, SpotifyLibraryBinding")]
		void OnLoggedIn ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/interface[@name='ConnectionStateCallback']/method[@name='onLoggedOut' and count(parameter)=0]"
		[Register ("onLoggedOut", "()V", "GetOnLoggedOutHandler:Com.Spotify.Sdk.Android.Player.IConnectionStateCallbackInvoker, SpotifyLibraryBinding")]
		void OnLoggedOut ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/interface[@name='ConnectionStateCallback']/method[@name='onLoginFailed' and count(parameter)=1 and parameter[1][@type='com.spotify.sdk.android.player.Error']]"
		[Register ("onLoginFailed", "(Lcom/spotify/sdk/android/player/Error;)V", "GetOnLoginFailed_Lcom_spotify_sdk_android_player_Error_Handler:Com.Spotify.Sdk.Android.Player.IConnectionStateCallbackInvoker, SpotifyLibraryBinding")]
		void OnLoginFailed (global::Com.Spotify.Sdk.Android.Player.Error p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/interface[@name='ConnectionStateCallback']/method[@name='onTemporaryError' and count(parameter)=0]"
		[Register ("onTemporaryError", "()V", "GetOnTemporaryErrorHandler:Com.Spotify.Sdk.Android.Player.IConnectionStateCallbackInvoker, SpotifyLibraryBinding")]
		void OnTemporaryError ();

	}

	[global::Android.Runtime.Register ("com/spotify/sdk/android/player/ConnectionStateCallback", DoNotGenerateAcw=true)]
	internal class IConnectionStateCallbackInvoker : global::Java.Lang.Object, IConnectionStateCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/spotify/sdk/android/player/ConnectionStateCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IConnectionStateCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IConnectionStateCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConnectionStateCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.spotify.sdk.android.player.ConnectionStateCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConnectionStateCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onConnectionMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnConnectionMessage_Ljava_lang_String_Handler ()
		{
			if (cb_onConnectionMessage_Ljava_lang_String_ == null)
				cb_onConnectionMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConnectionMessage_Ljava_lang_String_);
			return cb_onConnectionMessage_Ljava_lang_String_;
		}

		static void n_OnConnectionMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Spotify.Sdk.Android.Player.IConnectionStateCallback __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IConnectionStateCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectionMessage (p0);
		}
#pragma warning restore 0169

		IntPtr id_onConnectionMessage_Ljava_lang_String_;
		public unsafe void OnConnectionMessage (string p0)
		{
			if (id_onConnectionMessage_Ljava_lang_String_ == IntPtr.Zero)
				id_onConnectionMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onConnectionMessage", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnectionMessage_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onLoggedIn;
#pragma warning disable 0169
		static Delegate GetOnLoggedInHandler ()
		{
			if (cb_onLoggedIn == null)
				cb_onLoggedIn = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnLoggedIn);
			return cb_onLoggedIn;
		}

		static void n_OnLoggedIn (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Sdk.Android.Player.IConnectionStateCallback __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IConnectionStateCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLoggedIn ();
		}
#pragma warning restore 0169

		IntPtr id_onLoggedIn;
		public unsafe void OnLoggedIn ()
		{
			if (id_onLoggedIn == IntPtr.Zero)
				id_onLoggedIn = JNIEnv.GetMethodID (class_ref, "onLoggedIn", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLoggedIn);
		}

		static Delegate cb_onLoggedOut;
#pragma warning disable 0169
		static Delegate GetOnLoggedOutHandler ()
		{
			if (cb_onLoggedOut == null)
				cb_onLoggedOut = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnLoggedOut);
			return cb_onLoggedOut;
		}

		static void n_OnLoggedOut (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Sdk.Android.Player.IConnectionStateCallback __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IConnectionStateCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLoggedOut ();
		}
#pragma warning restore 0169

		IntPtr id_onLoggedOut;
		public unsafe void OnLoggedOut ()
		{
			if (id_onLoggedOut == IntPtr.Zero)
				id_onLoggedOut = JNIEnv.GetMethodID (class_ref, "onLoggedOut", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLoggedOut);
		}

		static Delegate cb_onLoginFailed_Lcom_spotify_sdk_android_player_Error_;
#pragma warning disable 0169
		static Delegate GetOnLoginFailed_Lcom_spotify_sdk_android_player_Error_Handler ()
		{
			if (cb_onLoginFailed_Lcom_spotify_sdk_android_player_Error_ == null)
				cb_onLoginFailed_Lcom_spotify_sdk_android_player_Error_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLoginFailed_Lcom_spotify_sdk_android_player_Error_);
			return cb_onLoginFailed_Lcom_spotify_sdk_android_player_Error_;
		}

		static void n_OnLoginFailed_Lcom_spotify_sdk_android_player_Error_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Spotify.Sdk.Android.Player.IConnectionStateCallback __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IConnectionStateCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Spotify.Sdk.Android.Player.Error p0 = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Error> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLoginFailed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onLoginFailed_Lcom_spotify_sdk_android_player_Error_;
		public unsafe void OnLoginFailed (global::Com.Spotify.Sdk.Android.Player.Error p0)
		{
			if (id_onLoginFailed_Lcom_spotify_sdk_android_player_Error_ == IntPtr.Zero)
				id_onLoginFailed_Lcom_spotify_sdk_android_player_Error_ = JNIEnv.GetMethodID (class_ref, "onLoginFailed", "(Lcom/spotify/sdk/android/player/Error;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLoginFailed_Lcom_spotify_sdk_android_player_Error_, __args);
		}

		static Delegate cb_onTemporaryError;
#pragma warning disable 0169
		static Delegate GetOnTemporaryErrorHandler ()
		{
			if (cb_onTemporaryError == null)
				cb_onTemporaryError = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnTemporaryError);
			return cb_onTemporaryError;
		}

		static void n_OnTemporaryError (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Sdk.Android.Player.IConnectionStateCallback __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IConnectionStateCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnTemporaryError ();
		}
#pragma warning restore 0169

		IntPtr id_onTemporaryError;
		public unsafe void OnTemporaryError ()
		{
			if (id_onTemporaryError == IntPtr.Zero)
				id_onTemporaryError = JNIEnv.GetMethodID (class_ref, "onTemporaryError", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTemporaryError);
		}

	}

}
