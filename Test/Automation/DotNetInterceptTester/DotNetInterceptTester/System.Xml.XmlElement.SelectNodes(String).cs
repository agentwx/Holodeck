namespace DotNetInterceptTester.My_System.Xml.XmlElement
{
public class SelectNodes_System_Xml_XmlElement_System_String
{
public static bool _SelectNodes_System_Xml_XmlElement_System_String( )
{
   //Parameters
   System.String xpath = null;

   //ReturnType/Value
   System.Xml.XmlNodeList returnVal_Real = null;
   System.Xml.XmlNodeList returnVal_Intercepted = null;

   //Exception
   Exception exception_Real = null;
   Exception exception_Intercepted = null;

   InterceptionMaintenance.disableInterception( );

   try
   {
      returnValue_Real = System.Xml.XmlElement.SelectNodes(xpath);
   }

   catch( Exception e )
   {
      exception_Real = e;
   }


   InterceptionMaintenance.enableInterception( );

   try
   {
      returnValue_Intercepted = System.Xml.XmlElement.SelectNodes(xpath);
   }

   catch( Exception e )
   {
      exception_Intercepted = e;
   }


   Return ( ( exception_Real.Messsage == exception_Intercepted.Message ) && ( returnValue_Real == returnValue_Intercepted ) );
}
}
}