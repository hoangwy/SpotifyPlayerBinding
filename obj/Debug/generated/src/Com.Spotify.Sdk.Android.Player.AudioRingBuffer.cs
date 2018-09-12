using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Spotify.Sdk.Android.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='AudioRingBuffer']"
	[global::Android.Runtime.Register ("com/spotify/sdk/android/player/AudioRingBuffer", DoNotGenerateAcw=true)]
	public partial class AudioRingBuffer : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/spotify/sdk/android/player/AudioRingBuffer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AudioRingBuffer); }
		}

		protected AudioRingBuffer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='AudioRingBuffer']/constructor[@name='AudioRingBuffer' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe AudioRingBuffer (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (AudioRingBuffer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Sdk.Android.Player.AudioRingBuffer __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.AudioRingBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='AudioRingBuffer']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()V"));
			} finally {
			}
		}

		static Delegate cb_peek_arrayS;
#pragma warning disable 0169
		static Delegate GetPeek_arraySHandler ()
		{
			if (cb_peek_arrayS == null)
				cb_peek_arrayS = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_Peek_arrayS);
			return cb_peek_arrayS;
		}

		static int n_Peek_arrayS (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Spotify.Sdk.Android.Player.AudioRingBuffer __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.AudioRingBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			short[] p0 = (short[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (short));
			int __ret = __this.Peek (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_peek_arrayS;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='AudioRingBuffer']/method[@name='peek' and count(parameter)=1 and parameter[1][@type='short[]']]"
		[Register ("peek", "([S)I", "GetPeek_arraySHandler")]
		public virtual unsafe int Peek (short[] p0)
		{
			if (id_peek_arrayS == IntPtr.Zero)
				id_peek_arrayS = JNIEnv.GetMethodID (class_ref, "peek", "([S)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_peek_arrayS, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "peek", "([S)I"), __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_remove_I;
#pragma warning disable 0169
		static Delegate GetRemove_IHandler ()
		{
			if (cb_remove_I == null)
				cb_remove_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Remove_I);
			return cb_remove_I;
		}

		static void n_Remove_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Spotify.Sdk.Android.Player.AudioRingBuffer __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.AudioRingBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Remove (p0);
		}
#pragma warning restore 0169

		static IntPtr id_remove_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='AudioRingBuffer']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("remove", "(I)V", "GetRemove_IHandler")]
		public virtual unsafe void Remove (int p0)
		{
			if (id_remove_I == IntPtr.Zero)
				id_remove_I = JNIEnv.GetMethodID (class_ref, "remove", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_remove_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_write_arrayS;
#pragma warning disable 0169
		static Delegate GetWrite_arraySHandler ()
		{
			if (cb_write_arrayS == null)
				cb_write_arrayS = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_Write_arrayS);
			return cb_write_arrayS;
		}

		static int n_Write_arrayS (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Spotify.Sdk.Android.Player.AudioRingBuffer __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.AudioRingBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			short[] p0 = (short[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (short));
			int __ret = __this.Write (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_write_arrayS;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='AudioRingBuffer']/method[@name='write' and count(parameter)=1 and parameter[1][@type='short[]']]"
		[Register ("write", "([S)I", "GetWrite_arraySHandler")]
		public virtual unsafe int Write (short[] p0)
		{
			if (id_write_arrayS == IntPtr.Zero)
				id_write_arrayS = JNIEnv.GetMethodID (class_ref, "write", "([S)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_write_arrayS, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "([S)I"), __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_write_arraySI;
#pragma warning disable 0169
		static Delegate GetWrite_arraySIHandler ()
		{
			if (cb_write_arraySI == null)
				cb_write_arraySI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int>) n_Write_arraySI);
			return cb_write_arraySI;
		}

		static int n_Write_arraySI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Spotify.Sdk.Android.Player.AudioRingBuffer __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Sdk.Android.Player.AudioRingBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			short[] p0 = (short[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (short));
			int __ret = __this.Write (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_write_arraySI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.sdk.android.player']/class[@name='AudioRingBuffer']/method[@name='write' and count(parameter)=2 and parameter[1][@type='short[]'] and parameter[2][@type='int']]"
		[Register ("write", "([SI)I", "GetWrite_arraySIHandler")]
		public virtual unsafe int Write (short[] p0, int p1)
		{
			if (id_write_arraySI == IntPtr.Zero)
				id_write_arraySI = JNIEnv.GetMethodID (class_ref, "write", "([SI)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_write_arraySI, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "([SI)I"), __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
