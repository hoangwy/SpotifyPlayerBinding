using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Spotify.Sdk.Android.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='PlaybackState']"
	[global::Android.Runtime.Register ("com/spotify/sdk/android/player/PlaybackState", DoNotGenerateAcw=true)]
	public partial class PlaybackState : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='PlaybackState']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr isActiveDevice_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='PlaybackState']/field[@name='isActiveDevice']"
		[Register ("isActiveDevice")]
		public bool IsActiveDevice {
			get {
				if (isActiveDevice_jfieldId == IntPtr.Zero)
					isActiveDevice_jfieldId = JNIEnv.GetFieldID (class_ref, "isActiveDevice", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, isActiveDevice_jfieldId);
			}
			set {
				if (isActiveDevice_jfieldId == IntPtr.Zero)
					isActiveDevice_jfieldId = JNIEnv.GetFieldID (class_ref, "isActiveDevice", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, isActiveDevice_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr isPlaying_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='PlaybackState']/field[@name='isPlaying']"
		[Register ("isPlaying")]
		public bool IsPlaying {
			get {
				if (isPlaying_jfieldId == IntPtr.Zero)
					isPlaying_jfieldId = JNIEnv.GetFieldID (class_ref, "isPlaying", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, isPlaying_jfieldId);
			}
			set {
				if (isPlaying_jfieldId == IntPtr.Zero)
					isPlaying_jfieldId = JNIEnv.GetFieldID (class_ref, "isPlaying", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, isPlaying_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr isRepeating_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='PlaybackState']/field[@name='isRepeating']"
		[Register ("isRepeating")]
		public bool IsRepeating {
			get {
				if (isRepeating_jfieldId == IntPtr.Zero)
					isRepeating_jfieldId = JNIEnv.GetFieldID (class_ref, "isRepeating", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, isRepeating_jfieldId);
			}
			set {
				if (isRepeating_jfieldId == IntPtr.Zero)
					isRepeating_jfieldId = JNIEnv.GetFieldID (class_ref, "isRepeating", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, isRepeating_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr isShuffling_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='PlaybackState']/field[@name='isShuffling']"
		[Register ("isShuffling")]
		public bool IsShuffling {
			get {
				if (isShuffling_jfieldId == IntPtr.Zero)
					isShuffling_jfieldId = JNIEnv.GetFieldID (class_ref, "isShuffling", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, isShuffling_jfieldId);
			}
			set {
				if (isShuffling_jfieldId == IntPtr.Zero)
					isShuffling_jfieldId = JNIEnv.GetFieldID (class_ref, "isShuffling", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, isShuffling_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr positionMs_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='PlaybackState']/field[@name='positionMs']"
		[Register ("positionMs")]
		public long PositionMs {
			get {
				if (positionMs_jfieldId == IntPtr.Zero)
					positionMs_jfieldId = JNIEnv.GetFieldID (class_ref, "positionMs", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, positionMs_jfieldId);
			}
			set {
				if (positionMs_jfieldId == IntPtr.Zero)
					positionMs_jfieldId = JNIEnv.GetFieldID (class_ref, "positionMs", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, positionMs_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/spotify/sdk/android/player/PlaybackState", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PlaybackState); }
		}

		protected PlaybackState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_ZZZZJ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='PlaybackState']/constructor[@name='PlaybackState' and count(parameter)=5 and parameter[1][@type='boolean'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean'] and parameter[5][@type='long']]"
		[Register (".ctor", "(ZZZZJ)V", "")]
		public unsafe PlaybackState (bool p0, bool p1, bool p2, bool p3, long p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				if (((object) this).GetType () != typeof (PlaybackState)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(ZZZZJ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(ZZZZJ)V", __args);
					return;
				}

				if (id_ctor_ZZZZJ == IntPtr.Zero)
					id_ctor_ZZZZJ = JNIEnv.GetMethodID (class_ref, "<init>", "(ZZZZJ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ZZZZJ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_ZZZZJ, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='PlaybackState']/constructor[@name='PlaybackState' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected unsafe PlaybackState (global::Android.OS.Parcel p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (PlaybackState)) {
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
			global::Com.Spotify.Sdk.Android.Player.PlaybackState __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.PlaybackState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='PlaybackState']/method[@name='describeContents' and count(parameter)=0]"
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
			global::Com.Spotify.Sdk.Android.Player.PlaybackState __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.PlaybackState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='PlaybackState']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
