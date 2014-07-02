using System;

namespace DotNetInterceptTester.My_System.ComponentModel.EnumConverter
{
public class GetStandardValuesExclusive_System_ComponentModel_EnumConverter
{
public static bool _GetStandardValuesExclusive_System_ComponentModel_EnumConverter( )
{

   //class object
    System.ComponentModel.EnumConverter _System_ComponentModel_EnumConverter = new System.ComponentModel.EnumConverter();

   //Parameters

   //ReturnType/Value
   System.Boolean returnVal_Real = false;
   System.Boolean returnVal_Intercepted = false;

   //Exception
   System.Exception exception_Real = null;
   System.Exception exception_Intercepted = null;

   InterceptionMaintenance.disableInterception( );

   try
   {
      returnVal_Real = _System_ComponentModel_EnumConverter.GetStandardValuesExclusive();
   }

   catch( System.Exception e )
   {
      exception_Real = e;
   }


   InterceptionMaintenance.enableInterception( );

   try
   {
      returnVal_Intercepted = _System_ComponentModel_EnumConverter.GetStandardValuesExclusive();
   }

   catch( System.Exception e )
   {
      exception_Intercepted = e;
   }


   return( ( exception_Real.Messsage == exception_Intercepted.Message ) && ( returnValue_Real == returnValue_Intercepted ) );
}
}
}