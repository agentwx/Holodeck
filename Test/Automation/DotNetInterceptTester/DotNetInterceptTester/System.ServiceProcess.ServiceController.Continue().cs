namespace DotNetInterceptTester.My_System.ServiceProcess.ServiceController
{
public class Continue_System_ServiceProcess_ServiceController
{
public static bool _Continue_System_ServiceProcess_ServiceController( )
{
   //Parameters


   //Exception
   Exception exception_Real = null;
   Exception exception_Intercepted = null;

   InterceptionMaintenance.disableInterception( );

   try
   {
      returnValue_Real = System.ServiceProcess.ServiceController.Continue();
   }

   catch( Exception e )
   {
      exception_Real = e;
   }


   InterceptionMaintenance.enableInterception( );

   try
   {
      returnValue_Intercepted = System.ServiceProcess.ServiceController.Continue();
   }

   catch( Exception e )
   {
      exception_Intercepted = e;
   }


}
}
}