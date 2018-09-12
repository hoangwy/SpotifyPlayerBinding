using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Spotify.Sdk.Android.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Connectivity']"
	[global::Android.Runtime.Register ("com/spotify/sdk/android/player/Connectivity", DoNotGenerateAcw=true)]
	public abstract partial class Connectivity : global::Java.Lang.Object {


		static IntPtr MOBILE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Connectivity']/field[@name='MOBILE']"
		[Register ("MOBILE")]
		public static global::Com.Spotify.Sdk.Android.Player.Connectivity Mobile {
			get {
				if (MOBILE_jfieldId == IntPtr.Zero)
					MOBILE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MOBILE", "Lcom/spotify/sdk/android/player/Connectivity;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MOBILE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Connectivity> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr OFFLINE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Connectivity']/field[@name='OFFLINE']"
		[Register ("OFFLINE")]
		public static global::Com.Spotify.Sdk.Android.Player.Connectivity Offline {
			get {
				if (OFFLINE_jfieldId == IntPtr.Zero)
					OFFLINE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OFFLINE", "Lcom/spotify/sdk/android/player/Connectivity;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OFFLINE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Connectivity> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr WIRED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Connectivity']/field[@name='WIRED']"
		[Register ("WIRED")]
		public static global::Com.Spotify.Sdk.Android.Player.Connectivity Wired {
			get {
				if (WIRED_jfieldId == IntPtr.Zero)
					WIRED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WIRED", "Lcom/spotify/sdk/android/player/Connectivity;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WIRED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Connectivity> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr WIRELESS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Connectivity']/field[@name='WIRELESS']"
		[Register ("WIRELESS")]
		public static global::Com.Spotify.Sdk.Android.Player.Connectivity Wireless {
			get {
				if (WIRELESS_jfieldId == IntPtr.Zero)
					WIRELESS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WIRELESS", "Lcom/spotify/sdk/android/player/Connectivity;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WIRELESS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Connectivity> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/spotify/sdk/android/player/Connectivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Connectivity); }
		}

		protected Connectivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Connectivity']/constructor[@name='Connectivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Connectivity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Connectivity)) {
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

		static IntPtr id_fromNetworkType_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='Connectivity']/method[@name='fromNetworkType' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromNetworkType", "(I)Lcom/spotify/sdk/android/player/Connectivity;", "")]
		public static unsafe global::Com.Spotify.Sdk.Android.Player.Connectivity FromNetworkType (int p0)
		{
			if (id_fromNetworkType_I == IntPtr.Zero)
				id_fromNetworkType_I = JNIEnv.GetStaticMethodID (class_ref, "fromNetworkType", "(I)Lcom/spotify/sdk/android/player/Connectivity;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.Connectivity> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromNetworkType_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/spotify/sdk/android/player/Connectivity", DoNotGenerateAcw=true)]
	internal partial class ConnectivityInvoker : Connectivity {

		public ConnectivityInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConnectivityInvoker); }
		}

	}

}
