namespace ComoFuncinamOsMapas.Mapas {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ComoFuncinamOsMapas.Schemas.PessoaOrigem", typeof(global::ComoFuncinamOsMapas.Schemas.PessoaOrigem))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ComoFuncinamOsMapas.Schemas.PessoaDestino", typeof(global::ComoFuncinamOsMapas.Schemas.PessoaDestino))]
    public sealed class Map1 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://ComoFuncinamOsMapas.PessoaDestino"" xmlns:s0=""http://ComoFuncinamOsMapas.PessoaOrigem"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:PessoaOrigem"" />
  </xsl:template>
  <xsl:template match=""/s0:PessoaOrigem"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(string(Nome/text()) , &quot; &quot; , string(Apelido/text()))"" />
    <xsl:variable name=""var:v3"" select=""userCSharp:LogicalIsString(string(CodigoPostal/text()))"" />
    <ns0:PessoaDestino>
      <NomeCompleto>
        <xsl:value-of select=""$var:v1"" />
      </NomeCompleto>
      <xsl:variable name=""var:v2"" select=""userCSharp:CalcularIdade(string(DataNascimento/text()))"" />
      <Idade>
        <xsl:value-of select=""$var:v2"" />
      </Idade>
      <Morada>
        <xsl:value-of select=""Morada/text()"" />
      </Morada>
      <xsl:if test=""string($var:v3)='true'"">
        <xsl:variable name=""var:v4"" select=""CodigoPostal/text()"" />
        <CodigoPostal>
          <xsl:value-of select=""$var:v4"" />
        </CodigoPostal>
      </xsl:if>
    </ns0:PessoaDestino>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public bool LogicalIsString(string val)
{
	return (val != null && val !="""");
}


public string StringConcat(string param0, string param1, string param2)
{
   return param0 + param1 + param2;
}


public int CalcularIdade(string dataNascimento)
{
     System.DateTime dNasc = System.Convert.ToDateTime(dataNascimento);
            int idade = DateTime.Now.Year - dNasc.Year;

            if(DateTime.Now.Month < dNasc.Month ||
                (DateTime.Now.Month == dNasc.Month &&
                DateTime.Now.Day < dNasc.Day))
                idade--;

            return idade;
}


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"ComoFuncinamOsMapas.Schemas.PessoaOrigem";
        
        private const global::ComoFuncinamOsMapas.Schemas.PessoaOrigem _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"ComoFuncinamOsMapas.Schemas.PessoaDestino";
        
        private const global::ComoFuncinamOsMapas.Schemas.PessoaDestino _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"ComoFuncinamOsMapas.Schemas.PessoaOrigem";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"ComoFuncinamOsMapas.Schemas.PessoaDestino";
                return _TrgSchemas;
            }
        }
    }
}
