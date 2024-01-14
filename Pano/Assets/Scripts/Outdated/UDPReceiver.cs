using UnityEngine;
using System.Net;
using System.Net.Sockets;
using System.Text;

public class UDPReceiver : MonoBehaviour
{
    UdpClient udpClient;
    int port = 8001;

    void Start() => udpClient = new UdpClient(port);

    void Update()
    {
        if (udpClient.Available > 0)
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 0);
            string receivedString = Encoding.ASCII.GetString(udpClient.Receive(ref endPoint));

            if (float.TryParse(receivedString, out float receivedFloat))
            {
                Debug.Log("Received Float: " + receivedFloat);
            }
        }
    }

    void OnApplicationQuit() => udpClient?.Close();
}
