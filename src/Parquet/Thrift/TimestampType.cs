#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/*
 * Autogenerated by Thrift Compiler (0.10.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;

using Thrift.Protocol;
using Thrift.Transport;

namespace Parquet.Thrift
{

  /// <summary>
  /// Timestamp logical type annotation
  /// 
  /// Allowed for physical types: INT64
  /// </summary>

  public partial class TimestampType : TBase
  {

    public bool IsAdjustedToUTC { get; set; }

    public TimeUnit Unit { get; set; }

    public TimestampType() {
    }

    public TimestampType(bool isAdjustedToUTC, TimeUnit unit) : this() {
      this.IsAdjustedToUTC = isAdjustedToUTC;
      this.Unit = unit;
    }

    public void Read (TProtocol iprot)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_isAdjustedToUTC = false;
        bool isset_unit = false;
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
              if (field.Type == TType.Bool) {
                IsAdjustedToUTC = iprot.ReadBool();
                isset_isAdjustedToUTC = true;
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.Struct) {
                Unit = new TimeUnit();
                Unit.Read(iprot);
                isset_unit = true;
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
        if (!isset_isAdjustedToUTC)
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        if (!isset_unit)
          throw new TProtocolException(TProtocolException.INVALID_DATA);
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
        TStruct struc = new TStruct("TimestampType");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        field.Name = "isAdjustedToUTC";
        field.Type = TType.Bool;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(IsAdjustedToUTC);
        oprot.WriteFieldEnd();
        field.Name = "unit";
        field.Type = TType.Struct;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        Unit.Write(oprot);
        oprot.WriteFieldEnd();
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("TimestampType(");
      __sb.Append(", IsAdjustedToUTC: ");
      __sb.Append(IsAdjustedToUTC);
      __sb.Append(", Unit: ");
      __sb.Append(Unit== null ? "<null>" : Unit.ToString());
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member