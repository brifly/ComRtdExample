using System;
using System.Runtime.InteropServices;

namespace ComRtdExample
{
    [ComVisible(true)]
    [ProgId("ComSample.RtdServer")]
    [Guid("F465CAAC-70CB-494C-A3A4-2C95835A974C")]
    public class RtdServer : IRtdServer
    {
        public int ServerStart(IRTDUpdateEvent CallbackObject)
        {
            return 1;
        }

        public object ConnectData(int topicId, ref Array strings, ref bool newValues)
        {
            return 2;
        }

        public Array RefreshData(ref int topicCount)
        {
            return new[] { 2 };
        }

        public void DisconnectData(int topicID)
        {

        }

        public int Heartbeat()
        {
            return 1;
        }

        public void ServerTerminate()
        {
        }

        public string GetValue()
        {
            return nameof(RtdServer);
        }
    }
}