using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Spotify.Jni {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.spotify.jni']/class[@name='NativeObject']"
	[global::Android.Runtime.Register ("com/spotify/jni/NativeObject", DoNotGenerateAcw=true)]
	public abstract partial class NativeObject : global::Java.Lang.Object {


		static IntPtr nPtr_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.spotify.jni']/class[@name='NativeObject']/field[@name='nPtr']"
		[Register ("nPtr")]
		protected long NPtr {
			get {
				if (nPtr_jfieldId == IntPtr.Zero)
					nPtr_jfieldId = JNIEnv.GetFieldID (class_ref, "nPtr", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, nPtr_jfieldId);
			}
			set {
				if (nPtr_jfieldId == IntPtr.Zero)
					nPtr_jfieldId = JNIEnv.GetFieldID (class_ref, "nPtr", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, nPtr_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/spotify/jni/NativeObject", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NativeObject); }
		}

		protected NativeObject (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.spotify.jni']/class[@name='NativeObject']/constructor[@name='NativeObject' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NativeObject ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (NativeObject)) {
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

		static Delegate cb_destroy;
#pragma warning disable 0169
		static Delegate GetDestroyHandler ()
		{
			if (cb_destroy == null)
				cb_destroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Destroy);
			return cb_destroy;
		}

		static void n_Destroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Spotify.Jni.NativeObject __this = global::Java.Lang.Object.GetObject<global::Com.Spotify.Jni.NativeObject> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.jni']/class[@name='NativeObject']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler")]
		public abstract void Destroy ();

	}

	[global::Android.Runtime.Register ("com/spotify/jni/NativeObject", DoNotGenerateAcw=true)]
	internal partial class NativeObjectInvoker : NativeObject {

		public NativeObjectInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (NativeObjectInvoker); }
		}

		static IntPtr id_destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.spotify.jni']/class[@name='NativeObject']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler")]
		public override unsafe void Destroy ()
		{
			if (id_destroy == IntPtr.Zero)
				id_destroy = JNIEnv.GetMethodID (class_ref, "destroy", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_destroy);
			} finally {
			}
		}

	}

}
