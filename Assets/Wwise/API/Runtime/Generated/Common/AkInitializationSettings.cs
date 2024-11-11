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


public class AkInitializationSettings : global::System.IDisposable {
  private global::System.IntPtr swigCPtr;
  protected bool swigCMemOwn;

  internal AkInitializationSettings(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  internal static global::System.IntPtr getCPtr(AkInitializationSettings obj) {
    return (obj == null) ? global::System.IntPtr.Zero : obj.swigCPtr;
  }

  internal virtual void setCPtr(global::System.IntPtr cPtr) {
    Dispose();
    swigCPtr = cPtr;
  }

  ~AkInitializationSettings() {
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
          AkUnitySoundEnginePINVOKE.CSharp_delete_AkInitializationSettings(swigCPtr);
        }
        swigCPtr = global::System.IntPtr.Zero;
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public AkInitializationSettings() : this(AkUnitySoundEnginePINVOKE.CSharp_new_AkInitializationSettings(), true) {
  }

  public AkStreamMgrSettings streamMgrSettings { set { AkUnitySoundEnginePINVOKE.CSharp_AkInitializationSettings_streamMgrSettings_set(swigCPtr, AkStreamMgrSettings.getCPtr(value)); } 
    get {
      global::System.IntPtr cPtr = AkUnitySoundEnginePINVOKE.CSharp_AkInitializationSettings_streamMgrSettings_get(swigCPtr);
      AkStreamMgrSettings ret = (cPtr == global::System.IntPtr.Zero) ? null : new AkStreamMgrSettings(cPtr, false);
      return ret;
    } 
  }

  public AkDeviceSettings deviceSettings { set { AkUnitySoundEnginePINVOKE.CSharp_AkInitializationSettings_deviceSettings_set(swigCPtr, AkDeviceSettings.getCPtr(value)); } 
    get {
      global::System.IntPtr cPtr = AkUnitySoundEnginePINVOKE.CSharp_AkInitializationSettings_deviceSettings_get(swigCPtr);
      AkDeviceSettings ret = (cPtr == global::System.IntPtr.Zero) ? null : new AkDeviceSettings(cPtr, false);
      return ret;
    } 
  }

  public AkInitSettings initSettings { set { AkUnitySoundEnginePINVOKE.CSharp_AkInitializationSettings_initSettings_set(swigCPtr, AkInitSettings.getCPtr(value)); } 
    get {
      global::System.IntPtr cPtr = AkUnitySoundEnginePINVOKE.CSharp_AkInitializationSettings_initSettings_get(swigCPtr);
      AkInitSettings ret = (cPtr == global::System.IntPtr.Zero) ? null : new AkInitSettings(cPtr, false);
      return ret;
    } 
  }

  public AkPlatformInitSettings platformSettings { set { AkUnitySoundEnginePINVOKE.CSharp_AkInitializationSettings_platformSettings_set(swigCPtr, AkPlatformInitSettings.getCPtr(value)); } 
    get {
      global::System.IntPtr cPtr = AkUnitySoundEnginePINVOKE.CSharp_AkInitializationSettings_platformSettings_get(swigCPtr);
      AkPlatformInitSettings ret = (cPtr == global::System.IntPtr.Zero) ? null : new AkPlatformInitSettings(cPtr, false);
      return ret;
    } 
  }

  public AkMusicSettings musicSettings { set { AkUnitySoundEnginePINVOKE.CSharp_AkInitializationSettings_musicSettings_set(swigCPtr, AkMusicSettings.getCPtr(value)); } 
    get {
      global::System.IntPtr cPtr = AkUnitySoundEnginePINVOKE.CSharp_AkInitializationSettings_musicSettings_get(swigCPtr);
      AkMusicSettings ret = (cPtr == global::System.IntPtr.Zero) ? null : new AkMusicSettings(cPtr, false);
      return ret;
    } 
  }

  public uint uMemoryPrimarySbaInitSize { set { AkUnitySoundEnginePINVOKE.CSharp_AkInitializationSettings_uMemoryPrimarySbaInitSize_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkInitializationSettings_uMemoryPrimarySbaInitSize_get(swigCPtr); } 
  }

  public uint uMemoryPrimaryTlsfInitSize { set { AkUnitySoundEnginePINVOKE.CSharp_AkInitializationSettings_uMemoryPrimaryTlsfInitSize_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkInitializationSettings_uMemoryPrimaryTlsfInitSize_get(swigCPtr); } 
  }

  public uint uMemoryPrimaryTlsfSpanSize { set { AkUnitySoundEnginePINVOKE.CSharp_AkInitializationSettings_uMemoryPrimaryTlsfSpanSize_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkInitializationSettings_uMemoryPrimaryTlsfSpanSize_get(swigCPtr); } 
  }

  public uint uMemoryPrimaryAllocSizeHuge { set { AkUnitySoundEnginePINVOKE.CSharp_AkInitializationSettings_uMemoryPrimaryAllocSizeHuge_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkInitializationSettings_uMemoryPrimaryAllocSizeHuge_get(swigCPtr); } 
  }

  public uint uMemoryPrimaryReservedLimit { set { AkUnitySoundEnginePINVOKE.CSharp_AkInitializationSettings_uMemoryPrimaryReservedLimit_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkInitializationSettings_uMemoryPrimaryReservedLimit_get(swigCPtr); } 
  }

  public uint uMemoryMediaTlsfInitSize { set { AkUnitySoundEnginePINVOKE.CSharp_AkInitializationSettings_uMemoryMediaTlsfInitSize_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkInitializationSettings_uMemoryMediaTlsfInitSize_get(swigCPtr); } 
  }

  public uint uMemoryMediaTlsfSpanSize { set { AkUnitySoundEnginePINVOKE.CSharp_AkInitializationSettings_uMemoryMediaTlsfSpanSize_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkInitializationSettings_uMemoryMediaTlsfSpanSize_get(swigCPtr); } 
  }

  public uint uMemoryMediaAllocSizeHuge { set { AkUnitySoundEnginePINVOKE.CSharp_AkInitializationSettings_uMemoryMediaAllocSizeHuge_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkInitializationSettings_uMemoryMediaAllocSizeHuge_get(swigCPtr); } 
  }

  public uint uMemoryMediaReservedLimit { set { AkUnitySoundEnginePINVOKE.CSharp_AkInitializationSettings_uMemoryMediaReservedLimit_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkInitializationSettings_uMemoryMediaReservedLimit_get(swigCPtr); } 
  }

  public uint uMemDebugLevel { set { AkUnitySoundEnginePINVOKE.CSharp_AkInitializationSettings_uMemDebugLevel_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkInitializationSettings_uMemDebugLevel_get(swigCPtr); } 
  }

}
#endif // #if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_WIIU || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.