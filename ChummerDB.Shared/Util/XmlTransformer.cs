using System.Text;
using System.Xml;
using System.Xml.Xsl;
using ChummerDB.Shared.xml.Gear;

namespace ChummerDB.Shared.Util;

public static class XmlTransformationManager
{
    private const string GearsXsl = """
                                    <xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
                                        <xsl:output method="xml" indent="yes"/>
                                        <xsl:template match="gears/gear">
                                        <xsl:choose>
                                            <xsl:when test='category = "Ammunition"'>
                                                <xsl:element name="Ammunition">
                                                    <xsl:apply-templates select="node()|@*"/>
                                                </xsl:element>
                                            </xsl:when>
                                            <xsl:when test='category = "Commlink Accessories" or
                                                            category = "Commlink/Cyberdeck Form Factors" or
                                                            category = "Commlinks" or
                                                            category = "Commlink Accessories" or
                                                            category = "Custom Cyberdeck Attributes" or
                                                            category = "Cyberdeck Modules" or
                                                            category = "Cyberdecks" or
                                                            category = "Cyberterminals" or
                                                            category = "Electronic Modification" or
                                                            category = "Entertainment" or
                                                            category = "RFID Tags" or
                                                            category = "Rigger Command Consoles"'>
                                                <xsl:element name="ElectronicGear">
                                                    <xsl:apply-templates select="node()|@*"/>
                                                </xsl:element>
                                            </xsl:when>
                                            <xsl:otherwise>
                                                <gear>
                                                    <xsl:apply-templates select='node()|@*'/>
                                                </gear>
                                            </xsl:otherwise>
                                        </xsl:choose>
                                        </xsl:template>
                                        <xsl:template match="@*|node()">
                                            <xsl:copy>
                                                <xsl:apply-templates select="@*|node()"/>
                                            </xsl:copy>
                                        </xsl:template>
                                    </xsl:stylesheet>
                                    """;

    private static readonly Dictionary<Type, string> Transformations = new()
    {
        {typeof(GearsXmlRecord), GearsXsl}
    };

    public static bool ShouldTransform<T>()
    {
        return Transformations.ContainsKey(typeof(T));
    }
    
    public static MemoryStream TransformXml<T>(Stream xmlStream)
    {
        // Load input xml as XmlDocument
        var sourceXml = new XmlDocument();
        sourceXml.Load(xmlStream);
        
        if (!Transformations.TryGetValue(typeof(T), out var xsl))
        {
            throw new InvalidOperationException("There was no transformation for this");
        }

        // Create XSL transformation.
        var transform = new XslCompiledTransform();
        transform.Load(new XmlTextReader(new StringReader(xsl)));

        var sourceNavigator = sourceXml.CreateNavigator();
        if (sourceNavigator is null)
        {
            throw new InvalidOperationException("Source Navigator was null");
        }
        
        // Apply transformation to input xml and write result out to target xml doc.
        var targetXml = new XmlDocument(sourceNavigator.NameTable);

        var targetNavigator = targetXml.CreateNavigator();

        if (targetNavigator is null)
        {
            throw new InvalidOperationException("Target Navigator was null");
        }
        
        using (var writer = targetNavigator.AppendChild())
        {
            transform.Transform(sourceXml, writer);
        }

        var byteArray = Encoding.UTF8.GetBytes(targetXml.InnerXml);
        var ms = new MemoryStream(byteArray);
        
        // Return transformed xml string.
        return ms;
    }
}