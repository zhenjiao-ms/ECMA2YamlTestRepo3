using System;
using System.Runtime.Remoting.Metadata;
using System.Security.Permissions;

namespace ExampleNamespace
{
    public class ExampleClass
    {
        [SoapMethod(
             ResponseXmlElementName="ExampleResponseElement",
             ResponseXmlNamespace=
                "http://example.org/MethodResponseXmlNamespace",
             ReturnXmlElementName="HelloMessage",
             SoapAction="http://example.org/ExampleSoapAction#GetHello",
             XmlNamespace="http://example.org/MethodCallXmlNamespace")]
        public string GetHello(string name)
        {
            return "Hello, " + name;
        }
    }
}

public class Demo
{
[SecurityPermission(SecurityAction.Demand)]
    public static void Main(string[] args)
    {
        // Get the method info object for the GetHello method.
        System.Reflection.MethodBase getHelloMethod = 
            typeof(ExampleNamespace.ExampleClass).GetMethod("GetHello");

        // Print the XML namespace for the invocation of this method.
        string methodCallXmlNamespace = 
            System.Runtime.Remoting.SoapServices.
                GetXmlNamespaceForMethodCall(getHelloMethod);
        Console.WriteLine(
            "The XML namespace for the response of the method " +
            "GetHello in ExampleClass is {0}.",
            methodCallXmlNamespace);

        // Print the XML namespace for the response of this method.
        string methodResponseXmlNamespace =
            System.Runtime.Remoting.SoapServices.
                GetXmlNamespaceForMethodResponse(getHelloMethod);
        Console.WriteLine(
            "The XML namespace for the invocation of the method " +
            "GetHello in ExampleClass is {0}.",
            methodResponseXmlNamespace);

        // Print the SOAP action for this method.
        string getHelloSoapAction =
            System.Runtime.Remoting.SoapServices.
                GetSoapActionFromMethodBase(getHelloMethod);
        Console.WriteLine(
            "The SOAP action for the method " +
            "GetHello in ExampleClass is {0}.", 
            getHelloSoapAction);
    }
}