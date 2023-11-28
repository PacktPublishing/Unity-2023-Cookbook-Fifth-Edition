
/// source: Unity Threads: post by Anagr Oct 2016
/// https://forum.unity.com/threads/uniy-2018-2-https-webrequest-failes-on-latest-hololens-os-udpate.550429/

using UnityEngine.Networking;
public class CertHandler : CertificateHandler
{
    protected override bool ValidateCertificate(byte[] certificateData)
    {
        return true;
    }
}