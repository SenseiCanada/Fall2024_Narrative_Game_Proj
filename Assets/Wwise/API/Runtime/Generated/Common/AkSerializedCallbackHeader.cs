#if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_WIIU || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.
//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.2.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class AkSerializedCallbackHeader : global::System.IDisposable {
  private global::System.IntPtr swigCPtr;
  protected bool swigCMemOwn;

  internal AkSerializedCallbackHeader(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  internal static global::System.IntPtr getCPtr(AkSerializedCallbackHeader obj) {
    return (obj == null) ? global::System.IntPtr.Zero : obj.swigCPtr;
  }

  internal virtual void setCPtr(global::System.IntPtr cPtr) {
    Dispose();
    swigCPtr = cPtr;
  }

  ~AkSerializedCallbackHeader() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AkUnitySoundEnginePINVOKE.CSharp_delete_AkSerializedCallbackHeader(swigCPtr);
        }
        swigCPtr = global::System.IntPtr.Zero;
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public global::System.IntPtr pPackage { get { return AkUnitySoundEnginePINVOKE.CSharp_AkSerializedCallbackHeader_pPackage_get(swigCPtr); }
  }

  public uint eType { get { return AkUnitySoundEnginePINVOKE.CSharp_AkSerializedCallbackHeader_eType_get(swigCPtr); } 
  }

  public global::System.IntPtr GetData() { return AkUnitySoundEnginePINVOKE.CSharp_AkSerializedCallbackHeader_GetData(swigCPtr); }

  public AkSerializedCallbackHeader pNext {
    get {
      global::System.IntPtr cPtr = AkUnitySoundEnginePINVOKE.CSharp_AkSerializedCallbackHeader_pNext_get(swigCPtr);
      AkSerializedCallbackHeader ret = (cPtr == global::System.IntPtr.Zero) ? null : new AkSerializedCallbackHeader(cPtr, false);
      return ret;
    } 
  }

  public AkSerializedCallbackHeader() : this(AkUnitySoundEnginePINVOKE.CSharp_new_AkSerializedCallbackHeader(), true) {
  }

}
#endif // #if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_WIIU || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.