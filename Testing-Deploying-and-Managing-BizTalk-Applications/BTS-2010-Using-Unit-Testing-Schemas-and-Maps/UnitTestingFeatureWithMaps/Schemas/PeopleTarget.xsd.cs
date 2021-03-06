namespace UnitTestingFeatureWithMaps.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://HowMapsWorks.PeopleTarget",@"PeopleTarget")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"PeopleTarget"})]
    public sealed class PeopleTarget : Microsoft.BizTalk.TestTools.Schema.TestableSchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://HowMapsWorks.PeopleTarget"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://HowMapsWorks.PeopleTarget"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""PeopleTarget"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Person"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""LineNumber"" type=""xs:int"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Name"" type=""xs:string"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Sex"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public PeopleTarget() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "PeopleTarget";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
