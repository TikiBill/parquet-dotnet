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
  /// Data page header
  /// </summary>

  public partial class DataPageHeader : TBase
  {
    private Statistics _statistics;

    /// <summary>
    /// Number of values, including NULLs, in this data page. *
    /// </summary>
    public int Num_values { get; set; }

    /// <summary>
    /// Encoding used for this data page *
    /// 
    /// <seealso cref="Encoding"/>
    /// </summary>
    public Encoding Encoding { get; set; }

    /// <summary>
    /// Encoding used for definition levels *
    /// 
    /// <seealso cref="Encoding"/>
    /// </summary>
    public Encoding Definition_level_encoding { get; set; }

    /// <summary>
    /// Encoding used for repetition levels *
    /// 
    /// <seealso cref="Encoding"/>
    /// </summary>
    public Encoding Repetition_level_encoding { get; set; }

    /// <summary>
    /// Optional statistics for the data in this page*
    /// </summary>
    public Statistics Statistics
    {
      get
      {
        return _statistics;
      }
      set
      {
        __isset.statistics = true;
        this._statistics = value;
      }
    }


    public Isset __isset;

    public struct Isset {
      public bool statistics;
    }

    public DataPageHeader() {
    }

    public DataPageHeader(int num_values, Encoding encoding, Encoding definition_level_encoding, Encoding repetition_level_encoding) : this() {
      this.Num_values = num_values;
      this.Encoding = encoding;
      this.Definition_level_encoding = definition_level_encoding;
      this.Repetition_level_encoding = repetition_level_encoding;
    }

    public void Read (TProtocol iprot)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_num_values = false;
        bool isset_encoding = false;
        bool isset_definition_level_encoding = false;
        bool isset_repetition_level_encoding = false;
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
              if (field.Type == TType.I32) {
                Num_values = iprot.ReadI32();
                isset_num_values = true;
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.I32) {
                Encoding = (Encoding)iprot.ReadI32();
                isset_encoding = true;
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.I32) {
                Definition_level_encoding = (Encoding)iprot.ReadI32();
                isset_definition_level_encoding = true;
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.I32) {
                Repetition_level_encoding = (Encoding)iprot.ReadI32();
                isset_repetition_level_encoding = true;
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 5:
              if (field.Type == TType.Struct) {
                Statistics = new Statistics();
                Statistics.Read(iprot);
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
        if (!isset_num_values)
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        if (!isset_encoding)
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        if (!isset_definition_level_encoding)
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        if (!isset_repetition_level_encoding)
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
        TStruct struc = new TStruct("DataPageHeader");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        field.Name = "num_values";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Num_values);
        oprot.WriteFieldEnd();
        field.Name = "encoding";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32((int)Encoding);
        oprot.WriteFieldEnd();
        field.Name = "definition_level_encoding";
        field.Type = TType.I32;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32((int)Definition_level_encoding);
        oprot.WriteFieldEnd();
        field.Name = "repetition_level_encoding";
        field.Type = TType.I32;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32((int)Repetition_level_encoding);
        oprot.WriteFieldEnd();
        if (Statistics != null && __isset.statistics) {
          field.Name = "statistics";
          field.Type = TType.Struct;
          field.ID = 5;
          oprot.WriteFieldBegin(field);
          Statistics.Write(oprot);
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
      StringBuilder __sb = new StringBuilder("DataPageHeader(");
      __sb.Append(", Num_values: ");
      __sb.Append(Num_values);
      __sb.Append(", Encoding: ");
      __sb.Append(Encoding);
      __sb.Append(", Definition_level_encoding: ");
      __sb.Append(Definition_level_encoding);
      __sb.Append(", Repetition_level_encoding: ");
      __sb.Append(Repetition_level_encoding);
      if (Statistics != null && __isset.statistics) {
        __sb.Append(", Statistics: ");
        __sb.Append(Statistics== null ? "<null>" : Statistics.ToString());
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member