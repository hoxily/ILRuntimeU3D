using System;
using System.Collections.Generic;

namespace HotFix_Project
{
    public class InstanceClass
    {
        private int id;

        public InstanceClass()
        {
            UnityEngine.Debug.Log("!!! InstanceClass::InstanceClass()");
            this.id = 0;
        }

        public InstanceClass(int id)
        {
            UnityEngine.Debug.Log("!!! InstanceClass::InstanceClass() id = " + id);
            this.id = id;
        }

        public int ID
        {
            get { return id; }
        }

        // static method
        public static void StaticFunTest()
        {
            UnityEngine.Debug.Log("!!! InstanceClass.StaticFunTest()");

            try
            {
                JSONObject json = new JSONObject();
                Data data = new Data();

                json.GetField(out data._int_value, nameof(data._int_value), 0);
                UnityEngine.Debug.Log("parse int value success.");
                json.GetField(out data._bool_value, nameof(data._bool_value), false);
                UnityEngine.Debug.Log("parse bool value success.");
            }
            catch (Exception e)
            {
                UnityEngine.Debug.LogError("parse data error.");
                UnityEngine.Debug.LogException(e);
            }
        }

        public static void StaticFunTest2(int a)
        {
            UnityEngine.Debug.Log("!!! InstanceClass.StaticFunTest2(), a=" + a);
        }

        public static void GenericMethod<T>(T a)
        {
            UnityEngine.Debug.Log("!!! InstanceClass.GenericMethod(), a=" + a);
        }

        public void RefOutMethod(int addition, out List<int> lst, ref int val)
        {
            val = val + addition + id;
            lst = new List<int>();
            lst.Add(id);
        }
    }


}
