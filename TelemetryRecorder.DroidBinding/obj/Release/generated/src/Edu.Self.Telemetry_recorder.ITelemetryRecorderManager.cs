using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Edu.Self.Telemetry_recorder {

	// Metadata.xml XPath interface reference: path="/api/package[@name='edu.self.telemetry_recorder']/interface[@name='TelemetryRecorderManager']"
	[Register ("edu/self/telemetry_recorder/TelemetryRecorderManager", "", "Edu.Self.Telemetry_recorder.ITelemetryRecorderManagerInvoker")]
	public partial interface ITelemetryRecorderManager : IJavaObject {

		bool IsStarted {
			// Metadata.xml XPath method reference: path="/api/package[@name='edu.self.telemetry_recorder']/interface[@name='TelemetryRecorderManager']/method[@name='isStarted' and count(parameter)=0]"
			[Register ("isStarted", "()Z", "GetIsStartedHandler:Edu.Self.Telemetry_recorder.ITelemetryRecorderManagerInvoker, TelemetryRecorder.DroidBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='edu.self.telemetry_recorder']/interface[@name='TelemetryRecorderManager']/method[@name='getRegistration' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getRegistration", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetRegistration_Ljava_lang_String_Handler:Edu.Self.Telemetry_recorder.ITelemetryRecorderManagerInvoker, TelemetryRecorder.DroidBinding")]
		string GetRegistration (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='edu.self.telemetry_recorder']/interface[@name='TelemetryRecorderManager']/method[@name='register' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("register", "(Ljava/lang/String;)Ljava/lang/String;", "GetRegister_Ljava_lang_String_Handler:Edu.Self.Telemetry_recorder.ITelemetryRecorderManagerInvoker, TelemetryRecorder.DroidBinding")]
		string Register (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='edu.self.telemetry_recorder']/interface[@name='TelemetryRecorderManager']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler:Edu.Self.Telemetry_recorder.ITelemetryRecorderManagerInvoker, TelemetryRecorder.DroidBinding")]
		void Start ();

		// Metadata.xml XPath method reference: path="/api/package[@name='edu.self.telemetry_recorder']/interface[@name='TelemetryRecorderManager']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler:Edu.Self.Telemetry_recorder.ITelemetryRecorderManagerInvoker, TelemetryRecorder.DroidBinding")]
		void Stop ();

	}

	[global::Android.Runtime.Register ("edu/self/telemetry_recorder/TelemetryRecorderManager", DoNotGenerateAcw=true)]
	internal class ITelemetryRecorderManagerInvoker : global::Java.Lang.Object, ITelemetryRecorderManager {

		static IntPtr java_class_ref = JNIEnv.FindClass ("edu/self/telemetry_recorder/TelemetryRecorderManager");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ITelemetryRecorderManagerInvoker); }
		}

		IntPtr class_ref;

		public static ITelemetryRecorderManager GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITelemetryRecorderManager> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "edu.self.telemetry_recorder.TelemetryRecorderManager"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITelemetryRecorderManagerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Edu.Self.Telemetry_recorder.ITelemetryRecorderManager __this = global::Java.Lang.Object.GetObject<global::Edu.Self.Telemetry_recorder.ITelemetryRecorderManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsStarted;
		}
#pragma warning restore 0169

		IntPtr id_isStarted;
		public unsafe bool IsStarted {
			get {
				if (id_isStarted == IntPtr.Zero)
					id_isStarted = JNIEnv.GetMethodID (class_ref, "isStarted", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isStarted);
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

		static IntPtr n_GetRegistration_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Edu.Self.Telemetry_recorder.ITelemetryRecorderManager __this = global::Java.Lang.Object.GetObject<global::Edu.Self.Telemetry_recorder.ITelemetryRecorderManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetRegistration (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getRegistration_Ljava_lang_String_;
		public unsafe string GetRegistration (string p0)
		{
			if (id_getRegistration_Ljava_lang_String_ == IntPtr.Zero)
				id_getRegistration_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getRegistration", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRegistration_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_register_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRegister_Ljava_lang_String_Handler ()
		{
			if (cb_register_Ljava_lang_String_ == null)
				cb_register_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Register_Ljava_lang_String_);
			return cb_register_Ljava_lang_String_;
		}

		static IntPtr n_Register_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Edu.Self.Telemetry_recorder.ITelemetryRecorderManager __this = global::Java.Lang.Object.GetObject<global::Edu.Self.Telemetry_recorder.ITelemetryRecorderManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Register (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_register_Ljava_lang_String_;
		public unsafe string Register (string p0)
		{
			if (id_register_Ljava_lang_String_ == IntPtr.Zero)
				id_register_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "register", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_register_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
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
			global::Edu.Self.Telemetry_recorder.ITelemetryRecorderManager __this = global::Java.Lang.Object.GetObject<global::Edu.Self.Telemetry_recorder.ITelemetryRecorderManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		IntPtr id_start;
		public unsafe void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_start);
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
			global::Edu.Self.Telemetry_recorder.ITelemetryRecorderManager __this = global::Java.Lang.Object.GetObject<global::Edu.Self.Telemetry_recorder.ITelemetryRecorderManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		IntPtr id_stop;
		public unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop);
		}

	}

}
