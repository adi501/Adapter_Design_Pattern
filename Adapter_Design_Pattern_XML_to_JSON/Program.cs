using Adapter_Design_Pattern_XML_to_JSON.Adapter;
using Adapter_Design_Pattern_XML_to_JSON;
//Ref : https://code-maze.com/adapter/

var xmlConverter = new XmlConverter();
var adapter = new XmlToJsonAdapter(xmlConverter);
adapter.ConvertXmlToJson();

Console.ReadLine();