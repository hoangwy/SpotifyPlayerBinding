using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Spotify.Sdk.Android.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='PlayerEvent']"
	[global::Android.Runtime.Register ("com/spotify/sdk/android/player/PlayerEvent", DoNotGenerateAcw=true)]
	public sealed partial class PlayerEvent : global::Java.Lang.Enum {


		static IntPtr UNKNOWN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='PlayerEvent']/field[@name='UNKNOWN']"
		[Register ("UNKNOWN")]
		public static global::Com.Spotify.Sdk.Android.Player.PlayerEvent Unknown {
			get {
				if (UNKNOWN_jfieldId == IntPtr.Zero)
					UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lcom/spotify/sdk/android/player/PlayerEvent;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.PlayerEvent> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr kSpPlaybackEventAudioFlush_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='PlayerEvent']/field[@name='kSpPlaybackEventAudioFlush']"
		[Register ("kSpPlaybackEventAudioFlush")]
		public static global::Com.Spotify.Sdk.Android.Player.PlayerEvent KSpPlaybackEventAudioFlush {
			get {
				if (kSpPlaybackEventAudioFlush_jfieldId == IntPtr.Zero)
					kSpPlaybackEventAudioFlush_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "kSpPlaybackEventAudioFlush", "Lcom/spotify/sdk/android/player/PlayerEvent;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, kSpPlaybackEventAudioFlush_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.PlayerEvent> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr kSpPlaybackNotifyAudioDeliveryDone_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='PlayerEvent']/field[@name='kSpPlaybackNotifyAudioDeliveryDone']"
		[Register ("kSpPlaybackNotifyAudioDeliveryDone")]
		public static global::Com.Spotify.Sdk.Android.Player.PlayerEvent KSpPlaybackNotifyAudioDeliveryDone {
			get {
				if (kSpPlaybackNotifyAudioDeliveryDone_jfieldId == IntPtr.Zero)
					kSpPlaybackNotifyAudioDeliveryDone_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "kSpPlaybackNotifyAudioDeliveryDone", "Lcom/spotify/sdk/android/player/PlayerEvent;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, kSpPlaybackNotifyAudioDeliveryDone_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.PlayerEvent> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr kSpPlaybackNotifyBecameActive_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='PlayerEvent']/field[@name='kSpPlaybackNotifyBecameActive']"
		[Register ("kSpPlaybackNotifyBecameActive")]
		public static global::Com.Spotify.Sdk.Android.Player.PlayerEvent KSpPlaybackNotifyBecameActive {
			get {
				if (kSpPlaybackNotifyBecameActive_jfieldId == IntPtr.Zero)
					kSpPlaybackNotifyBecameActive_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "kSpPlaybackNotifyBecameActive", "Lcom/spotify/sdk/android/player/PlayerEvent;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, kSpPlaybackNotifyBecameActive_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.PlayerEvent> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr kSpPlaybackNotifyBecameInactive_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='PlayerEvent']/field[@name='kSpPlaybackNotifyBecameInactive']"
		[Register ("kSpPlaybackNotifyBecameInactive")]
		public static global::Com.Spotify.Sdk.Android.Player.PlayerEvent KSpPlaybackNotifyBecameInactive {
			get {
				if (kSpPlaybackNotifyBecameInactive_jfieldId == IntPtr.Zero)
					kSpPlaybackNotifyBecameInactive_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "kSpPlaybackNotifyBecameInactive", "Lcom/spotify/sdk/android/player/PlayerEvent;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, kSpPlaybackNotifyBecameInactive_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.PlayerEvent> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr kSpPlaybackNotifyContextChanged_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='PlayerEvent']/field[@name='kSpPlaybackNotifyContextChanged']"
		[Register ("kSpPlaybackNotifyContextChanged")]
		public static global::Com.Spotify.Sdk.Android.Player.PlayerEvent KSpPlaybackNotifyContextChanged {
			get {
				if (kSpPlaybackNotifyContextChanged_jfieldId == IntPtr.Zero)
					kSpPlaybackNotifyContextChanged_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "kSpPlaybackNotifyContextChanged", "Lcom/spotify/sdk/android/player/PlayerEvent;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, kSpPlaybackNotifyContextChanged_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.PlayerEvent> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr kSpPlaybackNotifyLostPermission_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='PlayerEvent']/field[@name='kSpPlaybackNotifyLostPermission']"
		[Register ("kSpPlaybackNotifyLostPermission")]
		public static global::Com.Spotify.Sdk.Android.Player.PlayerEvent KSpPlaybackNotifyLostPermission {
			get {
				if (kSpPlaybackNotifyLostPermission_jfieldId == IntPtr.Zero)
					kSpPlaybackNotifyLostPermission_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "kSpPlaybackNotifyLostPermission", "Lcom/spotify/sdk/android/player/PlayerEvent;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, kSpPlaybackNotifyLostPermission_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.PlayerEvent> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr kSpPlaybackNotifyMetadataChanged_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='PlayerEvent']/field[@name='kSpPlaybackNotifyMetadataChanged']"
		[Register ("kSpPlaybackNotifyMetadataChanged")]
		public static global::Com.Spotify.Sdk.Android.Player.PlayerEvent KSpPlaybackNotifyMetadataChanged {
			get {
				if (kSpPlaybackNotifyMetadataChanged_jfieldId == IntPtr.Zero)
					kSpPlaybackNotifyMetadataChanged_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "kSpPlaybackNotifyMetadataChanged", "Lcom/spotify/sdk/android/player/PlayerEvent;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, kSpPlaybackNotifyMetadataChanged_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.PlayerEvent> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr kSpPlaybackNotifyNext_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='PlayerEvent']/field[@name='kSpPlaybackNotifyNext']"
		[Register ("kSpPlaybackNotifyNext")]
		public static global::Com.Spotify.Sdk.Android.Player.PlayerEvent KSpPlaybackNotifyNext {
			get {
				if (kSpPlaybackNotifyNext_jfieldId == IntPtr.Zero)
					kSpPlaybackNotifyNext_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "kSpPlaybackNotifyNext", "Lcom/spotify/sdk/android/player/PlayerEvent;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, kSpPlaybackNotifyNext_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.PlayerEvent> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr kSpPlaybackNotifyPause_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='PlayerEvent']/field[@name='kSpPlaybackNotifyPause']"
		[Register ("kSpPlaybackNotifyPause")]
		public static global::Com.Spotify.Sdk.Android.Player.PlayerEvent KSpPlaybackNotifyPause {
			get {
				if (kSpPlaybackNotifyPause_jfieldId == IntPtr.Zero)
					kSpPlaybackNotifyPause_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "kSpPlaybackNotifyPause", "Lcom/spotify/sdk/android/player/PlayerEvent;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, kSpPlaybackNotifyPause_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.PlayerEvent> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr kSpPlaybackNotifyPlay_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='PlayerEvent']/field[@name='kSpPlaybackNotifyPlay']"
		[Register ("kSpPlaybackNotifyPlay")]
		public static global::Com.Spotify.Sdk.Android.Player.PlayerEvent KSpPlaybackNotifyPlay {
			get {
				if (kSpPlaybackNotifyPlay_jfieldId == IntPtr.Zero)
					kSpPlaybackNotifyPlay_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "kSpPlaybackNotifyPlay", "Lcom/spotify/sdk/android/player/PlayerEvent;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, kSpPlaybackNotifyPlay_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.PlayerEvent> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr kSpPlaybackNotifyPrev_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='PlayerEvent']/field[@name='kSpPlaybackNotifyPrev']"
		[Register ("kSpPlaybackNotifyPrev")]
		public static global::Com.Spotify.Sdk.Android.Player.PlayerEvent KSpPlaybackNotifyPrev {
			get {
				if (kSpPlaybackNotifyPrev_jfieldId == IntPtr.Zero)
					kSpPlaybackNotifyPrev_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "kSpPlaybackNotifyPrev", "Lcom/spotify/sdk/android/player/PlayerEvent;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, kSpPlaybackNotifyPrev_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.PlayerEvent> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr kSpPlaybackNotifyRepeatOff_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='PlayerEvent']/field[@name='kSpPlaybackNotifyRepeatOff']"
		[Register ("kSpPlaybackNotifyRepeatOff")]
		public static global::Com.Spotify.Sdk.Android.Player.PlayerEvent KSpPlaybackNotifyRepeatOff {
			get {
				if (kSpPlaybackNotifyRepeatOff_jfieldId == IntPtr.Zero)
					kSpPlaybackNotifyRepeatOff_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "kSpPlaybackNotifyRepeatOff", "Lcom/spotify/sdk/android/player/PlayerEvent;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, kSpPlaybackNotifyRepeatOff_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.PlayerEvent> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr kSpPlaybackNotifyRepeatOn_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='PlayerEvent']/field[@name='kSpPlaybackNotifyRepeatOn']"
		[Register ("kSpPlaybackNotifyRepeatOn")]
		public static global::Com.Spotify.Sdk.Android.Player.PlayerEvent KSpPlaybackNotifyRepeatOn {
			get {
				if (kSpPlaybackNotifyRepeatOn_jfieldId == IntPtr.Zero)
					kSpPlaybackNotifyRepeatOn_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "kSpPlaybackNotifyRepeatOn", "Lcom/spotify/sdk/android/player/PlayerEvent;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, kSpPlaybackNotifyRepeatOn_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.PlayerEvent> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr kSpPlaybackNotifyShuffleOff_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='PlayerEvent']/field[@name='kSpPlaybackNotifyShuffleOff']"
		[Register ("kSpPlaybackNotifyShuffleOff")]
		public static global::Com.Spotify.Sdk.Android.Player.PlayerEvent KSpPlaybackNotifyShuffleOff {
			get {
				if (kSpPlaybackNotifyShuffleOff_jfieldId == IntPtr.Zero)
					kSpPlaybackNotifyShuffleOff_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "kSpPlaybackNotifyShuffleOff", "Lcom/spotify/sdk/android/player/PlayerEvent;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, kSpPlaybackNotifyShuffleOff_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.PlayerEvent> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr kSpPlaybackNotifyShuffleOn_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='PlayerEvent']/field[@name='kSpPlaybackNotifyShuffleOn']"
		[Register ("kSpPlaybackNotifyShuffleOn")]
		public static global::Com.Spotify.Sdk.Android.Player.PlayerEvent KSpPlaybackNotifyShuffleOn {
			get {
				if (kSpPlaybackNotifyShuffleOn_jfieldId == IntPtr.Zero)
					kSpPlaybackNotifyShuffleOn_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "kSpPlaybackNotifyShuffleOn", "Lcom/spotify/sdk/android/player/PlayerEvent;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, kSpPlaybackNotifyShuffleOn_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.PlayerEvent> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr kSpPlaybackNotifyTrackChanged_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='PlayerEvent']/field[@name='kSpPlaybackNotifyTrackChanged']"
		[Register ("kSpPlaybackNotifyTrackChanged")]
		public static global::Com.Spotify.Sdk.Android.Player.PlayerEvent KSpPlaybackNotifyTrackChanged {
			get {
				if (kSpPlaybackNotifyTrackChanged_jfieldId == IntPtr.Zero)
					kSpPlaybackNotifyTrackChanged_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "kSpPlaybackNotifyTrackChanged", "Lcom/spotify/sdk/android/player/PlayerEvent;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, kSpPlaybackNotifyTrackChanged_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.PlayerEvent> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr kSpPlaybackNotifyTrackDelivered_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='PlayerEvent']/field[@name='kSpPlaybackNotifyTrackDelivered']"
		[Register ("kSpPlaybackNotifyTrackDelivered")]
		public static global::Com.Spotify.Sdk.Android.Player.PlayerEvent KSpPlaybackNotifyTrackDelivered {
			get {
				if (kSpPlaybackNotifyTrackDelivered_jfieldId == IntPtr.Zero)
					kSpPlaybackNotifyTrackDelivered_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "kSpPlaybackNotifyTrackDelivered", "Lcom/spotify/sdk/android/player/PlayerEvent;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, kSpPlaybackNotifyTrackDelivered_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.PlayerEvent> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/spotify/sdk/android/player/PlayerEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PlayerEvent); }
		}

		internal PlayerEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='PlayerEvent']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/spotify/sdk/android/player/PlayerEvent;", "")]
		public static unsafe global::Com.Spotify.Sdk.Android.Player.PlayerEvent ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/spotify/sdk/android/player/PlayerEvent;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Spotify.Sdk.Android.Player.PlayerEvent __ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.PlayerEvent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='PlayerEvent']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/spotify/sdk/android/player/PlayerEvent;", "")]
		public static unsafe global::Com.Spotify.Sdk.Android.Player.PlayerEvent[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/spotify/sdk/android/player/PlayerEvent;");
			try {
				return (global::Com.Spotify.Sdk.Android.Player.PlayerEvent[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Spotify.Sdk.Android.Player.PlayerEvent));
			} finally {
			}
		}

	}
}
