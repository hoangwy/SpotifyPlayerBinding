using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Spotify.Sdk.Android.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Config']"
	[global::Android.Runtime.Register ("com/spotify/sdk/android/player/Config", DoNotGenerateAcw=true)]
	public sealed partial class Config : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Config']/field[@name='IN_FIELD_SEPARATOR']"
		[Register ("IN_FIELD_SEPARATOR")]
		public const string InFieldSeparator = (string) "_";

		static IntPtr brandName_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Config']/field[@name='brandName']"
		[Register ("brandName")]
		public string BrandName {
			get {
				if (brandName_jfieldId == IntPtr.Zero)
					brandName_jfieldId = JNIEnv.GetFieldID (class_ref, "brandName", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, brandName_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (brandName_jfieldId == IntPtr.Zero)
					brandName_jfieldId = JNIEnv.GetFieldID (class_ref, "brandName", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, brandName_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr cacheAgeLimitInSeconds_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Config']/field[@name='cacheAgeLimitInSeconds']"
		[Register ("cacheAgeLimitInSeconds")]
		public int CacheAgeLimitInSeconds {
			get {
				if (cacheAgeLimitInSeconds_jfieldId == IntPtr.Zero)
					cacheAgeLimitInSeconds_jfieldId = JNIEnv.GetFieldID (class_ref, "cacheAgeLimitInSeconds", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, cacheAgeLimitInSeconds_jfieldId);
			}
			set {
				if (cacheAgeLimitInSeconds_jfieldId == IntPtr.Zero)
					cacheAgeLimitInSeconds_jfieldId = JNIEnv.GetFieldID (class_ref, "cacheAgeLimitInSeconds", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, cacheAgeLimitInSeconds_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr cachePath_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Config']/field[@name='cachePath']"
		[Register ("cachePath")]
		public string CachePath {
			get {
				if (cachePath_jfieldId == IntPtr.Zero)
					cachePath_jfieldId = JNIEnv.GetFieldID (class_ref, "cachePath", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, cachePath_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (cachePath_jfieldId == IntPtr.Zero)
					cachePath_jfieldId = JNIEnv.GetFieldID (class_ref, "cachePath", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, cachePath_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr cacheSizeLimitInMegabytes_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Config']/field[@name='cacheSizeLimitInMegabytes']"
		[Register ("cacheSizeLimitInMegabytes")]
		public int CacheSizeLimitInMegabytes {
			get {
				if (cacheSizeLimitInMegabytes_jfieldId == IntPtr.Zero)
					cacheSizeLimitInMegabytes_jfieldId = JNIEnv.GetFieldID (class_ref, "cacheSizeLimitInMegabytes", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, cacheSizeLimitInMegabytes_jfieldId);
			}
			set {
				if (cacheSizeLimitInMegabytes_jfieldId == IntPtr.Zero)
					cacheSizeLimitInMegabytes_jfieldId = JNIEnv.GetFieldID (class_ref, "cacheSizeLimitInMegabytes", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, cacheSizeLimitInMegabytes_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr clientId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Config']/field[@name='clientId']"
		[Register ("clientId")]
		public string ClientId {
			get {
				if (clientId_jfieldId == IntPtr.Zero)
					clientId_jfieldId = JNIEnv.GetFieldID (class_ref, "clientId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, clientId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (clientId_jfieldId == IntPtr.Zero)
					clientId_jfieldId = JNIEnv.GetFieldID (class_ref, "clientId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, clientId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr displayName_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Config']/field[@name='displayName']"
		[Register ("displayName")]
		public string DisplayName {
			get {
				if (displayName_jfieldId == IntPtr.Zero)
					displayName_jfieldId = JNIEnv.GetFieldID (class_ref, "displayName", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, displayName_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (displayName_jfieldId == IntPtr.Zero)
					displayName_jfieldId = JNIEnv.GetFieldID (class_ref, "displayName", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, displayName_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr modelName_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Config']/field[@name='modelName']"
		[Register ("modelName")]
		public string ModelName {
			get {
				if (modelName_jfieldId == IntPtr.Zero)
					modelName_jfieldId = JNIEnv.GetFieldID (class_ref, "modelName", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, modelName_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (modelName_jfieldId == IntPtr.Zero)
					modelName_jfieldId = JNIEnv.GetFieldID (class_ref, "modelName", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, modelName_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr oauthToken_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Config']/field[@name='oauthToken']"
		[Register ("oauthToken")]
		public string OauthToken {
			get {
				if (oauthToken_jfieldId == IntPtr.Zero)
					oauthToken_jfieldId = JNIEnv.GetFieldID (class_ref, "oauthToken", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, oauthToken_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (oauthToken_jfieldId == IntPtr.Zero)
					oauthToken_jfieldId = JNIEnv.GetFieldID (class_ref, "oauthToken", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, oauthToken_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr osVersion_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Config']/field[@name='osVersion']"
		[Register ("osVersion")]
		public string OsVersion {
			get {
				if (osVersion_jfieldId == IntPtr.Zero)
					osVersion_jfieldId = JNIEnv.GetFieldID (class_ref, "osVersion", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, osVersion_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (osVersion_jfieldId == IntPtr.Zero)
					osVersion_jfieldId = JNIEnv.GetFieldID (class_ref, "osVersion", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, osVersion_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr uniqueId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Config']/field[@name='uniqueId']"
		[Register ("uniqueId")]
		public string UniqueId {
			get {
				if (uniqueId_jfieldId == IntPtr.Zero)
					uniqueId_jfieldId = JNIEnv.GetFieldID (class_ref, "uniqueId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, uniqueId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (uniqueId_jfieldId == IntPtr.Zero)
					uniqueId_jfieldId = JNIEnv.GetFieldID (class_ref, "uniqueId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, uniqueId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Config.DeviceType']"
		[global::Android.Runtime.Register ("com/spotify/sdk/android/player/Config$DeviceType", DoNotGenerateAcw=true)]
		public abstract partial class DeviceType : global::Java.Lang.Object {


			static IntPtr AVR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Config.DeviceType']/field[@name='AVR']"
			[Register ("AVR")]
			public static global::Com.Spotify.Sdk.Android.Player.Config.DeviceType Avr {
				get {
					if (AVR_jfieldId == IntPtr.Zero)
						AVR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AVR", "Lcom/spotify/sdk/android/player/Config$DeviceType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AVR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Config.DeviceType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr COMPUTER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Config.DeviceType']/field[@name='COMPUTER']"
			[Register ("COMPUTER")]
			public static global::Com.Spotify.Sdk.Android.Player.Config.DeviceType Computer {
				get {
					if (COMPUTER_jfieldId == IntPtr.Zero)
						COMPUTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COMPUTER", "Lcom/spotify/sdk/android/player/Config$DeviceType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COMPUTER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Config.DeviceType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DONGLE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Config.DeviceType']/field[@name='DONGLE']"
			[Register ("DONGLE")]
			public static global::Com.Spotify.Sdk.Android.Player.Config.DeviceType Dongle {
				get {
					if (DONGLE_jfieldId == IntPtr.Zero)
						DONGLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DONGLE", "Lcom/spotify/sdk/android/player/Config$DeviceType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DONGLE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Config.DeviceType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SMARTPHONE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Config.DeviceType']/field[@name='SMARTPHONE']"
			[Register ("SMARTPHONE")]
			public static global::Com.Spotify.Sdk.Android.Player.Config.DeviceType Smartphone {
				get {
					if (SMARTPHONE_jfieldId == IntPtr.Zero)
						SMARTPHONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SMARTPHONE", "Lcom/spotify/sdk/android/player/Config$DeviceType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SMARTPHONE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Config.DeviceType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SPEAKER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Config.DeviceType']/field[@name='SPEAKER']"
			[Register ("SPEAKER")]
			public static global::Com.Spotify.Sdk.Android.Player.Config.DeviceType Speaker {
				get {
					if (SPEAKER_jfieldId == IntPtr.Zero)
						SPEAKER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SPEAKER", "Lcom/spotify/sdk/android/player/Config$DeviceType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SPEAKER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Config.DeviceType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr STB_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Config.DeviceType']/field[@name='STB']"
			[Register ("STB")]
			public static global::Com.Spotify.Sdk.Android.Player.Config.DeviceType Stb {
				get {
					if (STB_jfieldId == IntPtr.Zero)
						STB_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STB", "Lcom/spotify/sdk/android/player/Config$DeviceType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STB_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Config.DeviceType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TABLET_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Config.DeviceType']/field[@name='TABLET']"
			[Register ("TABLET")]
			public static global::Com.Spotify.Sdk.Android.Player.Config.DeviceType Tablet {
				get {
					if (TABLET_jfieldId == IntPtr.Zero)
						TABLET_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TABLET", "Lcom/spotify/sdk/android/player/Config$DeviceType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TABLET_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Config.DeviceType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TV_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Config.DeviceType']/field[@name='TV']"
			[Register ("TV")]
			public static global::Com.Spotify.Sdk.Android.Player.Config.DeviceType Tv {
				get {
					if (TV_jfieldId == IntPtr.Zero)
						TV_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TV", "Lcom/spotify/sdk/android/player/Config$DeviceType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TV_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Config.DeviceType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UNKNOWN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Config.DeviceType']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public static global::Com.Spotify.Sdk.Android.Player.Config.DeviceType Unknown {
				get {
					if (UNKNOWN_jfieldId == IntPtr.Zero)
						UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lcom/spotify/sdk/android/player/Config$DeviceType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Config.DeviceType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/spotify/sdk/android/player/Config$DeviceType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DeviceType); }
			}

			protected DeviceType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Config.DeviceType']/constructor[@name='Config.DeviceType' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe DeviceType ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (DeviceType)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
						return;
					}

					if (id_ctor == IntPtr.Zero)
						id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
				} finally {
				}
			}

		}

		[global::Android.Runtime.Register ("com/spotify/sdk/android/player/Config$DeviceType", DoNotGenerateAcw=true)]
		internal partial class DeviceTypeInvoker : DeviceType {

			public DeviceTypeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (DeviceTypeInvoker); }
			}

		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/spotify/sdk/android/player/Config", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Config); }
		}

		internal Config (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Config']/constructor[@name='Config' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe Config (global::Android.Content.Context p0, string p1, string p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				if (((object) this).GetType () != typeof (Config)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_spotify_sdk_android_player_Config_DeviceType_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Config']/constructor[@name='Config' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.spotify.sdk.android.player.Config.DeviceType']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Lcom/spotify/sdk/android/player/Config$DeviceType;)V", "")]
		public unsafe Config (global::Android.Content.Context p0, string p1, string p2, global::Com.Spotify.Sdk.Android.Player.Config.DeviceType p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				if (((object) this).GetType () != typeof (Config)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Lcom/spotify/sdk/android/player/Config$DeviceType;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Lcom/spotify/sdk/android/player/Config$DeviceType;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_spotify_sdk_android_player_Config_DeviceType_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_spotify_sdk_android_player_Config_DeviceType_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Lcom/spotify/sdk/android/player/Config$DeviceType;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_spotify_sdk_android_player_Config_DeviceType_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lcom_spotify_sdk_android_player_Config_DeviceType_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_shouldUseCache;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Config']/method[@name='shouldUseCache' and count(parameter)=0]"
		[Register ("shouldUseCache", "()Z", "")]
		public unsafe bool ShouldUseCache ()
		{
			if (id_shouldUseCache == IntPtr.Zero)
				id_shouldUseCache = JNIEnv.GetMethodID (class_ref, "shouldUseCache", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_shouldUseCache);
			} finally {
			}
		}

		static IntPtr id_useCache_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Config']/method[@name='useCache' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("useCache", "(Z)V", "")]
		public unsafe void UseCache (bool p0)
		{
			if (id_useCache_Z == IntPtr.Zero)
				id_useCache_Z = JNIEnv.GetMethodID (class_ref, "useCache", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_useCache_Z, __args);
			} finally {
			}
		}

	}
}
