using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Edu.Self.Telemetry_recorder {

	// Metadata.xml XPath class reference: path="/api/package[@name='edu.self.telemetry_recorder']/class[@name='TelemetryRecorder']"
	[global::Android.Runtime.Register ("edu/self/telemetry_recorder/TelemetryRecorder", DoNotGenerateAcw=true)]
	public partial class TelemetryRecorder : global::Java.Lang.Object, global::Edu.Self.Telemetry_recorder.ITelemetryRecorderManager {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("edu/self/telemetry_recorder/TelemetryRecorder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TelemetryRecorder); }
		}

		protected TelemetryRecorder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='edu.self.telemetry_recorder']/class[@name='TelemetryRecorder']/constructor[@name='TelemetryRecorder' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe TelemetryRecorder (global::Android.Content.Context applicationContext)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (applicationContext);
				if (((object) this).GetType () != typeof (TelemetryRecorder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_isStarted;
#pragma warning disable 0169
		static Delegate GetIsStartedHandler ()
		{
			if (cb_isStarted == null)
				cb_isStarted = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsStarted);
			return cb_isStarted;
		}

		static bool n_IsStarted (IntPtr jnienv, IntPtr native__this)
		{
			global::Edu.Self.Telemetry_recorder.TelemetryRecorder __this = global::Java.Lang.Object.GetObject<global::Edu.Self.Telemetry_recorder.TelemetryRecorder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsStarted;
		}
#pragma warning restore 0169

		static IntPtr id_isStarted;
		public virtual unsafe bool IsStarted {
			// Metadata.xml XPath method reference: path="/api/package[@name='edu.self.telemetry_recorder']/class[@name='TelemetryRecorder']/method[@name='isStarted' and count(parameter)=0]"
			[Register ("isStarted", "()Z", "GetIsStartedHandler")]
			get {
				if (id_isStarted == IntPtr.Zero)
					id_isStarted = JNIEnv.GetMethodID (class_ref, "isStarted", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isStarted);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isStarted", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getRegistration_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetRegistration_Ljava_lang_String_Handler ()
		{
			if (cb_getRegistration_Ljava_lang_String_ == null)
				cb_getRegistration_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetRegistration_Ljava_lang_String_);
			return cb_getRegistration_Ljava_lang_String_;
		}

		static IntPtr n_GetRegistration_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_userHostAppId)
		{
			global::Edu.Self.Telemetry_recorder.TelemetryRecorder __this = global::Java.Lang.Object.GetObject<global::Edu.Self.Telemetry_recorder.TelemetryRecorder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string userHostAppId = JNIEnv.GetString (native_userHostAppId, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetRegistration (userHostAppId));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getRegistration_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='edu.self.telemetry_recorder']/class[@name='TelemetryRecorder']/method[@name='getRegistration' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getRegistration", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetRegistration_Ljava_lang_String_Handler")]
		public virtual unsafe string GetRegistration (string userHostAppId)
		{
			if (id_getRegistration_Ljava_lang_String_ == IntPtr.Zero)
				id_getRegistration_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getRegistration", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_userHostAppId = JNIEnv.NewString (userHostAppId);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_userHostAppId);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRegistration_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRegistration", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_userHostAppId);
			}
		}

		static Delegate cb_register_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRegister_Ljava_lang_String_Handler ()
		{
			if (cb_register_Ljava_lang_String_ == null)
				cb_register_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Register_Ljava_lang_String_);
			return cb_register_Ljava_lang_String_;
		}

		static IntPtr n_Register_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_userHostAppId)
		{
			global::Edu.Self.Telemetry_recorder.TelemetryRecorder __this = global::Java.Lang.Object.GetObject<global::Edu.Self.Telemetry_recorder.TelemetryRecorder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string userHostAppId = JNIEnv.GetString (native_userHostAppId, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Register (userHostAppId));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_register_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='edu.self.telemetry_recorder']/class[@name='TelemetryRecorder']/method[@name='register' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("register", "(Ljava/lang/String;)Ljava/lang/String;", "GetRegister_Ljava_lang_String_Handler")]
		public virtual unsafe string Register (string userHostAppId)
		{
			if (id_register_Ljava_lang_String_ == IntPtr.Zero)
				id_register_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "register", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_userHostAppId = JNIEnv.NewString (userHostAppId);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_userHostAppId);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_register_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "register", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_userHostAppId);
			}
		}

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			global::Edu.Self.Telemetry_recorder.TelemetryRecorder __this = global::Java.Lang.Object.GetObject<global::Edu.Self.Telemetry_recorder.TelemetryRecorder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='edu.self.telemetry_recorder']/class[@name='TelemetryRecorder']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public virtual unsafe void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_start);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "start", "()V"));
			} finally {
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Edu.Self.Telemetry_recorder.TelemetryRecorder __this = global::Java.Lang.Object.GetObject<global::Edu.Self.Telemetry_recorder.TelemetryRecorder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='edu.self.telemetry_recorder']/class[@name='TelemetryRecorder']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stop", "()V"));
			} finally {
			}
		}

	}
}
