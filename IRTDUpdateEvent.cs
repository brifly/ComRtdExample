using System.Runtime.InteropServices;

namespace ComRtdExample
{
    [Guid("A43788C1-D91B-11D3-8F39-00C04F3651B8")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ComImport]
    public interface IRTDUpdateEvent
    {
        [DispId(10)]
        void UpdateNotify();

        [DispId(11)]
        int HeartbeatInterval { get; set; }

        [DispId(12)]
        void Disconnect();
    }
}