using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Spotify.Sdk.Android.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Error']"
	[global::Android.Runtime.Register ("com/spotify/sdk/android/player/Error", DoNotGenerateAcw=true)]
	public sealed partial class Error : global::Java.Lang.Enum {


		static IntPtr UNKNOWN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Error']/field[@name='UNKNOWN']"
		[Register ("UNKNOWN")]
		public static global::Com.Spotify.Sdk.Android.Player.Error Unknown {
			get {
				if (UNKNOWN_jfieldId == IntPtr.Zero)
					UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lcom/spotify/sdk/android/player/Error;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Error> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr kSpAlreadyPrefetching_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Error']/field[@name='kSpAlreadyPrefetching']"
		[Register ("kSpAlreadyPrefetching")]
		public static global::Com.Spotify.Sdk.Android.Player.Error KSpAlreadyPrefetching {
			get {
				if (kSpAlreadyPrefetching_jfieldId == IntPtr.Zero)
					kSpAlreadyPrefetching_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "kSpAlreadyPrefetching", "Lcom/spotify/sdk/android/player/Error;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, kSpAlreadyPrefetching_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Error> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr kSpErrorAPIRateLimited_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Error']/field[@name='kSpErrorAPIRateLimited']"
		[Register ("kSpErrorAPIRateLimited")]
		public static global::Com.Spotify.Sdk.Android.Player.Error KSpErrorAPIRateLimited {
			get {
				if (kSpErrorAPIRateLimited_jfieldId == IntPtr.Zero)
					kSpErrorAPIRateLimited_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "kSpErrorAPIRateLimited", "Lcom/spotify/sdk/android/player/Error;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, kSpErrorAPIRateLimited_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Error> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr kSpErrorAdIsPlaying_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Error']/field[@name='kSpErrorAdIsPlaying']"
		[Register ("kSpErrorAdIsPlaying")]
		public static global::Com.Spotify.Sdk.Android.Player.Error KSpErrorAdIsPlaying {
			get {
				if (kSpErrorAdIsPlaying_jfieldId == IntPtr.Zero)
					kSpErrorAdIsPlaying_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "kSpErrorAdIsPlaying", "Lcom/spotify/sdk/android/player/Error;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, kSpErrorAdIsPlaying_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Error> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr kSpErrorAlreadyInitialized_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Error']/field[@name='kSpErrorAlreadyInitialized']"
		[Register ("kSpErrorAlreadyInitialized")]
		public static global::Com.Spotify.Sdk.Android.Player.Error KSpErrorAlreadyInitialized {
			get {
				if (kSpErrorAlreadyInitialized_jfieldId == IntPtr.Zero)
					kSpErrorAlreadyInitialized_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "kSpErrorAlreadyInitialized", "Lcom/spotify/sdk/android/player/Error;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, kSpErrorAlreadyInitialized_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Error> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr kSpErrorApplicationBanned_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Error']/field[@name='kSpErrorApplicationBanned']"
		[Register ("kSpErrorApplicationBanned")]
		public static global::Com.Spotify.Sdk.Android.Player.Error KSpErrorApplicationBanned {
			get {
				if (kSpErrorApplicationBanned_jfieldId == IntPtr.Zero)
					kSpErrorApplicationBanned_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "kSpErrorApplicationBanned", "Lcom/spotify/sdk/android/player/Error;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, kSpErrorApplicationBanned_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Error> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr kSpErrorContextFailed_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Error']/field[@name='kSpErrorContextFailed']"
		[Register ("kSpErrorContextFailed")]
		public static global::Com.Spotify.Sdk.Android.Player.Error KSpErrorContextFailed {
			get {
				if (kSpErrorContextFailed_jfieldId == IntPtr.Zero)
					kSpErrorContextFailed_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "kSpErrorContextFailed", "Lcom/spotify/sdk/android/player/Error;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, kSpErrorContextFailed_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Error> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr kSpErrorCorruptTrack_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Error']/field[@name='kSpErrorCorruptTrack']"
		[Register ("kSpErrorCorruptTrack")]
		public static global::Com.Spotify.Sdk.Android.Player.Error KSpErrorCorruptTrack {
			get {
				if (kSpErrorCorruptTrack_jfieldId == IntPtr.Zero)
					kSpErrorCorruptTrack_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "kSpErrorCorruptTrack", "Lcom/spotify/sdk/android/player/Error;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, kSpErrorCorruptTrack_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Error> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr kSpErrorFailed_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Error']/field[@name='kSpErrorFailed']"
		[Register ("kSpErrorFailed")]
		public static global::Com.Spotify.Sdk.Android.Player.Error KSpErrorFailed {
			get {
				if (kSpErrorFailed_jfieldId == IntPtr.Zero)
					kSpErrorFailed_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "kSpErrorFailed", "Lcom/spotify/sdk/android/player/Error;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, kSpErrorFailed_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Error> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr kSpErrorGeneralLoginError_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Error']/field[@name='kSpErrorGeneralLoginError']"
		[Register ("kSpErrorGeneralLoginError")]
		public static global::Com.Spotify.Sdk.Android.Player.Error KSpErrorGeneralLoginError {
			get {
				if (kSpErrorGeneralLoginError_jfieldId == IntPtr.Zero)
					kSpErrorGeneralLoginError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "kSpErrorGeneralLoginError", "Lcom/spotify/sdk/android/player/Error;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, kSpErrorGeneralLoginError_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Error> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr kSpErrorGeneralPlaybackError_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Error']/field[@name='kSpErrorGeneralPlaybackError']"
		[Register ("kSpErrorGeneralPlaybackError")]
		public static global::Com.Spotify.Sdk.Android.Player.Error KSpErrorGeneralPlaybackError {
			get {
				if (kSpErrorGeneralPlaybackError_jfieldId == IntPtr.Zero)
					kSpErrorGeneralPlaybackError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "kSpErrorGeneralPlaybackError", "Lcom/spotify/sdk/android/player/Error;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, kSpErrorGeneralPlaybackError_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Error> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr kSpErrorInitFailed_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Error']/field[@name='kSpErrorInitFailed']"
		[Register ("kSpErrorInitFailed")]
		public static global::Com.Spotify.Sdk.Android.Player.Error KSpErrorInitFailed {
			get {
				if (kSpErrorInitFailed_jfieldId == IntPtr.Zero)
					kSpErrorInitFailed_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "kSpErrorInitFailed", "Lcom/spotify/sdk/android/player/Error;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, kSpErrorInitFailed_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Error> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr kSpErrorInvalidArgument_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Error']/field[@name='kSpErrorInvalidArgument']"
		[Register ("kSpErrorInvalidArgument")]
		public static global::Com.Spotify.Sdk.Android.Player.Error KSpErrorInvalidArgument {
			get {
				if (kSpErrorInvalidArgument_jfieldId == IntPtr.Zero)
					kSpErrorInvalidArgument_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "kSpErrorInvalidArgument", "Lcom/spotify/sdk/android/player/Error;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, kSpErrorInvalidArgument_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Error> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr kSpErrorLoginBadCredentials_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Error']/field[@name='kSpErrorLoginBadCredentials']"
		[Register ("kSpErrorLoginBadCredentials")]
		public static global::Com.Spotify.Sdk.Android.Player.Error KSpErrorLoginBadCredentials {
			get {
				if (kSpErrorLoginBadCredentials_jfieldId == IntPtr.Zero)
					kSpErrorLoginBadCredentials_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "kSpErrorLoginBadCredentials", "Lcom/spotify/sdk/android/player/Error;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, kSpErrorLoginBadCredentials_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Error> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr kSpErrorNeedsPremium_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Error']/field[@name='kSpErrorNeedsPremium']"
		[Register ("kSpErrorNeedsPremium")]
		public static global::Com.Spotify.Sdk.Android.Player.Error KSpErrorNeedsPremium {
			get {
				if (kSpErrorNeedsPremium_jfieldId == IntPtr.Zero)
					kSpErrorNeedsPremium_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "kSpErrorNeedsPremium", "Lcom/spotify/sdk/android/player/Error;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, kSpErrorNeedsPremium_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Error> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr kSpErrorNotActiveDevice_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Error']/field[@name='kSpErrorNotActiveDevice']"
		[Register ("kSpErrorNotActiveDevice")]
		public static global::Com.Spotify.Sdk.Android.Player.Error KSpErrorNotActiveDevice {
			get {
				if (kSpErrorNotActiveDevice_jfieldId == IntPtr.Zero)
					kSpErrorNotActiveDevice_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "kSpErrorNotActiveDevice", "Lcom/spotify/sdk/android/player/Error;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, kSpErrorNotActiveDevice_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Error> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr kSpErrorNullArgument_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Error']/field[@name='kSpErrorNullArgument']"
		[Register ("kSpErrorNullArgument")]
		public static global::Com.Spotify.Sdk.Android.Player.Error KSpErrorNullArgument {
			get {
				if (kSpErrorNullArgument_jfieldId == IntPtr.Zero)
					kSpErrorNullArgument_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "kSpErrorNullArgument", "Lcom/spotify/sdk/android/player/Error;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, kSpErrorNullArgument_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Error> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr kSpErrorOk_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Error']/field[@name='kSpErrorOk']"
		[Register ("kSpErrorOk")]
		public static global::Com.Spotify.Sdk.Android.Player.Error KSpErrorOk {
			get {
				if (kSpErrorOk_jfieldId == IntPtr.Zero)
					kSpErrorOk_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "kSpErrorOk", "Lcom/spotify/sdk/android/player/Error;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, kSpErrorOk_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Error> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr kSpErrorPlaybackCappingLimitReached_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Error']/field[@name='kSpErrorPlaybackCappingLimitReached']"
		[Register ("kSpErrorPlaybackCappingLimitReached")]
		public static global::Com.Spotify.Sdk.Android.Player.Error KSpErrorPlaybackCappingLimitReached {
			get {
				if (kSpErrorPlaybackCappingLimitReached_jfieldId == IntPtr.Zero)
					kSpErrorPlaybackCappingLimitReached_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "kSpErrorPlaybackCappingLimitReached", "Lcom/spotify/sdk/android/player/Error;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, kSpErrorPlaybackCappingLimitReached_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Error> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr kSpErrorPlaybackErrorStart_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Error']/field[@name='kSpErrorPlaybackErrorStart']"
		[Register ("kSpErrorPlaybackErrorStart")]
		public static global::Com.Spotify.Sdk.Android.Player.Error KSpErrorPlaybackErrorStart {
			get {
				if (kSpErrorPlaybackErrorStart_jfieldId == IntPtr.Zero)
					kSpErrorPlaybackErrorStart_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "kSpErrorPlaybackErrorStart", "Lcom/spotify/sdk/android/player/Error;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, kSpErrorPlaybackErrorStart_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Error> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr kSpErrorPlaybackRateLimited_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Error']/field[@name='kSpErrorPlaybackRateLimited']"
		[Register ("kSpErrorPlaybackRateLimited")]
		public static global::Com.Spotify.Sdk.Android.Player.Error KSpErrorPlaybackRateLimited {
			get {
				if (kSpErrorPlaybackRateLimited_jfieldId == IntPtr.Zero)
					kSpErrorPlaybackRateLimited_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "kSpErrorPlaybackRateLimited", "Lcom/spotify/sdk/android/player/Error;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, kSpErrorPlaybackRateLimited_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Error> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr kSpErrorPrefetchItemUnavailable_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Error']/field[@name='kSpErrorPrefetchItemUnavailable']"
		[Register ("kSpErrorPrefetchItemUnavailable")]
		public static global::Com.Spotify.Sdk.Android.Player.Error KSpErrorPrefetchItemUnavailable {
			get {
				if (kSpErrorPrefetchItemUnavailable_jfieldId == IntPtr.Zero)
					kSpErrorPrefetchItemUnavailable_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "kSpErrorPrefetchItemUnavailable", "Lcom/spotify/sdk/android/player/Error;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, kSpErrorPrefetchItemUnavailable_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Error> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr kSpErrorTravelRestriction_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Error']/field[@name='kSpErrorTravelRestriction']"
		[Register ("kSpErrorTravelRestriction")]
		public static global::Com.Spotify.Sdk.Android.Player.Error KSpErrorTravelRestriction {
			get {
				if (kSpErrorTravelRestriction_jfieldId == IntPtr.Zero)
					kSpErrorTravelRestriction_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "kSpErrorTravelRestriction", "Lcom/spotify/sdk/android/player/Error;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, kSpErrorTravelRestriction_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Error> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr kSpErrorUninitialized_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Error']/field[@name='kSpErrorUninitialized']"
		[Register ("kSpErrorUninitialized")]
		public static global::Com.Spotify.Sdk.Android.Player.Error KSpErrorUninitialized {
			get {
				if (kSpErrorUninitialized_jfieldId == IntPtr.Zero)
					kSpErrorUninitialized_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "kSpErrorUninitialized", "Lcom/spotify/sdk/android/player/Error;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, kSpErrorUninitialized_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Error> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr kSpErrorUnsupported_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Error']/field[@name='kSpErrorUnsupported']"
		[Register ("kSpErrorUnsupported")]
		public static global::Com.Spotify.Sdk.Android.Player.Error KSpErrorUnsupported {
			get {
				if (kSpErrorUnsupported_jfieldId == IntPtr.Zero)
					kSpErrorUnsupported_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "kSpErrorUnsupported", "Lcom/spotify/sdk/android/player/Error;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, kSpErrorUnsupported_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Error> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr kSpErrorWrongAPIVersion_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Error']/field[@name='kSpErrorWrongAPIVersion']"
		[Register ("kSpErrorWrongAPIVersion")]
		public static global::Com.Spotify.Sdk.Android.Player.Error KSpErrorWrongAPIVersion {
			get {
				if (kSpErrorWrongAPIVersion_jfieldId == IntPtr.Zero)
					kSpErrorWrongAPIVersion_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "kSpErrorWrongAPIVersion", "Lcom/spotify/sdk/android/player/Error;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, kSpErrorWrongAPIVersion_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Error> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr kSpPrefetchDownloadFailed_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Error']/field[@name='kSpPrefetchDownloadFailed']"
		[Register ("kSpPrefetchDownloadFailed")]
		public static global::Com.Spotify.Sdk.Android.Player.Error KSpPrefetchDownloadFailed {
			get {
				if (kSpPrefetchDownloadFailed_jfieldId == IntPtr.Zero)
					kSpPrefetchDownloadFailed_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "kSpPrefetchDownloadFailed", "Lcom/spotify/sdk/android/player/Error;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, kSpPrefetchDownloadFailed_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Error> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr kSpStorageReadError_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Error']/field[@name='kSpStorageReadError']"
		[Register ("kSpStorageReadError")]
		public static global::Com.Spotify.Sdk.Android.Player.Error KSpStorageReadError {
			get {
				if (kSpStorageReadError_jfieldId == IntPtr.Zero)
					kSpStorageReadError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "kSpStorageReadError", "Lcom/spotify/sdk/android/player/Error;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, kSpStorageReadError_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Error> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr kSpStorageWriteError_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Error']/field[@name='kSpStorageWriteError']"
		[Register ("kSpStorageWriteError")]
		public static global::Com.Spotify.Sdk.Android.Player.Error KSpStorageWriteError {
			get {
				if (kSpStorageWriteError_jfieldId == IntPtr.Zero)
					kSpStorageWriteError_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "kSpStorageWriteError", "Lcom/spotify/sdk/android/player/Error;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, kSpStorageWriteError_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Error> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/spotify/sdk/android/player/Error", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Error); }
		}

		internal Error (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Error']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/spotify/sdk/android/player/Error;", "")]
		public static unsafe global::Com.Spotify.Sdk.Android.Player.Error ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/spotify/sdk/android/player/Error;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Spotify.Sdk.Android.Player.Error __ret = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Error> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Error']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/spotify/sdk/android/player/Error;", "")]
		public static unsafe global::Com.Spotify.Sdk.Android.Player.Error[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/spotify/sdk/android/player/Error;");
			try {
				return (global::Com.Spotify.Sdk.Android.Player.Error[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Spotify.Sdk.Android.Player.Error));
			} finally {
			}
		}

	}
}
