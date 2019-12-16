#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/*
 * Autogenerated by Thrift Compiler (0.10.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System.Text;
using Thrift.Protocol;

namespace Parquet.Thrift
{

   /// <summary>
   /// The algorithm used in Bloom filter. *
   /// </summary>
   public partial class BloomFilterAlgorithm : TBase
  {
    private SplitBlockAlgorithm _BLOCK;

    /// <summary>
    /// Block-based Bloom filter. *
    /// </summary>
    public SplitBlockAlgorithm BLOCK
    {
      get
      {
        return _BLOCK;
      }
      set
      {
        __isset.BLOCK = true;
        this._BLOCK = value;
      }
    }


    public Isset __isset;
    public struct Isset {
      public bool BLOCK;
    }

    public BloomFilterAlgorithm() {
    }

    public void Read (TProtocol iprot)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
        iprot.ReadStructBegin();
        while (true)
        {
          field = iprot.ReadFieldBegin();
          if (field.Type == TType.Stop) { 
            break;
          }
          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.Struct) {
                BLOCK = new SplitBlockAlgorithm();
                BLOCK.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            default: 
              TProtocolUtil.Skip(iprot, field.Type);
              break;
          }
          iprot.ReadFieldEnd();
        }
        iprot.ReadStructEnd();
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public void Write(TProtocol oprot) {
      oprot.IncrementRecursionDepth();
      try
      {
        TStruct struc = new TStruct("BloomFilterAlgorithm");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (BLOCK != null && __isset.BLOCK) {
          field.Name = "BLOCK";
          field.Type = TType.Struct;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          BLOCK.Write(oprot);
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("BloomFilterAlgorithm(");
      bool __first = true;
      if (BLOCK != null && __isset.BLOCK) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("BLOCK: ");
        __sb.Append(BLOCK== null ? "<null>" : BLOCK.ToString());
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member