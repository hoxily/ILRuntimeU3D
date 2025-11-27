using System.Collections.Generic;
using UnityEngine;

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
            HelloWorld hello = GameObject.FindObjectOfType<HelloWorld>();

            //输出是否Debug模式，方便对比。
#if DEBUG
            Debug.Log("in Debug mode.");
#else
            Debug.Log("in Release mode.");
#endif
            TestNullCompareBug(hello);
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
        //使用Debug模式生成HotFix_Project.dll是正常的，因为hello_data != local_data判定使用了Ceq.s指令。
        //使用Release模式生成HotFix_Project.dll，就会输出hello_data != local_data的日志。实际上两者都是null，不应该输出。使用ilspy查看，可以看到使用了Beq.s指令。
        public static void TestNullCompareBug(HelloWorld hello_world)
        {
            List<MainProject_Data> list = new List<MainProject_Data>();
            MainProject_Data local_data;
            if (list.Count <= 0)
            {
                local_data = null;
            }
            else
            {
                local_data = list[0];
            }
            MainProject_Data hello_data = hello_world.GetData();
            if (hello_data == null)
            {
                Debug.Log("hello_data is null.");
            }
            if (local_data == null)
            {
                Debug.Log("local_data is null.");
            }
            if (hello_data != local_data)
            {
                Debug.Log("bug: hello_data != local_data");
            }
            else
            {
                Debug.Log("no bug.");
            }
        }
    }


}
