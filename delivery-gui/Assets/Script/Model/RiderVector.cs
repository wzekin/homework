//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class RiderVector : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerable<Rider>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal RiderVector(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RiderVector obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~RiderVector() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          delivery_modelPINVOKE.delete_RiderVector(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public RiderVector(global::System.Collections.IEnumerable c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (Rider element in c) {
      this.Add(element);
    }
  }

  public RiderVector(global::System.Collections.Generic.IEnumerable<Rider> c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (Rider element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public Rider this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < size())
        throw new global::System.ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

  public void CopyTo(Rider[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(Rider[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, Rider[] array, int arrayIndex, int count)
  {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (index < 0)
      throw new global::System.ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new global::System.ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

  public Rider[] ToArray() {
    Rider[] array = new Rider[this.Count];
    this.CopyTo(array);
    return array;
  }

  global::System.Collections.Generic.IEnumerator<Rider> global::System.Collections.Generic.IEnumerable<Rider>.GetEnumerator() {
    return new RiderVectorEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new RiderVectorEnumerator(this);
  }

  public RiderVectorEnumerator GetEnumerator() {
    return new RiderVectorEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class RiderVectorEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<Rider>
  {
    private RiderVector collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public RiderVectorEnumerator(RiderVector collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public Rider Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (Rider)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object global::System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new global::System.InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
  }

  public void Clear() {
    delivery_modelPINVOKE.RiderVector_Clear(swigCPtr);
  }

  public void Add(Rider x) {
    delivery_modelPINVOKE.RiderVector_Add(swigCPtr, Rider.getCPtr(x));
    if (delivery_modelPINVOKE.SWIGPendingException.Pending) throw delivery_modelPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = delivery_modelPINVOKE.RiderVector_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = delivery_modelPINVOKE.RiderVector_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    delivery_modelPINVOKE.RiderVector_reserve(swigCPtr, n);
  }

  public RiderVector() : this(delivery_modelPINVOKE.new_RiderVector__SWIG_0(), true) {
  }

  public RiderVector(RiderVector other) : this(delivery_modelPINVOKE.new_RiderVector__SWIG_1(RiderVector.getCPtr(other)), true) {
    if (delivery_modelPINVOKE.SWIGPendingException.Pending) throw delivery_modelPINVOKE.SWIGPendingException.Retrieve();
  }

  public RiderVector(int capacity) : this(delivery_modelPINVOKE.new_RiderVector__SWIG_2(capacity), true) {
    if (delivery_modelPINVOKE.SWIGPendingException.Pending) throw delivery_modelPINVOKE.SWIGPendingException.Retrieve();
  }

  private Rider getitemcopy(int index) {
    Rider ret = new Rider(delivery_modelPINVOKE.RiderVector_getitemcopy(swigCPtr, index), true);
    if (delivery_modelPINVOKE.SWIGPendingException.Pending) throw delivery_modelPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private Rider getitem(int index) {
    Rider ret = new Rider(delivery_modelPINVOKE.RiderVector_getitem(swigCPtr, index), false);
    if (delivery_modelPINVOKE.SWIGPendingException.Pending) throw delivery_modelPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, Rider val) {
    delivery_modelPINVOKE.RiderVector_setitem(swigCPtr, index, Rider.getCPtr(val));
    if (delivery_modelPINVOKE.SWIGPendingException.Pending) throw delivery_modelPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(RiderVector values) {
    delivery_modelPINVOKE.RiderVector_AddRange(swigCPtr, RiderVector.getCPtr(values));
    if (delivery_modelPINVOKE.SWIGPendingException.Pending) throw delivery_modelPINVOKE.SWIGPendingException.Retrieve();
  }

  public RiderVector GetRange(int index, int count) {
    global::System.IntPtr cPtr = delivery_modelPINVOKE.RiderVector_GetRange(swigCPtr, index, count);
    RiderVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new RiderVector(cPtr, true);
    if (delivery_modelPINVOKE.SWIGPendingException.Pending) throw delivery_modelPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, Rider x) {
    delivery_modelPINVOKE.RiderVector_Insert(swigCPtr, index, Rider.getCPtr(x));
    if (delivery_modelPINVOKE.SWIGPendingException.Pending) throw delivery_modelPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, RiderVector values) {
    delivery_modelPINVOKE.RiderVector_InsertRange(swigCPtr, index, RiderVector.getCPtr(values));
    if (delivery_modelPINVOKE.SWIGPendingException.Pending) throw delivery_modelPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    delivery_modelPINVOKE.RiderVector_RemoveAt(swigCPtr, index);
    if (delivery_modelPINVOKE.SWIGPendingException.Pending) throw delivery_modelPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    delivery_modelPINVOKE.RiderVector_RemoveRange(swigCPtr, index, count);
    if (delivery_modelPINVOKE.SWIGPendingException.Pending) throw delivery_modelPINVOKE.SWIGPendingException.Retrieve();
  }

  public static RiderVector Repeat(Rider value, int count) {
    global::System.IntPtr cPtr = delivery_modelPINVOKE.RiderVector_Repeat(Rider.getCPtr(value), count);
    RiderVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new RiderVector(cPtr, true);
    if (delivery_modelPINVOKE.SWIGPendingException.Pending) throw delivery_modelPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    delivery_modelPINVOKE.RiderVector_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    delivery_modelPINVOKE.RiderVector_Reverse__SWIG_1(swigCPtr, index, count);
    if (delivery_modelPINVOKE.SWIGPendingException.Pending) throw delivery_modelPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, RiderVector values) {
    delivery_modelPINVOKE.RiderVector_SetRange(swigCPtr, index, RiderVector.getCPtr(values));
    if (delivery_modelPINVOKE.SWIGPendingException.Pending) throw delivery_modelPINVOKE.SWIGPendingException.Retrieve();
  }

}