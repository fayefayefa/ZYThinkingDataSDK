using System.Collections.Generic;
using ThinkingData.Analytics;

namespace ZYThinkingData.RunTime
{
    /// <summary>
    /// 数数SDK管理类
    /// </summary>
    public class ZYThinkingDataManager
    {
        /// <summary>
        /// 初始化数数
        /// </summary>
        /// <param name="appid"></param>
        /// <param name="server"></param>
        public static void Init(string appid, string server)
        {
            TDAnalytics.Init(appid,server);
            //开启安装、启动、关闭事件的自动采集
            TDAnalytics.EnableAutoTrack(TDAutoTrackEventType.All);
        }

        /// <summary>
        /// 设置账号ID
        /// </summary>
        /// <param name="accountId"></param>
        public static void Login(string accountId)
        {
            TDAnalytics.Login(accountId);
        }

        /// <summary>
        /// 设置静态公共事件属性
        /// </summary>
        /// <param name="superProperties"></param>
        public static void SetSuperProperties(Dictionary<string, object> superProperties)
        {
            //设置公共事件属性
            TDAnalytics.SetSuperProperties(superProperties);
        }

        /// <summary>
        /// 设置动态公共事件属性
        /// </summary>
        /// <param name="handler"></param>
        public static void SetSetDynamicSuperProperties(TDDynamicSuperPropertiesHandler handler)
        {
            TDAnalytics.SetDynamicSuperProperties(handler);
        }

        /// <summary>
        /// 设置用户属性
        /// </summary>
        /// <param name="userProperties"></param>
        public static void UserSet(Dictionary<string, object> userProperties)
        {
            TDAnalytics.UserSet(userProperties);
        }

        /// <summary>
        /// 用户属性只要设置一次
        /// </summary>
        /// <param name="userProperties"></param>
        public static void UserSetOnce(Dictionary<string, object> userProperties)
        {
            TDAnalytics.UserSetOnce(userProperties);
        }

        /// <summary>
        /// 发送事件
        /// </summary>
        /// <param name="eventName"></param>
        /// <param name="eventProperties"></param>
        public static void Track(string eventName, Dictionary<string, object> eventProperties)
        {
            TDAnalytics.Track(eventName, eventProperties);
        }
        
        /// <summary>
        /// 发送事件
        /// </summary>
        /// <param name="eventName"></param>
        public static void Track(string eventName)
        {
            TDAnalytics.Track(eventName);
        }

        /// <summary>
        /// 获取设备ID
        /// </summary>
        /// <returns></returns>
        public static string GetDeviceId()
        {
            return TDAnalytics.GetDeviceId();
        }
    }
}