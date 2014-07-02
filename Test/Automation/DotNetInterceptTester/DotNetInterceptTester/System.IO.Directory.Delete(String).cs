namespace DotNetInterceptTester.My_System.IO.Directory
{
public class Delete_System_String
{
public static bool _Delete_System_String( )
{
   //Parameters
   System.String path = null;


   //Exception
   Exception exception_Real = null;
   Exception exception_Intercepted = null;

   InterceptionMaintenance.disableInterception( );

   try
   {
      returnValue_Real = System.IO.Directory.Delete(path);
   }

   catch( Exception e )
   {
      exception_Real = e;
   }


   InterceptionMaintenance.enableInterception( );

   try
   {
      returnValue_Intercepted = System.IO.Directory.Delete(path);
   }

   catch( Exception e )
   {
      exception_Intercepted = e;
   }


}
}
}