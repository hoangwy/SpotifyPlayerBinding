using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Spotify.Sdk.Android.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Metadata']"
	[global::Android.Runtime.Register ("com/spotify/sdk/android/player/Metadata", DoNotGenerateAcw=true)]
	public partial class Metadata : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Metadata']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr contextName_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Metadata']/field[@name='contextName']"
		[Register ("contextName")]
		public string ContextName {
			get {
				if (contextName_jfieldId == IntPtr.Zero)
					contextName_jfieldId = JNIEnv.GetFieldID (class_ref, "contextName", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, contextName_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (contextName_jfieldId == IntPtr.Zero)
					contextName_jfieldId = JNIEnv.GetFieldID (class_ref, "contextName", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, contextName_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr contextUri_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Metadata']/field[@name='contextUri']"
		[Register ("contextUri")]
		public string ContextUri {
			get {
				if (contextUri_jfieldId == IntPtr.Zero)
					contextUri_jfieldId = JNIEnv.GetFieldID (class_ref, "contextUri", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, contextUri_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (contextUri_jfieldId == IntPtr.Zero)
					contextUri_jfieldId = JNIEnv.GetFieldID (class_ref, "contextUri", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, contextUri_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr currentTrack_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Metadata']/field[@name='currentTrack']"
		[Register ("currentTrack")]
		public global::Com.Spotify.Sdk.Android.Player.Metadata.Track CurrentTrack {
			get {
				if (currentTrack_jfieldId == IntPtr.Zero)
					currentTrack_jfieldId = JNIEnv.GetFieldID (class_ref, "currentTrack", "Lcom/spotify/sdk/android/player/Metadata$Track;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, currentTrack_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Metadata.Track> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (currentTrack_jfieldId == IntPtr.Zero)
					currentTrack_jfieldId = JNIEnv.GetFieldID (class_ref, "currentTrack", "Lcom/spotify/sdk/android/player/Metadata$Track;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, currentTrack_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr nextTrack_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Metadata']/field[@name='nextTrack']"
		[Register ("nextTrack")]
		public global::Com.Spotify.Sdk.Android.Player.Metadata.Track NextTrack {
			get {
				if (nextTrack_jfieldId == IntPtr.Zero)
					nextTrack_jfieldId = JNIEnv.GetFieldID (class_ref, "nextTrack", "Lcom/spotify/sdk/android/player/Metadata$Track;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, nextTrack_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Metadata.Track> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (nextTrack_jfieldId == IntPtr.Zero)
					nextTrack_jfieldId = JNIEnv.GetFieldID (class_ref, "nextTrack", "Lcom/spotify/sdk/android/player/Metadata$Track;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, nextTrack_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr prevTrack_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Metadata']/field[@name='prevTrack']"
		[Register ("prevTrack")]
		public global::Com.Spotify.Sdk.Android.Player.Metadata.Track PrevTrack {
			get {
				if (prevTrack_jfieldId == IntPtr.Zero)
					prevTrack_jfieldId = JNIEnv.GetFieldID (class_ref, "prevTrack", "Lcom/spotify/sdk/android/player/Metadata$Track;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, prevTrack_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Metadata.Track> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (prevTrack_jfieldId == IntPtr.Zero)
					prevTrack_jfieldId = JNIEnv.GetFieldID (class_ref, "prevTrack", "Lcom/spotify/sdk/android/player/Metadata$Track;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, prevTrack_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Metadata.Track']"
		[global::Android.Runtime.Register ("com/spotify/sdk/android/player/Metadata$Track", DoNotGenerateAcw=true)]
		public partial class Track : global::Java.Lang.Object, global::Android.OS.IParcelable {


			static IntPtr CREATOR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Metadata.Track']/field[@name='CREATOR']"
			[Register ("CREATOR")]
			public static global::Android.OS.IParcelableCreator Creator {
				get {
					if (CREATOR_jfieldId == IntPtr.Zero)
						CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr albumCoverWebUrl_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Metadata.Track']/field[@name='albumCoverWebUrl']"
			[Register ("albumCoverWebUrl")]
			public string AlbumCoverWebUrl {
				get {
					if (albumCoverWebUrl_jfieldId == IntPtr.Zero)
						albumCoverWebUrl_jfieldId = JNIEnv.GetFieldID (class_ref, "albumCoverWebUrl", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, albumCoverWebUrl_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (albumCoverWebUrl_jfieldId == IntPtr.Zero)
						albumCoverWebUrl_jfieldId = JNIEnv.GetFieldID (class_ref, "albumCoverWebUrl", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, albumCoverWebUrl_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr albumName_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Metadata.Track']/field[@name='albumName']"
			[Register ("albumName")]
			public string AlbumName {
				get {
					if (albumName_jfieldId == IntPtr.Zero)
						albumName_jfieldId = JNIEnv.GetFieldID (class_ref, "albumName", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, albumName_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (albumName_jfieldId == IntPtr.Zero)
						albumName_jfieldId = JNIEnv.GetFieldID (class_ref, "albumName", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, albumName_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr albumUri_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Metadata.Track']/field[@name='albumUri']"
			[Register ("albumUri")]
			public string AlbumUri {
				get {
					if (albumUri_jfieldId == IntPtr.Zero)
						albumUri_jfieldId = JNIEnv.GetFieldID (class_ref, "albumUri", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, albumUri_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (albumUri_jfieldId == IntPtr.Zero)
						albumUri_jfieldId = JNIEnv.GetFieldID (class_ref, "albumUri", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, albumUri_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr artistName_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Metadata.Track']/field[@name='artistName']"
			[Register ("artistName")]
			public string ArtistName {
				get {
					if (artistName_jfieldId == IntPtr.Zero)
						artistName_jfieldId = JNIEnv.GetFieldID (class_ref, "artistName", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, artistName_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (artistName_jfieldId == IntPtr.Zero)
						artistName_jfieldId = JNIEnv.GetFieldID (class_ref, "artistName", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, artistName_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr artistUri_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Metadata.Track']/field[@name='artistUri']"
			[Register ("artistUri")]
			public string ArtistUri {
				get {
					if (artistUri_jfieldId == IntPtr.Zero)
						artistUri_jfieldId = JNIEnv.GetFieldID (class_ref, "artistUri", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, artistUri_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (artistUri_jfieldId == IntPtr.Zero)
						artistUri_jfieldId = JNIEnv.GetFieldID (class_ref, "artistUri", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, artistUri_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr durationMs_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Metadata.Track']/field[@name='durationMs']"
			[Register ("durationMs")]
			public long DurationMs {
				get {
					if (durationMs_jfieldId == IntPtr.Zero)
						durationMs_jfieldId = JNIEnv.GetFieldID (class_ref, "durationMs", "J");
					return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, durationMs_jfieldId);
				}
				set {
					if (durationMs_jfieldId == IntPtr.Zero)
						durationMs_jfieldId = JNIEnv.GetFieldID (class_ref, "durationMs", "J");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, durationMs_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr indexInContext_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Metadata.Track']/field[@name='indexInContext']"
			[Register ("indexInContext")]
			public long IndexInContext {
				get {
					if (indexInContext_jfieldId == IntPtr.Zero)
						indexInContext_jfieldId = JNIEnv.GetFieldID (class_ref, "indexInContext", "J");
					return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, indexInContext_jfieldId);
				}
				set {
					if (indexInContext_jfieldId == IntPtr.Zero)
						indexInContext_jfieldId = JNIEnv.GetFieldID (class_ref, "indexInContext", "J");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, indexInContext_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr name_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Metadata.Track']/field[@name='name']"
			[Register ("name")]
			public string Name {
				get {
					if (name_jfieldId == IntPtr.Zero)
						name_jfieldId = JNIEnv.GetFieldID (class_ref, "name", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, name_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (name_jfieldId == IntPtr.Zero)
						name_jfieldId = JNIEnv.GetFieldID (class_ref, "name", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, name_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr uri_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Metadata.Track']/field[@name='uri']"
			[Register ("uri")]
			public string Uri {
				get {
					if (uri_jfieldId == IntPtr.Zero)
						uri_jfieldId = JNIEnv.GetFieldID (class_ref, "uri", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, uri_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (uri_jfieldId == IntPtr.Zero)
						uri_jfieldId = JNIEnv.GetFieldID (class_ref, "uri", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, uri_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/spotify/sdk/android/player/Metadata$Track", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Track); }
			}

			protected Track (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJLjava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Metadata.Track']/constructor[@name='Metadata.Track' and count(parameter)=9 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='long'] and parameter[8][@type='long'] and parameter[9][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;JJLjava/lang/String;)V", "")]
			public unsafe Track (string p0, string p1, string p2, string p3, string p4, string p5, long p6, long p7, string p8)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewString (p2);
				IntPtr native_p3 = JNIEnv.NewString (p3);
				IntPtr native_p4 = JNIEnv.NewString (p4);
				IntPtr native_p5 = JNIEnv.NewString (p5);
				IntPtr native_p8 = JNIEnv.NewString (p8);
				try {
					JValue* __args = stackalloc JValue [9];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (native_p2);
					__args [3] = new JValue (native_p3);
					__args [4] = new JValue (native_p4);
					__args [5] = new JValue (native_p5);
					__args [6] = new JValue (p6);
					__args [7] = new JValue (p7);
					__args [8] = new JValue (native_p8);
					if (((object) this).GetType () != typeof (Track)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;JJLjava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;JJLjava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJLjava_lang_String_ == IntPtr.Zero)
						id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;JJLjava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJLjava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_JJLjava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
					JNIEnv.DeleteLocalRef (native_p3);
					JNIEnv.DeleteLocalRef (native_p4);
					JNIEnv.DeleteLocalRef (native_p5);
					JNIEnv.DeleteLocalRef (native_p8);
				}
			}

			static IntPtr id_ctor_Landroid_os_Parcel_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Metadata.Track']/constructor[@name='Metadata.Track' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
			[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
			protected unsafe Track (global::Android.OS.Parcel p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (Track)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/os/Parcel;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/os/Parcel;)V", __args);
						return;
					}

					if (id_ctor_Landroid_os_Parcel_ == IntPtr.Zero)
						id_ctor_Landroid_os_Parcel_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Parcel;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Parcel_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_os_Parcel_, __args);
				} finally {
				}
			}

			static Delegate cb_describeContents;
#pragma warning disable 0169
			static Delegate GetDescribeContentsHandler ()
			{
				if (cb_describeContents == null)
					cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
				return cb_describeContents;
			}

			static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Spotify.Sdk.Android.Player.Metadata.Track __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Metadata.Track> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.DescribeContents ();
			}
#pragma warning restore 0169

			static IntPtr id_describeContents;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Metadata.Track']/method[@name='describeContents' and count(parameter)=0]"
			[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
			public virtual unsafe int DescribeContents ()
			{
				if (id_describeContents == IntPtr.Zero)
					id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_describeContents);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "describeContents", "()I"));
				} finally {
				}
			}

			static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
			static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
			{
				if (cb_writeToParcel_Landroid_os_Parcel_I == null)
					cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
				return cb_writeToParcel_Landroid_os_Parcel_I;
			}

			static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1)
			{
				global::Com.Spotify.Sdk.Android.Player.Metadata.Track __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Metadata.Track> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
				__this.WriteToParcel (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Metadata.Track']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
			[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
			public virtual unsafe void WriteToParcel (global::Android.OS.Parcel p0, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags p1)
			{
				if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
					id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue ((int) p1);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeToParcel", "(Landroid/os/Parcel;I)V"), __args);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/spotify/sdk/android/player/Metadata", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Metadata); }
		}

		protected Metadata (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_spotify_sdk_android_player_Metadata_Track_Lcom_spotify_sdk_android_player_Metadata_Track_Lcom_spotify_sdk_android_player_Metadata_Track_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Metadata']/constructor[@name='Metadata' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.spotify.sdk.android.player.Metadata.Track'] and parameter[4][@type='com.spotify.sdk.android.player.Metadata.Track'] and parameter[5][@type='com.spotify.sdk.android.player.Metadata.Track']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Lcom/spotify/sdk/android/player/Metadata$Track;Lcom/spotify/sdk/android/player/Metadata$Track;Lcom/spotify/sdk/android/player/Metadata$Track;)V", "")]
		public unsafe Metadata (string p0, string p1, global::Com.Spotify.Sdk.Android.Player.Metadata.Track p2, global::Com.Spotify.Sdk.Android.Player.Metadata.Track p3, global::Com.Spotify.Sdk.Android.Player.Metadata.Track p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				if (((object) this).GetType () != typeof (Metadata)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Lcom/spotify/sdk/android/player/Metadata$Track;Lcom/spotify/sdk/android/player/Metadata$Track;Lcom/spotify/sdk/android/player/Metadata$Track;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Lcom/spotify/sdk/android/player/Metadata$Track;Lcom/spotify/sdk/android/player/Metadata$Track;Lcom/spotify/sdk/android/player/Metadata$Track;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_spotify_sdk_android_player_Metadata_Track_Lcom_spotify_sdk_android_player_Metadata_Track_Lcom_spotify_sdk_android_player_Metadata_Track_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_spotify_sdk_android_player_Metadata_Track_Lcom_spotify_sdk_android_player_Metadata_Track_Lcom_spotify_sdk_android_player_Metadata_Track_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Lcom/spotify/sdk/android/player/Metadata$Track;Lcom/spotify/sdk/android/player/Metadata$Track;Lcom/spotify/sdk/android/player/Metadata$Track;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_spotify_sdk_android_player_Metadata_Track_Lcom_spotify_sdk_android_player_Metadata_Track_Lcom_spotify_sdk_android_player_Metadata_Track_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Lcom_spotify_sdk_android_player_Metadata_Track_Lcom_spotify_sdk_android_player_Metadata_Track_Lcom_spotify_sdk_android_player_Metadata_Track_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Metadata']/constructor[@name='Metadata' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected unsafe Metadata (global::Android.OS.Parcel p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (Metadata)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/os/Parcel;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/os/Parcel;)V", __args);
					return;
				}

				if (id_ctor_Landroid_os_Parcel_ == IntPtr.Zero)
					id_ctor_Landroid_os_Parcel_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Parcel;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Parcel_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_os_Parcel_, __args);
			} finally {
			}
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Sdk.Android.Player.Metadata __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Metadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Metadata']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual unsafe int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_describeContents);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "describeContents", "()I"));
			} finally {
			}
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1)
		{
			global::Com.Spotify.Sdk.Android.Player.Metadata __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Metadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Metadata']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe void WriteToParcel (global::Android.OS.Parcel p0, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((int) p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeToParcel", "(Landroid/os/Parcel;I)V"), __args);
			} finally {
			}
		}

	}
}
