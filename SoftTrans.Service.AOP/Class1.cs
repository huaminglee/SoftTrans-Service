using CYQ.Data.Aop;
using SoftTrans.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftTrans.Service.AOP
{
    public class MyAop : CYQ.Data.Aop.IAop
{
    
        public void Begin(AopEnum action, AopInfo aopInfo)
        {

        }



        public void End(AopEnum action, AopInfo aopInfo)
        {
            switch (action)
            {
                case AopEnum.Delete:
                    break;
                case AopEnum.ExeMDataTable:
                    break;
                case AopEnum.ExeNonQuery:
                    break;
                case AopEnum.ExeScalar:
                    break;
                case AopEnum.Fill:
                    break;
                case AopEnum.GetCount:
                    break;
                case AopEnum.Insert:
                    break;
                case AopEnum.Select:
                    CYQ.Data.Log.WriteLogToTxt("测试" + Class1.qq);
                    break;
                case AopEnum.Update:
                    break;
                default:
                    break;
            }
        }


        public void OnError(string msg)
        {
           
        }





        public IAop Clone()
        {
            return null;
        }

        public IAop GetFromConfig()
        {
            return null;
        }

        public void OnLoad()
        {
           
        }

        AopResult IAop.Begin(AopEnum action, AopInfo aopInfo)
        {
            return AopResult.Continue;
        }
}
}
