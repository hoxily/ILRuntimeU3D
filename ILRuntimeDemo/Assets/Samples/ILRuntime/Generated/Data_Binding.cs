using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using ILRuntime.Reflection;
using ILRuntime.CLR.Utils;
#if DEBUG && !DISABLE_ILRUNTIME_DEBUG
using AutoList = System.Collections.Generic.List<object>;
#else
using AutoList = ILRuntime.Other.UncheckedList<object>;
#endif
namespace ILRuntime.Runtime.Generated
{
    unsafe class Data_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(global::Data);

            field = type.GetField("_int_value", flag);
            app.RegisterCLRFieldGetter(field, get__int_value_0);
            app.RegisterCLRFieldSetter(field, set__int_value_0);
            app.RegisterCLRFieldBinding(field, CopyToStack__int_value_0, AssignFromStack__int_value_0);
            field = type.GetField("_bool_value", flag);
            app.RegisterCLRFieldGetter(field, get__bool_value_1);
            app.RegisterCLRFieldSetter(field, set__bool_value_1);
            app.RegisterCLRFieldBinding(field, CopyToStack__bool_value_1, AssignFromStack__bool_value_1);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get__int_value_0(ref object o)
        {
            return ((global::Data)o)._int_value;
        }

        static StackObject* CopyToStack__int_value_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::Data)o)._int_value;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set__int_value_0(ref object o, object v)
        {
            ((global::Data)o)._int_value = (System.Int32)v;
        }

        static StackObject* AssignFromStack__int_value_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @_int_value = ptr_of_this_method->Value;
            ((global::Data)o)._int_value = @_int_value;
            return ptr_of_this_method;
        }

        static object get__bool_value_1(ref object o)
        {
            return ((global::Data)o)._bool_value;
        }

        static StackObject* CopyToStack__bool_value_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::Data)o)._bool_value;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set__bool_value_1(ref object o, object v)
        {
            ((global::Data)o)._bool_value = (System.Boolean)v;
        }

        static StackObject* AssignFromStack__bool_value_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @_bool_value = ptr_of_this_method->Value == 1;
            ((global::Data)o)._bool_value = @_bool_value;
            return ptr_of_this_method;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new global::Data();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
