using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Edu.Self.Telemetry_recorder {

	// Metadata.xml XPath class reference: path="/api/package[@name='edu.self.telemetry_recorder']/class[@name='Trip']"
	[global::Android.Runtime.Register ("edu/self/telemetry_recorder/Trip", DoNotGenerateAcw=true)]
	public partial class Trip : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("edu/self/telemetry_recorder/Trip", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Trip); }
		}

		protected Trip (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getDatabaseId;
#pragma warning disable 0169
		static Delegate GetGetDatabaseIdHandler ()
		{
			if (cb_getDatabaseId == null)
				cb_getDatabaseId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetDatabaseId);
			return cb_getDatabaseId;
		}

		static long n_GetDatabaseId (IntPtr jnienv, IntPtr native__this)
		{
			global::Edu.Self.Telemetry_recorder.Trip __this = global::Java.Lang.Object.GetObject<global::Edu.Self.Telemetry_recorder.Trip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DatabaseId;
		}
#pragma warning restore 0169

		static IntPtr id_getDatabaseId;
		public virtual unsafe long DatabaseId {
			// Metadata.xml XPath method reference: path="/api/package[@name='edu.self.telemetry_recorder']/class[@name='Trip']/method[@name='getDatabaseId' and count(parameter)=0]"
			[Register ("getDatabaseId", "()J", "GetGetDatabaseIdHandler")]
			get {
				if (id_getDatabaseId == IntPtr.Zero)
					id_getDatabaseId = JNIEnv.GetMethodID (class_ref, "getDatabaseId", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getDatabaseId);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDatabaseId", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getDistanceInKilometers;
#pragma warning disable 0169
		static Delegate GetGetDistanceInKilometersHandler ()
		{
			if (cb_getDistanceInKilometers == null)
				cb_getDistanceInKilometers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetDistanceInKilometers);
			return cb_getDistanceInKilometers;
		}

		static long n_GetDistanceInKilometers (IntPtr jnienv, IntPtr native__this)
		{
			global::Edu.Self.Telemetry_recorder.Trip __this = global::Java.Lang.Object.GetObject<global::Edu.Self.Telemetry_recorder.Trip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DistanceInKilometers;
		}
#pragma warning restore 0169

		static IntPtr id_getDistanceInKilometers;
		public virtual unsafe long DistanceInKilometers {
			// Metadata.xml XPath method reference: path="/api/package[@name='edu.self.telemetry_recorder']/class[@name='Trip']/method[@name='getDistanceInKilometers' and count(parameter)=0]"
			[Register ("getDistanceInKilometers", "()J", "GetGetDistanceInKilometersHandler")]
			get {
				if (id_getDistanceInKilometers == IntPtr.Zero)
					id_getDistanceInKilometers = JNIEnv.GetMethodID (class_ref, "getDistanceInKilometers", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getDistanceInKilometers);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDistanceInKilometers", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getDurationInSeconds;
#pragma warning disable 0169
		static Delegate GetGetDurationInSecondsHandler ()
		{
			if (cb_getDurationInSeconds == null)
				cb_getDurationInSeconds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetDurationInSeconds);
			return cb_getDurationInSeconds;
		}

		static long n_GetDurationInSeconds (IntPtr jnienv, IntPtr native__this)
		{
			global::Edu.Self.Telemetry_recorder.Trip __this = global::Java.Lang.Object.GetObject<global::Edu.Self.Telemetry_recorder.Trip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DurationInSeconds;
		}
#pragma warning restore 0169

		static IntPtr id_getDurationInSeconds;
		public virtual unsafe long DurationInSeconds {
			// Metadata.xml XPath method reference: path="/api/package[@name='edu.self.telemetry_recorder']/class[@name='Trip']/method[@name='getDurationInSeconds' and count(parameter)=0]"
			[Register ("getDurationInSeconds", "()J", "GetGetDurationInSecondsHandler")]
			get {
				if (id_getDurationInSeconds == IntPtr.Zero)
					id_getDurationInSeconds = JNIEnv.GetMethodID (class_ref, "getDurationInSeconds", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getDurationInSeconds);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDurationInSeconds", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getEndTimeStamp;
#pragma warning disable 0169
		static Delegate GetGetEndTimeStampHandler ()
		{
			if (cb_getEndTimeStamp == null)
				cb_getEndTimeStamp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetEndTimeStamp);
			return cb_getEndTimeStamp;
		}

		static long n_GetEndTimeStamp (IntPtr jnienv, IntPtr native__this)
		{
			global::Edu.Self.Telemetry_recorder.Trip __this = global::Java.Lang.Object.GetObject<global::Edu.Self.Telemetry_recorder.Trip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EndTimeStamp;
		}
#pragma warning restore 0169

		static IntPtr id_getEndTimeStamp;
		public virtual unsafe long EndTimeStamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='edu.self.telemetry_recorder']/class[@name='Trip']/method[@name='getEndTimeStamp' and count(parameter)=0]"
			[Register ("getEndTimeStamp", "()J", "GetGetEndTimeStampHandler")]
			get {
				if (id_getEndTimeStamp == IntPtr.Zero)
					id_getEndTimeStamp = JNIEnv.GetMethodID (class_ref, "getEndTimeStamp", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getEndTimeStamp);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEndTimeStamp", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getFromSuburb;
#pragma warning disable 0169
		static Delegate GetGetFromSuburbHandler ()
		{
			if (cb_getFromSuburb == null)
				cb_getFromSuburb = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFromSuburb);
			return cb_getFromSuburb;
		}

		static IntPtr n_GetFromSuburb (IntPtr jnienv, IntPtr native__this)
		{
			global::Edu.Self.Telemetry_recorder.Trip __this = global::Java.Lang.Object.GetObject<global::Edu.Self.Telemetry_recorder.Trip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FromSuburb);
		}
#pragma warning restore 0169

		static IntPtr id_getFromSuburb;
		public virtual unsafe string FromSuburb {
			// Metadata.xml XPath method reference: path="/api/package[@name='edu.self.telemetry_recorder']/class[@name='Trip']/method[@name='getFromSuburb' and count(parameter)=0]"
			[Register ("getFromSuburb", "()Ljava/lang/String;", "GetGetFromSuburbHandler")]
			get {
				if (id_getFromSuburb == IntPtr.Zero)
					id_getFromSuburb = JNIEnv.GetMethodID (class_ref, "getFromSuburb", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFromSuburb), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFromSuburb", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getStartTimeStamp;
#pragma warning disable 0169
		static Delegate GetGetStartTimeStampHandler ()
		{
			if (cb_getStartTimeStamp == null)
				cb_getStartTimeStamp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetStartTimeStamp);
			return cb_getStartTimeStamp;
		}

		static long n_GetStartTimeStamp (IntPtr jnienv, IntPtr native__this)
		{
			global::Edu.Self.Telemetry_recorder.Trip __this = global::Java.Lang.Object.GetObject<global::Edu.Self.Telemetry_recorder.Trip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartTimeStamp;
		}
#pragma warning restore 0169

		static IntPtr id_getStartTimeStamp;
		public virtual unsafe long StartTimeStamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='edu.self.telemetry_recorder']/class[@name='Trip']/method[@name='getStartTimeStamp' and count(parameter)=0]"
			[Register ("getStartTimeStamp", "()J", "GetGetStartTimeStampHandler")]
			get {
				if (id_getStartTimeStamp == IntPtr.Zero)
					id_getStartTimeStamp = JNIEnv.GetMethodID (class_ref, "getStartTimeStamp", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getStartTimeStamp);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStartTimeStamp", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getToSuburb;
#pragma warning disable 0169
		static Delegate GetGetToSuburbHandler ()
		{
			if (cb_getToSuburb == null)
				cb_getToSuburb = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetToSuburb);
			return cb_getToSuburb;
		}

		static IntPtr n_GetToSuburb (IntPtr jnienv, IntPtr native__this)
		{
			global::Edu.Self.Telemetry_recorder.Trip __this = global::Java.Lang.Object.GetObject<global::Edu.Self.Telemetry_recorder.Trip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToSuburb);
		}
#pragma warning restore 0169

		static IntPtr id_getToSuburb;
		public virtual unsafe string ToSuburb {
			// Metadata.xml XPath method reference: path="/api/package[@name='edu.self.telemetry_recorder']/class[@name='Trip']/method[@name='getToSuburb' and count(parameter)=0]"
			[Register ("getToSuburb", "()Ljava/lang/String;", "GetGetToSuburbHandler")]
			get {
				if (id_getToSuburb == IntPtr.Zero)
					id_getToSuburb = JNIEnv.GetMethodID (class_ref, "getToSuburb", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getToSuburb), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getToSuburb", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_fromDatabaseEnry_JJJJJLjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='edu.self.telemetry_recorder']/class[@name='Trip']/method[@name='fromDatabaseEnry' and count(parameter)=7 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='long'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String']]"
		[Register ("fromDatabaseEnry", "(JJJJJLjava/lang/String;Ljava/lang/String;)Ledu/self/telemetry_recorder/Trip;", "")]
		public static unsafe global::Edu.Self.Telemetry_recorder.Trip FromDatabaseEnry (long databaseId, long startTimeStamp, long endTimeStamp, long distanceInKilometers, long durationInSeconds, string fromSuburb, string toSuburb)
		{
			if (id_fromDatabaseEnry_JJJJJLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_fromDatabaseEnry_JJJJJLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "fromDatabaseEnry", "(JJJJJLjava/lang/String;Ljava/lang/String;)Ledu/self/telemetry_recorder/Trip;");
			IntPtr native_fromSuburb = JNIEnv.NewString (fromSuburb);
			IntPtr native_toSuburb = JNIEnv.NewString (toSuburb);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (databaseId);
				__args [1] = new JValue (startTimeStamp);
				__args [2] = new JValue (endTimeStamp);
				__args [3] = new JValue (distanceInKilometers);
				__args [4] = new JValue (durationInSeconds);
				__args [5] = new JValue (native_fromSuburb);
				__args [6] = new JValue (native_toSuburb);
				global::Edu.Self.Telemetry_recorder.Trip __ret = global::Java.Lang.Object.GetObject<global::Edu.Self.Telemetry_recorder.Trip> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromDatabaseEnry_JJJJJLjava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fromSuburb);
				JNIEnv.DeleteLocalRef (native_toSuburb);
			}
		}

		static IntPtr id_recordedNow_JJJJLjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='edu.self.telemetry_recorder']/class[@name='Trip']/method[@name='recordedNow' and count(parameter)=6 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String']]"
		[Register ("recordedNow", "(JJJJLjava/lang/String;Ljava/lang/String;)Ledu/self/telemetry_recorder/Trip;", "")]
		public static unsafe global::Edu.Self.Telemetry_recorder.Trip RecordedNow (long startTimeStamp, long endTimeStamp, long distanceInKilometers, long durationInSeconds, string fromSuburb, string toSuburb)
		{
			if (id_recordedNow_JJJJLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_recordedNow_JJJJLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "recordedNow", "(JJJJLjava/lang/String;Ljava/lang/String;)Ledu/self/telemetry_recorder/Trip;");
			IntPtr native_fromSuburb = JNIEnv.NewString (fromSuburb);
			IntPtr native_toSuburb = JNIEnv.NewString (toSuburb);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (startTimeStamp);
				__args [1] = new JValue (endTimeStamp);
				__args [2] = new JValue (distanceInKilometers);
				__args [3] = new JValue (durationInSeconds);
				__args [4] = new JValue (native_fromSuburb);
				__args [5] = new JValue (native_toSuburb);
				global::Edu.Self.Telemetry_recorder.Trip __ret = global::Java.Lang.Object.GetObject<global::Edu.Self.Telemetry_recorder.Trip> (JNIEnv.CallStaticObjectMethod  (class_ref, id_recordedNow_JJJJLjava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_fromSuburb);
				JNIEnv.DeleteLocalRef (native_toSuburb);
			}
		}

	}
}
