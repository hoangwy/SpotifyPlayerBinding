using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Spotify.Sdk.Android.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='PlaybackBitrate']"
	[global::Android.Runtime.Register ("com/spotify/sdk/android/player/PlaybackBitrate", DoNotGenerateAcw=true)]
	public sealed partial class PlaybackBitrate : global::Java.Lang.Enum {


		static IntPtr BITRATE_HIGH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='PlaybackBitrate']/field[@name='BITRATE_HIGH']"
		[Register ("BITRATE_HIGH")]
		public static global::Com.Spotify.Sdk.Android.Player.PlaybackBitrate BitrateHigh {
			get {
				if (BITRATE_HIGH_jfieldId == IntPtr.Zero)
					BITRATE_HIGH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BITRATE_HIGH", "Lcom/spotify/sdk/android/player/PlaybackBitrate;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BITRATE_HIGH_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.PlaybackBitrate> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BITRATE_LOW_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='PlaybackBitrate']/field[@name='BITRATE_LOW']"
		[Register ("BITRATE_LOW")]
		public static global::Com.Spotify.Sdk.Android.Player.PlaybackBitrate BitrateLow {
			get {
				if (BITRATE_LOW_jfieldId == IntPtr.Zero)
					BITRATE_LOW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BITRATE_LOW", "Lcom/spotify/sdk/android/player/PlaybackBitrate;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BITRATE_LOW_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.PlaybackBitrate> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BITRATE_NORMAL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='PlaybackBitrate']/field[@name='BITRATE_NORMAL']"
		[Register ("BITRATE_NORMAL")]
		public static global::Com.Spotify.Sdk.Android.Player.PlaybackBitrate BitrateNormal {
			get {
				if (BITRATE_NORMAL_jfieldId == IntPtr.Zero)
					BITRATE_NORMAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BITRATE_NORMAL", "Lcom/spotify/sdk/android/player/PlaybackBitrate;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BITRATE_NORMAL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.PlaybackBitrate> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/spotify/sdk/android/player/PlaybackBitrate", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PlaybackBitrate); }
		}

		internal PlaybackBitrate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getValue;
		public unsafe int Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='PlaybackBitrate']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()I", "GetGetValueHandler")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getValue);
				} finally {
				}
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='PlaybackBitrate']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/spotify/sdk/android/player/PlaybackBitrate;", "")]
		public static unsafe global::Com.Spotify.Sdk.Android.Player.PlaybackBitrate ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/spotify/sdk/android/player/PlaybackBitrate;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Spotify.Sdk.Android.Player.PlaybackBitrate __ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.PlaybackBitrate> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='PlaybackBitrate']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/spotify/sdk/android/player/PlaybackBitrate;", "")]
		public static unsafe global::Com.Spotify.Sdk.Android.Player.PlaybackBitrate[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/spotify/sdk/android/player/PlaybackBitrate;");
			try {
				return (global::Com.Spotify.Sdk.Android.Player.PlaybackBitrate[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Spotify.Sdk.Android.Player.PlaybackBitrate));
			} finally {
			}
		}

	}
}
