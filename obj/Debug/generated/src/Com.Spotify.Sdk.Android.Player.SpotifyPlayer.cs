using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Spotify.Sdk.Android.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='SpotifyPlayer']"
	[global::Android.Runtime.Register ("com/spotify/sdk/android/player/SpotifyPlayer", DoNotGenerateAcw=true)]
	public sealed partial class SpotifyPlayer : global::Com.Spotify.Jni.NativeObject, global::Com.Spotify.Sdk.Android.Player.IPlayer {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='SpotifyPlayer.Builder']"
		[global::Android.Runtime.Register ("com/spotify/sdk/android/player/SpotifyPlayer$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/spotify/sdk/android/player/SpotifyPlayer$Builder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Builder); }
			}

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_spotify_sdk_android_player_Config_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='SpotifyPlayer.Builder']/constructor[@name='SpotifyPlayer.Builder' and count(parameter)=1 and parameter[1][@type='com.spotify.sdk.android.player.Config']]"
			[Register (".ctor", "(Lcom/spotify/sdk/android/player/Config;)V", "")]
			public unsafe Builder (global::Com.Spotify.Sdk.Android.Player.Config p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (Builder)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/spotify/sdk/android/player/Config;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/spotify/sdk/android/player/Config;)V", __args);
						return;
					}

					if (id_ctor_Lcom_spotify_sdk_android_player_Config_ == IntPtr.Zero)
						id_ctor_Lcom_spotify_sdk_android_player_Config_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/spotify/sdk/android/player/Config;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_spotify_sdk_android_player_Config_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_spotify_sdk_android_player_Config_, __args);
				} finally {
				}
			}

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='SpotifyPlayer.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/spotify/sdk/android/player/SpotifyPlayer;", "GetBuildHandler")]
			public virtual unsafe global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/spotify/sdk/android/player/SpotifyPlayer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Lcom/spotify/sdk/android/player/SpotifyPlayer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_build_Lcom_spotify_sdk_android_player_SpotifyPlayer_InitializationObserver_;
#pragma warning disable 0169
			static Delegate GetBuild_Lcom_spotify_sdk_android_player_SpotifyPlayer_InitializationObserver_Handler ()
			{
				if (cb_build_Lcom_spotify_sdk_android_player_SpotifyPlayer_InitializationObserver_ == null)
					cb_build_Lcom_spotify_sdk_android_player_SpotifyPlayer_InitializationObserver_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Build_Lcom_spotify_sdk_android_player_SpotifyPlayer_InitializationObserver_);
				return cb_build_Lcom_spotify_sdk_android_player_SpotifyPlayer_InitializationObserver_;
			}

			static IntPtr n_Build_Lcom_spotify_sdk_android_player_SpotifyPlayer_InitializationObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer.IInitializationObserver p0 = (global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer.IInitializationObserver)global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer.IInitializationObserver> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Build (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_build_Lcom_spotify_sdk_android_player_SpotifyPlayer_InitializationObserver_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='SpotifyPlayer.Builder']/method[@name='build' and count(parameter)=1 and parameter[1][@type='com.spotify.sdk.android.player.SpotifyPlayer.InitializationObserver']]"
			[Register ("build", "(Lcom/spotify/sdk/android/player/SpotifyPlayer$InitializationObserver;)Lcom/spotify/sdk/android/player/SpotifyPlayer;", "GetBuild_Lcom_spotify_sdk_android_player_SpotifyPlayer_InitializationObserver_Handler")]
			public virtual unsafe global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer Build (global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer.IInitializationObserver p0)
			{
				if (id_build_Lcom_spotify_sdk_android_player_SpotifyPlayer_InitializationObserver_ == IntPtr.Zero)
					id_build_Lcom_spotify_sdk_android_player_SpotifyPlayer_InitializationObserver_ = JNIEnv.GetMethodID (class_ref, "build", "(Lcom/spotify/sdk/android/player/SpotifyPlayer$InitializationObserver;)Lcom/spotify/sdk/android/player/SpotifyPlayer;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build_Lcom_spotify_sdk_android_player_SpotifyPlayer_InitializationObserver_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "(Lcom/spotify/sdk/android/player/SpotifyPlayer$InitializationObserver;)Lcom/spotify/sdk/android/player/SpotifyPlayer;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setAudioController_Lcom_spotify_sdk_android_player_AudioController_;
#pragma warning disable 0169
			static Delegate GetSetAudioController_Lcom_spotify_sdk_android_player_AudioController_Handler ()
			{
				if (cb_setAudioController_Lcom_spotify_sdk_android_player_AudioController_ == null)
					cb_setAudioController_Lcom_spotify_sdk_android_player_AudioController_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAudioController_Lcom_spotify_sdk_android_player_AudioController_);
				return cb_setAudioController_Lcom_spotify_sdk_android_player_AudioController_;
			}

			static IntPtr n_SetAudioController_Lcom_spotify_sdk_android_player_AudioController_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Spotify.Sdk.Android.Player.IAudioController p0 = (global::Com.Spotify.Sdk.Android.Player.IAudioController)global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.IAudioController> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAudioController (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setAudioController_Lcom_spotify_sdk_android_player_AudioController_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='SpotifyPlayer.Builder']/method[@name='setAudioController' and count(parameter)=1 and parameter[1][@type='com.spotify.sdk.android.player.AudioController']]"
			[Register ("setAudioController", "(Lcom/spotify/sdk/android/player/AudioController;)Lcom/spotify/sdk/android/player/SpotifyPlayer$Builder;", "GetSetAudioController_Lcom_spotify_sdk_android_player_AudioController_Handler")]
			public virtual unsafe global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer.Builder SetAudioController (global::Com.Spotify.Sdk.Android.Player.IAudioController p0)
			{
				if (id_setAudioController_Lcom_spotify_sdk_android_player_AudioController_ == IntPtr.Zero)
					id_setAudioController_Lcom_spotify_sdk_android_player_AudioController_ = JNIEnv.GetMethodID (class_ref, "setAudioController", "(Lcom/spotify/sdk/android/player/AudioController;)Lcom/spotify/sdk/android/player/SpotifyPlayer$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setAudioController_Lcom_spotify_sdk_android_player_AudioController_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAudioController", "(Lcom/spotify/sdk/android/player/AudioController;)Lcom/spotify/sdk/android/player/SpotifyPlayer$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setCallbackHandler_Landroid_os_Handler_;
#pragma warning disable 0169
			static Delegate GetSetCallbackHandler_Landroid_os_Handler_Handler ()
			{
				if (cb_setCallbackHandler_Landroid_os_Handler_ == null)
					cb_setCallbackHandler_Landroid_os_Handler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCallbackHandler_Landroid_os_Handler_);
				return cb_setCallbackHandler_Landroid_os_Handler_;
			}

			static IntPtr n_SetCallbackHandler_Landroid_os_Handler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Handler p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCallbackHandler (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setCallbackHandler_Landroid_os_Handler_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='SpotifyPlayer.Builder']/method[@name='setCallbackHandler' and count(parameter)=1 and parameter[1][@type='android.os.Handler']]"
			[Register ("setCallbackHandler", "(Landroid/os/Handler;)Lcom/spotify/sdk/android/player/SpotifyPlayer$Builder;", "GetSetCallbackHandler_Landroid_os_Handler_Handler")]
			public virtual unsafe global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer.Builder SetCallbackHandler (global::Android.OS.Handler p0)
			{
				if (id_setCallbackHandler_Landroid_os_Handler_ == IntPtr.Zero)
					id_setCallbackHandler_Landroid_os_Handler_ = JNIEnv.GetMethodID (class_ref, "setCallbackHandler", "(Landroid/os/Handler;)Lcom/spotify/sdk/android/player/SpotifyPlayer$Builder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer.Builder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setCallbackHandler_Landroid_os_Handler_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCallbackHandler", "(Landroid/os/Handler;)Lcom/spotify/sdk/android/player/SpotifyPlayer$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='SpotifyPlayer.Command']"
		[global::Android.Runtime.Register ("com/spotify/sdk/android/player/SpotifyPlayer$Command", DoNotGenerateAcw=true)]
		public abstract partial class Command : global::Java.Lang.Object, global::Java.Util.Concurrent.ICallable {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/spotify/sdk/android/player/SpotifyPlayer$Command", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Command); }
			}

			protected Command (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_call;
#pragma warning disable 0169
			static Delegate GetCallHandler ()
			{
				if (cb_call == null)
					cb_call = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Call);
				return cb_call;
			}

			static IntPtr n_Call (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer.Command __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer.Command> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Call ());
			}
#pragma warning restore 0169

			[Register ("call", "()Ljava/lang/Object;", "GetCallHandler")]
			public abstract global::Java.Lang.Object Call ();

		}

		[global::Android.Runtime.Register ("com/spotify/sdk/android/player/SpotifyPlayer$Command", DoNotGenerateAcw=true)]
		internal partial class CommandInvoker : Command {

			public CommandInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (CommandInvoker); }
			}

			static IntPtr id_call;
			[Register ("call", "()Ljava/lang/Object;", "GetCallHandler")]
			public override unsafe global::Java.Lang.Object Call ()
			{
				if (id_call == IntPtr.Zero)
					id_call = JNIEnv.GetMethodID (class_ref, "call", "()Ljava/lang/Object;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_call), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.spotify.sdk.android.player']/interface[@name='SpotifyPlayer.InitializationObserver']"
		[Register ("com/spotify/sdk/android/player/SpotifyPlayer$InitializationObserver", "", "Com.Spotify.Sdk.Android.Player.SpotifyPlayer/IInitializationObserverInvoker")]
		public partial interface IInitializationObserver : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/interface[@name='SpotifyPlayer.InitializationObserver']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
			[Register ("onError", "(Ljava/lang/Throwable;)V", "GetOnError_Ljava_lang_Throwable_Handler:Com.Spotify.Sdk.Android.Player.SpotifyPlayer/IInitializationObserverInvoker, SpotifyLibraryBinding")]
			void OnError (global::Java.Lang.Throwable p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/interface[@name='SpotifyPlayer.InitializationObserver']/method[@name='onInitialized' and count(parameter)=1 and parameter[1][@type='com.spotify.sdk.android.player.SpotifyPlayer']]"
			[Register ("onInitialized", "(Lcom/spotify/sdk/android/player/SpotifyPlayer;)V", "GetOnInitialized_Lcom_spotify_sdk_android_player_SpotifyPlayer_Handler:Com.Spotify.Sdk.Android.Player.SpotifyPlayer/IInitializationObserverInvoker, SpotifyLibraryBinding")]
			void OnInitialized (global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer p0);

		}

		[global::Android.Runtime.Register ("com/spotify/sdk/android/player/SpotifyPlayer$InitializationObserver", DoNotGenerateAcw=true)]
		internal class IInitializationObserverInvoker : global::Java.Lang.Object, IInitializationObserver {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/spotify/sdk/android/player/SpotifyPlayer$InitializationObserver");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IInitializationObserverInvoker); }
			}

			IntPtr class_ref;

			public static IInitializationObserver GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IInitializationObserver> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.spotify.sdk.android.player.SpotifyPlayer.InitializationObserver"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IInitializationObserverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onError_Ljava_lang_Throwable_;
#pragma warning disable 0169
			static Delegate GetOnError_Ljava_lang_Throwable_Handler ()
			{
				if (cb_onError_Ljava_lang_Throwable_ == null)
					cb_onError_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnError_Ljava_lang_Throwable_);
				return cb_onError_Ljava_lang_Throwable_;
			}

			static void n_OnError_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer.IInitializationObserver __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer.IInitializationObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Throwable p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnError (p0);
			}
#pragma warning restore 0169

			IntPtr id_onError_Ljava_lang_Throwable_;
			public unsafe void OnError (global::Java.Lang.Throwable p0)
			{
				if (id_onError_Ljava_lang_Throwable_ == IntPtr.Zero)
					id_onError_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onError", "(Ljava/lang/Throwable;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Ljava_lang_Throwable_, __args);
			}

			static Delegate cb_onInitialized_Lcom_spotify_sdk_android_player_SpotifyPlayer_;
#pragma warning disable 0169
			static Delegate GetOnInitialized_Lcom_spotify_sdk_android_player_SpotifyPlayer_Handler ()
			{
				if (cb_onInitialized_Lcom_spotify_sdk_android_player_SpotifyPlayer_ == null)
					cb_onInitialized_Lcom_spotify_sdk_android_player_SpotifyPlayer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnInitialized_Lcom_spotify_sdk_android_player_SpotifyPlayer_);
				return cb_onInitialized_Lcom_spotify_sdk_android_player_SpotifyPlayer_;
			}

			static void n_OnInitialized_Lcom_spotify_sdk_android_player_SpotifyPlayer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer.IInitializationObserver __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer.IInitializationObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer p0 = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnInitialized (p0);
			}
#pragma warning restore 0169

			IntPtr id_onInitialized_Lcom_spotify_sdk_android_player_SpotifyPlayer_;
			public unsafe void OnInitialized (global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer p0)
			{
				if (id_onInitialized_Lcom_spotify_sdk_android_player_SpotifyPlayer_ == IntPtr.Zero)
					id_onInitialized_Lcom_spotify_sdk_android_player_SpotifyPlayer_ = JNIEnv.GetMethodID (class_ref, "onInitialized", "(Lcom/spotify/sdk/android/player/SpotifyPlayer;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInitialized_Lcom_spotify_sdk_android_player_SpotifyPlayer_, __args);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='SpotifyPlayer.InitializationState']"
		[global::Android.Runtime.Register ("com/spotify/sdk/android/player/SpotifyPlayer$InitializationState", DoNotGenerateAcw=true)]
		public sealed partial class InitializationState : global::Java.Lang.Enum {


			static IntPtr INITIALIZED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='SpotifyPlayer.InitializationState']/field[@name='INITIALIZED']"
			[Register ("INITIALIZED")]
			public static global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer.InitializationState Initialized {
				get {
					if (INITIALIZED_jfieldId == IntPtr.Zero)
						INITIALIZED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INITIALIZED", "Lcom/spotify/sdk/android/player/SpotifyPlayer$InitializationState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INITIALIZED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer.InitializationState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PENDING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='SpotifyPlayer.InitializationState']/field[@name='PENDING']"
			[Register ("PENDING")]
			public static global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer.InitializationState Pending {
				get {
					if (PENDING_jfieldId == IntPtr.Zero)
						PENDING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PENDING", "Lcom/spotify/sdk/android/player/SpotifyPlayer$InitializationState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PENDING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer.InitializationState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TERMINATED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='SpotifyPlayer.InitializationState']/field[@name='TERMINATED']"
			[Register ("TERMINATED")]
			public static global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer.InitializationState Terminated {
				get {
					if (TERMINATED_jfieldId == IntPtr.Zero)
						TERMINATED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TERMINATED", "Lcom/spotify/sdk/android/player/SpotifyPlayer$InitializationState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TERMINATED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer.InitializationState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/spotify/sdk/android/player/SpotifyPlayer$InitializationState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (InitializationState); }
			}

			internal InitializationState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/spotify/sdk/android/player/SpotifyPlayer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SpotifyPlayer); }
		}

		internal SpotifyPlayer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isInitialized;
		public unsafe bool IsInitialized {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='SpotifyPlayer']/method[@name='isInitialized' and count(parameter)=0]"
			[Register ("isInitialized", "()Z", "GetIsInitializedHandler")]
			get {
				if (id_isInitialized == IntPtr.Zero)
					id_isInitialized = JNIEnv.GetMethodID (class_ref, "isInitialized", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isInitialized);
				} finally {
				}
			}
		}

		static IntPtr id_isLoggedIn;
		public unsafe bool IsLoggedIn {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='SpotifyPlayer']/method[@name='isLoggedIn' and count(parameter)=0]"
			[Register ("isLoggedIn", "()Z", "GetIsLoggedInHandler")]
			get {
				if (id_isLoggedIn == IntPtr.Zero)
					id_isLoggedIn = JNIEnv.GetMethodID (class_ref, "isLoggedIn", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLoggedIn);
				} finally {
				}
			}
		}

		static IntPtr id_isShutdown;
		public unsafe bool IsShutdown {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='SpotifyPlayer']/method[@name='isShutdown' and count(parameter)=0]"
			[Register ("isShutdown", "()Z", "GetIsShutdownHandler")]
			get {
				if (id_isShutdown == IntPtr.Zero)
					id_isShutdown = JNIEnv.GetMethodID (class_ref, "isShutdown", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isShutdown);
				} finally {
				}
			}
		}

		static IntPtr id_isTerminated;
		public unsafe bool IsTerminated {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='SpotifyPlayer']/method[@name='isTerminated' and count(parameter)=0]"
			[Register ("isTerminated", "()Z", "GetIsTerminatedHandler")]
			get {
				if (id_isTerminated == IntPtr.Zero)
					id_isTerminated = JNIEnv.GetMethodID (class_ref, "isTerminated", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isTerminated);
				} finally {
				}
			}
		}

		static IntPtr id_getMetadata;
		public unsafe global::Com.Spotify.Sdk.Android.Player.Metadata Metadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='SpotifyPlayer']/method[@name='getMetadata' and count(parameter)=0]"
			[Register ("getMetadata", "()Lcom/spotify/sdk/android/player/Metadata;", "GetGetMetadataHandler")]
			get {
				if (id_getMetadata == IntPtr.Zero)
					id_getMetadata = JNIEnv.GetMethodID (class_ref, "getMetadata", "()Lcom/spotify/sdk/android/player/Metadata;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Metadata> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMetadata), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getPlaybackState;
		public unsafe global::Com.Spotify.Sdk.Android.Player.PlaybackState PlaybackState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='SpotifyPlayer']/method[@name='getPlaybackState' and count(parameter)=0]"
			[Register ("getPlaybackState", "()Lcom/spotify/sdk/android/player/PlaybackState;", "GetGetPlaybackStateHandler")]
			get {
				if (id_getPlaybackState == IntPtr.Zero)
					id_getPlaybackState = JNIEnv.GetMethodID (class_ref, "getPlaybackState", "()Lcom/spotify/sdk/android/player/PlaybackState;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.PlaybackState> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPlaybackState), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_addConnectionStateCallback_Lcom_spotify_sdk_android_player_ConnectionStateCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='SpotifyPlayer']/method[@name='addConnectionStateCallback' and count(parameter)=1 and parameter[1][@type='com.spotify.sdk.android.player.ConnectionStateCallback']]"
		[Register ("addConnectionStateCallback", "(Lcom/spotify/sdk/android/player/ConnectionStateCallback;)Z", "")]
		public unsafe bool AddConnectionStateCallback (global::Com.Spotify.Sdk.Android.Player.IConnectionStateCallback p0)
		{
			if (id_addConnectionStateCallback_Lcom_spotify_sdk_android_player_ConnectionStateCallback_ == IntPtr.Zero)
				id_addConnectionStateCallback_Lcom_spotify_sdk_android_player_ConnectionStateCallback_ = JNIEnv.GetMethodID (class_ref, "addConnectionStateCallback", "(Lcom/spotify/sdk/android/player/ConnectionStateCallback;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_addConnectionStateCallback_Lcom_spotify_sdk_android_player_ConnectionStateCallback_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_addNotificationCallback_Lcom_spotify_sdk_android_player_Player_NotificationCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='SpotifyPlayer']/method[@name='addNotificationCallback' and count(parameter)=1 and parameter[1][@type='com.spotify.sdk.android.player.Player.NotificationCallback']]"
		[Register ("addNotificationCallback", "(Lcom/spotify/sdk/android/player/Player$NotificationCallback;)Z", "")]
		public unsafe bool AddNotificationCallback (global::Com.Spotify.Sdk.Android.Player.IPlayerNotificationCallback p0)
		{
			if (id_addNotificationCallback_Lcom_spotify_sdk_android_player_Player_NotificationCallback_ == IntPtr.Zero)
				id_addNotificationCallback_Lcom_spotify_sdk_android_player_Player_NotificationCallback_ = JNIEnv.GetMethodID (class_ref, "addNotificationCallback", "(Lcom/spotify/sdk/android/player/Player$NotificationCallback;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_addNotificationCallback_Lcom_spotify_sdk_android_player_Player_NotificationCallback_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_create_Lcom_spotify_sdk_android_player_Config_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='SpotifyPlayer']/method[@name='create' and count(parameter)=1 and parameter[1][@type='com.spotify.sdk.android.player.Config']]"
		[Register ("create", "(Lcom/spotify/sdk/android/player/Config;)Lcom/spotify/sdk/android/player/SpotifyPlayer;", "")]
		public static unsafe global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer Create (global::Com.Spotify.Sdk.Android.Player.Config p0)
		{
			if (id_create_Lcom_spotify_sdk_android_player_Config_ == IntPtr.Zero)
				id_create_Lcom_spotify_sdk_android_player_Config_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Lcom/spotify/sdk/android/player/Config;)Lcom/spotify/sdk/android/player/SpotifyPlayer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer __ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Lcom_spotify_sdk_android_player_Config_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_create_Lcom_spotify_sdk_android_player_Config_Lcom_spotify_sdk_android_player_SpotifyPlayer_InitializationObserver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='SpotifyPlayer']/method[@name='create' and count(parameter)=2 and parameter[1][@type='com.spotify.sdk.android.player.Config'] and parameter[2][@type='com.spotify.sdk.android.player.SpotifyPlayer.InitializationObserver']]"
		[Register ("create", "(Lcom/spotify/sdk/android/player/Config;Lcom/spotify/sdk/android/player/SpotifyPlayer$InitializationObserver;)Lcom/spotify/sdk/android/player/SpotifyPlayer;", "")]
		public static unsafe global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer Create (global::Com.Spotify.Sdk.Android.Player.Config p0, global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer.IInitializationObserver p1)
		{
			if (id_create_Lcom_spotify_sdk_android_player_Config_Lcom_spotify_sdk_android_player_SpotifyPlayer_InitializationObserver_ == IntPtr.Zero)
				id_create_Lcom_spotify_sdk_android_player_Config_Lcom_spotify_sdk_android_player_SpotifyPlayer_InitializationObserver_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Lcom/spotify/sdk/android/player/Config;Lcom/spotify/sdk/android/player/SpotifyPlayer$InitializationObserver;)Lcom/spotify/sdk/android/player/SpotifyPlayer;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer __ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.SpotifyPlayer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Lcom_spotify_sdk_android_player_Config_Lcom_spotify_sdk_android_player_SpotifyPlayer_InitializationObserver_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='SpotifyPlayer']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "")]
		public override unsafe void Destroy ()
		{
			if (id_destroy == IntPtr.Zero)
				id_destroy = JNIEnv.GetMethodID (class_ref, "destroy", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_destroy);
			} finally {
			}
		}

		static IntPtr id_initialize_Lcom_spotify_sdk_android_player_Config_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='SpotifyPlayer']/method[@name='initialize' and count(parameter)=1 and parameter[1][@type='com.spotify.sdk.android.player.Config']]"
		[Register ("initialize", "(Lcom/spotify/sdk/android/player/Config;)V", "")]
		public unsafe void Initialize (global::Com.Spotify.Sdk.Android.Player.Config p0)
		{
			if (id_initialize_Lcom_spotify_sdk_android_player_Config_ == IntPtr.Zero)
				id_initialize_Lcom_spotify_sdk_android_player_Config_ = JNIEnv.GetMethodID (class_ref, "initialize", "(Lcom/spotify/sdk/android/player/Config;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initialize_Lcom_spotify_sdk_android_player_Config_, __args);
			} finally {
			}
		}

		static IntPtr id_login_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='SpotifyPlayer']/method[@name='login' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("login", "(Ljava/lang/String;)Z", "")]
		public unsafe bool Login (string p0)
		{
			if (id_login_Ljava_lang_String_ == IntPtr.Zero)
				id_login_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "login", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_login_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_logout;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='SpotifyPlayer']/method[@name='logout' and count(parameter)=0]"
		[Register ("logout", "()Z", "")]
		public unsafe bool Logout ()
		{
			if (id_logout == IntPtr.Zero)
				id_logout = JNIEnv.GetMethodID (class_ref, "logout", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_logout);
			} finally {
			}
		}

		static IntPtr id_onAudioDelivered_arraySIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='SpotifyPlayer']/method[@name='onAudioDelivered' and count(parameter)=4 and parameter[1][@type='short[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onAudioDelivered", "([SIII)I", "")]
		public unsafe int OnAudioDelivered (short[] p0, int p1, int p2, int p3)
		{
			if (id_onAudioDelivered_arraySIII == IntPtr.Zero)
				id_onAudioDelivered_arraySIII = JNIEnv.GetMethodID (class_ref, "onAudioDelivered", "([SIII)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_onAudioDelivered_arraySIII, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_onAudioFlush;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='SpotifyPlayer']/method[@name='onAudioFlush' and count(parameter)=0]"
		[Register ("onAudioFlush", "()V", "")]
		public unsafe void OnAudioFlush ()
		{
			if (id_onAudioFlush == IntPtr.Zero)
				id_onAudioFlush = JNIEnv.GetMethodID (class_ref, "onAudioFlush", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAudioFlush);
			} finally {
			}
		}

		static IntPtr id_pause_Lcom_spotify_sdk_android_player_Player_OperationCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='SpotifyPlayer']/method[@name='pause' and count(parameter)=1 and parameter[1][@type='com.spotify.sdk.android.player.Player.OperationCallback']]"
		[Register ("pause", "(Lcom/spotify/sdk/android/player/Player$OperationCallback;)V", "")]
		public unsafe void Pause (global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback p0)
		{
			if (id_pause_Lcom_spotify_sdk_android_player_Player_OperationCallback_ == IntPtr.Zero)
				id_pause_Lcom_spotify_sdk_android_player_Player_OperationCallback_ = JNIEnv.GetMethodID (class_ref, "pause", "(Lcom/spotify/sdk/android/player/Player$OperationCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pause_Lcom_spotify_sdk_android_player_Player_OperationCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_playUri_Lcom_spotify_sdk_android_player_Player_OperationCallback_Ljava_lang_String_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='SpotifyPlayer']/method[@name='playUri' and count(parameter)=4 and parameter[1][@type='com.spotify.sdk.android.player.Player.OperationCallback'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("playUri", "(Lcom/spotify/sdk/android/player/Player$OperationCallback;Ljava/lang/String;II)V", "")]
		public unsafe void PlayUri (global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback p0, string p1, int p2, int p3)
		{
			if (id_playUri_Lcom_spotify_sdk_android_player_Player_OperationCallback_Ljava_lang_String_II == IntPtr.Zero)
				id_playUri_Lcom_spotify_sdk_android_player_Player_OperationCallback_Ljava_lang_String_II = JNIEnv.GetMethodID (class_ref, "playUri", "(Lcom/spotify/sdk/android/player/Player$OperationCallback;Ljava/lang/String;II)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_playUri_Lcom_spotify_sdk_android_player_Player_OperationCallback_Ljava_lang_String_II, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_queue_Lcom_spotify_sdk_android_player_Player_OperationCallback_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='SpotifyPlayer']/method[@name='queue' and count(parameter)=2 and parameter[1][@type='com.spotify.sdk.android.player.Player.OperationCallback'] and parameter[2][@type='java.lang.String']]"
		[Register ("queue", "(Lcom/spotify/sdk/android/player/Player$OperationCallback;Ljava/lang/String;)V", "")]
		public unsafe void Queue (global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback p0, string p1)
		{
			if (id_queue_Lcom_spotify_sdk_android_player_Player_OperationCallback_Ljava_lang_String_ == IntPtr.Zero)
				id_queue_Lcom_spotify_sdk_android_player_Player_OperationCallback_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "queue", "(Lcom/spotify/sdk/android/player/Player$OperationCallback;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_queue_Lcom_spotify_sdk_android_player_Player_OperationCallback_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_refreshCache;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='SpotifyPlayer']/method[@name='refreshCache' and count(parameter)=0]"
		[Register ("refreshCache", "()V", "")]
		public unsafe void RefreshCache ()
		{
			if (id_refreshCache == IntPtr.Zero)
				id_refreshCache = JNIEnv.GetMethodID (class_ref, "refreshCache", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_refreshCache);
			} finally {
			}
		}

		static IntPtr id_removeConnectionStateCallback_Lcom_spotify_sdk_android_player_ConnectionStateCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='SpotifyPlayer']/method[@name='removeConnectionStateCallback' and count(parameter)=1 and parameter[1][@type='com.spotify.sdk.android.player.ConnectionStateCallback']]"
		[Register ("removeConnectionStateCallback", "(Lcom/spotify/sdk/android/player/ConnectionStateCallback;)Z", "")]
		public unsafe bool RemoveConnectionStateCallback (global::Com.Spotify.Sdk.Android.Player.IConnectionStateCallback p0)
		{
			if (id_removeConnectionStateCallback_Lcom_spotify_sdk_android_player_ConnectionStateCallback_ == IntPtr.Zero)
				id_removeConnectionStateCallback_Lcom_spotify_sdk_android_player_ConnectionStateCallback_ = JNIEnv.GetMethodID (class_ref, "removeConnectionStateCallback", "(Lcom/spotify/sdk/android/player/ConnectionStateCallback;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_removeConnectionStateCallback_Lcom_spotify_sdk_android_player_ConnectionStateCallback_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_removeNotificationCallback_Lcom_spotify_sdk_android_player_Player_NotificationCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='SpotifyPlayer']/method[@name='removeNotificationCallback' and count(parameter)=1 and parameter[1][@type='com.spotify.sdk.android.player.Player.NotificationCallback']]"
		[Register ("removeNotificationCallback", "(Lcom/spotify/sdk/android/player/Player$NotificationCallback;)Z", "")]
		public unsafe bool RemoveNotificationCallback (global::Com.Spotify.Sdk.Android.Player.IPlayerNotificationCallback p0)
		{
			if (id_removeNotificationCallback_Lcom_spotify_sdk_android_player_Player_NotificationCallback_ == IntPtr.Zero)
				id_removeNotificationCallback_Lcom_spotify_sdk_android_player_Player_NotificationCallback_ = JNIEnv.GetMethodID (class_ref, "removeNotificationCallback", "(Lcom/spotify/sdk/android/player/Player$NotificationCallback;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_removeNotificationCallback_Lcom_spotify_sdk_android_player_Player_NotificationCallback_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_resume_Lcom_spotify_sdk_android_player_Player_OperationCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='SpotifyPlayer']/method[@name='resume' and count(parameter)=1 and parameter[1][@type='com.spotify.sdk.android.player.Player.OperationCallback']]"
		[Register ("resume", "(Lcom/spotify/sdk/android/player/Player$OperationCallback;)V", "")]
		public unsafe void Resume (global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback p0)
		{
			if (id_resume_Lcom_spotify_sdk_android_player_Player_OperationCallback_ == IntPtr.Zero)
				id_resume_Lcom_spotify_sdk_android_player_Player_OperationCallback_ = JNIEnv.GetMethodID (class_ref, "resume", "(Lcom/spotify/sdk/android/player/Player$OperationCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resume_Lcom_spotify_sdk_android_player_Player_OperationCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_seekToPosition_Lcom_spotify_sdk_android_player_Player_OperationCallback_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='SpotifyPlayer']/method[@name='seekToPosition' and count(parameter)=2 and parameter[1][@type='com.spotify.sdk.android.player.Player.OperationCallback'] and parameter[2][@type='int']]"
		[Register ("seekToPosition", "(Lcom/spotify/sdk/android/player/Player$OperationCallback;I)V", "")]
		public unsafe void SeekToPosition (global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback p0, int p1)
		{
			if (id_seekToPosition_Lcom_spotify_sdk_android_player_Player_OperationCallback_I == IntPtr.Zero)
				id_seekToPosition_Lcom_spotify_sdk_android_player_Player_OperationCallback_I = JNIEnv.GetMethodID (class_ref, "seekToPosition", "(Lcom/spotify/sdk/android/player/Player$OperationCallback;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_seekToPosition_Lcom_spotify_sdk_android_player_Player_OperationCallback_I, __args);
			} finally {
			}
		}

		static IntPtr id_setConnectivityStatus_Lcom_spotify_sdk_android_player_Player_OperationCallback_Lcom_spotify_sdk_android_player_Connectivity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='SpotifyPlayer']/method[@name='setConnectivityStatus' and count(parameter)=2 and parameter[1][@type='com.spotify.sdk.android.player.Player.OperationCallback'] and parameter[2][@type='com.spotify.sdk.android.player.Connectivity']]"
		[Register ("setConnectivityStatus", "(Lcom/spotify/sdk/android/player/Player$OperationCallback;Lcom/spotify/sdk/android/player/Connectivity;)V", "")]
		public unsafe void SetConnectivityStatus (global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback p0, global::Com.Spotify.Sdk.Android.Player.Connectivity p1)
		{
			if (id_setConnectivityStatus_Lcom_spotify_sdk_android_player_Player_OperationCallback_Lcom_spotify_sdk_android_player_Connectivity_ == IntPtr.Zero)
				id_setConnectivityStatus_Lcom_spotify_sdk_android_player_Player_OperationCallback_Lcom_spotify_sdk_android_player_Connectivity_ = JNIEnv.GetMethodID (class_ref, "setConnectivityStatus", "(Lcom/spotify/sdk/android/player/Player$OperationCallback;Lcom/spotify/sdk/android/player/Connectivity;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setConnectivityStatus_Lcom_spotify_sdk_android_player_Player_OperationCallback_Lcom_spotify_sdk_android_player_Connectivity_, __args);
			} finally {
			}
		}

		static IntPtr id_setPlaybackBitrate_Lcom_spotify_sdk_android_player_Player_OperationCallback_Lcom_spotify_sdk_android_player_PlaybackBitrate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='SpotifyPlayer']/method[@name='setPlaybackBitrate' and count(parameter)=2 and parameter[1][@type='com.spotify.sdk.android.player.Player.OperationCallback'] and parameter[2][@type='com.spotify.sdk.android.player.PlaybackBitrate']]"
		[Register ("setPlaybackBitrate", "(Lcom/spotify/sdk/android/player/Player$OperationCallback;Lcom/spotify/sdk/android/player/PlaybackBitrate;)V", "")]
		public unsafe void SetPlaybackBitrate (global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback p0, global::Com.Spotify.Sdk.Android.Player.PlaybackBitrate p1)
		{
			if (id_setPlaybackBitrate_Lcom_spotify_sdk_android_player_Player_OperationCallback_Lcom_spotify_sdk_android_player_PlaybackBitrate_ == IntPtr.Zero)
				id_setPlaybackBitrate_Lcom_spotify_sdk_android_player_Player_OperationCallback_Lcom_spotify_sdk_android_player_PlaybackBitrate_ = JNIEnv.GetMethodID (class_ref, "setPlaybackBitrate", "(Lcom/spotify/sdk/android/player/Player$OperationCallback;Lcom/spotify/sdk/android/player/PlaybackBitrate;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPlaybackBitrate_Lcom_spotify_sdk_android_player_Player_OperationCallback_Lcom_spotify_sdk_android_player_PlaybackBitrate_, __args);
			} finally {
			}
		}

		static IntPtr id_setRepeat_Lcom_spotify_sdk_android_player_Player_OperationCallback_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='SpotifyPlayer']/method[@name='setRepeat' and count(parameter)=2 and parameter[1][@type='com.spotify.sdk.android.player.Player.OperationCallback'] and parameter[2][@type='boolean']]"
		[Register ("setRepeat", "(Lcom/spotify/sdk/android/player/Player$OperationCallback;Z)V", "")]
		public unsafe void SetRepeat (global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback p0, bool p1)
		{
			if (id_setRepeat_Lcom_spotify_sdk_android_player_Player_OperationCallback_Z == IntPtr.Zero)
				id_setRepeat_Lcom_spotify_sdk_android_player_Player_OperationCallback_Z = JNIEnv.GetMethodID (class_ref, "setRepeat", "(Lcom/spotify/sdk/android/player/Player$OperationCallback;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRepeat_Lcom_spotify_sdk_android_player_Player_OperationCallback_Z, __args);
			} finally {
			}
		}

		static IntPtr id_setShuffle_Lcom_spotify_sdk_android_player_Player_OperationCallback_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='SpotifyPlayer']/method[@name='setShuffle' and count(parameter)=2 and parameter[1][@type='com.spotify.sdk.android.player.Player.OperationCallback'] and parameter[2][@type='boolean']]"
		[Register ("setShuffle", "(Lcom/spotify/sdk/android/player/Player$OperationCallback;Z)V", "")]
		public unsafe void SetShuffle (global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback p0, bool p1)
		{
			if (id_setShuffle_Lcom_spotify_sdk_android_player_Player_OperationCallback_Z == IntPtr.Zero)
				id_setShuffle_Lcom_spotify_sdk_android_player_Player_OperationCallback_Z = JNIEnv.GetMethodID (class_ref, "setShuffle", "(Lcom/spotify/sdk/android/player/Player$OperationCallback;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setShuffle_Lcom_spotify_sdk_android_player_Player_OperationCallback_Z, __args);
			} finally {
			}
		}

		static IntPtr id_shutdown;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='SpotifyPlayer']/method[@name='shutdown' and count(parameter)=0]"
		[Register ("shutdown", "()V", "")]
		public unsafe void Shutdown ()
		{
			if (id_shutdown == IntPtr.Zero)
				id_shutdown = JNIEnv.GetMethodID (class_ref, "shutdown", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_shutdown);
			} finally {
			}
		}

		static IntPtr id_skipToNext_Lcom_spotify_sdk_android_player_Player_OperationCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='SpotifyPlayer']/method[@name='skipToNext' and count(parameter)=1 and parameter[1][@type='com.spotify.sdk.android.player.Player.OperationCallback']]"
		[Register ("skipToNext", "(Lcom/spotify/sdk/android/player/Player$OperationCallback;)V", "")]
		public unsafe void SkipToNext (global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback p0)
		{
			if (id_skipToNext_Lcom_spotify_sdk_android_player_Player_OperationCallback_ == IntPtr.Zero)
				id_skipToNext_Lcom_spotify_sdk_android_player_Player_OperationCallback_ = JNIEnv.GetMethodID (class_ref, "skipToNext", "(Lcom/spotify/sdk/android/player/Player$OperationCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_skipToNext_Lcom_spotify_sdk_android_player_Player_OperationCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_skipToPrevious_Lcom_spotify_sdk_android_player_Player_OperationCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='SpotifyPlayer']/method[@name='skipToPrevious' and count(parameter)=1 and parameter[1][@type='com.spotify.sdk.android.player.Player.OperationCallback']]"
		[Register ("skipToPrevious", "(Lcom/spotify/sdk/android/player/Player$OperationCallback;)V", "")]
		public unsafe void SkipToPrevious (global::Com.Spotify.Sdk.Android.Player.IPlayerOperationCallback p0)
		{
			if (id_skipToPrevious_Lcom_spotify_sdk_android_player_Player_OperationCallback_ == IntPtr.Zero)
				id_skipToPrevious_Lcom_spotify_sdk_android_player_Player_OperationCallback_ = JNIEnv.GetMethodID (class_ref, "skipToPrevious", "(Lcom/spotify/sdk/android/player/Player$OperationCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_skipToPrevious_Lcom_spotify_sdk_android_player_Player_OperationCallback_, __args);
			} finally {
			}
		}

	}
}
