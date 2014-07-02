namespace DotNetInterceptTester.My_System.IO.TextWriter
{
public class Flush_System_IO_TextWriter
{
public static bool _Flush_System_IO_TextWriter( )
{
   //Parameters


   //Exception
   Exception exception_Real = null;
   Exception exception_Intercepted = null;

   InterceptionMaintenance.disableInterception( );

   try
   {
      returnValue_Real = System.IO.TextWriter.Flush();
   }

   catch( Exception e )
   {
      exception_Real = e;
   }


   InterceptionMaintenance.enableInterception( );

   try
   {
      returnValue_Intercepted = System.IO.TextWriter.Flush();
   }

   catch( Exception e )
   {
      exception_Intercepted = e;
   }


}
}
}