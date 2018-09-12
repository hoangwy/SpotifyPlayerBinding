using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Spotify.Sdk.Android.Player {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.spotify.sdk.android.player']/interface[@name='AudioController']"
	[Register ("com/spotify/sdk/android/player/AudioController", "", "Com.Spotify.Sdk.Android.Player.IAudioControllerInvoker")]
	public partial interface IAudioController : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/interface[@name='AudioController']/method[@name='onAudioDataDelivered' and count(parameter)=4 and parameter[1][@type='short[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onAudioDataDelivered", "([SIII)I", "GetOnAudioDataDelivered_arraySIIIHandler:Com.Spotify.Sdk.Android.Player.IAudioControllerInvoker, SpotifyLibraryBinding")]
		int OnAudioDataDelivered (short[] p0, int p1, int p2, int p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/interface[@name='AudioController']/method[@name='onAudioFlush' and count(parameter)=0]"
		[Register ("onAudioFlush", "()V", "GetOnAudioFlushHandler:Com.Spotify.Sdk.Android.Player.IAudioControllerInvoker, SpotifyLibraryBinding")]
		void OnAudioFlush ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/interface[@name='AudioController']/method[@name='onAudioPaused' and count(parameter)=0]"
		[Register ("onAudioPaused", "()V", "GetOnAudioPausedHandler:Com.Spotify.Sdk.Android.Player.IAudioControllerInvoker, SpotifyLibraryBinding")]
		void OnAudioPaused ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/interface[@name='AudioController']/method[@name='onAudioResumed' and count(parameter)=0]"
		[Register ("onAudioResumed", "()V", "GetOnAudioResumedHandler:Com.Spotify.Sdk.Android.Player.IAudioControllerInvoker, SpotifyLibraryBinding")]
		void OnAudioResumed ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/interface[@name='AudioController']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler:Com.Spotify.Sdk.Android.Player.IAudioControllerInvoker, SpotifyLibraryBinding")]
		void Start ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/interface[@name='AudioController']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler:Com.Spotify.Sdk.Android.Player.IAudioControllerInvoker, SpotifyLibraryBinding")]
		void Stop ();

	}

	[global::Android.Runtime.Register ("com/spotify/sdk/android/player/AudioController", DoNotGenerateAcw=true)]
	internal class IAudioControllerInvoker : global::Java.Lang.Object, IAudioController {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/spotify/sdk/android/player/AudioController");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAudioControllerInvoker); }
		}

		IntPtr class_ref;

		public static IAudioController GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAudioController> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.spotify.sdk.android.player.AudioController"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAudioControllerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAudioDataDelivered_arraySIII;
#pragma warning disable 0169
		static Delegate GetOnAudioDataDelivered_arraySIIIHandler ()
		{
			if (cb_onAudioDataDelivered_arraySIII == null)
				cb_onAudioDataDelivered_arraySIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, int, int>) n_OnAudioDataDelivered_arraySIII);
			return cb_onAudioDataDelivered_arraySIII;
		}

		static int n_OnAudioDataDelivered_arraySIII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3)
		{
			global::Com.Spotify.Sdk.Android.Player.IAudioController __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IAudioController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			short[] p0 = (short[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (short));
			int __ret = __this.OnAudioDataDelivered (p0, p1, p2, p3);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_onAudioDataDelivered_arraySIII;
		public unsafe int OnAudioDataDelivered (short[] p0, int p1, int p2, int p3)
		{
			if (id_onAudioDataDelivered_arraySIII == IntPtr.Zero)
				id_onAudioDataDelivered_arraySIII = JNIEnv.GetMethodID (class_ref, "onAudioDataDelivered", "([SIII)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_onAudioDataDelivered_arraySIII, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
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
			global::Com.Spotify.Sdk.Android.Player.IAudioController __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IAudioController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_onAudioPaused;
#pragma warning disable 0169
		static Delegate GetOnAudioPausedHandler ()
		{
			if (cb_onAudioPaused == null)
				cb_onAudioPaused = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnAudioPaused);
			return cb_onAudioPaused;
		}

		static void n_OnAudioPaused (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Sdk.Android.Player.IAudioController __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IAudioController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAudioPaused ();
		}
#pragma warning restore 0169

		IntPtr id_onAudioPaused;
		public unsafe void OnAudioPaused ()
		{
			if (id_onAudioPaused == IntPtr.Zero)
				id_onAudioPaused = JNIEnv.GetMethodID (class_ref, "onAudioPaused", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAudioPaused);
		}

		static Delegate cb_onAudioResumed;
#pragma warning disable 0169
		static Delegate GetOnAudioResumedHandler ()
		{
			if (cb_onAudioResumed == null)
				cb_onAudioResumed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnAudioResumed);
			return cb_onAudioResumed;
		}

		static void n_OnAudioResumed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Sdk.Android.Player.IAudioController __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IAudioController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAudioResumed ();
		}
#pragma warning restore 0169

		IntPtr id_onAudioResumed;
		public unsafe void OnAudioResumed ()
		{
			if (id_onAudioResumed == IntPtr.Zero)
				id_onAudioResumed = JNIEnv.GetMethodID (class_ref, "onAudioResumed", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAudioResumed);
		}

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Sdk.Android.Player.IAudioController __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IAudioController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		IntPtr id_start;
		public unsafe void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_start);
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Sdk.Android.Player.IAudioController __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IAudioController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		IntPtr id_stop;
		public unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop);
		}

	}

}
