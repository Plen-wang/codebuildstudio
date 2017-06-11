/*
 *author:南京.王清培
 *coding time:2011.10.8
 *copyright:快捷速递
 *function:托管对象池，为了方便各构件之间的对象传递使用对象池进行保存。
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
using System.Security.Permissions;

namespace Main.Interface.ComeBaseModule
{
    /// <summary>
    /// 对象池的安全封送委托，UnManagerObjectPolling不支持直接访问对象池，只能在某些时刻允许访问。
    /// </summary>
    /// <param name="PrivateObjectPolling">UnManagerObjectPolling对象中的实质性的对象池</param>
    public delegate void UnManagerObjectPollingHandler(Dictionary<string, object> PrivateObjectPolling);
    /// <summary>
    /// 构件对象池，保存构件之间的互操作对象，方便构件之间的对象读取使用。
    /// </summary>
    public static class UnManagerObjectPolling
    {
        /// <summary>
        /// 对象字典
        /// </summary>
        private static Dictionary<string, object> ObjectPollList = new Dictionary<string, object>();
        /// <summary>
        /// 该事件只在某些安全的时刻才会触发(如：调用AddObject方法的时候，如果对象池中有指定的键了则触发该事件，安全的将对象池传递给调用客户端)
        /// </summary>
        public static event UnManagerObjectPollingHandler UnManagerObjectPollingTimeSpanEvent;
        /// <summary>
        /// 安全的获取放入对象池中的对象。
        /// </summary>
        /// <typeparam name="T">对象类型
        /// (为了安全的获取到存入对象池中的对象，该类型用来检查是否存入和获取的对象是一致的)</typeparam>
        /// <param name="name">对象在池中的唯一标识</param>
        /// <returns>获取的对象</returns>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public static object GetObjectByName<T>(string name) where T : new()
        {
            if (ObjectPollList.Count == 0)
                return null;
            else if (ObjectPollList.ContainsKey(name))
            {
                object t = ObjectPollList[name];
                if (t is T)
                    return t;
            }
            return null;
        }
        /// <summary>
        /// 将对象放入对象池，不替换已经存在的键值。
        /// </summary>
        /// <param name="name">对象在池中的唯一标识</param>
        /// <param name="o">要放入对象池中的对象</param>
        public static void AddObject(string name, object o)
        {
            AddObject(name, o, false);
        }
        /// <summary>
        /// 将对象放入对象池。
        /// </summary>
        /// <param name="name">对象在池中的唯一标识</param>
        /// <param name="o">要放入的对象</param>
        /// <param name="isreplace">如果已经存在相同的键值，是否替换池中的对象。
        /// true替换(不触发UnManagerObjectPollingTimeSpanEvent事件)，false不替换(触发UnManagerObjectPollingTimeSpanEvent事件)</param>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public static void AddObject(string name, object o, bool isreplace)
        {
            if (!ObjectPollList.ContainsKey(name))
            {
                ObjectPollList.Add(name, o);
            }
            else if (isreplace)
            {
                ObjectPollList.Remove(name);
                ObjectPollList.Add(name, o);
            }
            else if (!isreplace)
                UnManagerObjectPollingTimeSpanEvent(ObjectPollList);
        }
        /// <summary>
        /// 移除指定的内存池对象
        /// </summary>
        /// <param name="name">对象在池中的唯一key</param>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public static void DeleteObejct(string name)
        {
            if (ObjectPollList.ContainsKey(name))
            {
                ObjectPollList.Remove(name);
            }
        }
    }
}
